// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateSubscriptions.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   TODO: Update summary.
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
    /// Create Subscriptions for the reports on the reportserver
    /// </summary>
    public class CreateSubscriptions : Task
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.Build.Utilities.Task"/> class.
        /// </summary>
        public CreateSubscriptions()
        {
            this.DeleteExistingSubscriptions = false;
            this.DeployIfExistingSubscriptions = false;
        }

        #region Properties

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

        /// <summary>
        /// Gets or sets the report schedules.
        /// </summary>
        /// <value>The report schedules.</value>
        /// <remarks>
        /// This will create a Subscription for the the report
        /// <para>
        /// The following meta data is required:
        /// SubscriptionDescription: single string describing the subscription.
        /// ReportScheduleName:  the shared reporting schedule name that the subscription will use
        /// DeliveryMethod: Needs to be set as file or email.
        /// SubscriptionReportParamters:  A semi-colon list of [report parameter name] = [report parameter value]
        /// SubscriptionSettings: A semi-colon list of [subscription setting name] = [subscription setting value] 
        /// SubscriptionReports: A semi-colon list of the full report server path of the reports for this subscription.
        /// </para>
        /// <para>
        /// For Data Driven Subscription the following extra metadata is required: 
        /// QueryText: the query for the subscription data
        /// QueryFields: A semi-colon list of fields that the query will create
        /// SubscriptionShareConnection: full report server path to the shared data source
        /// SubscriptioSettingsFieldReferences: A semi-colon list of [subscription setting name] = [Field reference]
        /// SubscriptionReportsFieldReferences: A semi-colon list of [report parameter name] = [Field reference]
        /// </para>
        /// <para>
        /// Export Settings: 
        ///     <para>Email: TO, CC, BCC, ReplyTo, IncludeReport, RenderFormat, Priority, Subject, Comment, IncludeLink, SendEmailToUserAlias</para>
        ///     <para>FileShare: FILENAME, PATH, RENDER_FORMAT, WRITEMODE, FILEEXTN, USERNAME, PASSWORD</para>
        /// </para>
        /// </remarks>
        [Required]
        public ITaskItem[] Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [delete existing subscriptions].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [delete existing subscriptions]; otherwise, <c>false</c>.
        /// </value>
        public bool DeleteExistingSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [deploy if existing subscriptions].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [deploy if existing subscriptions]; otherwise, <c>false</c>.
        /// </value>
        public bool DeployIfExistingSubscriptions { get; set; }

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
            ReportSubscription[] reportSubscriptions = new ReportSubscription[this.Subscriptions.Length];

            try
            {
                for (int i = 0; i < this.Subscriptions.Length; i++)
                {
                    if (!string.IsNullOrEmpty(this.Subscriptions[i].GetMetadata("QueryText")))
                    {
                        ReportDataSubscription reportDataSubscription = new ReportDataSubscription();
                        reportDataSubscription.Description = this.Subscriptions[i].GetMetadata("SubscriptionDescription");
                        reportDataSubscription.ScheduleName = this.Subscriptions[i].GetMetadata("ReportScheduleName");
                        reportDataSubscription.DeliveryMethodOptions = RSBuildHelper.DeliveryMethodOption(this.Subscriptions[i].GetMetadata("DeliveryMethod"));
                        RSBuildHelper.GetParameters(
                            reportDataSubscription.ReportParameters,
                            this.Subscriptions[i].GetMetadata("SubscriptionReportParamters"));
                        RSBuildHelper.GetParameters(
                            reportDataSubscription.ExtensionSettings,
                            this.Subscriptions[i].GetMetadata("SubscriptionSettings"));
                        reportDataSubscription.Reports.AddRange(
                            this.Subscriptions[i].GetMetadata("SubscriptionReports").Split(new[] { ';' }));
                        reportDataSubscription.SubscriptionQuery.QueryText = this.Subscriptions[i].GetMetadata("QueryText");
                        reportDataSubscription.SubscriptionQuery.Fields.AddRange(this.Subscriptions[i].GetMetadata("QueryFields").Split(new[] { ';' }));
                        reportDataSubscription.SubscriptionQuery.ShareConnection = this.Subscriptions[i].GetMetadata("SubscriptionShareConnection");
                        RSBuildHelper.GetParameters(reportDataSubscription.ExtensionSettingsFieldReferences, this.Subscriptions[i].GetMetadata("SubscriptioSettingsFieldReferences"));
                        RSBuildHelper.GetParameters(reportDataSubscription.ReportFieldReferences, this.Subscriptions[i].GetMetadata("SubscriptionReportsFieldReferences"));
                        reportSubscriptions[i] = reportDataSubscription;
                    }
                    else
                    {
                        reportSubscriptions[i] = new ReportSubscription();
                        reportSubscriptions[i].Description = this.Subscriptions[i].GetMetadata("SubscriptionDescription");
                        reportSubscriptions[i].ScheduleName = this.Subscriptions[i].GetMetadata("ReportScheduleName");
                        reportSubscriptions[i].DeliveryMethodOptions =
                            RSBuildHelper.DeliveryMethodOption(this.Subscriptions[i].GetMetadata("DeliveryMethod"));
                        RSBuildHelper.GetParameters(
                            reportSubscriptions[i].ReportParameters,
                            this.Subscriptions[i].GetMetadata("SubscriptionReportParamters"));
                        RSBuildHelper.GetParameters(
                            reportSubscriptions[i].ExtensionSettings,
                            this.Subscriptions[i].GetMetadata("SubscriptionSettings"));
                        reportSubscriptions[i].Reports.AddRange(
                            this.Subscriptions[i].GetMetadata("SubscriptionReports").Split(new[] { ';' }));
                    }
                }

                return r2DeploymentManger.CreateSubscrptions(reportSubscriptions, this.ReportingSite, this.DeleteExistingSubscriptions, this.DeployIfExistingSubscriptions);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting",
                        "CreateSubscriptions",
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