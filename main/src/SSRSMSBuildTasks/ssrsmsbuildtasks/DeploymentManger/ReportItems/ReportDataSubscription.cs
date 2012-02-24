// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportDataSubscription.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The Report Data Subscription
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region Directives

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The Report Data Subscription 
    /// </summary>
    public class ReportDataSubscription : ReportSubscription
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSubscription"/> class.
        /// </summary>
        public ReportDataSubscription()
        {
            this.ReportFieldReferences = new Dictionary<string, string>();
            this.ExtensionSettingsFieldReferences = new Dictionary<string, string>();
            this.SubscriptionQuery = new DataSubscriptionQuery();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the extension settings field references.
        /// </summary>
        public Dictionary<string, string> ExtensionSettingsFieldReferences { get; private set; }

        /// <summary>
        /// Gets the report field references.
        /// </summary>
        public Dictionary<string, string> ReportFieldReferences { get; private set; }

        /// <summary>
        /// Gets the subscription query.
        /// </summary>
        public DataSubscriptionQuery SubscriptionQuery { get; private set; }

        #endregion
    }
}