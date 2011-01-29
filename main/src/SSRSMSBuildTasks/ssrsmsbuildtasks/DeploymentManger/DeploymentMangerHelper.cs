// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerHelper.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{

    /// <summary>
    /// Deployment Manger Helper
    /// </summary>
    public static class DeploymentMangerHelper
    {
        #region Constants and Fields

        /// <summary>
        /// The reportservic e 2005 asmx.
        /// </summary>
        private const string REPORTSERVICE2005ASMX = "ReportService2005.asmx";

        /// <summary>
        /// The vtibinreportserverreportservic e 2006 asmx.
        /// </summary>
        private const string VTIBINREPORTSERVERREPORTSERVICE2006ASMX = @"/_vti_bin/ReportServer/ReportService2006.asmx";

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds the integrated web service to URL.
        /// </summary>
        /// <param name="sharePointSiteUrl">
        /// The share point site URL.
        /// </param>
        /// <returns>
        /// Report Server Web Services URL
        /// </returns>
        public static string AddIntegratedWebServiceToUrl(string sharePointSiteUrl)
        {
            if (sharePointSiteUrl.EndsWith(VTIBINREPORTSERVERREPORTSERVICE2006ASMX))
            {
                return sharePointSiteUrl;
            }

            if (sharePointSiteUrl.EndsWith("/"))
            {
                return string.Format(@"{0}{1}", sharePointSiteUrl, VTIBINREPORTSERVERREPORTSERVICE2006ASMX);
            }

            return string.Format(@"{0}/{1}", sharePointSiteUrl, VTIBINREPORTSERVERREPORTSERVICE2006ASMX);
        }

        /// <summary>
        /// Adds the native web service to URL.
        /// </summary>
        /// <param name="reportServerURL">
        /// The report server URL.
        /// </param>
        /// <returns>
        /// Report Server Web Services URL
        /// </returns>
        public static string AddNativeWebServiceToUrl(string reportServerURL)
        {
            if (reportServerURL.EndsWith(REPORTSERVICE2005ASMX))
            {
                return reportServerURL;
            }

            if (reportServerURL.EndsWith("/"))
            {
                return string.Format("{0}{1}", reportServerURL, REPORTSERVICE2005ASMX);
            }

            return string.Format("{0}/{1}", reportServerURL, REPORTSERVICE2005ASMX);
        }

        /// <summary>
        /// Finds the folder.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <param name="reportItemName">
        /// Name of the report item.
        /// </param>
        /// <param name="itemFindType">
        /// Type of the item find.
        /// </param>
        /// <returns>
        /// <c>true</c> if exists; otherwise, <c>false</c>.
        /// </returns>
        public static bool FindItemType(Proxy.Itergrated.CatalogItem[] items, string reportItemName, Proxy.Itergrated.ItemTypeEnum itemFindType)
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
        /// <param name="items">
        /// The items.
        /// </param>
        /// <param name="reportItemName">
        /// Name of the report item.
        /// </param>
        /// <param name="itemFindType">
        /// Type of the item find.
        /// </param>
        /// <returns>
        /// <c>true</c> if exists; otherwise, <c>false</c>.
        /// </returns>
        public static bool FindItemType(
            Proxy.Native.CatalogItem[] items, string reportItemName, Proxy.Native.ItemTypeEnum itemFindType)
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
        /// The find item type.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <param name="reportItemName">
        /// The report item name.
        /// </param>
        /// <param name="itemFindType">
        /// The item find type.
        /// </param>
        /// <returns>
        /// The find item type.
        /// </returns>
        public static bool FindItemType(Proxy.R2.CatalogItem[] items, string reportItemName, string itemFindType)
        {
            bool flag = false;
            for (int i = 0; (i < items.Length) && !flag; i++)
            {
                if ((items[i].TypeName == itemFindType) && (items[i].Name == reportItemName))
                {
                    flag = true;
                }
            }

            return flag;
        }

        /// <summary>
        /// Formats the folder path.
        /// </summary>
        /// <param name="folderPath">
        /// The folder path.
        /// </param>
        /// <returns>
        /// Formatted folder path
        /// </returns>
        public static string FormatFolderPath(string folderPath)
        {
            return FormatItemPath(folderPath);
        }

        /// <summary>
        /// Formats the item path.
        /// </summary>
        /// <param name="itemPath">
        /// The item path.
        /// </param>
        /// <returns>
        /// Formatted item path
        /// </returns>
        public static string FormatItemPath(string itemPath)
        {
            string newItemPath = itemPath.StartsWith("/") ? itemPath : string.Concat("/", itemPath);
            return newItemPath.Replace("//", "/");
        }

        #endregion
    }
}