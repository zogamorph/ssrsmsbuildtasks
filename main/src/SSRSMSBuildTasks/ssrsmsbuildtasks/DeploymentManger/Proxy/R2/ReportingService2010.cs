// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportingService2010.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The reporting service 2010.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.Proxy.R2
{
    /// <summary>
    /// The reporting service 2010.
    /// </summary>
    public partial class ReportingService2010
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingService2010"/> class.
        /// </summary>
        /// <param name="reportingService2010Url">
        /// The reporting service 2010 url.
        /// </param>
        public ReportingService2010(string reportingService2010Url)
        {
            this.Url = reportingService2010Url;
        }

        #endregion
    }
}