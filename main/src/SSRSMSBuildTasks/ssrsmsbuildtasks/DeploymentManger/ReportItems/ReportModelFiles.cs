// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportModelFiles.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Server Model project files.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region using directive

    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;

    using ssrsmsbuildtasks.DeploymentManger.InterFaces;

    #endregion

    /// <summary>
    /// Report Server Model project files.
    /// </summary>
    public sealed class ReportModelFiles : IReportServerUploadItem
    {
        #region Constants and Fields

        /// <summary>
        ///   The reporting services properties
        /// </summary>
        private readonly Dictionary<string, string> reportServerProperties;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the  class.
        /// </summary>
        public ReportModelFiles()
        {
            this.reportServerProperties = new Dictionary<string, string>();
        }

        /// <summary>
        /// Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the ReportModelFiles class. Initializes a new instance of the  class. The full path.The data source full path.Name of the model.
        /// </summary>
        /// <param name="fullPath">
        /// The full path.
        /// </param>
        /// <param name="dataSourceFullPath">
        /// The data source full path.
        /// </param>
        /// <param name="modelName">
        /// Name of the model.
        /// </param>
        public ReportModelFiles(string fullPath, string dataSourceFullPath, string modelName)
            : this(fullPath, dataSourceFullPath)
        {
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportModelFiles"/> class.
        /// </summary>
        /// <param name="fullPath">
        /// The full path.
        /// </param>
        /// <param name="dataSourceFullPath">
        /// The data source full path.
        /// </param>
        public ReportModelFiles(string fullPath, string dataSourceFullPath)
            : this()
        {
            this.FullPath = fullPath;
            this.DataSourceFullPath = dataSourceFullPath;
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets the data source full path.
        /// </summary>
        /// <value>The data source full path.</value>
        public string DataSourceFullPath { get; set; }

        /// <summary>
        ///   Gets or sets the full path.
        /// </summary>
        /// <value>The full path.</value>
        public string FullPath { get; set; }

        /// <summary>
        ///   Gets or sets the name of the model.
        /// </summary>
        /// <value>The name of the model.</value>
        public string ModelName { get; set; }

        /// <summary>
        ///   Gets the model properties.
        /// </summary>
        /// <value>The model properties.</value>
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
                return this.ModelName;
            }
        }

        #endregion

        #region Implemented Interfaces

        #region IReportServerUploadItem

        /// <summary>
        /// Gets the bytes.
        /// </summary>
        /// <returns>
        /// Return array of bytes.
        /// </returns>
        /// <exception cref="System.InvalidOperationException">
        /// Calling this method on a node type which cannot be imported.
        /// </exception>
        public byte[] GetBytes()
        {
            XmlDocument xmlModel = new XmlDocument();
            XmlDocument xmlDataSource = new XmlDocument();
            FileInfo fileInfo = new FileInfo(this.FullPath);

            // load the xml files
            xmlModel.Load(fileInfo.FullName);
            xmlDataSource.Load(this.DataSourceFullPath);

            // load all data into nodes
            XmlNode documentElement = xmlModel.DocumentElement;
            XmlNode node = xmlDataSource.DocumentElement;

            // import data source node into a clean node 
            XmlNode newChild = xmlModel.ImportNode(node, true);

            // append the new node to model document to create a complete model file
            documentElement.AppendChild(newChild);

            // return the bytes
            return new UTF8Encoding().GetBytes(documentElement.OuterXml);
        }

        #endregion

        #endregion
    }
}