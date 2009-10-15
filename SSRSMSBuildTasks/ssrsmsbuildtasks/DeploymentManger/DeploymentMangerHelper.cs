// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerHelper.cs" company="">
//   
// </copyright>
// <summary>
//   Static class with reuseable functions for reporting services.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    #region Directives

    using ssrsmsbuildtasks.MSReportService2005;

    #endregion

    /// <summary>
    /// Static class with reuseable functions for reporting services.
    /// </summary>
    public static class DeploymentMangerHelper
    {
        #region Public Methods

        /// <summary>
        /// Looks trought the list items to find the folder.
        /// </summary>
        /// <param name="items">
        /// List of item in the currnet folder.
        /// </param>
        /// <param name="folderName">
        /// The folder name to look for.
        /// </param>
        /// <returns>
        /// Flag if the folder has been found.
        /// </returns>
        public static bool FindFolder(CatalogItem[] items, string folderName)
        {
            bool found = false;

            for (int index = 0; index < items.Length && !found; index++)
            {
                if ((items[index].Type == ItemTypeEnum.Folder) && (items[index].Name == folderName))
                {
                    found = true;
                }
            }

            return found;
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
        /// Flag if the is item has been found.
        /// </returns>
        public static bool FindItemType(CatalogItem[] items, string reportItemName, ItemTypeEnum itemFindType)
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
        /// Make sure the folder path is correct formated.
        /// </summary>
        /// <param name="folderPath">
        /// The folder path.
        /// </param>
        /// <returns>
        /// The path for folder.
        /// </returns>
        public static string FormatFolderPath(string folderPath)
        {
            return FormatItemPath(folderPath);
        }

        /// <summary>
        /// This make sure the path to a item start with the / - to show root.
        /// </summary>
        /// <param name="itemPath">
        /// The item path. 
        /// </param>
        /// <returns>
        /// Correct the item path.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">
        /// value is null. 
        /// </exception>
        public static string FormatItemPath(string itemPath)
        {
            string newItemPath = itemPath.StartsWith("/") ? itemPath : string.Concat("/", itemPath);
            return newItemPath.Replace("//", "/");
        }

        /// <summary>
        /// This will take the url to the report server and append the web service.
        /// </summary>
        /// <param name="reportServerURL">
        /// The url to the report server.
        /// </param>
        /// <returns>
        /// The full url address to the report server web services.
        /// </returns>
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
        /// This will take the url to the report server and append the web service.
        /// </summary>
        /// <param name="reportServerURL">
        /// The url to the report server.
        /// </param>
        /// <returns>
        /// The full url address to the report server web services.
        /// </returns>
        public static string AddIntegratedWebServiceToUrl(string reportServerURL)
        {
            if (reportServerURL.EndsWith(@"/_vti_bin/ReportServer/ReportService2006.asmx"))
            {
                return reportServerURL;
            }

            if (reportServerURL.EndsWith("/"))
            {
                return string.Format(@"{0}_vti_bin/ReportServer/ReportService2006.asmx", reportServerURL);
            }

            return string.Format(@"{0}/_vti_bin/ReportServer/ReportService2006.asmx", reportServerURL);
        }

        #endregion
    }
}