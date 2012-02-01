// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateReportFolder.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will create a folder within the requested SharePoint report document library path.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Integrated
{
    #region Directives

    using System;
    using System.Collections.Generic;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// This MSBuild Task will create a folder within the requested SharePoint report document library path.
    /// </summary>
    public class CreateReportFolder : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets the new name of the folder.
        /// </summary>
        /// <value>The new name of the folder.</value>
        [Required]
        public string NewFolderName { get; set; }

        /// <summary>
        ///   Gets or sets the parent folder path.
        /// </summary>
        /// <value>The parent folder path.</value>
        /// <remarks>
        ///   The parent path is the SharePoint report document library path that the folder
        /// </remarks>
        public string ParentPath { get; set; }

        /// <summary>
        ///   Gets or sets SharePoint site Url.
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
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public override bool Execute()
        {
            IntegratedDeploymentManager integratedDeploymentManager =
                new IntegratedDeploymentManager(this.SharePointSiteUrl);
            integratedDeploymentManager.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                return integratedDeploymentManager.CreateFolder(this.NewFolderName, this.ParentPath);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "CreateReportFolder", 
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
        /// <param name="propertiesString">
        /// The properties string.
        /// </param>
        /// <returns>
        /// Dictionary of Report Folder Properties
        /// </returns>
        private Dictionary<string, string> CreateReportFolderProperties(string propertiesString)
        {
            Dictionary<string, string> reportFolderProperties = new Dictionary<string, string>();
            string[] strings;

            if (!string.IsNullOrEmpty(propertiesString))
            {
                foreach (string propertery in propertiesString.Split(new[] { ';' }))
                {
                    strings = propertery.Split(new[] { '=' });
                    reportFolderProperties.Add(strings[0], strings[1]);
                }
            }

            return reportFolderProperties;
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