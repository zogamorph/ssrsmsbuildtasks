// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportUserExists.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The report user exists.
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
    /// The report user exists.
    /// </summary>
    public class ReportUserExists : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets a value indicating whether this <see cref = "ReportUserExists" /> is exists.
        /// </summary>
        /// <value><c>true</c> if exists; otherwise, <c>false</c>.</value>
        [Output]
        public bool Exists { get; set; }

        /// <summary>
        ///   Gets or sets the report folder path.
        /// </summary>
        /// <value>The report folder path.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        ///   Gets or sets Report Server User name.
        /// </summary>
        /// <value>The name of the report user.</value>
        [Required]
        public string ReportUserName { get; set; }

        /// <summary>
        ///   Gets or sets the share point site URL.
        /// </summary>
        /// <value>The share point site URL.</value>
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
            // Connecting to the reporting server
            IntegratedDeploymentManager integratedDeploymentManager =
                new IntegratedDeploymentManager(this.SharePointSiteUrl);
            integratedDeploymentManager.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                this.Exists = integratedDeploymentManager.ReportUserExists(this.ReportUserName, this.Folder);
                return true;
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "DeleteReportUser", 
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