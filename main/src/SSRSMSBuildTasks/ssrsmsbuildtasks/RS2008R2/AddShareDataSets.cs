// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddShareDataSets.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The add share data sets.
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
    /// The add share data sets.
    /// </summary>
    public class AddShareDataSets : Task
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddShareDataSets"/> class. 
        /// Initializes a new instance of the <see cref="T:Microsoft.Build.Utilities.Task"/> class.
        /// </summary>
        public AddShareDataSets()
        {
            this.DisableWarnings = false;
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets a value indicating whether [disable warnings].
        /// </summary>
        /// <value><c>true</c> if [disable warnings]; otherwise, <c>false</c>.</value>
        public bool DisableWarnings { get; set; }

        /// <summary>
        ///   Gets or sets the folder.
        /// </summary>
        /// <value>The folder.</value>
        public string Folder { get; set; }

        /// <summary>
        ///   Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        /// <summary>
        ///   Gets or sets the share data set.
        /// </summary>
        /// <value>The share data set.</value>
        /// <remarks>
        ///   Adding the meta data ReportServerProperties will with comma
        ///   separated name value paired list will set the report server
        ///   properties I.E.: [Properties Name]=[Value];[Properties Name]=[Value]
        /// </remarks>
        [Required]
        public ITaskItem[] ShareDataSets { get; set; }

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
            // Creates the new instances of the reporting services.  
            // Use the current users windows credentials to connect to the report server.
            R2DeploymentManger r2DeploymentManger = new R2DeploymentManger(this.ReportServerURL);
            ReportDataSet[] reportDataSets = new ReportDataSet[this.ShareDataSets.Length];
            r2DeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;

            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.ShareDataSets.Length; index++)
                {
                    reportDataSets[index] = new ReportDataSet()
                        {
                            ShareDataSetName = this.ShareDataSets[index].GetMetadata("Filename"), 
                            ShareDataSetFilePath = this.ShareDataSets[index].GetMetadata("FullPath"), 
                            DataSource = this.ShareDataSets[index].GetMetadata("DataSource"), 
                            DateSetFolder = this.ShareDataSets[index].GetMetadata("Folder"), 
                            DocumentLibraryURL =
                                string.IsNullOrEmpty(this.ShareDataSets[index].GetMetadata("ReportDataSetNames"))
                                    ? null
                                    : this.ShareDataSets[index].GetMetadata("DocumentLibraryURL")
                        };

                    string propertiesString = this.ShareDataSets[index].GetMetadata("ReportServerProperties");
                    if (!string.IsNullOrEmpty(propertiesString))
                    {
                        this.AddReportProperties(reportDataSets[index], propertiesString);
                    }
                }

                return r2DeploymentManger.UploadShareDataSets(reportDataSets, this.DisableWarnings);
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
        /// <param name="reportDataSet">
        /// The report data set.
        /// </param>
        /// <param name="propertiesString">
        /// The properties string.
        /// </param>
        private void AddReportProperties(ReportDataSet reportDataSet, string propertiesString)
        {
            string[] strings;
            foreach (string propertery in propertiesString.Split(new[] { ';' }))
            {
                strings = propertery.Split(new[] { '=' });
                reportDataSet.ReportServerProperties.Add(strings[0], strings[1]);
            }
        }

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