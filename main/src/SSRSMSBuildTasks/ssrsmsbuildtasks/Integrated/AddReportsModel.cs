// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddReportsModel.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Upload a report model to the report server
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Integrated
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
        /// <summary>
        /// Initializes a new instance of the <see cref="AddReportsModel"/> class.
        /// </summary>
        public AddReportsModel()
        {
            this.DisableWarnings = false;
        }

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
        /// Gets or sets SharePointSiteUrl.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string SharePointSiteUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to disable warnings.
        /// </summary>
        /// <value><c>true</c> if [disable warnings]; otherwise, <c>false</c>.</value>
        public bool DisableWarnings { get; set; }

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
            IntegratedDeploymentManager integratedDeploymentManager =
                new IntegratedDeploymentManager(this.SharePointSiteUrl);
            ReportModelFiles[] reportModelsFiles = new ReportModelFiles[this.ReportModels.Length];
            integratedDeploymentManager.DeploymentMangerMessages += this.deploymentMangerMessages;
            try
            {
                for (int index = 0; index < this.ReportModels.Length; index++)
                {
                    reportModelsFiles[index] = new ReportModelFiles(
                        this.ReportModels[index].GetMetadata("FullPath"), 
                        this.ReportModels[index].GetMetadata("DataSourceFullPath"), 
                        this.ReportModels[index].GetMetadata("ModelName"));
                    string propertiesString = this.ReportModels[index].GetMetadata("ReportServerProperties");
                    if (!string.IsNullOrEmpty(propertiesString))
                    {
                        this.AddModelProperties(reportModelsFiles[index], propertiesString);
                    }
                }

                return integratedDeploymentManager.UploadModel(reportModelsFiles, this.Folder, this.DisableWarnings);
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
        private void deploymentMangerMessages(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendDeploymentMangerMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        #endregion
    }
}