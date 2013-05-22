// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportingService2010.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The reporting service 2010.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net;

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

            var credentials = GetCredentialsInUrl(reportingService2010Url);
            if (credentials != null)
            {
                PerformFormsAuthentication(credentials);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets ReportingSite.
        /// </summary>
        public string ReportingSite
        {
            get
            {
                return this.Url.Substring(0, this.Url.LastIndexOf("/"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Perform forms authentication with the reporting service server
        /// </summary>
        /// <param name="credentials">The credentials to be used</param>
        private void PerformFormsAuthentication(NetworkCredential credentials)
        {
            // Register a cookie-container to store the authentication token
            this.CookieContainer = new CookieContainer();

            // Call the LogonUser method to get authenticated
            this.LogonUser(credentials.UserName, credentials.Password, "");
        }

        /// <summary>
        /// Fetch credentials stored in userinfo-section in an URL
        /// </summary>
        /// <param name="reportingService2010Url">The URL</param>
        /// <returns>The stored credentials or null if none found</returns>
        private NetworkCredential GetCredentialsInUrl(string reportingService2010Url)
        {
            var uri = new Uri(reportingService2010Url);
            var userInfo = uri.UserInfo;
            if (!String.IsNullOrEmpty(userInfo))
            {
                var idx = userInfo.IndexOf(":");
                return new NetworkCredential
                {
                    UserName = userInfo.Substring(0, idx),
                    Password = userInfo.Substring(idx + 1)
                };
            }
            return null;
        }

        #endregion
    }
}