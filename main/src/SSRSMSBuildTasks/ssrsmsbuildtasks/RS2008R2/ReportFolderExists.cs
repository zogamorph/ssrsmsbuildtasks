// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportFolderExists.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will check for the existences of folder within report server folder on the report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.RS2008R2
{
    #region Directives

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;
    using ssrsmsbuildtasks.DeploymentManger.ReportItems;

    #endregion

    /// <summary>
    /// This MSBuild Task will check for the existences of folder within report server folder on the report server.
    /// </summary>
    public class ReportFolderExists : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets a value indicating whether this <see cref = "ReportFolderExists" /> is exists.
        /// </summary>
        /// <value><c>true</c> if exists; otherwise, <c>false</c>.</value>
        [Output]
        public bool Exists { get; set; }

        /// <summary>
        ///   Gets or sets the report folder path.
        /// </summary>
        /// <value>The report folder path.</value>
        public string Folder { get; set; }

        /// <summary>
        ///   Gets or sets the name of the folder.
        /// </summary>
        /// <value>The name of the folder.</value>
        [Required]
        public string FolderName { get; set; }

        /// <summary>
        ///   Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        public string DocumentLibraryURL { get; set; }

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
                if (String.IsNullOrEmpty(this.FolderName))
                {
                    this.FolderName = "/";
                }

                this.Exists = r2DeploymentManger.ReportItemExists(
                    this.FolderName, ReportItemStrings.Folder, this.Folder, this.DocumentLibraryURL);
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
        private void deploymentMangerMessages(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendDeploymentMangerMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}