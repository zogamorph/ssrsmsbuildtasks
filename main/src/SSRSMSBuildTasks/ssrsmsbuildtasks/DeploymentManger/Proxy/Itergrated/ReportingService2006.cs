// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportingService2006.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The reporting service 2006.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.Proxy.Itergrated
{
    /// <summary>
    /// The reporting service 2006.
    /// </summary>
    public partial class ReportingService2006
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingService2006"/> class.
        /// </summary>
        /// <param name="reportingService2006Url">
        /// The reporting service 2006 url.
        /// </param>
        public ReportingService2006(string reportingService2006Url)
        {
            this.Url = reportingService2006Url;
        }

        #endregion
    }
}