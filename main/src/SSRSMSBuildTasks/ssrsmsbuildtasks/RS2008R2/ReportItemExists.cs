// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportItemExists.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will check for the existences of the report item a within the report server folder on the report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.RS2008R2
{
    #region Directives

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// This MSBuild Task will check for the existences of the report item a within the report server folder on the report server.
    /// </summary>
    public class ReportItemExists : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets a value indicating whether this <see cref = "ReportItemExists" /> is exists.
        /// </summary>
        /// <value><c>true</c> if exists; otherwise, <c>false</c>.</value>
        [Output]
        public bool Exists { get; set; }

        /// <summary>
        ///   Gets or sets the report server folder path.
        /// </summary>
        /// <value>The report server folder path.</value>
        public string Folder { get; set; }

        /// <summary>
        ///   Gets or sets the report item.
        /// </summary>
        /// <value>The report item.</value>
        [Required]
        public string ReportItemName { get; set; }

        /// <summary>
        ///   Gets or sets the name of the report item type.
        /// </summary>
        /// <value>The name of the report item type.</value>
        /// <remarks>
        ///   Report Item Type Name are names used within reporting services ItemTypeEnum
        /// </remarks>
        [Required]
        public string ReportItemTypeName { get; set; }

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
                if (String.IsNullOrEmpty(this.Folder))
                {
                    this.Folder = "/";
                }

                this.Exists = r2DeploymentManger.ReportItemExists(
                    this.ReportItemName, this.ReportItemTypeName, this.Folder,this.DocumentLibraryURL);
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