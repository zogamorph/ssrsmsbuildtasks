// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteDataSource.cs" company="">
//   
// </copyright>
// <summary>
//   This MSBuild Task will delete report server data source on the report server.
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
    /// This MSBuild Task will delete report server data source on the report server.
    /// </summary>
    public class DeleteReportingDataSource : Task
    {
        #region Properties

        /// <summary>
        /// The data of the data source
        /// </summary>
        /// <value>The name of the data source.</value>
        [Required]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The location of the data source
        /// </summary>
        /// <value>The data source folder.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        /// The Report Server name.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

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
            NativeDeploymentManger rs = new NativeDeploymentManger(this.ReportServerURL);
            rs.DeploymentMangerMessages += this.reportingServicesMessage;
            try
            {
                return rs.DeleteReportDataSource(this.DataSourceName, this.Folder);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "DeleteDataSource", 
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