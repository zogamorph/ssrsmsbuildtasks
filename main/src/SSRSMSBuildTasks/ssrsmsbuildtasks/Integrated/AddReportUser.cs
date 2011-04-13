// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddReportUser.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will create a new report user to the requested SharePoint report document library path.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Integrated
{
    #region using directive

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// This MSBuild Task will create a new report user to the requested SharePoint report document library path.
    /// </summary>
    public class AddReportUser : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets the SharePoint report document library path.
        /// </summary>
        /// <value>The SharePoint report document library path.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        ///   Gets or sets new report user name which need to added to the report document library path.
        /// </summary>
        /// <value>The name of the report user.</value>
        [Required]
        public string ReportUserName { get; set; }

        /// <summary>
        ///   Gets or sets the reporting roles.
        /// </summary>
        /// <value>The reporting roles.</value>
        [Required]
        public string[] ReportingRoles { get; set; }

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
        /// True if the mothed dosen't error
        /// </returns>
        public override bool Execute()
        {
            // Connecting to the reporting server
            IntegratedDeploymentManager integratedDeploymentManager =
                new IntegratedDeploymentManager(this.SharePointSiteUrl);
            integratedDeploymentManager.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                return integratedDeploymentManager.AddReportUser(this.ReportUserName, this.ReportingRoles, this.Folder);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "AddReportUser", 
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