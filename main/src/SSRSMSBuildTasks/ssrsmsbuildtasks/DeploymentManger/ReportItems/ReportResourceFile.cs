// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportResourceFile.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Server Resource class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region using directive

    using System;
    using System.Collections.Generic;
    using System.IO;

    using ssrsmsbuildtasks.DeploymentManger.InterFaces;

    #endregion

    /// <summary>
    /// Report Server Resource class.
    /// </summary>
    public class ReportResourceFile : IReportServerUploadItem
    {
        #region Constants and Fields

        /// <summary>
        ///   fileInfo field
        /// </summary>
        private readonly FileInfo fileInfo;

        /// <summary>
        ///   The reporting services properties
        /// </summary>
        private readonly Dictionary<string, string> reportServerProperties;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the ReportResourceFile class. Initializes a new instance of the ReportResourceFile class. Initializes a new instance of the ReportResourceFile class. Initializes a new instance of the ReportResourceFile class. Initializes a new instance of the  class. Name of the file.  The full file name of the resoucre.
        /// </summary>
        /// <param name="fileName">
        /// Name of the file.
        /// </param>
        public ReportResourceFile(string fileName)
        {
            this.reportServerProperties = new Dictionary<string, string>();
            this.fileInfo = new FileInfo(fileName);
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets the type of the mine.
        /// </summary>
        /// <value>The type of the mine.</value>
        public string MineType { get; set; }

        /// <summary>
        ///   Gets the resource name.
        /// </summary>
        /// <value>The Resource name.</value>
        public string Name
        {
            get
            {
                return this.fileInfo.Name;
            }
        }

        /// <summary>
        ///   Gets the resource properties.
        /// </summary>
        /// <value>The resource  properties.</value>
        public Dictionary<string, string> ReportServerProperties
        {
            get
            {
                return this.reportServerProperties;
            }
        }

        /// <summary>
        ///   Gets UploadItemName.
        /// </summary>
        /// <exception cref = "NotImplementedException">
        /// </exception>
        string IReportServerUploadItem.UploadItemName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Implemented Interfaces

        #region IReportServerUploadItem

        /// <summary>
        /// Gets the resource bytes.
        /// </summary>
        /// <returns>
        /// Bytes of the resource file.
        /// </returns>
        public byte[] GetBytes()
        {
            int bytesRead;
            byte[] artefactBytes;
            using (FileStream fs = File.Open(this.fileInfo.FullName, FileMode.Open, FileAccess.Read))
            {
                artefactBytes = new byte[fs.Length];
                bytesRead = fs.Read(artefactBytes, 0, Convert.ToInt32(fs.Length));
            }

            if (bytesRead <= 0)
            {
                return null;
            }

            return artefactBytes;
        }

        #endregion

        #endregion
    }
}