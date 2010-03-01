// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportingService2005.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The reporting service 2005.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.Proxy.Native
{
    /// <summary>
    /// The reporting service 2005.
    /// </summary>
    public partial class ReportingService2005
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingService2005"/> class.
        /// </summary>
        /// <param name="reportingService2005Url">
        /// The reporting service 2005 url.
        /// </param>
        public ReportingService2005(string reportingService2005Url)
        {
            this.Url = reportingService2005Url;
        }

        #endregion
    }
}