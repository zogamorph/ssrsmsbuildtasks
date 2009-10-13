﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataSourceExists.cs" company="">
//   
// </copyright>
// <summary>
//   The report folder exists.
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
    /// The report folder exists.
    /// </summary>
    public class DataSourceExists : Task
    {
        #region Properties

        /// <summary>
        /// Gets or sets the report item.
        /// </summary>
        /// <value>The report item.</value>
        [Required]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportItemExists"/> is exists.
        /// </summary>
        /// <value><c>true</c> if exists; otherwise, <c>false</c>.</value>
        [Output]
        public bool Exists { get; set; }

        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        /// <value>The name of the folder.</value>
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
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
            rs.DeploymentMangerMessages += this.reportingServicesMessage;
            try
            {
                if (String.IsNullOrEmpty(this.Folder))
                {
                    this.Folder = "/";
                }

                this.Exists = rs.ReportItemExists(
                    this.DataSourceName, NativeDeploymentManger.GetReportItemtype("DataSource"), this.Folder);
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