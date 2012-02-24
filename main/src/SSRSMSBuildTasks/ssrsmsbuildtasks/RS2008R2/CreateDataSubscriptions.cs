// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateDataSubscriptions.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//  Create a Data Subscriptions for the reporting server;
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
    /// The Create Data Subscriptions
    /// </summary>
    public class CreateDataSubscriptions : Task
    {
        #region Properties

        /// <summary>
        ///   Gets or sets the report schedules.
        /// </summary>
        /// <value>The report schedules.</value>
        /// <remarks>
        /// This will create a Data Subscriptions of the selected report
        /// The following meta data is required:
        /// SubscriptionDescription: single string describing the subscription.
        /// ReportScheduleName:  the shared reporting schedule name that the subscription will use
        /// DeliveryMethod: Needs to be set as file or email.
        /// SubscriptionReportParamters:  A semi-colon list of <report parameter name> = <report parameter value> 
        /// SubscriptionSettings: A semi-colon list of <subscription setting name> = <subscription setting value> 
        /// SubscriptionReports: A semi-colon list of the full report server path of the reports for this subscription.
        /// QueryText: the query for the subscription data
        /// QueryFields: A semi-colon list of fields that the query will create
        /// SubscriptionShareConnection: full report server path to the shared data source
        /// SubscriptioSettingsFieldReferences: A semi-colon list of <subscription setting name> = <Field reference> 
        /// SubscriptionReportsFieldReferences: A semi-colon list of <report parameter name> = <Field reference>
        /// 
        /// Report Server Email
        ///     TO
        ///     CC
        ///     BCC
        ///     ReplyTo
        ///     IncludeReport
        ///     RenderFormat
        ///     Priority
        ///     Subject
        ///     Comment
        ///     IncludeLink
        ///     SendEmailToUserAlias
        /// 
        /// Report Server FileShare
        ///     FILENAME
        ///     PATH
        ///     RENDER_FORMAT
        ///     WRITEMODE
        ///     FILEEXTN
        ///     USERNAME
        ///     PASSWORD 
        /// </remarks>
        [Required]
        public ITaskItem[] DataSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets ReportingSite.
        /// </summary>
        /// <remarks>
        /// This only needs to set if the report server is an integrated report server then it needs to the site of the schedule
        /// </remarks>
        public string ReportingSite { get; set; }

        /// <summary>
        ///   Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

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
            R2DeploymentManger r2DeploymentManger = new R2DeploymentManger(this.ReportServerURL);
            r2DeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
            ReportDataSubscription[] reportDataSubscriptions = new ReportDataSubscription[this.DataSubscriptions.Length];

            try
            {
                for (int i = 0; i < this.DataSubscriptions.Length; i++)
                {
                    reportDataSubscriptions[i] = new ReportDataSubscription();
                    reportDataSubscriptions[i].Description =
                        this.DataSubscriptions[i].GetMetadata("SubscriptionDescription");
                    reportDataSubscriptions[i].ScheduleName = this.DataSubscriptions[i].GetMetadata(
                        "ReportScheduleName");
                    reportDataSubscriptions[i].DeliveryMethodOptions =
                        RSBuildHelper.DeliveryMethodOption(this.DataSubscriptions[i].GetMetadata("DeliveryMethod"));
                    RSBuildHelper.GetParameters(
                        reportDataSubscriptions[i].ReportParameters, 
                        this.DataSubscriptions[i].GetMetadata("SubscriptionReportParamters"));
                    RSBuildHelper.GetParameters(
                        reportDataSubscriptions[i].ExtensionSettings, 
                        this.DataSubscriptions[i].GetMetadata("SubscriptionSettings"));
                    reportDataSubscriptions[i].Reports.AddRange(
                        this.DataSubscriptions[i].GetMetadata("SubscriptionReports").Split(new[] { ';' }));
                    reportDataSubscriptions[i].SubscriptionQuery.QueryText =
                        this.DataSubscriptions[i].GetMetadata("QueryText");
                    reportDataSubscriptions[i].SubscriptionQuery.Fields.AddRange(
                        this.DataSubscriptions[i].GetMetadata("QueryFields").Split(new[] { ';' }));
                    reportDataSubscriptions[i].SubscriptionQuery.ShareConnection =
                        this.DataSubscriptions[i].GetMetadata("SubscriptionShareConnection");
                    RSBuildHelper.GetParameters(
                        reportDataSubscriptions[i].ExtensionSettingsFieldReferences, 
                        this.DataSubscriptions[i].GetMetadata("SubscriptioSettingsFieldReferences"));
                    RSBuildHelper.GetParameters(
                        reportDataSubscriptions[i].ReportFieldReferences, 
                        this.DataSubscriptions[i].GetMetadata("SubscriptionReportsFieldReferences"));
                }

                return r2DeploymentManger.CreateDataSubscrptions(reportDataSubscriptions, this.ReportingSite);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "CreateDataSubscriptions", 
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