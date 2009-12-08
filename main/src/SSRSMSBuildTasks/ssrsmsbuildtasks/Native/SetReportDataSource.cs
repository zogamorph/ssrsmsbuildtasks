// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetReportDataSource.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The set report data source.
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
    /// The set report data source.
    /// </summary>
    public class SetReportDataSource : Task
    {
        #region Properties

        /// <summary>
        /// Gets or sets the data sources list.
        /// </summary>
        /// <value>The data sources list.</value>
        public ITaskItem[] DataSources { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SetReportDataSource"/> is recursive.
        /// </summary>
        /// <value><c>true</c> if recursive; otherwise, <c>false</c>.</value>
        [Required]
        public bool Recursive { get; set; }

        /// <summary>
        /// Gets or sets the report item.
        /// </summary>
        /// <value>The report item.</value>
        [Required]
        public string ReportItem { get; set; }

        /// <summary>
        /// Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [use match case].
        /// </summary>
        /// <value><c>true</c> if [use match case]; otherwise, <c>false</c>.</value>
        public bool UseMatchCase { get; set; }

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
            NativeDeploymentManger nativeDeploymentManger = new NativeDeploymentManger(this.ReportServerURL);
            nativeDeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
            ReportServerDataSource[] reportServerDataSources = new ReportServerDataSource[this.DataSources.Length];
            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.DataSources.Length; index++)
                {
                    reportServerDataSources[index] = new ReportServerDataSource()
                        {
                            DataSourceFolder = this.DataSources[index].GetMetadata("Folder"), 
                            Name = this.DataSources[index].ItemSpec, 
                            ReportDataSourceNames =
                                string.IsNullOrEmpty(this.DataSources[index].GetMetadata("ReportDataSourceNames"))
                                    ? null
                                    : this.DataSources[index].GetMetadata("ReportDataSourceNames").Split(
                                          new char[] { ';' }) 
                        };
                }

                return nativeDeploymentManger.SetReportDataSource(
                    this.ReportItem, this.Recursive, reportServerDataSources, this.UseMatchCase);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "SetReportDataSource", 
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