// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerHelper.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Static class with reuseable functions for reporting services.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    #region Directives

    using ssrsmsbuildtasks.MSReportService2005;
    using ssrsmsbuildtasks.MSReportService2006;
    #endregion

    /// <summary>
    /// Deployment Manger Helper
    /// </summary>
    public static class DeploymentMangerHelper
    {
        #region Public Methods

        /// <summary>
        /// Adds the integrated web service to URL.
        /// </summary>
        /// <param name="sharePointSiteUrl">The share point site URL.</param>
        /// <returns>Report Server Web Services URL</returns>
        public static string AddIntegratedWebServiceToUrl(string sharePointSiteUrl)
        {
            if (sharePointSiteUrl.EndsWith(@"/_vti_bin/ReportServer/ReportService2006.asmx"))
            {
                return sharePointSiteUrl;
            }

            if (sharePointSiteUrl.EndsWith("/"))
            {
                return string.Format(@"{0}_vti_bin/ReportServer/ReportService2006.asmx", sharePointSiteUrl);
            }

            return string.Format(@"{0}/_vti_bin/ReportServer/ReportService2006.asmx", sharePointSiteUrl);
        }


        /// <summary>
        /// Adds the native web service to URL.
        /// </summary>
        /// <param name="reportServerURL">The report server URL.</param>
        /// <returns>Report Server Web Services URL</returns>
        public static string AddNativeWebServiceToUrl(string reportServerURL)
        {
            if (reportServerURL.EndsWith("ReportService2005.asmx"))
            {
                return reportServerURL;
            }

            if (reportServerURL.EndsWith("/"))
            {
                return string.Format("{0}ReportService2005.asmx", reportServerURL);
            }

            return string.Format("{0}/ReportService2005.asmx", reportServerURL);
        }

        /// <summary>
        /// Finds the folder.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="folderName">Name of the folder.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public static bool FindItemType(ssrsmsbuildtasks.MSReportService2006.CatalogItem[] items, string reportItemName, ssrsmsbuildtasks.MSReportService2006.ItemTypeEnum itemFindType)
        {

            bool flag = false;
            for (int i = 0; (i < items.Length) && !flag; i++)
            {
                if ((items[i].Type == itemFindType) && (items[i].Name == reportItemName))
                {
                    flag = true;
                }
            }

            return flag;
        }


        /// <summary>
        /// Finds the type of the item.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="reportItemName">Name of the report item.</param>
        /// <param name="itemFindType">Type of the item find.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public static bool FindItemType(ssrsmsbuildtasks.MSReportService2005.CatalogItem[] items, string reportItemName, ssrsmsbuildtasks.MSReportService2005.ItemTypeEnum itemFindType)
        {
            bool flag = false;
            for (int i = 0; (i < items.Length) && !flag; i++)
            {
                if ((items[i].Type == itemFindType) && (items[i].Name == reportItemName))
                {
                    flag = true;
                }
            }

            return flag;
        }


        /// <summary>
        /// Formats the folder path.
        /// </summary>
        /// <param name="folderPath">The folder path.</param>
        /// <returns>Formatted folder path</returns>
        public static string FormatFolderPath(string folderPath)
        {
            return FormatItemPath(folderPath);
        }


        /// <summary>
        /// Formats the item path.
        /// </summary>
        /// <param name="itemPath">The item path.</param>
        /// <returns>Formatted item path</returns>
        public static string FormatItemPath(string itemPath)
        {
            string newItemPath = itemPath.StartsWith("/") ? itemPath : string.Concat("/", itemPath);
            return newItemPath.Replace("//", "/");
        }

        #endregion
    }
}