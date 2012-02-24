// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportSubscription.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Subscription
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region Directives

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// Report Subscription
    /// </summary>
    public class ReportSubscription
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportSubscription"/> class.
        /// </summary>
        public ReportSubscription()
        {
            this.ExtensionSettings = new Dictionary<string, string>();
            this.ReportParameters = new Dictionary<string, string>();
            this.Reports = new List<string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the delivery method options.
        /// </summary>
        /// <value>The delivery method options.</value>
        public SubsrptionDeliveryMethodOptions DeliveryMethodOptions { get; set; }

        /// <summary>
        /// The Subscription description
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// The extension of Subscription
        /// </summary>
        /// <value>The extension settings.</value>
        public Dictionary<string, string> ExtensionSettings { get; private set; }

        /// <summary>
        /// The extension of the report Parameters Subscription
        /// </summary>
        /// <value>The report parameters.</value>
        public Dictionary<string, string> ReportParameters { get; private set; }

        /// <summary>
        /// The list of the reports that need to have the subscription
        /// </summary>
        /// <value>The reports.</value>
        public List<string> Reports { get; private set; }

        /// <summary>
        /// The Schedule Name the subscription is to use
        /// </summary>
        /// <value>The name of the schedule.</value>
        public string ScheduleName { get; set; }

        #endregion
    }
}