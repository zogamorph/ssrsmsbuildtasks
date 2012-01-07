// -----------------------------------------------------------------------
// <copyright file="ReportScheduleWeekDays.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.Proxy.R2
{
    /// <summary>
    ///   The reporting service 2010.
    /// </summary>
    public partial class ReportingService2010
    {
        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the <see cref="ReportingService2010" /> class.
        /// </summary>
        /// <param name="reportingService2010Url"> The reporting service 2010 url. </param>
        public ReportingService2010(string reportingService2010Url)
        {
            this.Url = reportingService2010Url;
        }

        #endregion

        #region Public Properties

        public string ReportingSite
        {
            get
            {
                return this.Url.Substring(0, this.Url.LastIndexOf("/"));
            }
        }

        #endregion
    }
}