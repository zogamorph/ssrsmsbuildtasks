// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntegratedDeploymentManager.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   The integrated deployment manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    #region Directives

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Net;
    using System.Text;

    using ssrsmsbuildtasks.MSReportService2006;

    #endregion

    /// <summary>
    /// The integrated deployment manager.
    /// </summary>
    public class IntegratedDeploymentManager
    {
        #region Constants and Fields

        /// <summary>
        /// MS Reporting Services Web Services Class
        /// </summary>
        private readonly ReportingService2006 reportingService2006;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegratedDeploymentManager"/> class.
        /// </summary>
        /// <param name="SharepointSiteURL">The sharepoint site URL.</param>
        public IntegratedDeploymentManager(string SharepointSiteURL)
        {
            SharepointSiteURL = DeploymentMangerHelper.AddIntegratedWebServiceToUrl(SharepointSiteURL);
            this.reportingService2006 = new ReportingService2006(SharepointSiteURL)
                {
                    Credentials = CredentialCache.DefaultCredentials 
                };
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when [deployment manger messages].
        /// </summary>
        public event DeploymentMangerMessage DeploymentMangerMessages;

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the report itemtype.
        /// </summary>
        /// <param name="itemTypeName">Name of the item type.</param>
        /// <returns></returns>
        public static ItemTypeEnum GetReportItemtype(string itemTypeName)
        {
            return (ItemTypeEnum)Enum.Parse(typeof(ItemTypeEnum), itemTypeName, true);
        }


        /// <summary>
        /// Adds the report user.
        /// </summary>
        /// <param name="reportUserName">Name of the report user.</param>
        /// <param name="reportingRoles">The reporting roles.</param>
        /// <param name="reportFolder">The report folder.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool AddReportUser(string reportUserName, string[] reportingRoles, string reportFolder)
        {
            int index;
            bool inheritParent, policyExists;
            Policy[] oldPolicy, newPolicy;

            try
            {
                // formats the folder name.
                reportFolder = DeploymentMangerHelper.FormatFolderPath(reportFolder);

                // Get the access policies of the folder.
                oldPolicy = this.reportingService2006.GetPolicies(reportFolder, out inheritParent);

                // Check to see if the user exists.
                policyExists = this.DoesPolicyExists(oldPolicy, reportUserName);

                // Create a new list Policy for the folder.  if the current user exists then it
                // will be list of the same length else the list will have a one new policy added
                newPolicy = new Policy[policyExists ? oldPolicy.Length : oldPolicy.Length + 1];

                // Copys the old policy to the new list.  If the policy already exists then copy
                // is not a straight forward.
                index = policyExists
                            ? this.RemovePolicy(reportUserName, oldPolicy, newPolicy)
                            : this.CopyOldPolicy(oldPolicy, newPolicy);

                // Adding the new user.
                newPolicy[index] = new Policy();
                newPolicy[index].GroupUserName = reportUserName;

                // Assgining the new roles to the user.
                newPolicy[index].Roles = new Role[reportingRoles.Length];
                this.AddReportingRoles(index, newPolicy, reportingRoles);

                // Updating the policies of the folder.
                this.reportingService2006.SetPolicies(reportFolder, newPolicy);
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Information, 
                    "AddReportUser", 
                    this.CreateCompleteMessage(reportUserName, reportingRoles, reportFolder));
                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Information, "AddReportUser", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Creates the data source.
        /// </summary>
        /// <param name="dataSources">The data sources.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool CreateDataSource(ReportServerDataSource[] dataSources)
        {
            bool success = false;
            foreach (ReportServerDataSource dataSource in dataSources)
            {
                success = this.CreateReportDataSource(dataSource);
                if (!success)
                {
                    break;
                }
            }

            return success;
        }


        /// <summary>
        /// Creates the folder.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="parentPath">The parent path.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool CreateFolder(string folderName, string parentPath)
        {
            try
            {
                this.reportingService2006.CreateFolder(folderName, parentPath);
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Information, 
                    "CreateFolder", 
                    string.Format("Created Report Folder: {0}/{1}", parentPath, folderName));

                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "CreateFolder", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Deletes the model.
        /// </summary>
        /// <param name="modelName">Name of the model.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool DeleteModel(string modelName)
        {
            // Create the item and format the items
            ItemTypeEnum currentItemType;
            modelName = DeploymentMangerHelper.FormatFolderPath(modelName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2006.GetItemType(modelName);
                if (currentItemType == ItemTypeEnum.Model)
                {
                    // Delete the folder
                    this.reportingService2006.DeleteItem(modelName);
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Information, 
                        "DeleteModel", 
                        string.Format("Deleted Report Item Source: {0}", modelName));
                    return true;
                }

                // raise a error because the item was not a folder.
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Warning, 
                    "DeleteModel", 
                    string.Format("Item not a Report: {0}", modelName));
                return false;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "DeleteReportFolder", ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Deletes the report.
        /// </summary>
        /// <param name="reportName">Name of the report.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool DeleteReport(string reportName)
        {
            // Create the item and format the items
            ItemTypeEnum currentItemType;
            reportName = DeploymentMangerHelper.FormatFolderPath(reportName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2006.GetItemType(reportName);
                if (currentItemType == ItemTypeEnum.Report)
                {
                    // Delete the folder
                    this.reportingService2006.DeleteItem(reportName);
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Information, 
                        "DeleteReport", 
                        string.Format("Deleted Report Item Source: {0}", reportName));
                    return true;
                }

                // raise a error because the item was not a folder.
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Warning, 
                    "DeleteReport", 
                    string.Format("Item not a Report: {0}", reportName));
                return false;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "DeleteReportFolder", ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Deletes the report data source.
        /// </summary>
        /// <param name="dataSourceName">Name of the data source.</param>
        /// <param name="dataSourceFolder">The data source folder.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool DeleteReportDataSource(string dataSourceName, string dataSourceFolder)
        {
            ItemTypeEnum currentItemType;

            // make sure the item path is formated.
            dataSourceFolder = DeploymentMangerHelper.FormatFolderPath(dataSourceFolder);
            try
            {
                // get the item type of the item check if datasource
                currentItemType =
                    this.reportingService2006.GetItemType(string.Format("{0}/{1}", dataSourceFolder, dataSourceName));

                // If not a data source then send a warning
                if (currentItemType != ItemTypeEnum.DataSource)
                {
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Warning, 
                        "DeleteReportDataSource", 
                        string.Format("Report Item is not a data source:{0}/{1}", dataSourceFolder, dataSourceName));
                    return false;
                }

                // else Delete the data source
                this.reportingService2006.DeleteItem(string.Format("{0}/{1}", dataSourceFolder, dataSourceName));
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Information, 
                    "DeleteReportDataSource", 
                    string.Format("Deleted Data Source {1}/{0}", dataSourceName, dataSourceFolder));
                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "DeleteReportDataSource", ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Deletes the report folder.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool DeleteReportFolder(string folderName)
        {
            // Create the item and format the items
            ItemTypeEnum currentItemType;
            folderName = DeploymentMangerHelper.FormatFolderPath(folderName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2006.GetItemType(folderName);
                if (currentItemType == ItemTypeEnum.Folder)
                {
                    // Delete the folder
                    this.reportingService2006.DeleteItem(folderName);
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Information, 
                        "DeleteReportFolder", 
                        string.Format("Deleted Report Folder Source: {0}", folderName));
                    return true;
                }

                // raise a error because the item was not a folder.
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Warning, 
                    "DeleteReportFolder", 
                    string.Format("Item not a folder: {0}", folderName));
                return false;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "DeleteReportFolder", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Deletes the resource.
        /// </summary>
        /// <param name="resourceName">Name of the resource.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool DeleteResource(string resourceName)
        {
            // Create the item and format the items
            ItemTypeEnum currentItemType;
            resourceName = DeploymentMangerHelper.FormatFolderPath(resourceName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2006.GetItemType(resourceName);
                if (currentItemType == ItemTypeEnum.Resource)
                {
                    // Delete the folder
                    this.reportingService2006.DeleteItem(resourceName);
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Information, 
                        "DeleteResource", 
                        string.Format("Deleted Report Item Source: {0}", resourceName));
                    return true;
                }

                // raise a error because the item was not a folder.
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Warning, 
                    "DeleteResource", 
                    string.Format("Item not a Resource: {0}", resourceName));
                return false;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "DeleteReportFolder", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Moves the report item.
        /// </summary>
        /// <param name="reportItem">The report item.</param>
        /// <param name="destinationItem">The destination item.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool MoveReportItem(string reportItem, string destinationItem)
        {
            try
            {
                // Fromat the item paths to make sure they are vaild
                reportItem = DeploymentMangerHelper.FormatItemPath(reportItem);
                destinationItem = DeploymentMangerHelper.FormatItemPath(destinationItem);

                // Call the move item method 
                this.reportingService2006.MoveItem(reportItem, destinationItem);
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Information, 
                    "MoveReportItem", 
                    string.Format("Moved {0} to {1}", reportItem, destinationItem));
                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "MoveReportItem", ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Reports the item exists.
        /// </summary>
        /// <param name="reportItemName">Name of the report item.</param>
        /// <param name="reportItemType">Type of the report item.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool ReportItemExists(string reportItemName, ItemTypeEnum reportItemType)
        {
            return this.ReportItemExists(reportItemName, reportItemType, string.Empty);
        }


        /// <summary>
        /// Reports the item exists.
        /// </summary>
        /// <param name="reportItemName">Name of the report item.</param>
        /// <param name="reportItemType">Type of the report item.</param>
        /// <param name="folderName">Name of the folder.</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool ReportItemExists(string reportItemName, ItemTypeEnum reportItemType, string folderName)
        {
            throw new NotImplementedException();

            //// Create the search condition
            // SearchCondition[] conditions = new[] { new SearchCondition() };

            //// Get formats the folder name
            // folderName = string.IsNullOrEmpty(folderName) ? "/" : DeploymentMangerHelper.FormatFolderPath(folderName);

            // try
            // {
            // // Set the search paramter
            // conditions[0].Condition = ConditionEnum.Equals;
            // conditions[0].ConditionSpecified = true;
            // conditions[0].Name = "Name";
            // conditions[0].Value = reportItemName;

            // // all the items that equal to the search parameter
            // CatalogItem[] items = this.reportingService2006.FindItems(
            // folderName, BooleanOperatorEnum.And, conditions);

            // // Find the item of the that type
            // return DeploymentMangerHelper.FindItemType(items, reportItemName, reportItemType);
            // }
            // catch (Exception exception)
            // {
            // this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "ReportItemExists", exception.Message);
            // return false;
            // }
        }

        /// <summary>
        /// Sets the report data source.
        /// </summary>
        /// <param name="reportItem">The report item.</param>
        /// <param name="recursive">if set to <c>true</c> [recursive].</param>
        /// <param name="dataSources">The data sources.</param>
        /// <param name="useMatchCase">if set to <c>true</c> [use match case].</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>.</returns>
        public bool SetReportDataSource(
            string reportItem, bool recursive, ReportServerDataSource[] dataSources, bool useMatchCase)
        {
            try
            {
                // Create hashtable 
                Hashtable reportDataSources = new Hashtable(dataSources.Length);

                ItemTypeEnum currentItemType = this.reportingService2006.GetItemType(reportItem);

                // build table if there was error then stop
                if (!this.BuildReportDataSourceTable(dataSources, reportDataSources, useMatchCase))
                {
                    return false;
                }

                // depending on the type call the correct assgin function
                switch (currentItemType)
                {
                        // if folder then loop through the items to assgin the data source.
                    case ItemTypeEnum.Folder:
                        this.AssginDataSourceToReports(reportItem, recursive, reportDataSources, useMatchCase);
                        break;

                        // assgin the data source item to the report it self.
                    case ItemTypeEnum.Report:
                        this.AssignReportDataSource(reportItem, reportDataSources, useMatchCase);
                        break;

                    default:
                        this.OnDeploymentMangerMessage(
                            DeploymentMangerMessageType.Warning, 
                            "SetReportDataSource", 
                            string.Format("Report Item:{0} is not support for the method", reportItem));
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "SetReportDataSource", ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Uploads the model.
        /// </summary>
        /// <param name="reportModelsFiles">The report models files.</param>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="disableWarnings">if set to <c>true</c> [disable
        /// warnings].</param>
        /// <returns><c>true</c> if exists; otherwise, <c>false</c>./// </returns>
        public bool UploadModel(ReportModelFiles[] reportModelsFiles, string folderName, bool disableWarnings)
        {
            Warning[] warnings;
            Property[] properties;

            // Make sure the folder name is formated correctly
            folderName = DeploymentMangerHelper.FormatFolderPath(folderName);
            try
            {
                // loop through all the models create the properties which
                // need to be set and display any warnings
                foreach (ReportModelFiles model in reportModelsFiles)
                {
                    properties = this.CreateProperties(model.ReportServerProperties);
                    this.reportingService2006.CreateModel(
                        model.ModelName, folderName, model.GetBytes(), properties, out warnings);
                    
                    if (warnings != null && !disableWarnings)
                    {
                        if (warnings.Length > 0)
                        {
                            this.SendWarningsMessage(model.ModelName, warnings, "UploadModel");
                        }
                    }

                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Information, 
                        "UploadModel", 
                        string.Format("Upload Report Model: {0} to folder: {1} ", model.ModelName, folderName));
                }

                // report true
                return true;
            }
            catch (Exception exception)
            {
                // Send message and set report fales
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "UploadModel", exception.Message);
                return false;
            }
        }

        /// <summary>
        /// Ups the load reports.
        /// </summary>
        /// <param name="reportFiles">The report files.</param>
        /// <param name="folderName">Name of the folder.</param>
        /// <param name="disableWarnings">if set to <c>true</c> [disable warnings].</param>
        /// <returns>Ture if the reports are uploaded.</returns>
        public bool UpLoadReports(ReportFile[] reportFiles, string folderName, bool disableWarnings)
        {
            Warning[] warnings;
            Property[] properties;

            try
            {
                // loop through the array of reports.
                foreach (ReportFile reportFile in reportFiles)
                {
                    // Create any reports properties that need to be set.
                    properties = this.CreateProperties(reportFile.ReportServerProperties);

                    // uploads reports then outputs that reports was uploaded.
                    this.reportingService2006.CreateReport(
                        reportFile.ReportFileInfo.Name, 
                        folderName, 
                        true, 
                        reportFile.GetBytes(), 
                        properties, 
                        out warnings);

                    if (warnings != null && !disableWarnings)
                    {
                        if (warnings.Length > 0)
                        {
                            this.SendWarningsMessage(reportFile.ReportName, warnings, "UpLoadReports");
                        }
                    }

                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Information, 
                        "UpLoadReports", 
                        string.Format("Upload report: {0} to folder: {1}", reportFile.ReportName, folderName));
                }

                return true;
            }
            catch (Exception ex)
            {
                // Display any errors
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "UpLoadReports", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Uploads the resoucre.
        /// </summary>
        /// <param name="resourceFileFiles">
        /// The resoucre files.
        /// </param>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <returns>
        /// Flag is the operation was successfully.
        /// </returns>
        public bool UploadResource(ReportResourceFile[] resourceFileFiles, string folderName)
        {
            Property[] properties;
            try
            {
                // Upload each of the reportServerResoucre
                foreach (ReportResourceFile reportServerResoucre in resourceFileFiles)
                {
                    // Get the bytes and properties 
                    byte[] artefactBytes = reportServerResoucre.GetBytes();
                    properties = this.CreateProperties(reportServerResoucre.ReportServerProperties);

                    // If there are bytes then upload the resouce
                    if (artefactBytes != null)
                    {
                        this.reportingService2006.CreateResource(
                            reportServerResoucre.Name, 
                            folderName, 
                            true, 
                            artefactBytes, 
                            reportServerResoucre.MineType, 
                            properties);
                        this.OnDeploymentMangerMessage(
                            DeploymentMangerMessageType.Information, 
                            "UploadResource", 
                            string.Format("Upload artefact: {0} to folder: {1}", reportServerResoucre.Name, folderName));
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                // catches the error and then reports out via msbuild.
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "UploadResource", ex.Message);
                return false;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the reporting roles.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="newPolicy">
        /// The new policy.
        /// </param>
        /// <param name="reportingRoles">
        /// The reporting roles.
        /// </param>
        private void AddReportingRoles(int index, Policy[] newPolicy, string[] reportingRoles)
        {
            // looping through the roles and assgin them.
            for (int roleIndex = 0; roleIndex < reportingRoles.Length; roleIndex++)
            {
                newPolicy[index].Roles[roleIndex] = new Role
                    {
                        Name = reportingRoles[roleIndex], 
                        Description = string.Format("Reporting {0} User / Group", reportingRoles[roleIndex])
                    };
            }
        }

        /// <summary>
        /// Assgins the data source to reports.
        /// </summary>
        /// <param name="folder">
        /// The folder.
        /// </param>
        /// <param name="recursive">
        /// If set to. <c>True.</c> [recursive].
        /// </param>
        /// <param name="dataSources">
        /// The data sources.
        /// </param>
        /// <param name="useMatchCase">
        /// If set to. <c>True.</c> [use match case].
        /// </param>
        private void AssginDataSourceToReports(string folder, bool recursive, Hashtable dataSources, bool useMatchCase)
        {
            // get list of all the items under the folder
            CatalogItem[] reportFolderItems = this.reportingService2006.ListChildren(folder);

            // loop through all items if they are a report then assgin the data source 
            // to the item.
            for (int index = 0; index < reportFolderItems.Length; index++)
            {
                if (reportFolderItems[index].Type == ItemTypeEnum.Report)
                {
                    this.AssignReportDataSource(reportFolderItems[index].Path, dataSources, useMatchCase);
                }
            }
        }

        /// <summary>
        /// Assigns the report data source.
        /// </summary>
        /// <param name="report">
        /// The report.
        /// </param>
        /// <param name="dataSources">
        /// The data sources.
        /// </param>
        /// <param name="useMatchCase">
        /// If set to. <c>True.</c> [use match case].
        /// </param>
        private void AssignReportDataSource(string report, Hashtable dataSources, bool useMatchCase)
        {
            // get the list of data source & creat a source reference
            DataSource[] reportDataSources = this.reportingService2006.GetItemDataSources(report);
            DataSourceReference dataSourceRef;

            // check with method is used. list data of data soruce to match or straight 
            // assginment.
            StringBuilder dataSourceUpdates = new StringBuilder();

            // loop through the report data sources
            for (int index = 0; index < reportDataSources.Length; index++)
            {
                // look for match in the list of data sources 
                if (
                    dataSources.ContainsKey(
                        useMatchCase ? reportDataSources[index].Name : reportDataSources[index].Name.ToLower()))
                {
                    // assgin the matched data source reference to the report.
                    dataSourceRef = new DataSourceReference
                        {
                            Reference = dataSources[useMatchCase
                                                        ? reportDataSources[index].Name
                                        : reportDataSources[index].Name.ToLower()] as string
                        };
                    reportDataSources[index].Item = dataSourceRef;
                    dataSourceUpdates.Append(
                        string.Format("{0}:{1};", reportDataSources[index].Name, dataSourceRef.Reference));
                }
            }

            // update the report with the new data sources.
            this.reportingService2006.SetItemDataSources(report, reportDataSources);
            this.OnDeploymentMangerMessage(
                DeploymentMangerMessageType.Warning, 
                "SetReportDataSource", 
                string.Format("Updated report: {0} data source(s):{1}", report, dataSourceUpdates));
        }


        /// <summary>
        /// Builds the report data source table.
        /// </summary>
        /// <param name="dataSources">The data sources.</param>
        /// <param name="reportDataSources">The report data sources.</param>
        /// <param name="useMatchCase">If set to. <c>True.</c> [use match case].</param>
        /// <returns>True if table was built.</returns>
        private bool BuildReportDataSourceTable(
            ReportServerDataSource[] dataSources, Hashtable reportDataSources, bool useMatchCase)
        {
            bool sucess = true;
            foreach (ReportServerDataSource dataSource in dataSources)
            {
                // make sure that no duplicates reporting data source names 
                if (dataSource.ReportDataSourceNames != null)
                {
                    foreach (string reportDataSourceName in dataSource.ReportDataSourceNames)
                    {
                        if (reportDataSources.ContainsKey(reportDataSourceName))
                        {
                            this.OnDeploymentMangerMessage(
                                DeploymentMangerMessageType.Error,
                                "SetReportDataSource",
                                string.Format("Duplicate Data Source Name: {0}", dataSource.ReportDataSourceNames));
                            sucess = false;
                            break;
                        }

                        reportDataSources.Add(useMatchCase ? reportDataSourceName : reportDataSourceName.ToLower(), string.Format("{0}/{1}.rsds", dataSource.DataSourceFolder, dataSource.Name));

                    }
                }

                if (reportDataSources.ContainsKey(dataSource.Name))
                {
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Error,
                        "SetReportDataSource",
                        string.Format("Duplicate Data Source Name: {0}", dataSource.Name));
                    sucess = false;
                }
                else
                {
                    reportDataSources.Add(useMatchCase ? dataSource.Name : dataSource.Name.ToLower(), string.Format("{0}/{1}.rsds", dataSource.DataSourceFolder, dataSource.Name));
                }

                if (!sucess)
                {
                    break;
                }
            }

            return sucess;
        }

        /// <summary>
        /// Copies the old policy.
        /// </summary>
        /// <param name="oldPolicy">
        /// The old policy.
        /// </param>
        /// <param name="newPolicy">
        /// The new policy.
        /// </param>
        /// <returns>
        /// Position of the free new policy which needs to be added.
        /// </returns>
        private int CopyOldPolicy(Policy[] oldPolicy, Policy[] newPolicy)
        {
            int index;

            // loop the old policy moving them from the old to the new list.
            for (index = 0; index < oldPolicy.Length; index++)
            {
                newPolicy[index] = new Policy();
                newPolicy[index] = oldPolicy[index];
            }

            return index;
        }

        /// <summary>
        /// Creates the complete message.
        /// </summary>
        /// <param name="reportUserName">
        /// Name of the report user.
        /// </param>
        /// <param name="reportingRoles">
        /// The reporting roles.
        /// </param>
        /// <param name="reportFolder">
        /// The report folder.
        /// </param>
        /// <returns>
        /// A complete string message.
        /// </returns>
        private string CreateCompleteMessage(string reportUserName, string[] reportingRoles, string reportFolder)
        {
            StringBuilder completeMessage = new StringBuilder();

            // Build the starting string by add the report user name
            // and the folder 
            completeMessage.Append("Add report user: ");
            completeMessage.Append(reportUserName);
            completeMessage.Append(" to folder: ");
            completeMessage.Append(reportFolder);
            completeMessage.Append(" with roles: ");

            // loop throught all the roles addd to the string
            for (int index = 0; index < reportingRoles.Length; index++)
            {
                completeMessage.Append(reportingRoles[index]);
                completeMessage.Append(", ");
            }

            completeMessage.Remove(completeMessage.Length - 2, 2);
            return completeMessage.ToString();
        }

        /// <summary>
        /// Creates the report server properties.
        /// </summary>
        /// <param name="itemProperties">
        /// The report properties.
        /// </param>
        /// <returns>
        /// A array report server properties.
        /// </returns>
        private Property[] CreateProperties(Dictionary<string, string> itemProperties)
        {
            // if no properties then return null
            if (itemProperties.Count <= 0)
            {
                return null;
            }

            // create array of properties to number of report properties
            // loop through the report properties and the key and value
            Property[] properties = new Property[itemProperties.Count];
            int index = 0;
            foreach (KeyValuePair<string, string> property in itemProperties)
            {
                properties[index] = new Property { Value = property.Value, Name = property.Key };
                index++;
            }

            return properties;
        }

        /// <summary>
        /// Creates the report data source.
        /// </summary>
        /// <param name="dataSource">
        /// The data source.
        /// </param>
        /// <returns>
        /// Flag is the operation was successfully.
        /// </returns>
        private bool CreateReportDataSource(ReportServerDataSource dataSource)
        {
            try
            {
                // formating the data source folder.
                dataSource.DataSourceFolder = dataSource.DataSourceFolder;

                // check to see if the properties are define if then create the default which are needed
                if (dataSource.ReportServerProperties.Count == 0)
                {
                    dataSource.CreateDefaultProperties();
                }

                Property[] properties = this.CreateProperties(dataSource.ReportServerProperties);

                // use SQL Connection String Build to break the connection string
                SqlConnectionStringBuilder sqlConStringBuilder =
                    new SqlConnectionStringBuilder(dataSource.ConnectionString);

                // create the objects.
                DataSourceDefinition definition = this.GetDataSourceDefinition(dataSource, sqlConStringBuilder);

                // create the data source
                this.reportingService2006.CreateDataSource(
                    string.Format("{0}.rsds", dataSource.Name), dataSource.DataSourceFolder, dataSource.OverWrite, definition, properties);

                // message the data source was created
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Information, 
                    "CreateDataSource", 
                    string.Format(
                        "Created Data Source {0}/{1} Connecting to Server:{2}, Database:{3}", 
                        new[]
                            {
                                dataSource.DataSourceFolder, dataSource.Name, sqlConStringBuilder.DataSource, 
                                sqlConStringBuilder.InitialCatalog
                            }));
                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Information, "CreateDataSource", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Does the policy exists.
        /// </summary>
        /// <param name="oldPolicy">
        /// The old policy.
        /// </param>
        /// <param name="reportUserName">
        /// Name of the report user.
        /// </param>
        /// <returns>
        /// Flag if the policy does exists.
        /// </returns>
        private bool DoesPolicyExists(Policy[] oldPolicy, string reportUserName)
        {
            bool returnValue = false;

            // loop through all the old Policy see if the policy is already created
            for (int index = 0; index < oldPolicy.Length && !returnValue; index++)
            {
                if (oldPolicy[index].GroupUserName == reportUserName)
                {
                    returnValue = true;
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Gets the data source definition.
        /// </summary>
        /// <param name="dataSource">
        /// The data source.
        /// </param>
        /// <param name="sqlConStringBuilder">
        /// The SQL con string builder.
        /// </param>
        /// <returns>
        /// DataSourceDefinition with default setting created.
        /// </returns>
        private DataSourceDefinition GetDataSourceDefinition(
            ReportServerDataSource dataSource, SqlConnectionStringBuilder sqlConStringBuilder)
        {
            // create a data source definition and apply default settings
            DataSourceDefinition definition = new DataSourceDefinition();
            this.SetDefaultDefinition(definition);

            // setting the conection string bas up the type
            switch (dataSource.Provider)
            {
                case DataProviderEnum.SQL:
                    definition.Extension = "SQL";
                    break;
                case DataProviderEnum.OLEDBMD:
                    definition.Extension = "OLEDB-MD";
                    break;
            }

            // get the Data Source and Catalogs 
            definition.ConnectString = string.Format(
                "Data Source={0};Initial Catalog={1}", 
                sqlConStringBuilder.DataSource, 
                sqlConStringBuilder.InitialCatalog);

            // check to if windows security is used or in the provicer is AS
            if (sqlConStringBuilder.IntegratedSecurity || dataSource.Provider == DataProviderEnum.OLEDBMD)
            {
                definition.WindowsCredentials = true;

                // checking to see if the impersonation needs to be set.
                if (dataSource.WindowCredentials != null)
                {
                    // set impersonation details of the windows user
                    definition.UserName = dataSource.WindowCredentials.UserName;
                    definition.Password = dataSource.WindowCredentials.PassWord;
                    definition.CredentialRetrieval = CredentialRetrievalEnum.Store;
                }
                else
                {
                    // user standard windows / Kebross security
                    definition.CredentialRetrieval = CredentialRetrievalEnum.Integrated;
                }
            }
            else
            {
                // llse use SQL Server security
                definition.UserName = sqlConStringBuilder.UserID;
                definition.Password = sqlConStringBuilder.Password;
                definition.CredentialRetrieval = CredentialRetrievalEnum.Store;
            }

            return definition;
        }

        /// <summary>
        /// The reporting services message.
        /// </summary>
        /// <param name="reportMessageType">
        /// Type of the reporting message.
        /// </param>
        /// <param name="method">
        /// The method.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        private void OnDeploymentMangerMessage(DeploymentMangerMessageType reportMessageType, string method, string message)
        {
            // check to see if the handle has been assign
            if (this.DeploymentMangerMessages != null)
            {
                this.DeploymentMangerMessages(
                    this, new DeploymentMangerMessageEventArgs(reportMessageType, method, message));
            }
        }

        /// <summary>
        /// Removes the policy.
        /// </summary>
        /// <param name="reportUserName">
        /// Name of the report user.
        /// </param>
        /// <param name="oldPolicy">
        /// The old policy.
        /// </param>
        /// <param name="newPolicy">
        /// The new policy.
        /// </param>
        /// <returns>
        /// Number to the free array space.
        /// </returns>
        private int RemovePolicy(string reportUserName, Policy[] oldPolicy, Policy[] newPolicy)
        {
            bool foundOldPolicy = false;
            int index;

            // loops the old policy list to copy them into the new list
            for (index = 0; index < oldPolicy.Length; index++)
            {
                // if the old policy contains the new username 
                // then flag the user has been found
                if (!oldPolicy[index].GroupUserName.Contains(reportUserName))
                {
                    // if the new user has been found the move the current policy 
                    // up the list laving the policy for the new user
                    // Other wise just copy from the old policy list
                    // to the new list.
                    if (foundOldPolicy)
                    {
                        newPolicy[index - 1] = new Policy();
                        newPolicy[index - 1] = oldPolicy[index];
                    }
                    else
                    {
                        newPolicy[index] = new Policy();
                        newPolicy[index] = oldPolicy[index];
                    }
                }
                else
                {
                    foundOldPolicy = true;
                }
            }

            // set the index point back to the empty policy
            index--;
            return index;
        }


        /// <summary>
        /// Sends the warnings message.
        /// </summary>
        /// <param name="reportItem">The report item.</param>
        /// <param name="warnings">The warnings.</param>
        /// <param name="sender">The sender.</param>
        private void SendWarningsMessage(string reportItem, Warning[] warnings, string sender)
        {
            // loop through each warning and send out a message
            foreach (Warning warning in warnings)
            {
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Warning, 
                    sender, 
                    string.Format("{0}:Warning:{1} ", reportItem, warning.Message));
            }
        }

        /// <summary>
        /// Sets the default definition.
        /// </summary>
        /// <param name="definition">
        /// The definition.
        /// </param>
        private void SetDefaultDefinition(DataSourceDefinition definition)
        {
            definition.UseOriginalConnectString = false;
            definition.OriginalConnectStringExpressionBased = false;
            definition.ImpersonateUser = false;
            definition.ImpersonateUserSpecified = true;
            definition.Prompt = "Enter a user name and password to access the data source:";
            definition.Enabled = true;
            definition.EnabledSpecified = true;
        }

        #endregion
    }
}
