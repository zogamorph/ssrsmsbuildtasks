// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddResource.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild  Task will upload a list of a reports to the requested report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Integrated
{
    #region Directives

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// This MSBuild Task will upload a list of resources files to the requested SharePoint report document library path.
    /// </summary>
    public class AddResource : Task
    {
        #region Properties

        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        /// <value>The files.</value>
        /// <remarks> The following meta data is require to upload resource file:
        ///      MineType - The file mine type
        /// Adding the meta data ReportServerProperties will with comma
        /// separated name value paired list will set the report server
        /// properties I.E.: [Properties Name]=[Value];[Properties Name]=[Value]
        /// </remarks>

        [Required]
        public ITaskItem[] Files { get; set; }

        /// <summary>
        /// Gets or sets new report user name which need to added to the report document library path.
        /// </summary>
        /// <value>The name of the report user.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets SharePoint site Url.
        /// </summary>
        /// <value>The SharePoint site Url.</value>
        [Required]
        public string SharePointSiteUrl { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The execute method which is call MSBuild to run the task
        /// </summary>
        /// <returns>
        /// <c>true</c> if the task runs correctly
        /// </returns>
        public override bool Execute()
        {
            // Creates the new instances of the reporting services.  
            // Use the current users windows credentials to connect to the report server.
            IntegratedDeploymentManager integratedDeploymentManager =
                new IntegratedDeploymentManager(this.SharePointSiteUrl);
            ReportResourceFile[] reportResourcesFile = new ReportResourceFile[this.Files.Length];
            integratedDeploymentManager.DeploymentMangerMessages += this.deploymentMangerMessages;

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

                return integratedDeploymentManager.UploadResource(reportResourcesFile, this.Folder);
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
        private void deploymentMangerMessages(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendDeploymentMangerMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}