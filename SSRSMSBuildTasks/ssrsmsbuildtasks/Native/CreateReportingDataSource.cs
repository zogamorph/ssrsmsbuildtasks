// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateReportingDataSource.cs" company="">
//   
// </copyright>
// <summary>
//   This MSBuild Task will create a new report server SQL Server shared data soruce on the report server.
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
    /// This MSBuild Task will create a new report server SQL Server shared data soruce on the report server.
    /// </summary>
    public class CreateReportingDataSource : Task
    {
        #region Constants and Fields

        /// <summary>
        /// The data provider.
        /// </summary>
        private DataProviderEnum dataProvider;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the data sources.
        /// </summary>
        /// <value>The data sources.</value>
        [Required]
        public ITaskItem[] DataSources { get; set; }

        /// <summary>
        /// The Report Server name.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Executes a task.
        /// </summary>
        /// <returns>
        /// true if the task executed successfully; otherwise, false.
        /// </returns>
        public override bool Execute()
        {
            // Connecting to the reporting server
            NativeDeploymentManger rs = new NativeDeploymentManger(this.ReportServerURL);
            rs.DeploymentMangerMessages += this.reportingServicesMessage;
            ReportServerDataSource[] reportServerDataSources = new ReportServerDataSource[this.DataSources.Length];
            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.DataSources.Length; index++)
                {
                    reportServerDataSources[index] = new ReportServerDataSource()
                        {
                            ConnectionString = this.DataSources[index].GetMetadata("ConnectionString"), 
                            DataSourceFolder = this.DataSources[index].GetMetadata("Folder"), 
                            Name = this.DataSources[index].GetMetadata("DataSourceName"), 
                            OverWrite = Convert.ToBoolean(this.DataSources[index].GetMetadata("OverWrite")), 
                            Provider =
                                (DataProviderEnum)
                                Enum.Parse(
                                    typeof(DataProviderEnum), this.DataSources[index].GetMetadata("Provider"), true)
                        };

                    if (!String.IsNullOrEmpty(this.DataSources[index].GetMetadata("WindowsUser")) &&
                        !String.IsNullOrEmpty(this.DataSources[index].GetMetadata("WindowsUserPassword")))
                    {
                        reportServerDataSources[index].WindowCredentials =
                            new ReportServerDataSourceWindowsCredentials(
                                this.DataSources[index].GetMetadata("WindowsUser"), 
                                this.DataSources[index].GetMetadata("WindowsUserPassWord"));
                    }

                    string propertiesString = this.DataSources[index].GetMetadata("ReportServerProperties");
                    if (!string.IsNullOrEmpty(propertiesString))
                    {
                        this.AddReportProperties(reportServerDataSources[index], propertiesString);
                    }
                }

                return rs.CreateDataSource(reportServerDataSources);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "CreateReportingDataSource", 
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
        /// <param name="reportServerDataSource">
        /// The report server reports.
        /// </param>
        /// <param name="propertiesString">
        /// The properties string.
        /// </param>
        private void AddReportProperties(ReportServerDataSource reportServerDataSource, string propertiesString)
        {
            string[] strings;
            foreach (string propertery in propertiesString.Split(new[] { ';' }))
            {
                strings = propertery.Split(new[] { '=' });
                reportServerDataSource.ReportServerProperties.Add(strings[0], strings[1]);
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
        private void reportingServicesMessage(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendReportMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}