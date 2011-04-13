// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddReportsModel.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This MSBuild Task will upload a list of a report models files to the requested report server.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.Native
{
    #region using directive

    using System;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;
    using ssrsmsbuildtasks.DeploymentManger.ReportItems;

    #endregion

    /// <summary>
    /// This MSBuild Task will upload a list of a report models files to the requested report server.
    /// </summary>
    public class AddReportsModel : Task
    {
        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the <see cref = "AddReportsModel" /> class.
        /// </summary>
        public AddReportsModel()
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
        ///   Gets or sets report folder path.
        /// </summary>
        /// <value>The report folder path.</value>
        [Required]
        public string Folder { get; set; }

        /// <summary>
        ///   Gets or sets ReportModels.
        /// </summary>
        /// <value>The report models.</value>
        /// <remarks>
        ///   The following meta data are needed to for report models
        ///   ModelName - Name of the model 
        ///   DataSourceFullPath - Location of the Data Source View File  
        ///   Adding the meta data ReportServerProperties will with comma
        ///   separated name value paired list will set the report server
        ///   properties I.E.: [Properties Name]=[Value];[Properties Name]=[Value]
        /// </remarks>
        [Required]
        public ITaskItem[] ReportModels { get; set; }

        /// <summary>
        ///   Gets or sets report server URL.
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
            NativeDeploymentManger nativeDeploymentManger = new NativeDeploymentManger(this.ReportServerURL);
            ReportModelFiles[] reportModelsFiles = new ReportModelFiles[this.ReportModels.Length];
            nativeDeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
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

                return nativeDeploymentManger.UploadModel(reportModelsFiles, this.Folder, this.DisableWarnings);
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