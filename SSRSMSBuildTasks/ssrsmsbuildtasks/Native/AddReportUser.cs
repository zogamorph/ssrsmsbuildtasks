// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddReportUser.cs" company="">
//   
// </copyright>
// <summary>
//   This MSBuild Task will create a new report server user on the report server.
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
    /// This MSBuild Task will create a new report server user on the report server.
    /// </summary>
    public class AddReportUser : Task
    {
        #region Properties

        /// <summary>
        /// The folder name where the report user will be allow to access.
        /// </summary>
        /// <value>The name of the folder.</value>
        [Required]
        public string FolderName { get; set; }

        /// <summary>
        /// The roles within the report server that the user will have in the report server
        /// </summary>
        /// <value>The reporting roles.</value>
        [Required]
        public string[] ReportingRoles { get; set; }

        /// <summary>
        /// The url of the report server.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        /// <summary>
        /// Gets or sets Report Server User name which need to added to the report server.
        /// </summary>
        /// <value>The name of the report user.</value>
        [Required]
        public string ReportUserName { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The execute method which is call msbuild to run the task
        /// </summary>
        /// <returns>
        /// True if the mothed dosen't error
        /// </returns>
        public override bool Execute()
        {
            // Connecting to the reporting server
            NativeDeploymentManger rs = new NativeDeploymentManger(this.ReportServerURL);
            rs.ReportingServicesMessage += this.reportingServicesMessage;
            try
            {
                return rs.AddReportUser(this.ReportUserName, this.ReportingRoles, this.FolderName);
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
        private void reportingServicesMessage(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendReportMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}