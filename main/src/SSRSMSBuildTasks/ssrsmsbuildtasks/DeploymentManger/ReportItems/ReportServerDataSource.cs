// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportServerDataSource.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Server Data Source Class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region Directives

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// Report Server Data Source Class.
    /// </summary>
    public sealed class ReportServerDataSource
    {
        #region Constants and Fields

        /// <summary>
        ///   The reporting services properties
        /// </summary>
        private readonly Dictionary<string, string> reportServerProperties;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the ReportServerDataSource class.
        /// </summary>
        public ReportServerDataSource()
        {
            this.reportServerProperties = new Dictionary<string, string>();
        }

        /// <summary>
        /// Initializes a new instance of the ReportServerDataSource class.
        /// </summary>
        /// <param name="reportDataSourceNames">
        /// List of the report data source names.
        /// </param>
        /// <param name="name">
        /// The Data Source name.
        /// </param>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <param name="connectionString">
        /// The connection string.
        /// </param>
        /// <param name="overWrite">
        /// if set to <c>true</c> [over write].
        /// </param>
        /// <param name="dataSourceFolder">
        /// The data source folder.
        /// </param>
        /// <param name="windowCredentials">
        /// The window credentials.
        /// </param>
        public ReportServerDataSource(
            string[] reportDataSourceNames, 
            string name, 
            DataProviderOprions provider, 
            string connectionString, 
            bool overWrite, 
            string dataSourceFolder, 
            ReportServerDataSourceWindowsCredentials windowCredentials)
            : this()
        {
            this.Name = name;
            this.Provider = provider;
            this.ConnectionString = connectionString;
            this.WindowCredentials = windowCredentials;
            this.OverWrite = overWrite;
            this.DataSourceFolder = dataSourceFolder;
        }

        /// <summary>
        /// Initializes a new instance of the ReportServerDataSource class.
        /// </summary>
        /// <param name="reportDataSourceNames">
        /// List of the report data source names.
        /// </param>
        /// <param name="name">
        /// The Data Source name.
        /// </param>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <param name="connectionString">
        /// The connection string.
        /// </param>
        /// <param name="overWrite">
        /// if set to <c>true</c> [over write].
        /// </param>
        /// <param name="dataSourceFolder">
        /// The data source folder.
        /// </param>
        public ReportServerDataSource(
            string[] reportDataSourceNames, 
            string name, 
            DataProviderOprions provider, 
            string connectionString, 
            bool overWrite, 
            string dataSourceFolder)
            : this()
        {
            this.Name = name;
            this.Provider = provider;
            this.ConnectionString = connectionString;
            this.OverWrite = overWrite;
            this.DataSourceFolder = dataSourceFolder;
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the prompt displayed to the user when asking for security credentials.
        /// </summary>
        /// <value>A string containing the text to use to prompt the user for credentials.</value>
        public string CredentialsPrompt { get; set; }

        /// <summary>
        ///   Gets or sets the data source folder.
        /// </summary>
        /// <value>The data source folder.</value>
        public string DataSourceFolder { get; set; }

        /// <summary>
        ///   Gets or sets the Data Source name.
        /// </summary>
        /// <value>The Data Source name.</value>
        public string Name { get; set; }

        /// <summary>
        ///   Gets or sets a value indicating whether [over write].
        /// </summary>
        /// <value>
        ///   <c>True.</c>If [over write]; otherwise,.
        ///   <c>False.</c>
        /// </value>
        public bool OverWrite { get; set; }

        /// <summary>
        ///   Gets or sets the provider.
        /// </summary>
        /// <value>The data provider.</value>
        public DataProviderOprions Provider { get; set; }

        /// <summary>
        ///   Gets or sets the name of the report.
        /// </summary>
        /// <value>The name of the report.</value>
        public string[] ReportDataSourceNames { get; set; }

        public string DocumentLibraryURL { get; set; }

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
        ///   Gets or sets the window credentials.
        /// </summary>
        /// <value>The window credentials.</value>
        public ReportServerDataSourceWindowsCredentials WindowCredentials { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates the data source properties.
        /// </summary>
        public void CreateDefaultProperties()
        {
            this.reportServerProperties.Clear();
            this.reportServerProperties.Add("Description", string.Empty);
            this.reportServerProperties.Add("Hidden", "False");
        }

        public string GetDataSourceFolder() 
        {
            this.DataSourceFolder = DeploymentMangerHelper.FormatFolderPath(this.DataSourceFolder);
            this.DocumentLibraryURL = DeploymentMangerHelper.FormatDocumentLibraryURL(this.DocumentLibraryURL);
            return string.IsNullOrEmpty(this.DocumentLibraryURL) ? this.DataSourceFolder : string.Concat(this.DocumentLibraryURL, this.DataSourceFolder);
        }

        public string GetDataSourceName()
        {
            return string.IsNullOrEmpty(this.DocumentLibraryURL) ? this.Name : string.Concat(this.Name, ".rsds");
        }

        #endregion
    }
}