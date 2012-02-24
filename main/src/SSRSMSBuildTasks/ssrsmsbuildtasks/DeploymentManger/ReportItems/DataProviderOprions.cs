// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataProviderOprions.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   A list of supported Data Provider.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    /// <summary>
    /// A list of supported Data Provider.
    /// </summary>
    public enum DataProviderOprions
    {
        /// <summary>
        ///   SQL Server Provider.
        /// </summary>
        SQL = 0, 

        /// <summary>
        ///   AS Provider.
        /// </summary>
        OLEDBMD = 1
    }
}