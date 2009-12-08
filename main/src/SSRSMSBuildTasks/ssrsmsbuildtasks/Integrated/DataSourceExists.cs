// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataSourceExists.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The report folder exists.
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
    /// Data Source Exists
    /// </summary>
    public class DataSourceExists : Task
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name of the data source.
        /// </summary>
        /// <value>The name of the data source.</value>
        [Required]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="DataSourceExists"/> is exists.
        /// </summary>
        /// <value><c>true</c> if exists; otherwise, <c>false</c>.</value>
        [Output]
        public bool Exists { get; set; }

        /// <summary>
        /// Gets or sets the folder.
        /// </summary>
        /// <value>The folder.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets the share point site URL.
        /// </summary>
        /// <value>The share point site URL.</value>
        [Required]
        public string SharePointSiteUrl { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// When overridden in a derived class, executes the task.
        /// </summary>
        /// <returns>
        /// true if the task successfully executed; otherwise, false.
        /// </returns>
        public override bool Execute()
        {
            IntegratedDeploymentManager integratedDeploymentManager =
                new IntegratedDeploymentManager(this.SharePointSiteUrl);
            integratedDeploymentManager.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                if (String.IsNullOrEmpty(this.Folder))
                {
                    this.Folder = "/";
                }

                this.Exists = integratedDeploymentManager.ReportItemExists(
                     this.Folder, this.DataSourceName, IntegratedDeploymentManager.GetReportItemtype("DataSource"));
                return true;
            }
            catch (Exception exception)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "ReportItemExists", 
                        this.BuildEngine.ProjectFileOfTaskNode, 
                        this.BuildEngine.LineNumberOfTaskNode, 
                        this.BuildEngine.ColumnNumberOfTaskNode, 
                        0, 
                        0, 
                        exception.Message, 
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
        /// <param name="sender">The sender.</param>
        /// <param name="eventArgs">The <see cref="ssrsmsbuildtasks.DeploymentManger.DeploymentMangerMessageEventArgs"/> instance containing the event data.</param>
        private void deploymentMangerMessages(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendDeploymentMangerMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}