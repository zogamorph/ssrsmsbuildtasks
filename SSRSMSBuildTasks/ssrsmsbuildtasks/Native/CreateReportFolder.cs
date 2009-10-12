// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateReportFolder.cs" company="">
//   
// </copyright>
// <summary>
//   This MSBuild Task will create a new report server folder on the report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Native
{
    #region Directives

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
        /// Gets or sets the folder report properties.
        /// </summary>
        /// <value>The folder report properties.</value>
        public string FolderReportProperties { get; set; }

        /// <summary>
        /// The path to the folder which needs to be created.
        /// </summary>
        [Required]
        public string NewFolderPath { get; set; }

        /// <summary>
        /// The url of the report server.
        /// </summary>
        [Required]
        public string ReportServerURL { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The execute.
        /// </summary>
        /// <returns>
        /// The execute.
        /// </returns>
        public override bool Execute()
        {
            NativeDeploymentManger rs = new NativeDeploymentManger(this.ReportServerURL);
            rs.ReportingServicesMessage += this.reportingServicesMessage;
            try
            {
                return rs.CreateFolder(
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
        private void reportingServicesMessage(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendReportMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}