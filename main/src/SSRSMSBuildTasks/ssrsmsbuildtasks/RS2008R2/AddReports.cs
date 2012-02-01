// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddReports.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will upload a list of a reports files to the requested report server.
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
    /// This MSBuild Task will upload a list of a reports files to the requested report server.
    /// </summary>
    public class AddReports : Task
    {
        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the <see cref = "AddReports" /> class.
        /// </summary>
        public AddReports()
        {
            this.DisableWarnings = false;
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets a value indicating whether to disable warnings.
        /// </summary>
        /// <value><c>true</c> if [disable warnings]; otherwise, <c>false</c>.</value>
        public bool DisableWarnings { get; set; }

        /// <summary>
        ///   Gets or sets the report folder path.
        /// </summary>
        /// <value>The report folder path.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        ///   Gets or sets the report files.
        /// </summary>
        /// <value>The report files.</value>
        /// <remarks>
        ///   Adding the meta data ReportServerProperties will with comma
        ///   separated name value paired list will set the report server
        ///   properties I.E.: [Properties Name]=[Value];[Properties Name]=[Value]
        /// </remarks>
        [Required]
        public ITaskItem[] ReportFiles { get; set; }

        /// <summary>
        ///   Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

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
            // Creates the new instances of the reporting services.  
            // Use the current users windows credentials to connect to the report server.
            R2DeploymentManger r2DeploymentManger = new R2DeploymentManger(this.ReportServerURL);
            ReportFile[] reportFiles = new ReportFile[this.ReportFiles.Length];
            r2DeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;

            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.ReportFiles.Length; index++)
                {
                    reportFiles[index] = new ReportFile(this.ReportFiles[index].GetMetadata("FullPath"));
                    string propertiesString = this.ReportFiles[index].GetMetadata("ReportServerProperties");
                    if (!string.IsNullOrEmpty(propertiesString))
                    {
                        this.AddReportProperties(reportFiles[index], propertiesString);
                    }
                }

                return r2DeploymentManger.UpLoadReports(reportFiles, this.Folder, this.DisableWarnings);
            }
            catch (Exception ex)
            {
                // catches the error and then reports out via msbuild.
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "AddReports", 
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
        /// Adds the report properties.
        /// </summary>
        /// <param name="reportFile">
        /// The report server reports.
        /// </param>
        /// <param name="propertiesString">
        /// The properties string.
        /// </param>
        private void AddReportProperties(ReportFile reportFile, string propertiesString)
        {
            string[] strings;
            foreach (string propertery in propertiesString.Split(new[] { ';' }))
            {
                strings = propertery.Split(new[] { '=' });
                reportFile.ReportServerProperties.Add(strings[0], strings[1]);
            }
        }

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