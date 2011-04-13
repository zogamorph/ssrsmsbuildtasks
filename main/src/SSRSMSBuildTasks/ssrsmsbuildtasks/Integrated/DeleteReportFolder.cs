// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteReportFolder.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will delete a folder within the requested SharePoint report document library path.
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
    /// This MSBuild Task will delete a folder within the requested SharePoint report document library path.
    /// </summary>
    public class DeleteReportFolder : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets the SharePoint report document library path.
        /// </summary>
        /// <value>The SharePoint report document library path.</value>
        [Required]
        public string Folder { get; set; }

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
            IntegratedDeploymentManager integratedDeploymentManager =
                new IntegratedDeploymentManager(this.SharePointSiteUrl);
            integratedDeploymentManager.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                return integratedDeploymentManager.DeleteReportFolder(this.Folder);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "DeleteReportFolder", 
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
        /// Deployments the manger messages.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The <see cref="ssrsmsbuildtasks.DeploymentManger.DeploymentMangerMessageEventArgs"/> instance containing the event data.
        /// </param>
        private void deploymentMangerMessages(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendDeploymentMangerMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}