// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddResource.cs" company="">
//   
// </copyright>
// <summary>
//   This MSBuild Task will upload a list of a reports to the requested report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Native
{
    #region Directives

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// This MSBuild Task will upload a list of a reports to the requested report server.
    /// </summary>
    public class AddResource : Task
    {
        #region Properties

        /// <summary>
        /// The list of report files, include full path, which need to upload to the report server.
        /// </summary>
        /// <value>The files.</value>
        [Required]
        public ITaskItem[] Files { get; set; }

        /// <summary>
        /// The report folder where the reports need to be uploaded.
        /// </summary>
        /// <value>The name of the folder.</value>
        [Required]
        public string FolderName { get; set; }

        /// <summary>
        /// The http address of the reports server.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The execute method which is call msbuild to run the task
        /// </summary>
        /// <returns>
        /// True if the task runs correctly
        /// </returns>
        public override bool Execute()
        {
            // Creates the new instances of the reporting services.  
            // Use the current users windows credentials to connect to the report server.
            NativeDeploymentManger rs = new NativeDeploymentManger(this.ReportServerURL);
            ReportResourceFile[] reportResourcesFile = new ReportResourceFile[this.Files.Length];
            rs.ReportingServicesMessage += this.reportingServicesMessage;

            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.Files.Length; index++)
                {
                    reportResourcesFile[index] = new ReportResourceFile(this.Files[index].GetMetadata("FullPath"));
                    reportResourcesFile[index].MineType = this.Files[index].GetMetadata("MineType");
                    string propertiesString = this.Files[index].GetMetadata("ReportServerProperties");
                    if (!string.IsNullOrEmpty(propertiesString))
                    {
                        this.AddFilesProperties(reportResourcesFile[index], propertiesString);
                    }
                }

                return rs.UploadResource(reportResourcesFile, this.FolderName);
            }
            catch (Exception ex)
            {
                // catches the error and then reports out via msbuild.
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "AddResources", 
                        this.BuildEngine.ProjectFileOfTaskNode, 
                        this.BuildEngine.LineNumberOfTaskNode, 
                        this.BuildEngine.ColumnNumberOfTaskNode, 
                        0, 
                        0, 
                        ex.Message, 
                        string.Empty, 
                        this.ToString()));
                return false;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the report properties.
        /// </summary>
        /// <param name="reportResourceFile">
        /// The report server reports.
        /// </param>
        /// <param name="propertiesString">
        /// The properties string.
        /// </param>
        private void AddFilesProperties(ReportResourceFile reportResourceFile, string propertiesString)
        {
            string[] strings;
            foreach (string propertery in propertiesString.Split(new[] { ';' }))
            {
                strings = propertery.Split(new[] { '=' });
                reportResourceFile.ReportServerProperties.Add(strings[0], strings[1]);
            }
        }

        /// <summary>
        /// The reporting services message.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
        private void reportingServicesMessage(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendReportMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}