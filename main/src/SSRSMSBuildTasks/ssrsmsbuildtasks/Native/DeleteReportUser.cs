// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteReportUser.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will delete report user for the folder.
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
    /// This MSBuild Task will delete report user for the folder.
    /// </summary>
    public class DeleteReportUser : Task
    {
        #region Properties

        /// <summary>
        /// Gets or sets the report folder path.
        /// </summary>
        /// <value>The report folder path.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        /// <summary>
        /// Gets or sets Report Server User name.
        /// </summary>
        /// <value>The name of the report user.</value>
        [Required]
        public string ReportUserName { get; set; }

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
            NativeDeploymentManger nativeDeploymentManger = new NativeDeploymentManger(this.ReportServerURL);
            nativeDeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                return nativeDeploymentManger.DeleteReportUser(this.ReportUserName, this.Folder);
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