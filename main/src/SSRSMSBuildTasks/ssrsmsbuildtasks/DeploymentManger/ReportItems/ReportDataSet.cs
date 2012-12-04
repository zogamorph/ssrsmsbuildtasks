// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportDataSet.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The report data set.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region Directives

    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using ssrsmsbuildtasks.DeploymentManger.InterFaces;

    #endregion

    /// <summary>
    /// The report data set.
    /// </summary>
    public class ReportDataSet : IReportServerUploadItem
    {
        #region Constants and Fields

        /// <summary>
        ///   The report server properties.
        /// </summary>
        private readonly Dictionary<string, string> reportServerProperties;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSet"/> class.
        /// </summary>
        /// <param name="shareDataSetFilePath">
        /// The share data set file path.
        /// </param>
        /// <param name="shareDataSetName">
        /// Name of the share data set.
        /// </param>
        /// <param name="dateSetFolder">
        /// The date set folder.
        /// </param>
        /// <param name="dataSource">
        /// The data source.
        /// </param>
        /// <param name="reportDataSetNames">
        /// The report data set names.
        /// </param>
        public ReportDataSet(
            string shareDataSetFilePath, 
            string shareDataSetName, 
            string dateSetFolder, 
            string dataSource, 
            string[] reportDataSetNames)
            : this(shareDataSetFilePath, shareDataSetName, dateSetFolder, dataSource)
        {
            this.ReportDataSetNames = reportDataSetNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSet"/> class.
        /// </summary>
        /// <param name="shareDataSetFilePath">
        /// The share data set file path.
        /// </param>
        /// <param name="shareDataSetName">
        /// Name of the share data set.
        /// </param>
        /// <param name="dateSetFolder">
        /// The date set folder.
        /// </param>
        /// <param name="dataSource">
        /// The data source.
        /// </param>
        public ReportDataSet(
            string shareDataSetFilePath, string shareDataSetName, string dateSetFolder, string dataSource)
            : this(shareDataSetFilePath, shareDataSetName, dateSetFolder)
        {
            this.DataSource = dataSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSet"/> class.
        /// </summary>
        /// <param name="shareDataSetFilePath">
        /// The share data set file path.
        /// </param>
        /// <param name="shareDataSetName">
        /// The share data set name.
        /// </param>
        /// <param name="dateSetFolder">
        /// The date set folder.
        /// </param>
        public ReportDataSet(string shareDataSetFilePath, string shareDataSetName, string dateSetFolder)
            : this(shareDataSetFilePath, shareDataSetName)
        {
            this.DateSetFolder = dateSetFolder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSet"/> class.
        /// </summary>
        /// <param name="shareDataSetFilePath">
        /// The share data set file path.
        /// </param>
        /// <param name="shareDataSetName">
        /// Name of the share data set.
        /// </param>
        public ReportDataSet(string shareDataSetFilePath, string shareDataSetName)
            : this(shareDataSetFilePath)
        {
            this.ShareDataSetName = shareDataSetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDataSet"/> class.
        /// </summary>
        /// <param name="shareDataSetFilePath">
        /// The share data set file path.
        /// </param>
        public ReportDataSet(string shareDataSetFilePath)
            : this()
        {
            this.ShareDataSetFilePath = shareDataSetFilePath;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref = "ReportDataSet" /> class.
        /// </summary>
        public ReportDataSet()
        {
            this.reportServerProperties = new Dictionary<string, string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets DataSource.
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        ///   Gets or sets the date set folder.
        /// </summary>
        /// <value>The date set folder.</value>
        public string DateSetFolder { get; set; }

        /// <summary>
        /// Gets or sets DocumentLibraryURL.
        /// </summary>
        public string DocumentLibraryURL { get; set; }

        /// <summary>
        ///   Gets or sets the report data set names.
        /// </summary>
        /// <value>The report data set names.</value>
        public string[] ReportDataSetNames { get; set; }

        /// <summary>
        ///   Gets ReportServerProperties.
        /// </summary>
        public Dictionary<string, string> ReportServerProperties
        {
            get
            {
                return this.reportServerProperties;
            }
        }

        /// <summary>
        ///   Gets or sets ShareDataSetFilePath.
        /// </summary>
        public string ShareDataSetFilePath { get; set; }

        /// <summary>
        ///   Gets or sets ShareDataSetName.
        /// </summary>
        public string ShareDataSetName { get; set; }

        /// <summary>
        ///   Gets the name of the upload item.
        /// </summary>
        /// <value>The name of the upload item.</value>
        public string UploadItemName
        {
            get
            {
                return string.IsNullOrEmpty(this.DocumentLibraryURL)
                           ? this.ShareDataSetName
                           : string.Concat(this.ShareDataSetName, ".rsd");
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The get data set folder.
        /// </summary>
        /// <returns>
        /// The get data set folder.
        /// </returns>
        public string GetDataSetFolder()
        {
            this.DateSetFolder = DeploymentMangerHelper.FormatFolderPath(this.DateSetFolder);
            this.DocumentLibraryURL = DeploymentMangerHelper.FormatDocumentLibraryURL(this.DocumentLibraryURL);
            return string.IsNullOrEmpty(this.DocumentLibraryURL)
                       ? this.DateSetFolder
                       : string.Concat(this.DocumentLibraryURL, this.DateSetFolder);
        }

        #endregion

        #region Implemented Interfaces

        #region IReportServerUploadItem

        /// <summary>
        /// The get bytes.
        /// </summary>
        /// <returns>
        /// a byte array
        /// </returns>
        public byte[] GetBytes()
        {
            string rdlString;
            using (StreamReader txtReader = File.OpenText(this.ShareDataSetFilePath))
            {
                rdlString = txtReader.ReadToEnd();
            }

            return (new UTF8Encoding()).GetBytes(rdlString);
        }

        #endregion

        #endregion
    }
}