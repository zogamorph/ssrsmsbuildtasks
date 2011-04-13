// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateReportFolder.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will create a new report server folder on the report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.RS2008R2
{
    #region using directive

    using System;
    using System.Collections.Generic;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// This MSBuild Task will create a new report server folder on the report server.
    /// </summary>
    public class CreateReportFolder : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets the folder report properties.
        /// </summary>
        /// <value>The folder report properties.</value>
        /// <remarks>
        ///   The folder properties need to be set as a comma separated
        ///   list I.E.: [Properties Name]=[Value];[Properties Name]=[Value]
        /// </remarks>
        public string FolderReportProperties { get; set; }

        /// <summary>
        ///   The path to the folder which needs to be created.
        /// </summary>
        [Required]
        public string NewFolderPath { get; set; }

        /// <summary>
        ///   The url of the report server.
        /// </summary>
        [Required]
        public string ReportServerURL { get; set; }

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
            R2DeploymentManger r2DeploymentManger = new R2DeploymentManger(this.ReportServerURL);
            r2DeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                return r2DeploymentManger.CreateFolder(
                    this.NewFolderPath, this.CreateReportFolderProperties(this.FolderReportProperties));
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