// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateReportingDataSource.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will create a new report server SQL Server shared data soruce on the report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Native
{
    #region Directives

    using System;
    using System.Text;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// This MSBuild Task will create a new report server SQL Server shared data soruce on the report server.
    /// </summary>
    public class CreateReportingDataSource : Task
    {
        #region Properties

        /// <summary>
        /// Gets or sets the data sources.
        /// </summary>
        /// <value>The data sources.</value>
        [Required]
        public ITaskItem[] DataSources { get; set; }

        /// <summary>
        /// Gets or sets the report server URL.
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
            string invaildDataourceMessage;

            // Connecting to the reporting server
            NativeDeploymentManger nativeDeploymentManger = new NativeDeploymentManger(this.ReportServerURL);
            nativeDeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
            ReportServerDataSource[] reportServerDataSources = new ReportServerDataSource[this.DataSources.Length];
            
            try
            {
                // loop through the array of reports.
                for (int index = 0; index < this.DataSources.Length; index++)
                {
                    
                    if (!this.isDataSourceValid(this.DataSources[index], out invaildDataourceMessage))
                    {
                        throw new Exception(invaildDataourceMessage);
                    }

                    reportServerDataSources[index] = new ReportServerDataSource()
                        {
                            ConnectionString = this.DataSources[index].GetMetadata("ConnectionString"), 
                            DataSourceFolder = this.DataSources[index].GetMetadata("Folder"), 
                            Name = this.DataSources[index].ItemSpec, 
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

                return nativeDeploymentManger.CreateDataSource(reportServerDataSources);
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
        private void deploymentMangerMessages(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendDeploymentMangerMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        /// <summary>
        /// The is data source vaild.
        /// </summary>
        /// <param name="dataSource">
        /// The data source.
        /// </param>
        /// <param name="invalidDataSourceMessage">
        /// The invalid data source message.
        /// </param>
        /// <returns>
        /// The is data source valid.
        /// </returns>
        private bool isDataSourceValid(ITaskItem dataSource, out string invalidDataSourceMessage)
        {
            StringBuilder invalidDataSourceMessageStringBuilder = new StringBuilder();
            bool isVaild = true;

            if (string.IsNullOrEmpty(dataSource.GetMetadata("ConnectionString")))
            {
                isVaild = false;
                invalidDataSourceMessageStringBuilder.AppendLine(
                    string.Format("{0}:Missing ConnectionString Metadata", dataSource.ItemSpec));
            }

            if (string.IsNullOrEmpty(dataSource.GetMetadata("Folder")))
            {
                isVaild = false;
                invalidDataSourceMessageStringBuilder.AppendLine(
                    string.Format("{0}:Missing Folder Metadata", dataSource.ItemSpec));
            }

            if (string.IsNullOrEmpty(dataSource.GetMetadata("OverWrite")))
            {
                isVaild = false;
                invalidDataSourceMessageStringBuilder.AppendLine(
                    string.Format("{0}:Missing OverWrite Metadata", dataSource.ItemSpec));
            }

            if (string.IsNullOrEmpty(dataSource.GetMetadata("Provider")))
            {
                isVaild = false;
                invalidDataSourceMessageStringBuilder.AppendLine(
                    string.Format("{0}:Missing Provider Metadata", dataSource.ItemSpec));
            }

            invalidDataSourceMessage = invalidDataSourceMessageStringBuilder.ToString();
            return isVaild;
        }

        #endregion
    }
}