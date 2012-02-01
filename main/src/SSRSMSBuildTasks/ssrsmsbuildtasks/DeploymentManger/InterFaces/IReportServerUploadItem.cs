// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReportServerUploadItem.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The Report upload services
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.InterFaces
{
    #region Directives

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The Report upload services
    /// </summary>
    internal interface IReportServerUploadItem
    {
        #region Properties

        /// <summary>
        ///   Gets the report server properties.
        /// </summary>
        /// <value>The report server properties.</value>
        Dictionary<string, string> ReportServerProperties { get; }

        /// <summary>
        ///   Gets the name of the upload item.
        /// </summary>
        /// <value>The name of the upload item.</value>
        string UploadItemName { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the bytes.
        /// </summary>
        /// <returns>
        /// a byte array
        /// </returns>
        byte[] GetBytes();

        #endregion
    }
}