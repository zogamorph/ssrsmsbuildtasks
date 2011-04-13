// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetFullURL.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The get full url.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.RS2008R2
{
    #region using directive

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// The get full url.
    /// </summary>
    public class GetFullURL : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets a value indicating whether this instance is intergated mode.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is intergated mode; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsIntergatedMode { get; set; }

        /// <summary>
        ///   Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Output]
        public string ReportServerUrl { get; private set; }

        /// <summary>
        ///   Gets or sets the server URL.
        /// </summary>
        /// <value>The server URL.</value>
        [Required]
        public string ServerURL { get; set; }

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
            try
            {
                if (!this.IsIntergatedMode)
                {
                    this.ReportServerUrl = R2DeploymentManger.GetNativeURL(this.ServerURL);
                }
                else
                {
                    this.ReportServerUrl = R2DeploymentManger.GetSharepoint(this.ServerURL);
                }

                return true;
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "ReportServerUrl", 
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
    }
}