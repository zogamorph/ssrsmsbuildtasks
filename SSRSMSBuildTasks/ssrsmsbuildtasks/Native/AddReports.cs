// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddReports.cs" company="">
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
    public class AddReports : Task
    {
        #region Properties

        /// <summary>
        /// The report folder where the reports need to be uploaded.
        /// </summary>
        /// <value>The name of the folder.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        /// The list of report files, include full path, which need to upload to the report server.
        /// </summary>
        /// <value>The report files.</value>
        [Required]
        public ITaskItem[] ReportFiles { get; set; }

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
            ReportFile[] reportFiles = new ReportFile[this.ReportFiles.Length];
            rs.DeploymentMangerMessages += this.reportingServicesMessage;

            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.ReportFiles.Length; index++)
                {
                    reportFiles[index] = new ReportFile(this.ReportFiles[index].GetMetadata("FullPath"));
                    string propertiesString = this.ReportFiles[index].GetMetadata("ReportServerProperties");
                    if (!string.IsNullOrEmpty(propertiesString))
                    {
                        this.AddReportProperties(reportFiles[index], propertiesString);
                    }
                }

                return rs.UpLoadReports(reportFiles, this.Folder);
            }
            catch (Exception ex)
            {
                // catches the error and then reports out via msbuild.
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "AddReports", 
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
        /// <param name="reportFile">
        /// The report server reports.
        /// </param>
        /// <param name="propertiesString">
        /// The properties string.
        /// </param>
        private void AddReportProperties(ReportFile reportFile, string propertiesString)
        {
            string[] strings;
            foreach (string propertery in propertiesString.Split(new[] { ';' }))
            {
                strings = propertery.Split(new[] { '=' });
                reportFile.ReportServerProperties.Add(strings[0], strings[1]);
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