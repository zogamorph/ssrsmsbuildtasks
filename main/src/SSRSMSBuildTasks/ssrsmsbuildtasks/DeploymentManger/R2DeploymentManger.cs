// --------------------------------------------------------------------------------------------------------------------
// <copyright file="R2DeploymentManger.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Server class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    #region using directive

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Net;
    using System.Text;

    using ssrsmsbuildtasks.DeploymentManger.InterFaces;
    using ssrsmsbuildtasks.DeploymentManger.Proxy.R2;
    using ssrsmsbuildtasks.DeploymentManger.ReportItems;

    #endregion

    /// <summary>
    /// Report Server class.
    /// </summary>
    public class R2DeploymentManger
    {
        #region Constants and Fields

        /// <summary>
        ///   The reportservic e 2010 asmx.
        /// </summary>
        private const string REPORTSERVICE2010ASMX = "ReportService2010.asmx";

        /// <summary>
        ///   The vtibinreportserver.
        /// </summary>
        private const string VTIBINREPORTSERVER = "/_vti_bin/ReportServer/";

        /// <summary>
        ///   MS Reporting Services Web Services Class
        /// </summary>
        private readonly ReportingService2010 reportingService2010;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="R2DeploymentManger"/> class. 
        ///   Initializes a new instance of the NativeDeploymentManger class.
        /// </summary>
        /// <param name="reportServerURL">
        /// The report server URL.
        /// </param>
        public R2DeploymentManger(string reportServerURL)
        {
            this.reportingService2010 = new ReportingService2010(reportServerURL)
                {
                   Credentials = CredentialCache.DefaultCredentials 
                };
        }

        #endregion

        #region Events

        /// <summary>
        ///   Occurs when [reporting services message].
        /// </summary>
        public event DeploymentMangerMessage DeploymentMangerMessages;

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the native URL.
        /// </summary>
        /// <param name="serverAddress">
        /// The server address.
        /// </param>
        /// <returns>
        /// The get native url.
        /// </returns>
        public static string GetNativeURL(string serverAddress)
        {
            if (serverAddress.EndsWith(REPORTSERVICE2010ASMX))
            {
                return serverAddress;
            }

            if (serverAddress.EndsWith("/"))
            {
                return string.Format("{0}{1}", serverAddress, REPORTSERVICE2010ASMX);
            }

            return string.Format("{0}/{1}", serverAddress, REPORTSERVICE2010ASMX);
        }

        /// <summary>
        /// Gets the sharepoint.
        /// </summary>
        /// <param name="serverAddress">
        /// The server address.
        /// </param>
        /// <returns>
        /// The get sharepoint.
        /// </returns>
        public static string GetSharepoint(string serverAddress)
        {
            string sharePointPrefix = string.Format("{0}{1}", VTIBINREPORTSERVER, REPORTSERVICE2010ASMX);
            if (serverAddress.EndsWith(sharePointPrefix))
            {
                return serverAddress;
            }

            if (serverAddress.EndsWith("/"))
            {
                return string.Format("{0}{1}", serverAddress, sharePointPrefix);
            }

            return string.Format("{0}/{1}", serverAddress, sharePointPrefix);
        }

        /// <summary>
        /// Adds the report user.
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
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
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
                oldPolicy = this.reportingService2010.GetPolicies(reportFolder, out inheritParent);

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
                this.reportingService2010.SetPolicies(reportFolder, newPolicy);
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Information, 
                    "AddReportUser", 
                    this.CreateCompleteMessage(reportUserName, reportingRoles, reportFolder));
                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "AddReportUser", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Creates the data source.
        /// </summary>
        /// <param name="dataSources">
        /// The data sources.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
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
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <param name="reportFolderProperites">
        /// The report Folder Properites.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool CreateFolder(string folderName, Dictionary<string, string> reportFolderProperites)
        {
            CatalogItem[] items;
            SearchCondition[] conditions = new SearchCondition[1];
            Property[] findProperites = new Property[1];
            Property[] folderProperites = new Property[0];

            // Connecting to the reporting server
            try
            {
                findProperites[0] = new Property { Name = "Resursive", Value = "False" };

                // Remove the root path
                folderName = folderName.StartsWith("/") ? folderName.Substring(1) : folderName;

                // split the folder path into units
                string[] folderNames = folderName.Split(new[] { '/' });
                string folderPath = "/";

                // loop the units of the path to see if exists.
                for (int index = 0; index < folderNames.Length; index++)
                {
                    // Create the search condition
                    conditions[0] = new SearchCondition
                        {
                            Condition = ConditionEnum.Equals, 
                            ConditionSpecified = true, 
                            Name = "Name", 
                            Values = new[] { folderNames[index] }
                        };

                    // Find Items in current folder
                    items = this.reportingService2010.FindItems(
                        folderPath, BooleanOperatorEnum.And, findProperites, conditions);

                    // if the folder name is not found then create the folder.
                    if (!DeploymentMangerHelper.FindItemType(items, folderNames[index], ReportItemStrings.Folder))
                    {
                        if (index == (folderNames.Length - 1) && reportFolderProperites != null)
                        {
                            folderProperites = new Property[reportFolderProperites.Count];
                            int folderProperiteIndex = 0;
                            foreach (KeyValuePair<string, string> folderProperite in reportFolderProperites)
                            {
                                folderProperites[folderProperiteIndex] = new Property
                                    {
                                       Name = folderProperite.Key, Value = folderProperite.Value 
                                    };
                                folderProperiteIndex++;
                            }
                        }

                        this.reportingService2010.CreateFolder(folderNames[index], folderPath, folderProperites);
                        this.OnDeploymentMangerMessage(
                            DeploymentMangerMessageType.Information, 
                            "CreateFolder", 
                            string.Format(
                                "Created Report Folder: {0}/{1}", 
                                folderPath != "/" ? folderPath : string.Empty, 
                                folderNames[index]));
                    }

                    // build move the path to the newly created or existing path. 
                    folderPath = string.Format(
                        "{0}/{1}", folderPath != "/" ? folderPath : string.Empty, folderNames[index]);
                }

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
        /// <param name="modelName">
        /// Name of the model.
        /// </param>
        /// <returns>
        /// The delete model.
        /// </returns>
        public bool DeleteModel(string modelName)
        {
            // Create the item and format the items
            string currentItemType;
            modelName = DeploymentMangerHelper.FormatFolderPath(modelName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2010.GetItemType(modelName);
                if (currentItemType == ReportItemStrings.Model)
                {
                    // Delete the folder
                    this.reportingService2010.DeleteItem(modelName);
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
        /// <param name="reportName">
        /// Name of the report.
        /// </param>
        /// <returns>
        /// The delete report.
        /// </returns>
        public bool DeleteReport(string reportName)
        {
            // Create the item and format the items
            string currentItemType;
            reportName = DeploymentMangerHelper.FormatFolderPath(reportName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2010.GetItemType(reportName);
                if (currentItemType == ReportItemStrings.Report || currentItemType == ReportItemStrings.LinkedReport)
                {
                    // Delete the folder
                    this.reportingService2010.DeleteItem(reportName);
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
        /// <param name="dataSourceName">
        /// Name of the data source.
        /// </param>
        /// <param name="dataSourceFolder">
        /// The data source folder.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool DeleteReportDataSource(string dataSourceName, string dataSourceFolder)
        {
            string currentItemType;

            // make sure the item path is formated.
            dataSourceFolder = DeploymentMangerHelper.FormatFolderPath(dataSourceFolder);
            try
            {
                // get the item type of the item check if datasource
                currentItemType =
                    this.reportingService2010.GetItemType(string.Format("{0}/{1}", dataSourceFolder, dataSourceName));

                // If not a data source then send a warning
                if (currentItemType != ReportItemStrings.DataSource)
                {
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Warning, 
                        "DeleteReportDataSource", 
                        string.Format("Report Item is not a data source:{0}/{1}", dataSourceFolder, dataSourceName));
                    return false;
                }

                // else Delete the data source
                this.reportingService2010.DeleteItem(string.Format("{0}/{1}", dataSourceFolder, dataSourceName));
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
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool DeleteReportFolder(string folderName)
        {
            // Create the item and format the items
            string currentItemType;
            folderName = DeploymentMangerHelper.FormatFolderPath(folderName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2010.GetItemType(folderName);
                if (currentItemType == ReportItemStrings.Folder)
                {
                    // Delete the folder
                    this.reportingService2010.DeleteItem(folderName);
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
        /// Deletes the report user.
        /// </summary>
        /// <param name="reportUserName">
        /// Name of the report user.
        /// </param>
        /// <param name="reportFolder">
        /// The report folder.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool DeleteReportUser(string reportUserName, string reportFolder)
        {
            bool inheritParent, policyExists, scusess = true;
            Policy[] oldPolicy, newPolicy;

            try
            {
                // formats the folder name.
                reportFolder = DeploymentMangerHelper.FormatFolderPath(reportFolder);

                // Get the access policies of the folder.
                oldPolicy = this.reportingService2010.GetPolicies(reportFolder, out inheritParent);

                // Check to see if the user exists.
                policyExists = this.DoesPolicyExists(oldPolicy, reportUserName);
                if (policyExists)
                {
                    newPolicy = new Policy[oldPolicy.Length - 1];
                    this.RemovePolicy(reportUserName, oldPolicy, newPolicy);
                    this.reportingService2010.SetPolicies(reportFolder, newPolicy);
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Information, 
                        "DeleteReportUser", 
                        string.Format("Deleted User:{0} from folder:{1}", reportUserName, reportFolder));
                }
                else
                {
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Error, 
                        "DeleteReportUser", 
                        string.Format("User:{0} not found for folder:{1}", reportUserName, reportFolder));
                    scusess = false;
                }

                return scusess;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Information, "DeleteReportUser", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Deletes the resource.
        /// </summary>
        /// <param name="resourceName">
        /// Name of the resource.
        /// </param>
        /// <returns>
        /// The delete resource.
        /// </returns>
        public bool DeleteResource(string resourceName)
        {
            // Create the item and format the items
            string currentItemType;
            resourceName = DeploymentMangerHelper.FormatFolderPath(resourceName);
            try
            {
                // get the item type.
                currentItemType = this.reportingService2010.GetItemType(resourceName);
                if (currentItemType == ReportItemStrings.Resource)
                {
                    // Delete the folder
                    this.reportingService2010.DeleteItem(resourceName);
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
        /// <param name="reportItem">
        /// The report item.
        /// </param>
        /// <param name="destinationItem">
        /// The destination of the Item.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool MoveReportItem(string reportItem, string destinationItem)
        {
            try
            {
                // Fromat the item paths to make sure they are vaild
                reportItem = DeploymentMangerHelper.FormatItemPath(reportItem);
                destinationItem = DeploymentMangerHelper.FormatItemPath(destinationItem);

                // Call the move item method 
                this.reportingService2010.MoveItem(reportItem, destinationItem);
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
        /// <param name="reportItemName">
        /// The report item.
        /// </param>
        /// <param name="reportItemType">
        /// Type of the report item.
        /// </param>
        /// <returns>
        /// True if the item of that type exists.
        /// </returns>
        public bool ReportItemExists(string reportItemName, string reportItemType)
        {
            return this.ReportItemExists(reportItemName, reportItemType, string.Empty);
        }

        /// <summary>
        /// Reports the item exists.
        /// </summary>
        /// <param name="reportItemName">
        /// The report item name.
        /// </param>
        /// <param name="reportItemType">
        /// Type of the report item.
        /// </param>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <returns>
        /// True if the item of that type exists.
        /// </returns>
        public bool ReportItemExists(string reportItemName, string reportItemType, string folderName)
        {
            Property[] searchProperties = new[] { new Property { Name = "Resursive", Value = "False" } };

            // Create the search condition
            SearchCondition[] conditions = new[] { new SearchCondition() };

            // Get formats the folder name
            folderName = string.IsNullOrEmpty(folderName) ? "/" : DeploymentMangerHelper.FormatFolderPath(folderName);

            try
            {
                // Set the search paramter
                conditions[0].Condition = ConditionEnum.Equals;
                conditions[0].ConditionSpecified = true;
                conditions[0].Name = "Name";
                conditions[0].Values = new[] { reportItemName };

                // all the items that equal to the search parameter
                CatalogItem[] items = this.reportingService2010.FindItems(
                    folderName, BooleanOperatorEnum.And, searchProperties, conditions);

                // Find the item of the that type
                return DeploymentMangerHelper.FindItemType(items, reportItemName, reportItemType);
            }
            catch (Exception exception)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "ReportItemExists", exception.Message);
                return false;
            }
        }

        /// <summary>
        /// Reports the user exists.
        /// </summary>
        /// <param name="reportUserName">
        /// Name of the report user.
        /// </param>
        /// <param name="reportFolder">
        /// The report folder.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool ReportUserExists(string reportUserName, string reportFolder)
        {
            bool inheritParent;
            Policy[] currentPolicies;

            reportFolder = DeploymentMangerHelper.FormatFolderPath(reportFolder);

            // Get the access policies of the folder.
            currentPolicies = this.reportingService2010.GetPolicies(reportFolder, out inheritParent);

            // Check to see if the user exists.
            return this.DoesPolicyExists(currentPolicies, reportUserName);
        }

        /// <summary>
        /// Sets the report data source.
        /// </summary>
        /// <param name="dataSetItem">
        /// The report item.
        /// </param>
        /// <param name="recursive">
        /// If set to. <c>True.</c> [recursive].
        /// </param>
        /// <param name="dataSets">
        /// The data sources.
        /// </param>
        /// <param name="useMatchCase">
        /// If set to. <c>True.</c> [use match case].
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool SetDataSetDataSource(
            string dataSetItem, bool recursive, ReportDataSet[] dataSets, bool useMatchCase)
        {
            try
            {
                // Create hashtable 
                Hashtable reportDataSets = new Hashtable();

                // format the Item path and get the item type
                dataSetItem = DeploymentMangerHelper.FormatItemPath(dataSetItem);
                string currentItemType = this.reportingService2010.GetItemType(dataSetItem);

                // build table if there was error then stop
                if (!this.BuildDataSetDataSourceTable(dataSets, reportDataSets, useMatchCase))
                {
                    return false;
                }

                // depending on the type call the correct assgin function
                switch (currentItemType)
                {
                        // if folder then loop through the items to assgin the data source.
                    case ReportItemStrings.Folder:
                        this.AssginDataSourceToDataSet(dataSetItem, recursive, reportDataSets, useMatchCase);
                        break;

                        // assgin the data source item to the report it self.
                    case ReportItemStrings.DataSet:
                        this.AssignDataSetSource(dataSetItem, reportDataSets, useMatchCase);
                        break;

                    default:
                        this.OnDeploymentMangerMessage(
                            DeploymentMangerMessageType.Warning, 
                            "SetDataSetDataSource", 
                            string.Format("Report Item:{0} is not support for the method", dataSetItem));
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "SetDataSetDataSource", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Sets the report data source.
        /// </summary>
        /// <param name="reportItem">
        /// The report item.
        /// </param>
        /// <param name="recursive">
        /// If set to. <c>True.</c> [recursive].
        /// </param>
        /// <param name="dataSets">
        /// The data sources.
        /// </param>
        /// <param name="useMatchCase">
        /// If set to. <c>True.</c> [use match case].
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool SetReportDataSet(string reportItem, bool recursive, ReportDataSet[] dataSets, bool useMatchCase)
        {
            try
            {
                // Create hashtable 
                Hashtable reportDataSets = new Hashtable();

                // format the Item path and get the item type
                reportItem = DeploymentMangerHelper.FormatItemPath(reportItem);
                string currentItemType = this.reportingService2010.GetItemType(reportItem);

                // build table if there was error then stop
                if (!this.BuildReportDataSetTable(dataSets, reportDataSets, useMatchCase))
                {
                    return false;
                }

                // depending on the type call the correct assgin function
                switch (currentItemType)
                {
                        // if folder then loop through the items to assgin the data source.
                    case ReportItemStrings.Folder:
                        this.AssginDataSetToReports(reportItem, recursive, reportDataSets, useMatchCase);
                        break;

                        // assgin the data source item to the report it self.
                    case ReportItemStrings.Report:
                        this.AssignReportDataSet(reportItem, reportDataSets, useMatchCase);
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
        /// Sets the report data source.
        /// </summary>
        /// <param name="reportItem">
        /// The report item.
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
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool SetReportDataSource(
            string reportItem, bool recursive, ReportServerDataSource[] dataSources, bool useMatchCase)
        {
            try
            {
                // Create hashtable 
                Hashtable reportDataSources = new Hashtable();

                // format the Item path and get the item type
                reportItem = DeploymentMangerHelper.FormatItemPath(reportItem);
                string currentItemType = this.reportingService2010.GetItemType(reportItem);

                // build table if there was error then stop
                if (!this.BuildReportDataSourceTable(dataSources, reportDataSources, useMatchCase))
                {
                    return false;
                }

                // depending on the type call the correct assgin function
                switch (currentItemType)
                {
                        // if folder then loop through the items to assgin the data source.
                    case ReportItemStrings.Folder:
                        this.AssginDataSourceToReports(reportItem, recursive, reportDataSources, useMatchCase);
                        break;

                        // assgin the data source item to the report it self.
                    case ReportItemStrings.Report:
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
        /// Ups the load reports.
        /// </summary>
        /// <param name="reportFiles">
        /// The report files.
        /// </param>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <param name="disableWarnings">
        /// The disable Warnings.
        /// </param>
        /// <returns>
        /// Ture if the reports are uploaded.
        /// </returns>
        public bool UpLoadReports(ReportFile[] reportFiles, string folderName, bool disableWarnings)
        {
            // make sure the folder the name correct.
            folderName = DeploymentMangerHelper.FormatFolderPath(folderName);
            try
            {
                // loop through the array of reports.
                foreach (ReportFile reportFile in reportFiles)
                {
                    // Create any reports properties that need to be set.
                    this.UploadToReportServer(folderName, reportFile, ReportItemStrings.Report, disableWarnings);
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
        /// Uploads the model.
        /// </summary>
        /// <param name="reportModelsFiles">
        /// The reporting services models.
        /// </param>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <param name="disableWarnings">
        /// if set to <c>true</c> [disable warnings].
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool UploadModel(ReportModelFiles[] reportModelsFiles, string folderName, bool disableWarnings)
        {
            // Make sure the folder name is formated correctly
            folderName = DeploymentMangerHelper.FormatFolderPath(folderName);
            try
            {
                // loop through all the models create the properties which
                // need to be set and display any warnings
                foreach (ReportModelFiles model in reportModelsFiles)
                {
                    this.UploadToReportServer(folderName, model, ReportItemStrings.Model, disableWarnings);
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
        /// Uploads the resoucre.
        /// </summary>
        /// <param name="resourceFileFiles">
        /// The resoucre files.
        /// </param>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <returns>
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        public bool UploadResource(ReportResourceFile[] resourceFileFiles, string folderName)
        {
            // make sure the folder the name correct.
            folderName = DeploymentMangerHelper.FormatFolderPath(folderName);
            try
            {
                // Upload each of the reportServerResoucre
                foreach (ReportResourceFile reportServerResoucre in resourceFileFiles)
                {
                    this.UploadToReportServer(folderName, reportServerResoucre, ReportItemStrings.Resource, true);
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

        /// <summary>
        /// The upload share data set.
        /// </summary>
        /// <param name="reportDataSets">
        /// The report data sets.
        /// </param>
        /// <param name="disableWarnings">
        /// if set to <c>true</c> [disable warnings].
        /// </param>
        /// <returns>
        /// The upload share data set.
        /// </returns>
        public bool UploadShareDataSet(ReportDataSet[] reportDataSets, bool disableWarnings)
        {
            try
            {
                // Upload each of the reportServerResoucre
                foreach (ReportDataSet reportDataSet in reportDataSets)
                {
                    // make sure the folder the name correct.
                    string folderName = DeploymentMangerHelper.FormatFolderPath(reportDataSet.DateSetFolder);
                    this.UploadToReportServer(folderName, reportDataSet, ReportItemStrings.DataSet, disableWarnings);
                }

                return true;
            }
            catch (Exception ex)
            {
                // catches the error and then reports out via msbuild.
                this.OnDeploymentMangerMessage(DeploymentMangerMessageType.Error, "UploadShareDataSet", ex.Message);
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
        private void AssginDataSetToReports(string folder, bool recursive, Hashtable dataSources, bool useMatchCase)
        {
            // get list of all the items under the folder
            CatalogItem[] reportFolderItems = this.reportingService2010.ListChildren(folder, recursive);

            // loop through all items if they are a report then assgin the data source 
            // to the item.
            for (int index = 0; index < reportFolderItems.Length; index++)
            {
                if (reportFolderItems[index].TypeName == ReportItemStrings.Report)
                {
                    this.AssginDataSetToReports(reportFolderItems[index].Path, dataSources, useMatchCase);
                }
            }
        }

        /// <summary>
        /// The assgin data set to reports.
        /// </summary>
        /// <param name="report">
        /// The report.
        /// </param>
        /// <param name="dataSets">
        /// The data sets.
        /// </param>
        /// <param name="useMatchCase">
        /// The use match case.
        /// </param>
        private void AssginDataSetToReports(string report, Hashtable dataSets, bool useMatchCase)
        {
            // get the list of data source & creat a source reference
            ItemReferenceData[] reportDataSets = this.reportingService2010.GetItemReferences(
                report, ReportItemStrings.DataSet);
            if (reportDataSets.Length > 0)
            {
                ItemReference[] itemReferences = new ItemReference[reportDataSets.Length];
                ItemReference itemReference;

                // check with method is used. list data of data soruce to match or straight 
                // assginment.
                StringBuilder dataSourceUpdates = new StringBuilder();

                // loop through the report data sources
                for (int index = 0; index < reportDataSets.Length; index++)
                {
                    // look for match in the list of data sources 
                    if (
                        dataSets.ContainsKey(
                            useMatchCase ? reportDataSets[index].Name : reportDataSets[index].Name.ToLower()))
                    {
                        // assgin the matched data source reference to the report.
                        itemReference = new ItemReference
                            {
                                Name = reportDataSets[index].Name, 
                                Reference =
                                    dataSets[
                                        useMatchCase ? reportDataSets[index].Name : reportDataSets[index].Name.ToLower()]
                                    as string
                            };
                        itemReferences[index] = itemReference;
                        dataSourceUpdates.Append(
                            string.Format("{0}:{1};", reportDataSets[index].Name, itemReference.Reference));
                    }
                }

                // update the report with the new data sources.
                this.reportingService2010.SetItemReferences(report, itemReferences);
                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Warning, 
                    "SetReportDataSource", 
                    string.Format("Updated report: {0} data source(s):{1}", report, dataSourceUpdates));
            }
        }

        /// <summary>
        /// The assgin data source to data set.
        /// </summary>
        /// <param name="folder">
        /// The folder.
        /// </param>
        /// <param name="recursive">
        /// The recursive.
        /// </param>
        /// <param name="reportDataSets">
        /// The report data sets.
        /// </param>
        /// <param name="useMatchCase">
        /// The use match case.
        /// </param>
        private void AssginDataSourceToDataSet(
            string folder, bool recursive, Hashtable reportDataSets, bool useMatchCase)
        {
            // get list of all the items under the folder
            CatalogItem[] reportFolderItems = this.reportingService2010.ListChildren(folder, recursive);

            // loop through all items if they are a report then assgin the data source 
            // to the item.
            for (int index = 0; index < reportFolderItems.Length; index++)
            {
                if (reportFolderItems[index].TypeName == ReportItemStrings.DataSet)
                {
                    this.AssignDataSetSource(reportFolderItems[index].Path, reportDataSets, useMatchCase);
                }
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
            CatalogItem[] reportFolderItems = this.reportingService2010.ListChildren(folder, recursive);

            // loop through all items if they are a report then assgin the data source 
            // to the item.
            for (int index = 0; index < reportFolderItems.Length; index++)
            {
                if (reportFolderItems[index].TypeName == ReportItemStrings.Report)
                {
                    this.AssignReportDataSource(reportFolderItems[index].Path, dataSources, useMatchCase);
                }
            }
        }

        /// <summary>
        /// Assigns the report data source.
        /// </summary>
        /// <param name="dataSet">
        /// The report.
        /// </param>
        /// <param name="dataSources">
        /// The data sources.
        /// </param>
        /// <param name="useMatchCase">
        /// If set to. <c>True.</c> [use match case].
        /// </param>
        private void AssignDataSetSource(string dataSet, Hashtable dataSources, bool useMatchCase)
        {
            bool updatedReferences = false;
            // get the list of data source & creat a source reference
            ItemReferenceData[] dataSetSources = this.reportingService2010.GetItemReferences(
                dataSet, ReportItemStrings.DataSet);
            ItemReference[] itemReferences = new ItemReference[dataSetSources.Length];
            if (itemReferences.Length > 0)
            {
                // check with method is used. list data of data soruce to match or straight 
                // assginment.
                StringBuilder dataSourceUpdates = new StringBuilder();

                // loop through the report data sources
                ItemReference itemReference;
                for (int index = 0; index < dataSetSources.Length; index++)
                {
                    // look for match in the list of data sources 
                    if (dataSources.ContainsKey(useMatchCase ? dataSet : dataSet.ToLower()))
                    {
                        updatedReferences = true;
                        // assgin the matched data source reference to the report.
                        itemReference = new ItemReference
                            {
                                Name = dataSetSources[index].Name, 
                                Reference = dataSources[useMatchCase ? dataSet : dataSet.ToLower()] as string
                            };
                        itemReferences[index] = itemReference;
                        dataSourceUpdates.Append(
                            string.Format("{0}:{1};", dataSetSources[index].Name, itemReference.Reference));
                    }
                }

                if (updatedReferences)
                {
                    // update the report with the new data sources.
                    this.reportingService2010.SetItemReferences(dataSet, itemReferences);
                }

                this.OnDeploymentMangerMessage(
                    DeploymentMangerMessageType.Warning, 
                    "SetReportDataSource", 
                    string.Format("Updated report: {0} data source(s):{1}", dataSet, dataSourceUpdates));
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
        private void AssignReportDataSet(string report, Hashtable dataSources, bool useMatchCase)
        {
            // get the list of data source & creat a source reference
            DataSource[] reportDataSources = this.reportingService2010.GetItemDataSources(report);
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
                            Reference =
                                dataSources[
                                    useMatchCase
                                        ? reportDataSources[index].Name
                                        : reportDataSources[index].Name.ToLower()] as string
                        };
                    reportDataSources[index].Item = dataSourceRef;
                    dataSourceUpdates.Append(
                        string.Format("{0}:{1};", reportDataSources[index].Name, dataSourceRef.Reference));
                }
            }

            // update the report with the new data sources.
            this.reportingService2010.SetItemDataSources(report, reportDataSources);
            this.OnDeploymentMangerMessage(
                DeploymentMangerMessageType.Warning, 
                "SetReportDataSource", 
                string.Format("Updated report: {0} data source(s):{1}", report, dataSourceUpdates));
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
            DataSource[] reportDataSources = this.reportingService2010.GetItemDataSources(report);
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
                            Reference =
                                dataSources[
                                    useMatchCase
                                        ? reportDataSources[index].Name
                                        : reportDataSources[index].Name.ToLower()] as string
                        };
                    reportDataSources[index].Item = dataSourceRef;
                    dataSourceUpdates.Append(
                        string.Format("{0}:{1};", reportDataSources[index].Name, dataSourceRef.Reference));
                }
            }

            // update the report with the new data sources.
            this.reportingService2010.SetItemDataSources(report, reportDataSources);
            this.OnDeploymentMangerMessage(
                DeploymentMangerMessageType.Warning, 
                "SetReportDataSource", 
                string.Format("Updated report: {0} data source(s):{1}", report, dataSourceUpdates));
        }

        /// <summary>
        /// The build data set data source table.
        /// </summary>
        /// <param name="dataSets">
        /// The data sets.
        /// </param>
        /// <param name="reportDataSets">
        /// The report data sets.
        /// </param>
        /// <param name="useMatchCase">
        /// The use match case.
        /// </param>
        /// <returns>
        /// The build data set data source table.
        /// </returns>
        private bool BuildDataSetDataSourceTable(ReportDataSet[] dataSets, Hashtable reportDataSets, bool useMatchCase)
        {
            bool sucess = true;
            foreach (ReportDataSet dataSet in dataSets)
            {
                if (
                    reportDataSets.ContainsKey(
                        string.Format(
                            "{0}/{1}",
                            useMatchCase ? dataSet.DateSetFolder : dataSet.DateSetFolder.ToLower(),
                            useMatchCase ? dataSet.ShareDataSetName : dataSet.ShareDataSetName.ToLower())))
                {
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Error, 
                        "SetReportDataSource", 
                        string.Format("Duplicate Data Source Name: {0}", dataSet.ShareDataSetName));
                    sucess = false;
                }
                else
                {
                    reportDataSets.Add(
                        string.Format(
                            "{0}/{1}",
                            useMatchCase ? dataSet.DateSetFolder : dataSet.DateSetFolder.ToLower(), 
                            useMatchCase ? dataSet.ShareDataSetName : dataSet.ShareDataSetName.ToLower()), 
                        DeploymentMangerHelper.FormatItemPath(dataSet.DataSource));
                }

                if (!sucess)
                {
                    break;
                }
            }

            return sucess;
        }

        /// <summary>
        /// The build report data set table.
        /// </summary>
        /// <param name="dataSets">
        /// The data sets.
        /// </param>
        /// <param name="reportDataSets">
        /// The report data sets.
        /// </param>
        /// <param name="useMatchCase">
        /// The use match case.
        /// </param>
        /// <returns>
        /// The build report data set table.
        /// </returns>
        private bool BuildReportDataSetTable(ReportDataSet[] dataSets, Hashtable reportDataSets, bool useMatchCase)
        {
            bool sucess = true;
            foreach (ReportDataSet dataSet in dataSets)
            {
                if (dataSet.ReportDataSetNames != null)
                {
                    foreach (string reportDataSetName in dataSet.ReportDataSetNames)
                    {
                        if (reportDataSets.ContainsKey(reportDataSetName))
                        {
                            this.OnDeploymentMangerMessage(
                                DeploymentMangerMessageType.Error, 
                                "SetReportDataSource", 
                                string.Format("Duplicate Data Source Name: {0}", dataSet.ReportDataSetNames));
                            sucess = false;
                            break;
                        }

                        reportDataSets.Add(
                            useMatchCase ? reportDataSetName : reportDataSetName.ToLower(), 
                            DeploymentMangerHelper.FormatItemPath(
                                string.Format("{0}/{1}", dataSet.DateSetFolder, dataSet.ShareDataSetName)));
                    }
                }

                // make sure that no duplicates reporting data source names 
                if (reportDataSets.ContainsKey(dataSet.ShareDataSetName))
                {
                    this.OnDeploymentMangerMessage(
                        DeploymentMangerMessageType.Error, 
                        "SetDataSetDataSource", 
                        string.Format("Duplicate Data Source Name: {0}", dataSet.ShareDataSetName));
                    sucess = false;
                }
                else
                {
                    reportDataSets.Add(
                        useMatchCase ? dataSet.ShareDataSetName : dataSet.ShareDataSetName.ToLower(), 
                        DeploymentMangerHelper.FormatItemPath(
                            string.Format("{0}/{1}", dataSet.DateSetFolder, dataSet.ShareDataSetName)));
                }

                if (!sucess)
                {
                    break;
                }
            }

            return sucess;
        }

        /// <summary>
        /// Builds the report data source table.
        /// </summary>
        /// <param name="dataSources">
        /// The data sources.
        /// </param>
        /// <param name="reportDataSources">
        /// The report data sources.
        /// </param>
        /// <param name="useMatchCase">
        /// If set to. <c>True.</c> [use match case].
        /// </param>
        /// <returns>
        /// True if table was built.
        /// </returns>
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

                        reportDataSources.Add(
                            useMatchCase ? reportDataSourceName : reportDataSourceName.ToLower(), 
                            DeploymentMangerHelper.FormatItemPath(
                                string.Format("{0}/{1}", dataSource.DataSourceFolder, dataSource.Name)));
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
                    reportDataSources.Add(
                        useMatchCase ? dataSource.Name : dataSource.Name.ToLower(), 
                        DeploymentMangerHelper.FormatItemPath(
                            string.Format("{0}/{1}", dataSource.DataSourceFolder, dataSource.Name)));
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
        /// <param name="oldPolicy">The old policy.</param>
        /// <param name="newPolicy">The new policy.</param>
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
        /// <param name="reportUserName">Name of the report user.</param>
        /// <param name="reportingRoles">The reporting roles.</param>
        /// <param name="reportFolder">The report folder.</param>
        /// <returns>A complete string message.</returns>
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
        /// <c>true</c> if successful ; otherwise, <c>false</c>.
        /// </returns>
        private bool CreateReportDataSource(ReportServerDataSource dataSource)
        {
            try
            {
                // formating the data source folder.
                dataSource.DataSourceFolder = DeploymentMangerHelper.FormatFolderPath(dataSource.DataSourceFolder);

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
                this.reportingService2010.CreateDataSource(
                    dataSource.Name, dataSource.DataSourceFolder, dataSource.OverWrite, definition, properties);

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
                returnValue = String.Compare(oldPolicy[index].GroupUserName, reportUserName, true) == 0;
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
        private void OnDeploymentMangerMessage(
            DeploymentMangerMessageType reportMessageType, string method, string message)
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
                if (!(String.Compare(oldPolicy[index].GroupUserName, reportUserName, true) == 0))
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
        /// <param name="reportItem">
        /// The report item.
        /// </param>
        /// <param name="warnings">
        /// The warnings.
        /// </param>
        /// <param name="sender">
        /// The sender.
        /// </param>
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

        /// <summary>
        /// Uploads to report server.
        /// </summary>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        /// <param name="uploadItem">
        /// The upload item.
        /// </param>
        /// <param name="UploadItemType">
        /// Type of the upload item.
        /// </param>
        /// <param name="disableWarnings">
        /// if set to <c>true</c> [disable warnings].
        /// </param>
        private void UploadToReportServer(
            string folderName, IReportServerUploadItem uploadItem, string UploadItemType, bool disableWarnings)
        {
            Property[] properties;
            Warning[] warnings;
            properties = this.CreateProperties(uploadItem.ReportServerProperties);

            // uploads reports then outputs that reports was uploaded.
            this.reportingService2010.CreateCatalogItem(
                UploadItemType, 
                uploadItem.UploadItemName, 
                folderName, 
                true, 
                uploadItem.GetBytes(), 
                properties, 
                out warnings);

            if (warnings != null && !disableWarnings)
            {
                if (warnings.Length > 0)
                {
                    this.SendWarningsMessage(uploadItem.UploadItemName, warnings, "UpLoadReports");
                }
            }

            this.OnDeploymentMangerMessage(
                DeploymentMangerMessageType.Information, 
                "UploadToReportServer", 
                string.Format("Upload {0}: {1} to folder: {2}", UploadItemType, uploadItem.UploadItemName, folderName));
        }

        #endregion
    }
}