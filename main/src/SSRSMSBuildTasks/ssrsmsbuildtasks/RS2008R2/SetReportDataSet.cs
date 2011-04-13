// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetReportDataSet.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The set report data source.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.RS2008R2
{
    #region using directive

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;
    using ssrsmsbuildtasks.DeploymentManger.ReportItems;

    #endregion

    /// <summary>
    /// The set report data source.
    /// </summary>
    public class SetReportDataSet : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets a value indicating whether function is recursive within the folders.
        /// </summary>
        /// <value><c>true</c> if recursive; otherwise, <c>false</c>.</value>
        [Required]
        public bool Recursive { get; set; }

        /// <summary>
        ///   Gets or sets the report item.
        /// </summary>
        /// <value>The report item.</value>
        /// <remarks>
        ///   The ReportItem can be a report server folder path which go through all the reports and sub folders report if recursive
        ///   or to path to the report which only set the data source for that report
        /// </remarks>
        [Required]
        public string ReportItem { get; set; }

        /// <summary>
        ///   Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }


        /// <summary>
        /// Gets or sets the share data sets.
        /// </summary>
        /// <value>The share data sets.</value>
        /// <remarks>
        /// The following meta data is required:  Folder - Folder of
        /// there the data source is stored within the report server. If the
        /// Reports use different data source name to refer to data source then
        /// add the refer name to following meta data on comma separated list:
        /// ReportDataSetNames
        /// </remarks>
        public ITaskItem[] ShareDataSets { get; set; }

        /// <summary>
        ///   Gets or sets a value indicating whether [use match case].
        /// </summary>
        /// <value><c>true</c> if [use match case]; otherwise, <c>false</c>.</value>
        public bool UseMatchCase { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The execute method which is call msbuild to run the task
        /// </summary>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public override bool Execute()
        {
            R2DeploymentManger r2DeploymentManger = new R2DeploymentManger(this.ReportServerURL);
            r2DeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
            ReportDataSet[] reportDataSets = new ReportDataSet[this.ShareDataSets.Length];
            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.ShareDataSets.Length; index++)
                {
                    reportDataSets[index] = new ReportDataSet
                        {
                            DateSetFolder = this.ShareDataSets[index].GetMetadata("Folder"), 
                            ShareDataSetName = this.ShareDataSets[index].GetMetadata("Filename"), 
                            ReportDataSetNames =
                                string.IsNullOrEmpty(this.ShareDataSets[index].GetMetadata("ReportDataSetNames"))
                                    ? null
                                    : this.ShareDataSets[index].GetMetadata("ReportDataSetNames").Split(new[] { ';' })
                        };
                }

                return r2DeploymentManger.SetReportDataSet(
                    this.ReportItem, this.Recursive, reportDataSets, this.UseMatchCase);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "SetReportDataSet", 
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