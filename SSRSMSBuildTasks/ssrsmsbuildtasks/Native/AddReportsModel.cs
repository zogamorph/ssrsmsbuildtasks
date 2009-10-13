// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddReportsModel.cs" company="">
//   
// </copyright>
// <summary>
//   Upload a report model to the report server
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
    /// Upload a report model to the report server
    /// </summary>
    public class AddReportsModel : Task
    {
        #region Properties

        /// <summary>
        /// Gets or sets Folder.
        /// </summary>
        /// <value>The name of the folder.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        /// Gets or sets ReportModels.
        /// </summary>
        /// <value>The report models.</value>
        [Required]
        public ITaskItem[] ReportModels { get; set; }

        /// <summary>
        /// Gets or sets ReportServerURL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The i task. execute.
        /// </summary>
        /// <returns>
        /// The i task. execute.
        /// </returns>
        public override bool Execute()
        {
            NativeDeploymentManger rs = new NativeDeploymentManger(this.ReportServerURL);
            ReportModelFiles[] reportModelsFiles = new ReportModelFiles[this.ReportModels.Length];
            rs.DeploymentMangerMessages += this.reportingServicesMessage;
            try
            {
                for (int index = 0; index < this.ReportModels.Length; index++)
                {
                    reportModelsFiles[index] = new ReportModelFiles(
                        this.ReportModels[index].GetMetadata("FullPath"), 
                        this.ReportModels[index].GetMetadata("DataSourceFullPath"));
                    string propertiesString = this.ReportModels[index].GetMetadata("ReportServerProperties");
                    if (!string.IsNullOrEmpty(propertiesString))
                    {
                        this.AddModelProperties(reportModelsFiles[index], propertiesString);
                    }
                }

                return rs.UploadModel(reportModelsFiles, this.Folder);
            }
            catch (Exception exception)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "AddReportsModel", 
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
        /// Adds the report properties.
        /// </summary>
        /// <param name="reportModelFiles">
        /// The report server reports.
        /// </param>
        /// <param name="propertiesString">
        /// The properties string.
        /// </param>
        private void AddModelProperties(ReportModelFiles reportModelFiles, string propertiesString)
        {
            string[] strings;
            foreach (string propertery in propertiesString.Split(new[] { ';' }))
            {
                strings = propertery.Split(new[] { '=' });
                reportModelFiles.ReportServerProperties.Add(strings[0], strings[1]);
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