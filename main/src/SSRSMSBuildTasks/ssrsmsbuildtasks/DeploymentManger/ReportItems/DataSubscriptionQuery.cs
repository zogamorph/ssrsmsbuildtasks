// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataSubscriptionQuery.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Data Subscription Query
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region Directives

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// Data Subscription Query
    /// </summary>
    public class DataSubscriptionQuery
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSubscriptionQuery"/> class. 
        /// </summary>
        public DataSubscriptionQuery()
        {
            this.Fields = new List<string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets a list Fields.
        /// </summary>
        public List<string> Fields { get; private set; }

        /// <summary>
        /// Gets or sets QueryText.
        /// </summary>
        public string QueryText { get; set; }

        /// <summary>
        /// Gets or sets ShareConnection.
        /// </summary>
        public string ShareConnection { get; set; }

        #endregion
    }
}