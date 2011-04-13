// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportFile.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Server Report Class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region using directive

    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using ssrsmsbuildtasks.DeploymentManger.InterFaces;

    #endregion

    /// <summary>
    /// Report Server Report Class.
    /// </summary>
    public class ReportFile : IReportServerUploadItem
    {
        #region Constants and Fields

        /// <summary>
        ///   The reporting services properties
        /// </summary>
        private readonly Dictionary<string, string> reportServerProperties;

        /// <summary>
        ///   Report file information.
        /// </summary>
        private FileInfo reportFileInfo;

        /// <summary>
        ///   Report name for report server.
        /// </summary>
        private string reportName;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the ReportFile class.
        /// </summary>
        public ReportFile()
        {
            this.reportServerProperties = new Dictionary<string, string>();
        }

        /// <summary>
        /// Initializes a new instance of the ReportFile class.
        /// </summary>
        /// <param name="reportFilePath">
        /// The report file path.
        /// </param>
        /// <param name="reportName">
        /// Name of the report.
        /// </param>
        public ReportFile(string reportFilePath, string reportName)
            : this(reportFilePath)
        {
            this.reportName = reportName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportFile"/> class.
        /// </summary>
        /// <param name="reportFilePath">
        /// The report file path.
        /// </param>
        public ReportFile(string reportFilePath)
            : this()
        {
            this.ReportFilePath = reportFilePath;
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets the report file info.
        /// </summary>
        /// <value>The report file info.</value>
        public FileInfo ReportFileInfo
        {
            get
            {
                return this.reportFileInfo;
            }
        }

        /// <summary>
        ///   Gets or sets the report file path.
        /// </summary>
        /// <value>The report file path.</value>
        public string ReportFilePath
        {
            get
            {
                return this.reportFileInfo.FullName;
            }

            set
            {
                this.reportFileInfo = new FileInfo(value);
            }
        }

        /// <summary>
        ///   Gets or sets the name of the report.
        /// </summary>
        /// <value>The name of the report.</value>
        public string ReportName
        {
            get
            {
                return this.reportName ?? this.reportFileInfo.Name.Replace(this.reportFileInfo.Extension, string.Empty);
            }

            set
            {
                this.reportName = value;
            }
        }

        /// <summary>
        ///   Gets the report properties.
        /// </summary>
        /// <value>The report properties.</value>
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
        string IReportServerUploadItem.UploadItemName
        {
            get
            {
                return this.ReportName;
            }
        }

        #endregion

        #region Implemented Interfaces

        #region IReportServerUploadItem

        /// <summary>
        /// Gets the bytes.
        /// </summary>
        /// <returns>
        /// Bytes array of the report file.
        /// </returns>
        public byte[] GetBytes()
        {
            string rdlString;
            using (StreamReader txtReader = this.reportFileInfo.OpenText())
            {
                rdlString = txtReader.ReadToEnd();
            }

            return (new UTF8Encoding()).GetBytes(rdlString);
        }

        #endregion

        #endregion
    }
}