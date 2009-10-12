// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Reference.cs" company="">
//   
// </copyright>
// <summary>
//   The reporting service 2005.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591

namespace ssrsmsbuildtasks.MSReportService2005
{
    #region Directives

    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using System.Xml;
    using System.Xml.Serialization;

    #endregion

    /// <summary>
    /// The reporting service 2005.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [WebServiceBinding(Name = "ReportingService2005Soap", 
        Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [XmlInclude(typeof(DataSourceDefinitionOrReference))]
    [XmlInclude(typeof(ExpirationDefinition))]
    [XmlInclude(typeof(RecurrencePattern))]
    [XmlInclude(typeof(ScheduleDefinitionOrReference))]
    public partial class ReportingService2005 : SoapHttpClientProtocol
    {
        #region Constants and Fields

        /// <summary>
        /// The batch header value field.
        /// </summary>
        private BatchHeader batchHeaderValueField;

        /// <summary>
        /// The cancel batch operation completed.
        /// </summary>
        private SendOrPostCallback CancelBatchOperationCompleted;

        /// <summary>
        /// The cancel job operation completed.
        /// </summary>
        private SendOrPostCallback CancelJobOperationCompleted;

        /// <summary>
        /// The create batch operation completed.
        /// </summary>
        private SendOrPostCallback CreateBatchOperationCompleted;

        /// <summary>
        /// The create data driven subscription operation completed.
        /// </summary>
        private SendOrPostCallback CreateDataDrivenSubscriptionOperationCompleted;

        /// <summary>
        /// The create data source operation completed.
        /// </summary>
        private SendOrPostCallback CreateDataSourceOperationCompleted;

        /// <summary>
        /// The create folder operation completed.
        /// </summary>
        private SendOrPostCallback CreateFolderOperationCompleted;

        /// <summary>
        /// The create linked report operation completed.
        /// </summary>
        private SendOrPostCallback CreateLinkedReportOperationCompleted;

        /// <summary>
        /// The create model operation completed.
        /// </summary>
        private SendOrPostCallback CreateModelOperationCompleted;

        /// <summary>
        /// The create report history snapshot operation completed.
        /// </summary>
        private SendOrPostCallback CreateReportHistorySnapshotOperationCompleted;

        /// <summary>
        /// The create report operation completed.
        /// </summary>
        private SendOrPostCallback CreateReportOperationCompleted;

        /// <summary>
        /// The create resource operation completed.
        /// </summary>
        private SendOrPostCallback CreateResourceOperationCompleted;

        /// <summary>
        /// The create role operation completed.
        /// </summary>
        private SendOrPostCallback CreateRoleOperationCompleted;

        /// <summary>
        /// The create schedule operation completed.
        /// </summary>
        private SendOrPostCallback CreateScheduleOperationCompleted;

        /// <summary>
        /// The create subscription operation completed.
        /// </summary>
        private SendOrPostCallback CreateSubscriptionOperationCompleted;

        /// <summary>
        /// The delete item operation completed.
        /// </summary>
        private SendOrPostCallback DeleteItemOperationCompleted;

        /// <summary>
        /// The delete report history snapshot operation completed.
        /// </summary>
        private SendOrPostCallback DeleteReportHistorySnapshotOperationCompleted;

        /// <summary>
        /// The delete role operation completed.
        /// </summary>
        private SendOrPostCallback DeleteRoleOperationCompleted;

        /// <summary>
        /// The delete schedule operation completed.
        /// </summary>
        private SendOrPostCallback DeleteScheduleOperationCompleted;

        /// <summary>
        /// The delete subscription operation completed.
        /// </summary>
        private SendOrPostCallback DeleteSubscriptionOperationCompleted;

        /// <summary>
        /// The disable data source operation completed.
        /// </summary>
        private SendOrPostCallback DisableDataSourceOperationCompleted;

        /// <summary>
        /// The enable data source operation completed.
        /// </summary>
        private SendOrPostCallback EnableDataSourceOperationCompleted;

        /// <summary>
        /// The execute batch operation completed.
        /// </summary>
        private SendOrPostCallback ExecuteBatchOperationCompleted;

        /// <summary>
        /// The find items operation completed.
        /// </summary>
        private SendOrPostCallback FindItemsOperationCompleted;

        /// <summary>
        /// The fire event operation completed.
        /// </summary>
        private SendOrPostCallback FireEventOperationCompleted;

        /// <summary>
        /// The flush cache operation completed.
        /// </summary>
        private SendOrPostCallback FlushCacheOperationCompleted;

        /// <summary>
        /// The generate model operation completed.
        /// </summary>
        private SendOrPostCallback GenerateModelOperationCompleted;

        /// <summary>
        /// The get cache options operation completed.
        /// </summary>
        private SendOrPostCallback GetCacheOptionsOperationCompleted;

        /// <summary>
        /// The get data driven subscription properties operation completed.
        /// </summary>
        private SendOrPostCallback GetDataDrivenSubscriptionPropertiesOperationCompleted;

        /// <summary>
        /// The get data source contents operation completed.
        /// </summary>
        private SendOrPostCallback GetDataSourceContentsOperationCompleted;

        /// <summary>
        /// The get execution options operation completed.
        /// </summary>
        private SendOrPostCallback GetExecutionOptionsOperationCompleted;

        /// <summary>
        /// The get extension settings operation completed.
        /// </summary>
        private SendOrPostCallback GetExtensionSettingsOperationCompleted;

        /// <summary>
        /// The get item data source prompts operation completed.
        /// </summary>
        private SendOrPostCallback GetItemDataSourcePromptsOperationCompleted;

        /// <summary>
        /// The get item data sources operation completed.
        /// </summary>
        private SendOrPostCallback GetItemDataSourcesOperationCompleted;

        /// <summary>
        /// The get item type operation completed.
        /// </summary>
        private SendOrPostCallback GetItemTypeOperationCompleted;

        /// <summary>
        /// The get model definition operation completed.
        /// </summary>
        private SendOrPostCallback GetModelDefinitionOperationCompleted;

        /// <summary>
        /// The get model item permissions operation completed.
        /// </summary>
        private SendOrPostCallback GetModelItemPermissionsOperationCompleted;

        /// <summary>
        /// The get model item policies operation completed.
        /// </summary>
        private SendOrPostCallback GetModelItemPoliciesOperationCompleted;

        /// <summary>
        /// The get permissions operation completed.
        /// </summary>
        private SendOrPostCallback GetPermissionsOperationCompleted;

        /// <summary>
        /// The get policies operation completed.
        /// </summary>
        private SendOrPostCallback GetPoliciesOperationCompleted;

        /// <summary>
        /// The get properties operation completed.
        /// </summary>
        private SendOrPostCallback GetPropertiesOperationCompleted;

        /// <summary>
        /// The get render resource operation completed.
        /// </summary>
        private SendOrPostCallback GetRenderResourceOperationCompleted;

        /// <summary>
        /// The get report definition operation completed.
        /// </summary>
        private SendOrPostCallback GetReportDefinitionOperationCompleted;

        /// <summary>
        /// The get report history limit operation completed.
        /// </summary>
        private SendOrPostCallback GetReportHistoryLimitOperationCompleted;

        /// <summary>
        /// The get report history options operation completed.
        /// </summary>
        private SendOrPostCallback GetReportHistoryOptionsOperationCompleted;

        /// <summary>
        /// The get report link operation completed.
        /// </summary>
        private SendOrPostCallback GetReportLinkOperationCompleted;

        /// <summary>
        /// The get report parameters operation completed.
        /// </summary>
        private SendOrPostCallback GetReportParametersOperationCompleted;

        /// <summary>
        /// The get resource contents operation completed.
        /// </summary>
        private SendOrPostCallback GetResourceContentsOperationCompleted;

        /// <summary>
        /// The get role properties operation completed.
        /// </summary>
        private SendOrPostCallback GetRolePropertiesOperationCompleted;

        /// <summary>
        /// The get schedule properties operation completed.
        /// </summary>
        private SendOrPostCallback GetSchedulePropertiesOperationCompleted;

        /// <summary>
        /// The get subscription properties operation completed.
        /// </summary>
        private SendOrPostCallback GetSubscriptionPropertiesOperationCompleted;

        /// <summary>
        /// The get system permissions operation completed.
        /// </summary>
        private SendOrPostCallback GetSystemPermissionsOperationCompleted;

        /// <summary>
        /// The get system policies operation completed.
        /// </summary>
        private SendOrPostCallback GetSystemPoliciesOperationCompleted;

        /// <summary>
        /// The get system properties operation completed.
        /// </summary>
        private SendOrPostCallback GetSystemPropertiesOperationCompleted;

        /// <summary>
        /// The get user model operation completed.
        /// </summary>
        private SendOrPostCallback GetUserModelOperationCompleted;

        /// <summary>
        /// The inherit model item parent security operation completed.
        /// </summary>
        private SendOrPostCallback InheritModelItemParentSecurityOperationCompleted;

        /// <summary>
        /// The inherit parent security operation completed.
        /// </summary>
        private SendOrPostCallback InheritParentSecurityOperationCompleted;

        /// <summary>
        /// The item namespace header value field.
        /// </summary>
        private ItemNamespaceHeader itemNamespaceHeaderValueField;

        /// <summary>
        /// The list children operation completed.
        /// </summary>
        private SendOrPostCallback ListChildrenOperationCompleted;

        /// <summary>
        /// The list dependent items operation completed.
        /// </summary>
        private SendOrPostCallback ListDependentItemsOperationCompleted;

        /// <summary>
        /// The list events operation completed.
        /// </summary>
        private SendOrPostCallback ListEventsOperationCompleted;

        /// <summary>
        /// The list extensions operation completed.
        /// </summary>
        private SendOrPostCallback ListExtensionsOperationCompleted;

        /// <summary>
        /// The list jobs operation completed.
        /// </summary>
        private SendOrPostCallback ListJobsOperationCompleted;

        /// <summary>
        /// The list model drillthrough reports operation completed.
        /// </summary>
        private SendOrPostCallback ListModelDrillthroughReportsOperationCompleted;

        /// <summary>
        /// The list model item children operation completed.
        /// </summary>
        private SendOrPostCallback ListModelItemChildrenOperationCompleted;

        /// <summary>
        /// The list model perspectives operation completed.
        /// </summary>
        private SendOrPostCallback ListModelPerspectivesOperationCompleted;

        /// <summary>
        /// The list report history operation completed.
        /// </summary>
        private SendOrPostCallback ListReportHistoryOperationCompleted;

        /// <summary>
        /// The list roles operation completed.
        /// </summary>
        private SendOrPostCallback ListRolesOperationCompleted;

        /// <summary>
        /// The list scheduled reports operation completed.
        /// </summary>
        private SendOrPostCallback ListScheduledReportsOperationCompleted;

        /// <summary>
        /// The list schedules operation completed.
        /// </summary>
        private SendOrPostCallback ListSchedulesOperationCompleted;

        /// <summary>
        /// The list secure methods operation completed.
        /// </summary>
        private SendOrPostCallback ListSecureMethodsOperationCompleted;

        /// <summary>
        /// The list subscriptions operation completed.
        /// </summary>
        private SendOrPostCallback ListSubscriptionsOperationCompleted;

        /// <summary>
        /// The list subscriptions using data source operation completed.
        /// </summary>
        private SendOrPostCallback ListSubscriptionsUsingDataSourceOperationCompleted;

        /// <summary>
        /// The list tasks operation completed.
        /// </summary>
        private SendOrPostCallback ListTasksOperationCompleted;

        /// <summary>
        /// The logoff operation completed.
        /// </summary>
        private SendOrPostCallback LogoffOperationCompleted;

        /// <summary>
        /// The logon user operation completed.
        /// </summary>
        private SendOrPostCallback LogonUserOperationCompleted;

        /// <summary>
        /// The move item operation completed.
        /// </summary>
        private SendOrPostCallback MoveItemOperationCompleted;

        /// <summary>
        /// The pause schedule operation completed.
        /// </summary>
        private SendOrPostCallback PauseScheduleOperationCompleted;

        /// <summary>
        /// The prepare query operation completed.
        /// </summary>
        private SendOrPostCallback PrepareQueryOperationCompleted;

        /// <summary>
        /// The regenerate model operation completed.
        /// </summary>
        private SendOrPostCallback RegenerateModelOperationCompleted;

        /// <summary>
        /// The remove all model item policies operation completed.
        /// </summary>
        private SendOrPostCallback RemoveAllModelItemPoliciesOperationCompleted;

        /// <summary>
        /// The resume schedule operation completed.
        /// </summary>
        private SendOrPostCallback ResumeScheduleOperationCompleted;

        /// <summary>
        /// The server info header value field.
        /// </summary>
        private ServerInfoHeader serverInfoHeaderValueField;

        /// <summary>
        /// The set cache options operation completed.
        /// </summary>
        private SendOrPostCallback SetCacheOptionsOperationCompleted;

        /// <summary>
        /// The set data driven subscription properties operation completed.
        /// </summary>
        private SendOrPostCallback SetDataDrivenSubscriptionPropertiesOperationCompleted;

        /// <summary>
        /// The set data source contents operation completed.
        /// </summary>
        private SendOrPostCallback SetDataSourceContentsOperationCompleted;

        /// <summary>
        /// The set execution options operation completed.
        /// </summary>
        private SendOrPostCallback SetExecutionOptionsOperationCompleted;

        /// <summary>
        /// The set item data sources operation completed.
        /// </summary>
        private SendOrPostCallback SetItemDataSourcesOperationCompleted;

        /// <summary>
        /// The set model definition operation completed.
        /// </summary>
        private SendOrPostCallback SetModelDefinitionOperationCompleted;

        /// <summary>
        /// The set model drillthrough reports operation completed.
        /// </summary>
        private SendOrPostCallback SetModelDrillthroughReportsOperationCompleted;

        /// <summary>
        /// The set model item policies operation completed.
        /// </summary>
        private SendOrPostCallback SetModelItemPoliciesOperationCompleted;

        /// <summary>
        /// The set policies operation completed.
        /// </summary>
        private SendOrPostCallback SetPoliciesOperationCompleted;

        /// <summary>
        /// The set properties operation completed.
        /// </summary>
        private SendOrPostCallback SetPropertiesOperationCompleted;

        /// <summary>
        /// The set report definition operation completed.
        /// </summary>
        private SendOrPostCallback SetReportDefinitionOperationCompleted;

        /// <summary>
        /// The set report history limit operation completed.
        /// </summary>
        private SendOrPostCallback SetReportHistoryLimitOperationCompleted;

        /// <summary>
        /// The set report history options operation completed.
        /// </summary>
        private SendOrPostCallback SetReportHistoryOptionsOperationCompleted;

        /// <summary>
        /// The set report link operation completed.
        /// </summary>
        private SendOrPostCallback SetReportLinkOperationCompleted;

        /// <summary>
        /// The set report parameters operation completed.
        /// </summary>
        private SendOrPostCallback SetReportParametersOperationCompleted;

        /// <summary>
        /// The set resource contents operation completed.
        /// </summary>
        private SendOrPostCallback SetResourceContentsOperationCompleted;

        /// <summary>
        /// The set role properties operation completed.
        /// </summary>
        private SendOrPostCallback SetRolePropertiesOperationCompleted;

        /// <summary>
        /// The set schedule properties operation completed.
        /// </summary>
        private SendOrPostCallback SetSchedulePropertiesOperationCompleted;

        /// <summary>
        /// The set subscription properties operation completed.
        /// </summary>
        private SendOrPostCallback SetSubscriptionPropertiesOperationCompleted;

        /// <summary>
        /// The set system policies operation completed.
        /// </summary>
        private SendOrPostCallback SetSystemPoliciesOperationCompleted;

        /// <summary>
        /// The set system properties operation completed.
        /// </summary>
        private SendOrPostCallback SetSystemPropertiesOperationCompleted;

        /// <summary>
        /// The update report execution snapshot operation completed.
        /// </summary>
        private SendOrPostCallback UpdateReportExecutionSnapshotOperationCompleted;

        /// <summary>
        /// The use default credentials set explicitly.
        /// </summary>
        private bool useDefaultCredentialsSetExplicitly;

        /// <summary>
        /// The validate extension settings operation completed.
        /// </summary>
        private SendOrPostCallback ValidateExtensionSettingsOperationCompleted;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingService2005"/> class. 
        /// The reporting service 2005.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <remarks>
        /// </remarks>
        public ReportingService2005(string url)
        {
            this.Url = url;
            if (this.IsLocalFileSystemWebService(this.Url) == true)
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// The cancel batch completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CancelBatchCompletedEventHandler CancelBatchCompleted;

        /// <summary>
        /// The cancel job completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CancelJobCompletedEventHandler CancelJobCompleted;

        /// <summary>
        /// The create batch completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateBatchCompletedEventHandler CreateBatchCompleted;

        /// <summary>
        /// The create data driven subscription completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateDataDrivenSubscriptionCompletedEventHandler CreateDataDrivenSubscriptionCompleted;

        /// <summary>
        /// The create data source completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateDataSourceCompletedEventHandler CreateDataSourceCompleted;

        /// <summary>
        /// The create folder completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateFolderCompletedEventHandler CreateFolderCompleted;

        /// <summary>
        /// The create linked report completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateLinkedReportCompletedEventHandler CreateLinkedReportCompleted;

        /// <summary>
        /// The create model completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateModelCompletedEventHandler CreateModelCompleted;

        /// <summary>
        /// The create report completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateReportCompletedEventHandler CreateReportCompleted;

        /// <summary>
        /// The create report history snapshot completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateReportHistorySnapshotCompletedEventHandler CreateReportHistorySnapshotCompleted;

        /// <summary>
        /// The create resource completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateResourceCompletedEventHandler CreateResourceCompleted;

        /// <summary>
        /// The create role completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateRoleCompletedEventHandler CreateRoleCompleted;

        /// <summary>
        /// The create schedule completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateScheduleCompletedEventHandler CreateScheduleCompleted;

        /// <summary>
        /// The create subscription completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event CreateSubscriptionCompletedEventHandler CreateSubscriptionCompleted;

        /// <summary>
        /// The delete item completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event DeleteItemCompletedEventHandler DeleteItemCompleted;

        /// <summary>
        /// The delete report history snapshot completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event DeleteReportHistorySnapshotCompletedEventHandler DeleteReportHistorySnapshotCompleted;

        /// <summary>
        /// The delete role completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event DeleteRoleCompletedEventHandler DeleteRoleCompleted;

        /// <summary>
        /// The delete schedule completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event DeleteScheduleCompletedEventHandler DeleteScheduleCompleted;

        /// <summary>
        /// The delete subscription completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event DeleteSubscriptionCompletedEventHandler DeleteSubscriptionCompleted;

        /// <summary>
        /// The disable data source completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event DisableDataSourceCompletedEventHandler DisableDataSourceCompleted;

        /// <summary>
        /// The enable data source completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event EnableDataSourceCompletedEventHandler EnableDataSourceCompleted;

        /// <summary>
        /// The execute batch completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ExecuteBatchCompletedEventHandler ExecuteBatchCompleted;

        /// <summary>
        /// The find items completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event FindItemsCompletedEventHandler FindItemsCompleted;

        /// <summary>
        /// The fire event completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event FireEventCompletedEventHandler FireEventCompleted;

        /// <summary>
        /// The flush cache completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event FlushCacheCompletedEventHandler FlushCacheCompleted;

        /// <summary>
        /// The generate model completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GenerateModelCompletedEventHandler GenerateModelCompleted;

        /// <summary>
        /// The get cache options completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetCacheOptionsCompletedEventHandler GetCacheOptionsCompleted;

        /// <summary>
        /// The get data driven subscription properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetDataDrivenSubscriptionPropertiesCompletedEventHandler
            GetDataDrivenSubscriptionPropertiesCompleted;

        /// <summary>
        /// The get data source contents completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetDataSourceContentsCompletedEventHandler GetDataSourceContentsCompleted;

        /// <summary>
        /// The get execution options completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetExecutionOptionsCompletedEventHandler GetExecutionOptionsCompleted;

        /// <summary>
        /// The get extension settings completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetExtensionSettingsCompletedEventHandler GetExtensionSettingsCompleted;

        /// <summary>
        /// The get item data source prompts completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetItemDataSourcePromptsCompletedEventHandler GetItemDataSourcePromptsCompleted;

        /// <summary>
        /// The get item data sources completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetItemDataSourcesCompletedEventHandler GetItemDataSourcesCompleted;

        /// <summary>
        /// The get item type completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetItemTypeCompletedEventHandler GetItemTypeCompleted;

        /// <summary>
        /// The get model definition completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetModelDefinitionCompletedEventHandler GetModelDefinitionCompleted;

        /// <summary>
        /// The get model item permissions completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetModelItemPermissionsCompletedEventHandler GetModelItemPermissionsCompleted;

        /// <summary>
        /// The get model item policies completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetModelItemPoliciesCompletedEventHandler GetModelItemPoliciesCompleted;

        /// <summary>
        /// The get permissions completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetPermissionsCompletedEventHandler GetPermissionsCompleted;

        /// <summary>
        /// The get policies completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetPoliciesCompletedEventHandler GetPoliciesCompleted;

        /// <summary>
        /// The get properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetPropertiesCompletedEventHandler GetPropertiesCompleted;

        /// <summary>
        /// The get render resource completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetRenderResourceCompletedEventHandler GetRenderResourceCompleted;

        /// <summary>
        /// The get report definition completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetReportDefinitionCompletedEventHandler GetReportDefinitionCompleted;

        /// <summary>
        /// The get report history limit completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetReportHistoryLimitCompletedEventHandler GetReportHistoryLimitCompleted;

        /// <summary>
        /// The get report history options completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetReportHistoryOptionsCompletedEventHandler GetReportHistoryOptionsCompleted;

        /// <summary>
        /// The get report link completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetReportLinkCompletedEventHandler GetReportLinkCompleted;

        /// <summary>
        /// The get report parameters completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetReportParametersCompletedEventHandler GetReportParametersCompleted;

        /// <summary>
        /// The get resource contents completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetResourceContentsCompletedEventHandler GetResourceContentsCompleted;

        /// <summary>
        /// The get role properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetRolePropertiesCompletedEventHandler GetRolePropertiesCompleted;

        /// <summary>
        /// The get schedule properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetSchedulePropertiesCompletedEventHandler GetSchedulePropertiesCompleted;

        /// <summary>
        /// The get subscription properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetSubscriptionPropertiesCompletedEventHandler GetSubscriptionPropertiesCompleted;

        /// <summary>
        /// The get system permissions completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetSystemPermissionsCompletedEventHandler GetSystemPermissionsCompleted;

        /// <summary>
        /// The get system policies completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetSystemPoliciesCompletedEventHandler GetSystemPoliciesCompleted;

        /// <summary>
        /// The get system properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetSystemPropertiesCompletedEventHandler GetSystemPropertiesCompleted;

        /// <summary>
        /// The get user model completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event GetUserModelCompletedEventHandler GetUserModelCompleted;

        /// <summary>
        /// The inherit model item parent security completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event InheritModelItemParentSecurityCompletedEventHandler InheritModelItemParentSecurityCompleted;

        /// <summary>
        /// The inherit parent security completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event InheritParentSecurityCompletedEventHandler InheritParentSecurityCompleted;

        /// <summary>
        /// The list children completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListChildrenCompletedEventHandler ListChildrenCompleted;

        /// <summary>
        /// The list dependent items completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListDependentItemsCompletedEventHandler ListDependentItemsCompleted;

        /// <summary>
        /// The list events completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListEventsCompletedEventHandler ListEventsCompleted;

        /// <summary>
        /// The list extensions completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListExtensionsCompletedEventHandler ListExtensionsCompleted;

        /// <summary>
        /// The list jobs completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListJobsCompletedEventHandler ListJobsCompleted;

        /// <summary>
        /// The list model drillthrough reports completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListModelDrillthroughReportsCompletedEventHandler ListModelDrillthroughReportsCompleted;

        /// <summary>
        /// The list model item children completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListModelItemChildrenCompletedEventHandler ListModelItemChildrenCompleted;

        /// <summary>
        /// The list model perspectives completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListModelPerspectivesCompletedEventHandler ListModelPerspectivesCompleted;

        /// <summary>
        /// The list report history completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListReportHistoryCompletedEventHandler ListReportHistoryCompleted;

        /// <summary>
        /// The list roles completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListRolesCompletedEventHandler ListRolesCompleted;

        /// <summary>
        /// The list scheduled reports completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListScheduledReportsCompletedEventHandler ListScheduledReportsCompleted;

        /// <summary>
        /// The list schedules completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListSchedulesCompletedEventHandler ListSchedulesCompleted;

        /// <summary>
        /// The list secure methods completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListSecureMethodsCompletedEventHandler ListSecureMethodsCompleted;

        /// <summary>
        /// The list subscriptions completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListSubscriptionsCompletedEventHandler ListSubscriptionsCompleted;

        /// <summary>
        /// The list subscriptions using data source completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListSubscriptionsUsingDataSourceCompletedEventHandler ListSubscriptionsUsingDataSourceCompleted;

        /// <summary>
        /// The list tasks completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ListTasksCompletedEventHandler ListTasksCompleted;

        /// <summary>
        /// The logoff completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event LogoffCompletedEventHandler LogoffCompleted;

        /// <summary>
        /// The logon user completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event LogonUserCompletedEventHandler LogonUserCompleted;

        /// <summary>
        /// The move item completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event MoveItemCompletedEventHandler MoveItemCompleted;

        /// <summary>
        /// The pause schedule completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event PauseScheduleCompletedEventHandler PauseScheduleCompleted;

        /// <summary>
        /// The prepare query completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event PrepareQueryCompletedEventHandler PrepareQueryCompleted;

        /// <summary>
        /// The regenerate model completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event RegenerateModelCompletedEventHandler RegenerateModelCompleted;

        /// <summary>
        /// The remove all model item policies completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event RemoveAllModelItemPoliciesCompletedEventHandler RemoveAllModelItemPoliciesCompleted;

        /// <summary>
        /// The resume schedule completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ResumeScheduleCompletedEventHandler ResumeScheduleCompleted;

        /// <summary>
        /// The set cache options completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetCacheOptionsCompletedEventHandler SetCacheOptionsCompleted;

        /// <summary>
        /// The set data driven subscription properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetDataDrivenSubscriptionPropertiesCompletedEventHandler
            SetDataDrivenSubscriptionPropertiesCompleted;

        /// <summary>
        /// The set data source contents completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetDataSourceContentsCompletedEventHandler SetDataSourceContentsCompleted;

        /// <summary>
        /// The set execution options completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetExecutionOptionsCompletedEventHandler SetExecutionOptionsCompleted;

        /// <summary>
        /// The set item data sources completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetItemDataSourcesCompletedEventHandler SetItemDataSourcesCompleted;

        /// <summary>
        /// The set model definition completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetModelDefinitionCompletedEventHandler SetModelDefinitionCompleted;

        /// <summary>
        /// The set model drillthrough reports completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetModelDrillthroughReportsCompletedEventHandler SetModelDrillthroughReportsCompleted;

        /// <summary>
        /// The set model item policies completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetModelItemPoliciesCompletedEventHandler SetModelItemPoliciesCompleted;

        /// <summary>
        /// The set policies completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetPoliciesCompletedEventHandler SetPoliciesCompleted;

        /// <summary>
        /// The set properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetPropertiesCompletedEventHandler SetPropertiesCompleted;

        /// <summary>
        /// The set report definition completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetReportDefinitionCompletedEventHandler SetReportDefinitionCompleted;

        /// <summary>
        /// The set report history limit completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetReportHistoryLimitCompletedEventHandler SetReportHistoryLimitCompleted;

        /// <summary>
        /// The set report history options completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetReportHistoryOptionsCompletedEventHandler SetReportHistoryOptionsCompleted;

        /// <summary>
        /// The set report link completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetReportLinkCompletedEventHandler SetReportLinkCompleted;

        /// <summary>
        /// The set report parameters completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetReportParametersCompletedEventHandler SetReportParametersCompleted;

        /// <summary>
        /// The set resource contents completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetResourceContentsCompletedEventHandler SetResourceContentsCompleted;

        /// <summary>
        /// The set role properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetRolePropertiesCompletedEventHandler SetRolePropertiesCompleted;

        /// <summary>
        /// The set schedule properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetSchedulePropertiesCompletedEventHandler SetSchedulePropertiesCompleted;

        /// <summary>
        /// The set subscription properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetSubscriptionPropertiesCompletedEventHandler SetSubscriptionPropertiesCompleted;

        /// <summary>
        /// The set system policies completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetSystemPoliciesCompletedEventHandler SetSystemPoliciesCompleted;

        /// <summary>
        /// The set system properties completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event SetSystemPropertiesCompletedEventHandler SetSystemPropertiesCompleted;

        /// <summary>
        /// The update report execution snapshot completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event UpdateReportExecutionSnapshotCompletedEventHandler UpdateReportExecutionSnapshotCompleted;

        /// <summary>
        /// The validate extension settings completed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public event ValidateExtensionSettingsCompletedEventHandler ValidateExtensionSettingsCompleted;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets BatchHeaderValue.
        /// </summary>
        public BatchHeader BatchHeaderValue
        {
            get
            {
                return this.batchHeaderValueField;
            }

            set
            {
                this.batchHeaderValueField = value;
            }
        }

        /// <summary>
        /// Gets or sets ItemNamespaceHeaderValue.
        /// </summary>
        public ItemNamespaceHeader ItemNamespaceHeaderValue
        {
            get
            {
                return this.itemNamespaceHeaderValueField;
            }

            set
            {
                this.itemNamespaceHeaderValueField = value;
            }
        }

        /// <summary>
        /// Gets or sets ServerInfoHeaderValue.
        /// </summary>
        public ServerInfoHeader ServerInfoHeaderValue
        {
            get
            {
                return this.serverInfoHeaderValueField;
            }

            set
            {
                this.serverInfoHeaderValueField = value;
            }
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        public new string Url
        {
            get
            {
                return base.Url;
            }

            set
            {
                if (((this.IsLocalFileSystemWebService(base.Url) == true) &&
                     (this.useDefaultCredentialsSetExplicitly == false)) &&
                    (this.IsLocalFileSystemWebService(value) == false))
                {
                    base.UseDefaultCredentials = false;
                }

                base.Url = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether UseDefaultCredentials.
        /// </summary>
        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }

            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The cancel async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        /// <summary>
        /// The cancel batch.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Can" + "celBatch", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void CancelBatch()
        {
            this.Invoke("CancelBatch", new object[0]);
        }

        /// <summary>
        /// The cancel batch async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void CancelBatchAsync()
        {
            this.CancelBatchAsync(null);
        }

        /// <summary>
        /// The cancel batch async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CancelBatchAsync(object userState)
        {
            if (this.CancelBatchOperationCompleted == null)
            {
                this.CancelBatchOperationCompleted = new SendOrPostCallback(this.OnCancelBatchOperationCompleted);
            }

            this.InvokeAsync("CancelBatch", new object[0], this.CancelBatchOperationCompleted, userState);
        }

        /// <summary>
        /// The cancel job.
        /// </summary>
        /// <param name="JobID">
        /// The Job ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The cancel job.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Can" + "celJob", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool CancelJob(string JobID)
        {
            object[] results = this.Invoke("CancelJob", new object[] { JobID });
            return (bool)results[0];
        }

        /// <summary>
        /// The cancel job async.
        /// </summary>
        /// <param name="JobID">
        /// The Job ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CancelJobAsync(string JobID)
        {
            this.CancelJobAsync(JobID, null);
        }

        /// <summary>
        /// The cancel job async.
        /// </summary>
        /// <param name="JobID">
        /// The Job ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CancelJobAsync(string JobID, object userState)
        {
            if (this.CancelJobOperationCompleted == null)
            {
                this.CancelJobOperationCompleted = new SendOrPostCallback(this.OnCancelJobOperationCompleted);
            }

            this.InvokeAsync("CancelJob", new object[] { JobID }, this.CancelJobOperationCompleted, userState);
        }

        /// <summary>
        /// The create batch.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The create batch.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateBatch", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("BatchID")]
        public string CreateBatch()
        {
            object[] results = this.Invoke("CreateBatch", new object[0]);
            return (string)results[0];
        }

        /// <summary>
        /// The create batch async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void CreateBatchAsync()
        {
            this.CreateBatchAsync(null);
        }

        /// <summary>
        /// The create batch async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateBatchAsync(object userState)
        {
            if (this.CreateBatchOperationCompleted == null)
            {
                this.CreateBatchOperationCompleted = new SendOrPostCallback(this.OnCreateBatchOperationCompleted);
            }

            this.InvokeAsync("CreateBatch", new object[0], this.CreateBatchOperationCompleted, userState);
        }

        /// <summary>
        /// The create data driven subscription.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="DataRetrievalPlan">
        /// The Data Retrieval Plan.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The create data driven subscription.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" +
            "ateDataDrivenSubscription", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("SubscriptionID")]
        public string CreateDataDrivenSubscription(
            string Report, 
            ExtensionSettings ExtensionSettings, 
            DataRetrievalPlan DataRetrievalPlan, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValueOrFieldReference[] Parameters)
        {
            object[] results = this.Invoke(
                "CreateDataDrivenSubscription", 
                new object[]
                    {
                        Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters 
                    });
            return (string)results[0];
        }

        /// <summary>
        /// The create data driven subscription async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="DataRetrievalPlan">
        /// The Data Retrieval Plan.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateDataDrivenSubscriptionAsync(
            string Report, 
            ExtensionSettings ExtensionSettings, 
            DataRetrievalPlan DataRetrievalPlan, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValueOrFieldReference[] Parameters)
        {
            this.CreateDataDrivenSubscriptionAsync(
                Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters, null);
        }

        /// <summary>
        /// The create data driven subscription async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="DataRetrievalPlan">
        /// The Data Retrieval Plan.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateDataDrivenSubscriptionAsync(
            string Report, 
            ExtensionSettings ExtensionSettings, 
            DataRetrievalPlan DataRetrievalPlan, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValueOrFieldReference[] Parameters, 
            object userState)
        {
            if (this.CreateDataDrivenSubscriptionOperationCompleted == null)
            {
                this.CreateDataDrivenSubscriptionOperationCompleted =
                    new SendOrPostCallback(this.OnCreateDataDrivenSubscriptionOperationCompleted);
            }

            this.InvokeAsync(
                "CreateDataDrivenSubscription", 
                new object[]
                    {
                        Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters 
                    }, 
                this.CreateDataDrivenSubscriptionOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create data source.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateDataSource", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void CreateDataSource(
            string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
        {
            this.Invoke("CreateDataSource", new object[] { DataSource, Parent, Overwrite, Definition, Properties });
        }

        /// <summary>
        /// The create data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateDataSourceAsync(
            string DataSource, string Parent, bool Overwrite, DataSourceDefinition Definition, Property[] Properties)
        {
            this.CreateDataSourceAsync(DataSource, Parent, Overwrite, Definition, Properties, null);
        }

        /// <summary>
        /// The create data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateDataSourceAsync(
            string DataSource, 
            string Parent, 
            bool Overwrite, 
            DataSourceDefinition Definition, 
            Property[] Properties, 
            object userState)
        {
            if (this.CreateDataSourceOperationCompleted == null)
            {
                this.CreateDataSourceOperationCompleted =
                    new SendOrPostCallback(this.OnCreateDataSourceOperationCompleted);
            }

            this.InvokeAsync(
                "CreateDataSource", 
                new object[] { DataSource, Parent, Overwrite, Definition, Properties }, 
                this.CreateDataSourceOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create folder.
        /// </summary>
        /// <param name="Folder">
        /// The Folder.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateFolder", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void CreateFolder(string Folder, string Parent, Property[] Properties)
        {
            this.Invoke("CreateFolder", new object[] { Folder, Parent, Properties });
        }

        /// <summary>
        /// The create folder async.
        /// </summary>
        /// <param name="Folder">
        /// The Folder.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateFolderAsync(string Folder, string Parent, Property[] Properties)
        {
            this.CreateFolderAsync(Folder, Parent, Properties, null);
        }

        /// <summary>
        /// The create folder async.
        /// </summary>
        /// <param name="Folder">
        /// The Folder.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateFolderAsync(string Folder, string Parent, Property[] Properties, object userState)
        {
            if (this.CreateFolderOperationCompleted == null)
            {
                this.CreateFolderOperationCompleted = new SendOrPostCallback(this.OnCreateFolderOperationCompleted);
            }

            this.InvokeAsync(
                "CreateFolder", 
                new object[] { Folder, Parent, Properties }, 
                this.CreateFolderOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create linked report.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Link">
        /// The Link.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateLinkedReport", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void CreateLinkedReport(string Report, string Parent, string Link, Property[] Properties)
        {
            this.Invoke("CreateLinkedReport", new object[] { Report, Parent, Link, Properties });
        }

        /// <summary>
        /// The create linked report async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Link">
        /// The Link.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateLinkedReportAsync(string Report, string Parent, string Link, Property[] Properties)
        {
            this.CreateLinkedReportAsync(Report, Parent, Link, Properties, null);
        }

        /// <summary>
        /// The create linked report async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Link">
        /// The Link.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateLinkedReportAsync(
            string Report, string Parent, string Link, Property[] Properties, object userState)
        {
            if (this.CreateLinkedReportOperationCompleted == null)
            {
                this.CreateLinkedReportOperationCompleted =
                    new SendOrPostCallback(this.OnCreateLinkedReportOperationCompleted);
            }

            this.InvokeAsync(
                "CreateLinkedReport", 
                new object[] { Report, Parent, Link, Properties }, 
                this.CreateLinkedReportOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create model.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateModel", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Warnings")]
        public Warning[] CreateModel(
            string Model, 
            string Parent, 
            [XmlElement(DataType = "base64Binary")] byte[] Definition, 
            Property[] Properties)
        {
            object[] results = this.Invoke("CreateModel", new object[] { Model, Parent, Definition, Properties });
            return (Warning[])results[0];
        }

        /// <summary>
        /// The create model async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateModelAsync(string Model, string Parent, byte[] Definition, Property[] Properties)
        {
            this.CreateModelAsync(Model, Parent, Definition, Properties, null);
        }

        /// <summary>
        /// The create model async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateModelAsync(
            string Model, string Parent, byte[] Definition, Property[] Properties, object userState)
        {
            if (this.CreateModelOperationCompleted == null)
            {
                this.CreateModelOperationCompleted = new SendOrPostCallback(this.OnCreateModelOperationCompleted);
            }

            this.InvokeAsync(
                "CreateModel", 
                new object[] { Model, Parent, Definition, Properties }, 
                this.CreateModelOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create report.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateReport", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Warnings")]
        public Warning[] CreateReport(
            string Report, 
            string Parent, 
            bool Overwrite, 
            [XmlElement(DataType = "base64Binary")] byte[] Definition, 
            Property[] Properties)
        {
            object[] results = this.Invoke(
                "CreateReport", new object[] { Report, Parent, Overwrite, Definition, Properties });
            return (Warning[])results[0];
        }

        /// <summary>
        /// The create report async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateReportAsync(
            string Report, string Parent, bool Overwrite, byte[] Definition, Property[] Properties)
        {
            this.CreateReportAsync(Report, Parent, Overwrite, Definition, Properties, null);
        }

        /// <summary>
        /// The create report async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateReportAsync(
            string Report, string Parent, bool Overwrite, byte[] Definition, Property[] Properties, object userState)
        {
            if (this.CreateReportOperationCompleted == null)
            {
                this.CreateReportOperationCompleted = new SendOrPostCallback(this.OnCreateReportOperationCompleted);
            }

            this.InvokeAsync(
                "CreateReport", 
                new object[] { Report, Parent, Overwrite, Definition, Properties }, 
                this.CreateReportOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create report history snapshot.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Warnings">
        /// The Warnings.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The create report history snapshot.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" +
            "ateReportHistorySnapshot", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("HistoryID")]
        public string CreateReportHistorySnapshot(string Report, out Warning[] Warnings)
        {
            object[] results = this.Invoke("CreateReportHistorySnapshot", new object[] { Report });
            Warnings = (Warning[])results[1];
            return (string)results[0];
        }

        /// <summary>
        /// The create report history snapshot async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateReportHistorySnapshotAsync(string Report)
        {
            this.CreateReportHistorySnapshotAsync(Report, null);
        }

        /// <summary>
        /// The create report history snapshot async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateReportHistorySnapshotAsync(string Report, object userState)
        {
            if (this.CreateReportHistorySnapshotOperationCompleted == null)
            {
                this.CreateReportHistorySnapshotOperationCompleted =
                    new SendOrPostCallback(this.OnCreateReportHistorySnapshotOperationCompleted);
            }

            this.InvokeAsync(
                "CreateReportHistorySnapshot", 
                new object[] { Report }, 
                this.CreateReportHistorySnapshotOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create resource.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Contents">
        /// The Contents.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateResource", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void CreateResource(
            string Resource, 
            string Parent, 
            bool Overwrite, 
            [XmlElement(DataType = "base64Binary")] byte[] Contents, 
            string MimeType, 
            Property[] Properties)
        {
            this.Invoke("CreateResource", new object[] { Resource, Parent, Overwrite, Contents, MimeType, Properties });
        }

        /// <summary>
        /// The create resource async.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Contents">
        /// The Contents.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateResourceAsync(
            string Resource, string Parent, bool Overwrite, byte[] Contents, string MimeType, Property[] Properties)
        {
            this.CreateResourceAsync(Resource, Parent, Overwrite, Contents, MimeType, Properties, null);
        }

        /// <summary>
        /// The create resource async.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Overwrite">
        /// The Overwrite.
        /// </param>
        /// <param name="Contents">
        /// The Contents.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateResourceAsync(
            string Resource, 
            string Parent, 
            bool Overwrite, 
            byte[] Contents, 
            string MimeType, 
            Property[] Properties, 
            object userState)
        {
            if (this.CreateResourceOperationCompleted == null)
            {
                this.CreateResourceOperationCompleted = new SendOrPostCallback(this.OnCreateResourceOperationCompleted);
            }

            this.InvokeAsync(
                "CreateResource", 
                new object[] { Resource, Parent, Overwrite, Contents, MimeType, Properties }, 
                this.CreateResourceOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create role.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Tasks">
        /// The Tasks.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateRole", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void CreateRole(string Name, string Description, Task[] Tasks)
        {
            this.Invoke("CreateRole", new object[] { Name, Description, Tasks });
        }

        /// <summary>
        /// The create role async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Tasks">
        /// The Tasks.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateRoleAsync(string Name, string Description, Task[] Tasks)
        {
            this.CreateRoleAsync(Name, Description, Tasks, null);
        }

        /// <summary>
        /// The create role async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Tasks">
        /// The Tasks.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateRoleAsync(string Name, string Description, Task[] Tasks, object userState)
        {
            if (this.CreateRoleOperationCompleted == null)
            {
                this.CreateRoleOperationCompleted = new SendOrPostCallback(this.OnCreateRoleOperationCompleted);
            }

            this.InvokeAsync(
                "CreateRole", new object[] { Name, Description, Tasks }, this.CreateRoleOperationCompleted, userState);
        }

        /// <summary>
        /// The create schedule.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="ScheduleDefinition">
        /// The Schedule Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The create schedule.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateSchedule", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("ScheduleID")]
        public string CreateSchedule(string Name, ScheduleDefinition ScheduleDefinition)
        {
            object[] results = this.Invoke("CreateSchedule", new object[] { Name, ScheduleDefinition });
            return (string)results[0];
        }

        /// <summary>
        /// The create schedule async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="ScheduleDefinition">
        /// The Schedule Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition)
        {
            this.CreateScheduleAsync(Name, ScheduleDefinition, null);
        }

        /// <summary>
        /// The create schedule async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="ScheduleDefinition">
        /// The Schedule Definition.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateScheduleAsync(string Name, ScheduleDefinition ScheduleDefinition, object userState)
        {
            if (this.CreateScheduleOperationCompleted == null)
            {
                this.CreateScheduleOperationCompleted = new SendOrPostCallback(this.OnCreateScheduleOperationCompleted);
            }

            this.InvokeAsync(
                "CreateSchedule", 
                new object[] { Name, ScheduleDefinition }, 
                this.CreateScheduleOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The create subscription.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The create subscription.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Cre" + "ateSubscription", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("SubscriptionID")]
        public string CreateSubscription(
            string Report, 
            ExtensionSettings ExtensionSettings, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValue[] Parameters)
        {
            object[] results = this.Invoke(
                "CreateSubscription", 
                new object[] { Report, ExtensionSettings, Description, EventType, MatchData, Parameters });
            return (string)results[0];
        }

        /// <summary>
        /// The create subscription async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateSubscriptionAsync(
            string Report, 
            ExtensionSettings ExtensionSettings, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValue[] Parameters)
        {
            this.CreateSubscriptionAsync(Report, ExtensionSettings, Description, EventType, MatchData, Parameters, null);
        }

        /// <summary>
        /// The create subscription async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void CreateSubscriptionAsync(
            string Report, 
            ExtensionSettings ExtensionSettings, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValue[] Parameters, 
            object userState)
        {
            if (this.CreateSubscriptionOperationCompleted == null)
            {
                this.CreateSubscriptionOperationCompleted =
                    new SendOrPostCallback(this.OnCreateSubscriptionOperationCompleted);
            }

            this.InvokeAsync(
                "CreateSubscription", 
                new object[] { Report, ExtensionSettings, Description, EventType, MatchData, Parameters }, 
                this.CreateSubscriptionOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The delete item.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" + "eteItem", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void DeleteItem(string Item)
        {
            this.Invoke("DeleteItem", new object[] { Item });
        }

        /// <summary>
        /// The delete item async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteItemAsync(string Item)
        {
            this.DeleteItemAsync(Item, null);
        }

        /// <summary>
        /// The delete item async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteItemAsync(string Item, object userState)
        {
            if (this.DeleteItemOperationCompleted == null)
            {
                this.DeleteItemOperationCompleted = new SendOrPostCallback(this.OnDeleteItemOperationCompleted);
            }

            this.InvokeAsync("DeleteItem", new object[] { Item }, this.DeleteItemOperationCompleted, userState);
        }

        /// <summary>
        /// The delete report history snapshot.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="HistoryID">
        /// The History ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" +
            "eteReportHistorySnapshot", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void DeleteReportHistorySnapshot(string Report, string HistoryID)
        {
            this.Invoke("DeleteReportHistorySnapshot", new object[] { Report, HistoryID });
        }

        /// <summary>
        /// The delete report history snapshot async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="HistoryID">
        /// The History ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteReportHistorySnapshotAsync(string Report, string HistoryID)
        {
            this.DeleteReportHistorySnapshotAsync(Report, HistoryID, null);
        }

        /// <summary>
        /// The delete report history snapshot async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="HistoryID">
        /// The History ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteReportHistorySnapshotAsync(string Report, string HistoryID, object userState)
        {
            if (this.DeleteReportHistorySnapshotOperationCompleted == null)
            {
                this.DeleteReportHistorySnapshotOperationCompleted =
                    new SendOrPostCallback(this.OnDeleteReportHistorySnapshotOperationCompleted);
            }

            this.InvokeAsync(
                "DeleteReportHistorySnapshot", 
                new object[] { Report, HistoryID }, 
                this.DeleteReportHistorySnapshotOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The delete role.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" + "eteRole", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void DeleteRole(string Name)
        {
            this.Invoke("DeleteRole", new object[] { Name });
        }

        /// <summary>
        /// The delete role async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteRoleAsync(string Name)
        {
            this.DeleteRoleAsync(Name, null);
        }

        /// <summary>
        /// The delete role async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteRoleAsync(string Name, object userState)
        {
            if (this.DeleteRoleOperationCompleted == null)
            {
                this.DeleteRoleOperationCompleted = new SendOrPostCallback(this.OnDeleteRoleOperationCompleted);
            }

            this.InvokeAsync("DeleteRole", new object[] { Name }, this.DeleteRoleOperationCompleted, userState);
        }

        /// <summary>
        /// The delete schedule.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" + "eteSchedule", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void DeleteSchedule(string ScheduleID)
        {
            this.Invoke("DeleteSchedule", new object[] { ScheduleID });
        }

        /// <summary>
        /// The delete schedule async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteScheduleAsync(string ScheduleID)
        {
            this.DeleteScheduleAsync(ScheduleID, null);
        }

        /// <summary>
        /// The delete schedule async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteScheduleAsync(string ScheduleID, object userState)
        {
            if (this.DeleteScheduleOperationCompleted == null)
            {
                this.DeleteScheduleOperationCompleted = new SendOrPostCallback(this.OnDeleteScheduleOperationCompleted);
            }

            this.InvokeAsync(
                "DeleteSchedule", new object[] { ScheduleID }, this.DeleteScheduleOperationCompleted, userState);
        }

        /// <summary>
        /// The delete subscription.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Del" + "eteSubscription", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void DeleteSubscription(string SubscriptionID)
        {
            this.Invoke("DeleteSubscription", new object[] { SubscriptionID });
        }

        /// <summary>
        /// The delete subscription async.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteSubscriptionAsync(string SubscriptionID)
        {
            this.DeleteSubscriptionAsync(SubscriptionID, null);
        }

        /// <summary>
        /// The delete subscription async.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DeleteSubscriptionAsync(string SubscriptionID, object userState)
        {
            if (this.DeleteSubscriptionOperationCompleted == null)
            {
                this.DeleteSubscriptionOperationCompleted =
                    new SendOrPostCallback(this.OnDeleteSubscriptionOperationCompleted);
            }

            this.InvokeAsync(
                "DeleteSubscription", 
                new object[] { SubscriptionID }, 
                this.DeleteSubscriptionOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The disable data source.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Dis" + "ableDataSource", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void DisableDataSource(string DataSource)
        {
            this.Invoke("DisableDataSource", new object[] { DataSource });
        }

        /// <summary>
        /// The disable data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DisableDataSourceAsync(string DataSource)
        {
            this.DisableDataSourceAsync(DataSource, null);
        }

        /// <summary>
        /// The disable data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void DisableDataSourceAsync(string DataSource, object userState)
        {
            if (this.DisableDataSourceOperationCompleted == null)
            {
                this.DisableDataSourceOperationCompleted =
                    new SendOrPostCallback(this.OnDisableDataSourceOperationCompleted);
            }

            this.InvokeAsync(
                "DisableDataSource", new object[] { DataSource }, this.DisableDataSourceOperationCompleted, userState);
        }

        /// <summary>
        /// The enable data source.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Ena" + "bleDataSource", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void EnableDataSource(string DataSource)
        {
            this.Invoke("EnableDataSource", new object[] { DataSource });
        }

        /// <summary>
        /// The enable data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void EnableDataSourceAsync(string DataSource)
        {
            this.EnableDataSourceAsync(DataSource, null);
        }

        /// <summary>
        /// The enable data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void EnableDataSourceAsync(string DataSource, object userState)
        {
            if (this.EnableDataSourceOperationCompleted == null)
            {
                this.EnableDataSourceOperationCompleted =
                    new SendOrPostCallback(this.OnEnableDataSourceOperationCompleted);
            }

            this.InvokeAsync(
                "EnableDataSource", new object[] { DataSource }, this.EnableDataSourceOperationCompleted, userState);
        }

        /// <summary>
        /// The execute batch.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Exe" + "cuteBatch", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void ExecuteBatch()
        {
            this.Invoke("ExecuteBatch", new object[0]);
        }

        /// <summary>
        /// The execute batch async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void ExecuteBatchAsync()
        {
            this.ExecuteBatchAsync(null);
        }

        /// <summary>
        /// The execute batch async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ExecuteBatchAsync(object userState)
        {
            if (this.ExecuteBatchOperationCompleted == null)
            {
                this.ExecuteBatchOperationCompleted = new SendOrPostCallback(this.OnExecuteBatchOperationCompleted);
            }

            this.InvokeAsync("ExecuteBatch", new object[0], this.ExecuteBatchOperationCompleted, userState);
        }

        /// <summary>
        /// The find items.
        /// </summary>
        /// <param name="Folder">
        /// The Folder.
        /// </param>
        /// <param name="BooleanOperator">
        /// The Boolean Operator.
        /// </param>
        /// <param name="Conditions">
        /// The Conditions.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Fin" + "dItems", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Items")]
        public CatalogItem[] FindItems(string Folder, BooleanOperatorEnum BooleanOperator, SearchCondition[] Conditions)
        {
            object[] results = this.Invoke("FindItems", new object[] { Folder, BooleanOperator, Conditions });
            return (CatalogItem[])results[0];
        }

        /// <summary>
        /// The find items async.
        /// </summary>
        /// <param name="Folder">
        /// The Folder.
        /// </param>
        /// <param name="BooleanOperator">
        /// The Boolean Operator.
        /// </param>
        /// <param name="Conditions">
        /// The Conditions.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void FindItemsAsync(string Folder, BooleanOperatorEnum BooleanOperator, SearchCondition[] Conditions)
        {
            this.FindItemsAsync(Folder, BooleanOperator, Conditions, null);
        }

        /// <summary>
        /// The find items async.
        /// </summary>
        /// <param name="Folder">
        /// The Folder.
        /// </param>
        /// <param name="BooleanOperator">
        /// The Boolean Operator.
        /// </param>
        /// <param name="Conditions">
        /// The Conditions.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void FindItemsAsync(
            string Folder, BooleanOperatorEnum BooleanOperator, SearchCondition[] Conditions, object userState)
        {
            if (this.FindItemsOperationCompleted == null)
            {
                this.FindItemsOperationCompleted = new SendOrPostCallback(this.OnFindItemsOperationCompleted);
            }

            this.InvokeAsync(
                "FindItems", 
                new object[] { Folder, BooleanOperator, Conditions }, 
                this.FindItemsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The fire event.
        /// </summary>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="EventData">
        /// The Event Data.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Fir" + "eEvent", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void FireEvent(string EventType, string EventData)
        {
            this.Invoke("FireEvent", new object[] { EventType, EventData });
        }

        /// <summary>
        /// The fire event async.
        /// </summary>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="EventData">
        /// The Event Data.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void FireEventAsync(string EventType, string EventData)
        {
            this.FireEventAsync(EventType, EventData, null);
        }

        /// <summary>
        /// The fire event async.
        /// </summary>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="EventData">
        /// The Event Data.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void FireEventAsync(string EventType, string EventData, object userState)
        {
            if (this.FireEventOperationCompleted == null)
            {
                this.FireEventOperationCompleted = new SendOrPostCallback(this.OnFireEventOperationCompleted);
            }

            this.InvokeAsync(
                "FireEvent", new object[] { EventType, EventData }, this.FireEventOperationCompleted, userState);
        }

        /// <summary>
        /// The flush cache.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Flu" + "shCache", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void FlushCache(string Report)
        {
            this.Invoke("FlushCache", new object[] { Report });
        }

        /// <summary>
        /// The flush cache async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void FlushCacheAsync(string Report)
        {
            this.FlushCacheAsync(Report, null);
        }

        /// <summary>
        /// The flush cache async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void FlushCacheAsync(string Report, object userState)
        {
            if (this.FlushCacheOperationCompleted == null)
            {
                this.FlushCacheOperationCompleted = new SendOrPostCallback(this.OnFlushCacheOperationCompleted);
            }

            this.InvokeAsync("FlushCache", new object[] { Report }, this.FlushCacheOperationCompleted, userState);
        }

        /// <summary>
        /// The generate model.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Gen" + "erateModel", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Warnings")]
        public Warning[] GenerateModel(string DataSource, string Model, string Parent, Property[] Properties)
        {
            object[] results = this.Invoke("GenerateModel", new object[] { DataSource, Model, Parent, Properties });
            return (Warning[])results[0];
        }

        /// <summary>
        /// The generate model async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GenerateModelAsync(string DataSource, string Model, string Parent, Property[] Properties)
        {
            this.GenerateModelAsync(DataSource, Model, Parent, Properties, null);
        }

        /// <summary>
        /// The generate model async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Parent">
        /// The Parent.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GenerateModelAsync(
            string DataSource, string Model, string Parent, Property[] Properties, object userState)
        {
            if (this.GenerateModelOperationCompleted == null)
            {
                this.GenerateModelOperationCompleted = new SendOrPostCallback(this.OnGenerateModelOperationCompleted);
            }

            this.InvokeAsync(
                "GenerateModel", 
                new object[] { DataSource, Model, Parent, Properties }, 
                this.GenerateModelOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get cache options.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The get cache options.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "CacheOptions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("CacheReport")]
        public bool GetCacheOptions(
            string Report, 
            [XmlElement("ScheduleExpiration", typeof(ScheduleExpiration))] [XmlElement("TimeExpiration", typeof(TimeExpiration))] out ExpirationDefinition Item)
        {
            object[] results = this.Invoke("GetCacheOptions", new object[] { Report });
            Item = (ExpirationDefinition)results[1];
            return (bool)results[0];
        }

        /// <summary>
        /// The get cache options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetCacheOptionsAsync(string Report)
        {
            this.GetCacheOptionsAsync(Report, null);
        }

        /// <summary>
        /// The get cache options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetCacheOptionsAsync(string Report, object userState)
        {
            if (this.GetCacheOptionsOperationCompleted == null)
            {
                this.GetCacheOptionsOperationCompleted = new SendOrPostCallback(
                    this.OnGetCacheOptionsOperationCompleted);
            }

            this.InvokeAsync(
                "GetCacheOptions", new object[] { Report }, this.GetCacheOptionsOperationCompleted, userState);
        }

        /// <summary>
        /// The get data driven subscription properties.
        /// </summary>
        /// <param name="DataDrivenSubscriptionID">
        /// The Data Driven Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="DataRetrievalPlan">
        /// The Data Retrieval Plan.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Active">
        /// The Active.
        /// </param>
        /// <param name="Status">
        /// The Status.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The get data driven subscription properties.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" +
            "DataDrivenSubscriptionProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Owner")]
        public string GetDataDrivenSubscriptionProperties(
            string DataDrivenSubscriptionID, 
            out ExtensionSettings ExtensionSettings, 
            out DataRetrievalPlan DataRetrievalPlan, 
            out string Description, 
            out ActiveState Active, 
            out string Status, 
            out string EventType, 
            out string MatchData, 
            out ParameterValueOrFieldReference[] Parameters)
        {
            object[] results = this.Invoke(
                "GetDataDrivenSubscriptionProperties", new object[] { DataDrivenSubscriptionID });
            ExtensionSettings = (ExtensionSettings)results[1];
            DataRetrievalPlan = (DataRetrievalPlan)results[2];
            Description = (string)results[3];
            Active = (ActiveState)results[4];
            Status = (string)results[5];
            EventType = (string)results[6];
            MatchData = (string)results[7];
            Parameters = (ParameterValueOrFieldReference[])results[8];
            return (string)results[0];
        }

        /// <summary>
        /// The get data driven subscription properties async.
        /// </summary>
        /// <param name="DataDrivenSubscriptionID">
        /// The Data Driven Subscription ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID)
        {
            this.GetDataDrivenSubscriptionPropertiesAsync(DataDrivenSubscriptionID, null);
        }

        /// <summary>
        /// The get data driven subscription properties async.
        /// </summary>
        /// <param name="DataDrivenSubscriptionID">
        /// The Data Driven Subscription ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetDataDrivenSubscriptionPropertiesAsync(string DataDrivenSubscriptionID, object userState)
        {
            if (this.GetDataDrivenSubscriptionPropertiesOperationCompleted == null)
            {
                this.GetDataDrivenSubscriptionPropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnGetDataDrivenSubscriptionPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "GetDataDrivenSubscriptionProperties", 
                new object[] { DataDrivenSubscriptionID }, 
                this.GetDataDrivenSubscriptionPropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get data source contents.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "DataSourceContents", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Definition")]
        public DataSourceDefinition GetDataSourceContents(string DataSource)
        {
            object[] results = this.Invoke("GetDataSourceContents", new object[] { DataSource });
            return (DataSourceDefinition)results[0];
        }

        /// <summary>
        /// The get data source contents async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetDataSourceContentsAsync(string DataSource)
        {
            this.GetDataSourceContentsAsync(DataSource, null);
        }

        /// <summary>
        /// The get data source contents async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetDataSourceContentsAsync(string DataSource, object userState)
        {
            if (this.GetDataSourceContentsOperationCompleted == null)
            {
                this.GetDataSourceContentsOperationCompleted =
                    new SendOrPostCallback(this.OnGetDataSourceContentsOperationCompleted);
            }

            this.InvokeAsync(
                "GetDataSourceContents", 
                new object[] { DataSource }, 
                this.GetDataSourceContentsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get execution options.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ExecutionOptions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("ExecutionSetting")]
        public ExecutionSettingEnum GetExecutionOptions(
            string Report, 
            [XmlElement("NoSchedule", typeof(NoSchedule))] [XmlElement("ScheduleDefinition", typeof(ScheduleDefinition))] [XmlElement("ScheduleReference", typeof(ScheduleReference))] out ScheduleDefinitionOrReference Item)
        {
            object[] results = this.Invoke("GetExecutionOptions", new object[] { Report });
            Item = (ScheduleDefinitionOrReference)results[1];
            return (ExecutionSettingEnum)results[0];
        }

        /// <summary>
        /// The get execution options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetExecutionOptionsAsync(string Report)
        {
            this.GetExecutionOptionsAsync(Report, null);
        }

        /// <summary>
        /// The get execution options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetExecutionOptionsAsync(string Report, object userState)
        {
            if (this.GetExecutionOptionsOperationCompleted == null)
            {
                this.GetExecutionOptionsOperationCompleted =
                    new SendOrPostCallback(this.OnGetExecutionOptionsOperationCompleted);
            }

            this.InvokeAsync(
                "GetExecutionOptions", new object[] { Report }, this.GetExecutionOptionsOperationCompleted, userState);
        }

        /// <summary>
        /// The get extension settings.
        /// </summary>
        /// <param name="Extension">
        /// The Extension.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ExtensionSettings", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("ExtensionParameters")]
        public ExtensionParameter[] GetExtensionSettings(string Extension)
        {
            object[] results = this.Invoke("GetExtensionSettings", new object[] { Extension });
            return (ExtensionParameter[])results[0];
        }

        /// <summary>
        /// The get extension settings async.
        /// </summary>
        /// <param name="Extension">
        /// The Extension.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetExtensionSettingsAsync(string Extension)
        {
            this.GetExtensionSettingsAsync(Extension, null);
        }

        /// <summary>
        /// The get extension settings async.
        /// </summary>
        /// <param name="Extension">
        /// The Extension.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetExtensionSettingsAsync(string Extension, object userState)
        {
            if (this.GetExtensionSettingsOperationCompleted == null)
            {
                this.GetExtensionSettingsOperationCompleted =
                    new SendOrPostCallback(this.OnGetExtensionSettingsOperationCompleted);
            }

            this.InvokeAsync(
                "GetExtensionSettings", 
                new object[] { Extension }, 
                this.GetExtensionSettingsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get item data source prompts.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" +
            "ItemDataSourcePrompts", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("DataSourcePrompts")]
        public DataSourcePrompt[] GetItemDataSourcePrompts(string Item)
        {
            object[] results = this.Invoke("GetItemDataSourcePrompts", new object[] { Item });
            return (DataSourcePrompt[])results[0];
        }

        /// <summary>
        /// The get item data source prompts async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetItemDataSourcePromptsAsync(string Item)
        {
            this.GetItemDataSourcePromptsAsync(Item, null);
        }

        /// <summary>
        /// The get item data source prompts async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetItemDataSourcePromptsAsync(string Item, object userState)
        {
            if (this.GetItemDataSourcePromptsOperationCompleted == null)
            {
                this.GetItemDataSourcePromptsOperationCompleted =
                    new SendOrPostCallback(this.OnGetItemDataSourcePromptsOperationCompleted);
            }

            this.InvokeAsync(
                "GetItemDataSourcePrompts", 
                new object[] { Item }, 
                this.GetItemDataSourcePromptsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get item data sources.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ItemDataSources", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("DataSources")]
        public DataSource[] GetItemDataSources(string Item)
        {
            object[] results = this.Invoke("GetItemDataSources", new object[] { Item });
            return (DataSource[])results[0];
        }

        /// <summary>
        /// The get item data sources async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetItemDataSourcesAsync(string Item)
        {
            this.GetItemDataSourcesAsync(Item, null);
        }

        /// <summary>
        /// The get item data sources async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetItemDataSourcesAsync(string Item, object userState)
        {
            if (this.GetItemDataSourcesOperationCompleted == null)
            {
                this.GetItemDataSourcesOperationCompleted =
                    new SendOrPostCallback(this.OnGetItemDataSourcesOperationCompleted);
            }

            this.InvokeAsync(
                "GetItemDataSources", new object[] { Item }, this.GetItemDataSourcesOperationCompleted, userState);
        }

        /// <summary>
        /// The get item type.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ItemType", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Type")]
        public ItemTypeEnum GetItemType(string Item)
        {
            object[] results = this.Invoke("GetItemType", new object[] { Item });
            return (ItemTypeEnum)results[0];
        }

        /// <summary>
        /// The get item type async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetItemTypeAsync(string Item)
        {
            this.GetItemTypeAsync(Item, null);
        }

        /// <summary>
        /// The get item type async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetItemTypeAsync(string Item, object userState)
        {
            if (this.GetItemTypeOperationCompleted == null)
            {
                this.GetItemTypeOperationCompleted = new SendOrPostCallback(this.OnGetItemTypeOperationCompleted);
            }

            this.InvokeAsync("GetItemType", new object[] { Item }, this.GetItemTypeOperationCompleted, userState);
        }

        /// <summary>
        /// The get model definition.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ModelDefinition", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Definition", DataType = "base64Binary")]
        public byte[] GetModelDefinition(string Model)
        {
            object[] results = this.Invoke("GetModelDefinition", new object[] { Model });
            return (byte[])results[0];
        }

        /// <summary>
        /// The get model definition async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetModelDefinitionAsync(string Model)
        {
            this.GetModelDefinitionAsync(Model, null);
        }

        /// <summary>
        /// The get model definition async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetModelDefinitionAsync(string Model, object userState)
        {
            if (this.GetModelDefinitionOperationCompleted == null)
            {
                this.GetModelDefinitionOperationCompleted =
                    new SendOrPostCallback(this.OnGetModelDefinitionOperationCompleted);
            }

            this.InvokeAsync(
                "GetModelDefinition", new object[] { Model }, this.GetModelDefinitionOperationCompleted, userState);
        }

        /// <summary>
        /// The get model item permissions.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ModelItemPermissions"
            , RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Permissions")]
        public string[] GetModelItemPermissions(string Model, string ModelItemID)
        {
            object[] results = this.Invoke("GetModelItemPermissions", new object[] { Model, ModelItemID });
            return (string[])results[0];
        }

        /// <summary>
        /// The get model item permissions async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetModelItemPermissionsAsync(string Model, string ModelItemID)
        {
            this.GetModelItemPermissionsAsync(Model, ModelItemID, null);
        }

        /// <summary>
        /// The get model item permissions async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetModelItemPermissionsAsync(string Model, string ModelItemID, object userState)
        {
            if (this.GetModelItemPermissionsOperationCompleted == null)
            {
                this.GetModelItemPermissionsOperationCompleted =
                    new SendOrPostCallback(this.OnGetModelItemPermissionsOperationCompleted);
            }

            this.InvokeAsync(
                "GetModelItemPermissions", 
                new object[] { Model, ModelItemID }, 
                this.GetModelItemPermissionsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get model item policies.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="InheritParent">
        /// The Inherit Parent.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ModelItemPolicies", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Policies")]
        public Policy[] GetModelItemPolicies(string Model, string ModelItemID, out bool InheritParent)
        {
            object[] results = this.Invoke("GetModelItemPolicies", new object[] { Model, ModelItemID });
            InheritParent = (bool)results[1];
            return (Policy[])results[0];
        }

        /// <summary>
        /// The get model item policies async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetModelItemPoliciesAsync(string Model, string ModelItemID)
        {
            this.GetModelItemPoliciesAsync(Model, ModelItemID, null);
        }

        /// <summary>
        /// The get model item policies async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetModelItemPoliciesAsync(string Model, string ModelItemID, object userState)
        {
            if (this.GetModelItemPoliciesOperationCompleted == null)
            {
                this.GetModelItemPoliciesOperationCompleted =
                    new SendOrPostCallback(this.OnGetModelItemPoliciesOperationCompleted);
            }

            this.InvokeAsync(
                "GetModelItemPolicies", 
                new object[] { Model, ModelItemID }, 
                this.GetModelItemPoliciesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get permissions.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "Permissions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Permissions")]
        [return: XmlArrayItem("Operation")]
        public string[] GetPermissions(string Item)
        {
            object[] results = this.Invoke("GetPermissions", new object[] { Item });
            return (string[])results[0];
        }

        /// <summary>
        /// The get permissions async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetPermissionsAsync(string Item)
        {
            this.GetPermissionsAsync(Item, null);
        }

        /// <summary>
        /// The get permissions async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetPermissionsAsync(string Item, object userState)
        {
            if (this.GetPermissionsOperationCompleted == null)
            {
                this.GetPermissionsOperationCompleted = new SendOrPostCallback(this.OnGetPermissionsOperationCompleted);
            }

            this.InvokeAsync("GetPermissions", new object[] { Item }, this.GetPermissionsOperationCompleted, userState);
        }

        /// <summary>
        /// The get policies.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="InheritParent">
        /// The Inherit Parent.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "Policies", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Policies")]
        public Policy[] GetPolicies(string Item, out bool InheritParent)
        {
            object[] results = this.Invoke("GetPolicies", new object[] { Item });
            InheritParent = (bool)results[1];
            return (Policy[])results[0];
        }

        /// <summary>
        /// The get policies async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetPoliciesAsync(string Item)
        {
            this.GetPoliciesAsync(Item, null);
        }

        /// <summary>
        /// The get policies async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetPoliciesAsync(string Item, object userState)
        {
            if (this.GetPoliciesOperationCompleted == null)
            {
                this.GetPoliciesOperationCompleted = new SendOrPostCallback(this.OnGetPoliciesOperationCompleted);
            }

            this.InvokeAsync("GetPolicies", new object[] { Item }, this.GetPoliciesOperationCompleted, userState);
        }

        /// <summary>
        /// The get properties.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("ItemNamespaceHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "Properties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Values")]
        public Property[] GetProperties(string Item, Property[] Properties)
        {
            object[] results = this.Invoke("GetProperties", new object[] { Item, Properties });
            return (Property[])results[0];
        }

        /// <summary>
        /// The get properties async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetPropertiesAsync(string Item, Property[] Properties)
        {
            this.GetPropertiesAsync(Item, Properties, null);
        }

        /// <summary>
        /// The get properties async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetPropertiesAsync(string Item, Property[] Properties, object userState)
        {
            if (this.GetPropertiesOperationCompleted == null)
            {
                this.GetPropertiesOperationCompleted = new SendOrPostCallback(this.OnGetPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "GetProperties", new object[] { Item, Properties }, this.GetPropertiesOperationCompleted, userState);
        }

        /// <summary>
        /// The get render resource.
        /// </summary>
        /// <param name="Format">
        /// The Format.
        /// </param>
        /// <param name="DeviceInfo">
        /// The Device Info.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "RenderResource", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Result", DataType = "base64Binary")]
        public byte[] GetRenderResource(string Format, string DeviceInfo, out string MimeType)
        {
            object[] results = this.Invoke("GetRenderResource", new object[] { Format, DeviceInfo });
            MimeType = (string)results[1];
            return (byte[])results[0];
        }

        /// <summary>
        /// The get render resource async.
        /// </summary>
        /// <param name="Format">
        /// The Format.
        /// </param>
        /// <param name="DeviceInfo">
        /// The Device Info.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetRenderResourceAsync(string Format, string DeviceInfo)
        {
            this.GetRenderResourceAsync(Format, DeviceInfo, null);
        }

        /// <summary>
        /// The get render resource async.
        /// </summary>
        /// <param name="Format">
        /// The Format.
        /// </param>
        /// <param name="DeviceInfo">
        /// The Device Info.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetRenderResourceAsync(string Format, string DeviceInfo, object userState)
        {
            if (this.GetRenderResourceOperationCompleted == null)
            {
                this.GetRenderResourceOperationCompleted =
                    new SendOrPostCallback(this.OnGetRenderResourceOperationCompleted);
            }

            this.InvokeAsync(
                "GetRenderResource", 
                new object[] { Format, DeviceInfo }, 
                this.GetRenderResourceOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get report definition.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ReportDefinition", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Definition", DataType = "base64Binary")]
        public byte[] GetReportDefinition(string Report)
        {
            object[] results = this.Invoke("GetReportDefinition", new object[] { Report });
            return (byte[])results[0];
        }

        /// <summary>
        /// The get report definition async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportDefinitionAsync(string Report)
        {
            this.GetReportDefinitionAsync(Report, null);
        }

        /// <summary>
        /// The get report definition async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportDefinitionAsync(string Report, object userState)
        {
            if (this.GetReportDefinitionOperationCompleted == null)
            {
                this.GetReportDefinitionOperationCompleted =
                    new SendOrPostCallback(this.OnGetReportDefinitionOperationCompleted);
            }

            this.InvokeAsync(
                "GetReportDefinition", new object[] { Report }, this.GetReportDefinitionOperationCompleted, userState);
        }

        /// <summary>
        /// The get report history limit.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="IsSystem">
        /// The Is System.
        /// </param>
        /// <param name="SystemLimit">
        /// The System Limit.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The get report history limit.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ReportHistoryLimit", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("HistoryLimit")]
        public int GetReportHistoryLimit(string Report, out bool IsSystem, out int SystemLimit)
        {
            object[] results = this.Invoke("GetReportHistoryLimit", new object[] { Report });
            IsSystem = (bool)results[1];
            SystemLimit = (int)results[2];
            return (int)results[0];
        }

        /// <summary>
        /// The get report history limit async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportHistoryLimitAsync(string Report)
        {
            this.GetReportHistoryLimitAsync(Report, null);
        }

        /// <summary>
        /// The get report history limit async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportHistoryLimitAsync(string Report, object userState)
        {
            if (this.GetReportHistoryLimitOperationCompleted == null)
            {
                this.GetReportHistoryLimitOperationCompleted =
                    new SendOrPostCallback(this.OnGetReportHistoryLimitOperationCompleted);
            }

            this.InvokeAsync(
                "GetReportHistoryLimit", 
                new object[] { Report }, 
                this.GetReportHistoryLimitOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get report history options.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="KeepExecutionSnapshots">
        /// The Keep Execution Snapshots.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The get report history options.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ReportHistoryOptions"
            , RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("EnableManualSnapshotCreation")]
        public bool GetReportHistoryOptions(
            string Report, 
            out bool KeepExecutionSnapshots, 
            [XmlElement("NoSchedule", typeof(NoSchedule))] [XmlElement("ScheduleDefinition", typeof(ScheduleDefinition))] [XmlElement("ScheduleReference", typeof(ScheduleReference))] out ScheduleDefinitionOrReference Item)
        {
            object[] results = this.Invoke("GetReportHistoryOptions", new object[] { Report });
            KeepExecutionSnapshots = (bool)results[1];
            Item = (ScheduleDefinitionOrReference)results[2];
            return (bool)results[0];
        }

        /// <summary>
        /// The get report history options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportHistoryOptionsAsync(string Report)
        {
            this.GetReportHistoryOptionsAsync(Report, null);
        }

        /// <summary>
        /// The get report history options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportHistoryOptionsAsync(string Report, object userState)
        {
            if (this.GetReportHistoryOptionsOperationCompleted == null)
            {
                this.GetReportHistoryOptionsOperationCompleted =
                    new SendOrPostCallback(this.OnGetReportHistoryOptionsOperationCompleted);
            }

            this.InvokeAsync(
                "GetReportHistoryOptions", 
                new object[] { Report }, 
                this.GetReportHistoryOptionsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get report link.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The get report link.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ReportLink", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Link")]
        public string GetReportLink(string Report)
        {
            object[] results = this.Invoke("GetReportLink", new object[] { Report });
            return (string)results[0];
        }

        /// <summary>
        /// The get report link async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportLinkAsync(string Report)
        {
            this.GetReportLinkAsync(Report, null);
        }

        /// <summary>
        /// The get report link async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportLinkAsync(string Report, object userState)
        {
            if (this.GetReportLinkOperationCompleted == null)
            {
                this.GetReportLinkOperationCompleted = new SendOrPostCallback(this.OnGetReportLinkOperationCompleted);
            }

            this.InvokeAsync("GetReportLink", new object[] { Report }, this.GetReportLinkOperationCompleted, userState);
        }

        /// <summary>
        /// The get report parameters.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="HistoryID">
        /// The History ID.
        /// </param>
        /// <param name="ForRendering">
        /// The For Rendering.
        /// </param>
        /// <param name="Values">
        /// The Values.
        /// </param>
        /// <param name="Credentials">
        /// The Credentials.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ReportParameters", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Parameters")]
        public ReportParameter[] GetReportParameters(
            string Report, 
            string HistoryID, 
            bool ForRendering, 
            ParameterValue[] Values, 
            DataSourceCredentials[] Credentials)
        {
            object[] results = this.Invoke(
                "GetReportParameters", new object[] { Report, HistoryID, ForRendering, Values, Credentials });
            return (ReportParameter[])results[0];
        }

        /// <summary>
        /// The get report parameters async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="HistoryID">
        /// The History ID.
        /// </param>
        /// <param name="ForRendering">
        /// The For Rendering.
        /// </param>
        /// <param name="Values">
        /// The Values.
        /// </param>
        /// <param name="Credentials">
        /// The Credentials.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportParametersAsync(
            string Report, 
            string HistoryID, 
            bool ForRendering, 
            ParameterValue[] Values, 
            DataSourceCredentials[] Credentials)
        {
            this.GetReportParametersAsync(Report, HistoryID, ForRendering, Values, Credentials, null);
        }

        /// <summary>
        /// The get report parameters async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="HistoryID">
        /// The History ID.
        /// </param>
        /// <param name="ForRendering">
        /// The For Rendering.
        /// </param>
        /// <param name="Values">
        /// The Values.
        /// </param>
        /// <param name="Credentials">
        /// The Credentials.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetReportParametersAsync(
            string Report, 
            string HistoryID, 
            bool ForRendering, 
            ParameterValue[] Values, 
            DataSourceCredentials[] Credentials, 
            object userState)
        {
            if (this.GetReportParametersOperationCompleted == null)
            {
                this.GetReportParametersOperationCompleted =
                    new SendOrPostCallback(this.OnGetReportParametersOperationCompleted);
            }

            this.InvokeAsync(
                "GetReportParameters", 
                new object[] { Report, HistoryID, ForRendering, Values, Credentials }, 
                this.GetReportParametersOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get resource contents.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ResourceContents", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Contents", DataType = "base64Binary")]
        public byte[] GetResourceContents(string Resource, out string MimeType)
        {
            object[] results = this.Invoke("GetResourceContents", new object[] { Resource });
            MimeType = (string)results[1];
            return (byte[])results[0];
        }

        /// <summary>
        /// The get resource contents async.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetResourceContentsAsync(string Resource)
        {
            this.GetResourceContentsAsync(Resource, null);
        }

        /// <summary>
        /// The get resource contents async.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetResourceContentsAsync(string Resource, object userState)
        {
            if (this.GetResourceContentsOperationCompleted == null)
            {
                this.GetResourceContentsOperationCompleted =
                    new SendOrPostCallback(this.OnGetResourceContentsOperationCompleted);
            }

            this.InvokeAsync(
                "GetResourceContents", new object[] { Resource }, this.GetResourceContentsOperationCompleted, userState);
        }

        /// <summary>
        /// The get role properties.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "RoleProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Tasks")]
        public Task[] GetRoleProperties(string Name, out string Description)
        {
            object[] results = this.Invoke("GetRoleProperties", new object[] { Name });
            Description = (string)results[1];
            return (Task[])results[0];
        }

        /// <summary>
        /// The get role properties async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetRolePropertiesAsync(string Name)
        {
            this.GetRolePropertiesAsync(Name, null);
        }

        /// <summary>
        /// The get role properties async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetRolePropertiesAsync(string Name, object userState)
        {
            if (this.GetRolePropertiesOperationCompleted == null)
            {
                this.GetRolePropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnGetRolePropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "GetRoleProperties", new object[] { Name }, this.GetRolePropertiesOperationCompleted, userState);
        }

        /// <summary>
        /// The get schedule properties.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "ScheduleProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Schedule")]
        public Schedule GetScheduleProperties(string ScheduleID)
        {
            object[] results = this.Invoke("GetScheduleProperties", new object[] { ScheduleID });
            return (Schedule)results[0];
        }

        /// <summary>
        /// The get schedule properties async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSchedulePropertiesAsync(string ScheduleID)
        {
            this.GetSchedulePropertiesAsync(ScheduleID, null);
        }

        /// <summary>
        /// The get schedule properties async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSchedulePropertiesAsync(string ScheduleID, object userState)
        {
            if (this.GetSchedulePropertiesOperationCompleted == null)
            {
                this.GetSchedulePropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnGetSchedulePropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "GetScheduleProperties", 
                new object[] { ScheduleID }, 
                this.GetSchedulePropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get subscription properties.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Active">
        /// The Active.
        /// </param>
        /// <param name="Status">
        /// The Status.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        /// <returns>
        /// The get subscription properties.
        /// </returns>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" +
            "SubscriptionProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Owner")]
        public string GetSubscriptionProperties(
            string SubscriptionID, 
            out ExtensionSettings ExtensionSettings, 
            out string Description, 
            out ActiveState Active, 
            out string Status, 
            out string EventType, 
            out string MatchData, 
            out ParameterValue[] Parameters)
        {
            object[] results = this.Invoke("GetSubscriptionProperties", new object[] { SubscriptionID });
            ExtensionSettings = (ExtensionSettings)results[1];
            Description = (string)results[2];
            Active = (ActiveState)results[3];
            Status = (string)results[4];
            EventType = (string)results[5];
            MatchData = (string)results[6];
            Parameters = (ParameterValue[])results[7];
            return (string)results[0];
        }

        /// <summary>
        /// The get subscription properties async.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSubscriptionPropertiesAsync(string SubscriptionID)
        {
            this.GetSubscriptionPropertiesAsync(SubscriptionID, null);
        }

        /// <summary>
        /// The get subscription properties async.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSubscriptionPropertiesAsync(string SubscriptionID, object userState)
        {
            if (this.GetSubscriptionPropertiesOperationCompleted == null)
            {
                this.GetSubscriptionPropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnGetSubscriptionPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "GetSubscriptionProperties", 
                new object[] { SubscriptionID }, 
                this.GetSubscriptionPropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get system permissions.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "SystemPermissions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Permissions")]
        [return: XmlArrayItem("Operation")]
        public string[] GetSystemPermissions()
        {
            object[] results = this.Invoke("GetSystemPermissions", new object[0]);
            return (string[])results[0];
        }

        /// <summary>
        /// The get system permissions async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void GetSystemPermissionsAsync()
        {
            this.GetSystemPermissionsAsync(null);
        }

        /// <summary>
        /// The get system permissions async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSystemPermissionsAsync(object userState)
        {
            if (this.GetSystemPermissionsOperationCompleted == null)
            {
                this.GetSystemPermissionsOperationCompleted =
                    new SendOrPostCallback(this.OnGetSystemPermissionsOperationCompleted);
            }

            this.InvokeAsync(
                "GetSystemPermissions", new object[0], this.GetSystemPermissionsOperationCompleted, userState);
        }

        /// <summary>
        /// The get system policies.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "SystemPolicies", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Policies")]
        public Policy[] GetSystemPolicies()
        {
            object[] results = this.Invoke("GetSystemPolicies", new object[0]);
            return (Policy[])results[0];
        }

        /// <summary>
        /// The get system policies async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void GetSystemPoliciesAsync()
        {
            this.GetSystemPoliciesAsync(null);
        }

        /// <summary>
        /// The get system policies async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSystemPoliciesAsync(object userState)
        {
            if (this.GetSystemPoliciesOperationCompleted == null)
            {
                this.GetSystemPoliciesOperationCompleted =
                    new SendOrPostCallback(this.OnGetSystemPoliciesOperationCompleted);
            }

            this.InvokeAsync("GetSystemPolicies", new object[0], this.GetSystemPoliciesOperationCompleted, userState);
        }

        /// <summary>
        /// The get system properties.
        /// </summary>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "SystemProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Values")]
        public Property[] GetSystemProperties(Property[] Properties)
        {
            object[] results = this.Invoke("GetSystemProperties", new object[] { Properties });
            return (Property[])results[0];
        }

        /// <summary>
        /// The get system properties async.
        /// </summary>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSystemPropertiesAsync(Property[] Properties)
        {
            this.GetSystemPropertiesAsync(Properties, null);
        }

        /// <summary>
        /// The get system properties async.
        /// </summary>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetSystemPropertiesAsync(Property[] Properties, object userState)
        {
            if (this.GetSystemPropertiesOperationCompleted == null)
            {
                this.GetSystemPropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnGetSystemPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "GetSystemProperties", 
                new object[] { Properties }, 
                this.GetSystemPropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The get user model.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Perspective">
        /// The Perspective.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Get" + "UserModel", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("Definition", DataType = "base64Binary")]
        public byte[] GetUserModel(string Model, string Perspective)
        {
            object[] results = this.Invoke("GetUserModel", new object[] { Model, Perspective });
            return (byte[])results[0];
        }

        /// <summary>
        /// The get user model async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Perspective">
        /// The Perspective.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetUserModelAsync(string Model, string Perspective)
        {
            this.GetUserModelAsync(Model, Perspective, null);
        }

        /// <summary>
        /// The get user model async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Perspective">
        /// The Perspective.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void GetUserModelAsync(string Model, string Perspective, object userState)
        {
            if (this.GetUserModelOperationCompleted == null)
            {
                this.GetUserModelOperationCompleted = new SendOrPostCallback(this.OnGetUserModelOperationCompleted);
            }

            this.InvokeAsync(
                "GetUserModel", new object[] { Model, Perspective }, this.GetUserModelOperationCompleted, userState);
        }

        /// <summary>
        /// The inherit model item parent security.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Inh" +
            "eritModelItemParentSecurity", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void InheritModelItemParentSecurity(string Model, string ModelItemID)
        {
            this.Invoke("InheritModelItemParentSecurity", new object[] { Model, ModelItemID });
        }

        /// <summary>
        /// The inherit model item parent security async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void InheritModelItemParentSecurityAsync(string Model, string ModelItemID)
        {
            this.InheritModelItemParentSecurityAsync(Model, ModelItemID, null);
        }

        /// <summary>
        /// The inherit model item parent security async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void InheritModelItemParentSecurityAsync(string Model, string ModelItemID, object userState)
        {
            if (this.InheritModelItemParentSecurityOperationCompleted == null)
            {
                this.InheritModelItemParentSecurityOperationCompleted =
                    new SendOrPostCallback(this.OnInheritModelItemParentSecurityOperationCompleted);
            }

            this.InvokeAsync(
                "InheritModelItemParentSecurity", 
                new object[] { Model, ModelItemID }, 
                this.InheritModelItemParentSecurityOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The inherit parent security.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Inh" + "eritParentSecurity", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void InheritParentSecurity(string Item)
        {
            this.Invoke("InheritParentSecurity", new object[] { Item });
        }

        /// <summary>
        /// The inherit parent security async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void InheritParentSecurityAsync(string Item)
        {
            this.InheritParentSecurityAsync(Item, null);
        }

        /// <summary>
        /// The inherit parent security async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void InheritParentSecurityAsync(string Item, object userState)
        {
            if (this.InheritParentSecurityOperationCompleted == null)
            {
                this.InheritParentSecurityOperationCompleted =
                    new SendOrPostCallback(this.OnInheritParentSecurityOperationCompleted);
            }

            this.InvokeAsync(
                "InheritParentSecurity", new object[] { Item }, this.InheritParentSecurityOperationCompleted, userState);
        }

        /// <summary>
        /// The list children.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Recursive">
        /// The Recursive.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tChildren", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("CatalogItems")]
        public CatalogItem[] ListChildren(string Item, bool Recursive)
        {
            object[] results = this.Invoke("ListChildren", new object[] { Item, Recursive });
            return (CatalogItem[])results[0];
        }

        /// <summary>
        /// The list children async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Recursive">
        /// The Recursive.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListChildrenAsync(string Item, bool Recursive)
        {
            this.ListChildrenAsync(Item, Recursive, null);
        }

        /// <summary>
        /// The list children async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Recursive">
        /// The Recursive.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListChildrenAsync(string Item, bool Recursive, object userState)
        {
            if (this.ListChildrenOperationCompleted == null)
            {
                this.ListChildrenOperationCompleted = new SendOrPostCallback(this.OnListChildrenOperationCompleted);
            }

            this.InvokeAsync(
                "ListChildren", new object[] { Item, Recursive }, this.ListChildrenOperationCompleted, userState);
        }

        /// <summary>
        /// The list dependent items.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tDependentItems", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("CatalogItems")]
        public CatalogItem[] ListDependentItems(string Item)
        {
            object[] results = this.Invoke("ListDependentItems", new object[] { Item });
            return (CatalogItem[])results[0];
        }

        /// <summary>
        /// The list dependent items async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListDependentItemsAsync(string Item)
        {
            this.ListDependentItemsAsync(Item, null);
        }

        /// <summary>
        /// The list dependent items async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListDependentItemsAsync(string Item, object userState)
        {
            if (this.ListDependentItemsOperationCompleted == null)
            {
                this.ListDependentItemsOperationCompleted =
                    new SendOrPostCallback(this.OnListDependentItemsOperationCompleted);
            }

            this.InvokeAsync(
                "ListDependentItems", new object[] { Item }, this.ListDependentItemsOperationCompleted, userState);
        }

        /// <summary>
        /// The list events.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tEvents", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Events")]
        public Event[] ListEvents()
        {
            object[] results = this.Invoke("ListEvents", new object[0]);
            return (Event[])results[0];
        }

        /// <summary>
        /// The list events async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void ListEventsAsync()
        {
            this.ListEventsAsync(null);
        }

        /// <summary>
        /// The list events async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListEventsAsync(object userState)
        {
            if (this.ListEventsOperationCompleted == null)
            {
                this.ListEventsOperationCompleted = new SendOrPostCallback(this.OnListEventsOperationCompleted);
            }

            this.InvokeAsync("ListEvents", new object[0], this.ListEventsOperationCompleted, userState);
        }

        /// <summary>
        /// The list extensions.
        /// </summary>
        /// <param name="ExtensionType">
        /// The Extension Type.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tExtensions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Extensions")]
        public Extension[] ListExtensions(ExtensionTypeEnum ExtensionType)
        {
            object[] results = this.Invoke("ListExtensions", new object[] { ExtensionType });
            return (Extension[])results[0];
        }

        /// <summary>
        /// The list extensions async.
        /// </summary>
        /// <param name="ExtensionType">
        /// The Extension Type.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListExtensionsAsync(ExtensionTypeEnum ExtensionType)
        {
            this.ListExtensionsAsync(ExtensionType, null);
        }

        /// <summary>
        /// The list extensions async.
        /// </summary>
        /// <param name="ExtensionType">
        /// The Extension Type.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListExtensionsAsync(ExtensionTypeEnum ExtensionType, object userState)
        {
            if (this.ListExtensionsOperationCompleted == null)
            {
                this.ListExtensionsOperationCompleted = new SendOrPostCallback(this.OnListExtensionsOperationCompleted);
            }

            this.InvokeAsync(
                "ListExtensions", new object[] { ExtensionType }, this.ListExtensionsOperationCompleted, userState);
        }

        /// <summary>
        /// The list jobs.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tJobs", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Jobs")]
        public Job[] ListJobs()
        {
            object[] results = this.Invoke("ListJobs", new object[0]);
            return (Job[])results[0];
        }

        /// <summary>
        /// The list jobs async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void ListJobsAsync()
        {
            this.ListJobsAsync(null);
        }

        /// <summary>
        /// The list jobs async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListJobsAsync(object userState)
        {
            if (this.ListJobsOperationCompleted == null)
            {
                this.ListJobsOperationCompleted = new SendOrPostCallback(this.OnListJobsOperationCompleted);
            }

            this.InvokeAsync("ListJobs", new object[0], this.ListJobsOperationCompleted, userState);
        }

        /// <summary>
        /// The list model drillthrough reports.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" +
            "tModelDrillthroughReports", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Reports")]
        public ModelDrillthroughReport[] ListModelDrillthroughReports(string Model, string ModelItemID)
        {
            object[] results = this.Invoke("ListModelDrillthroughReports", new object[] { Model, ModelItemID });
            return (ModelDrillthroughReport[])results[0];
        }

        /// <summary>
        /// The list model drillthrough reports async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListModelDrillthroughReportsAsync(string Model, string ModelItemID)
        {
            this.ListModelDrillthroughReportsAsync(Model, ModelItemID, null);
        }

        /// <summary>
        /// The list model drillthrough reports async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListModelDrillthroughReportsAsync(string Model, string ModelItemID, object userState)
        {
            if (this.ListModelDrillthroughReportsOperationCompleted == null)
            {
                this.ListModelDrillthroughReportsOperationCompleted =
                    new SendOrPostCallback(this.OnListModelDrillthroughReportsOperationCompleted);
            }

            this.InvokeAsync(
                "ListModelDrillthroughReports", 
                new object[] { Model, ModelItemID }, 
                this.ListModelDrillthroughReportsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The list model item children.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Recursive">
        /// The Recursive.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tModelItemChildren", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("ModelItems")]
        public ModelItem[] ListModelItemChildren(string Model, string ModelItemID, bool Recursive)
        {
            object[] results = this.Invoke("ListModelItemChildren", new object[] { Model, ModelItemID, Recursive });
            return (ModelItem[])results[0];
        }

        /// <summary>
        /// The list model item children async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Recursive">
        /// The Recursive.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListModelItemChildrenAsync(string Model, string ModelItemID, bool Recursive)
        {
            this.ListModelItemChildrenAsync(Model, ModelItemID, Recursive, null);
        }

        /// <summary>
        /// The list model item children async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Recursive">
        /// The Recursive.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListModelItemChildrenAsync(string Model, string ModelItemID, bool Recursive, object userState)
        {
            if (this.ListModelItemChildrenOperationCompleted == null)
            {
                this.ListModelItemChildrenOperationCompleted =
                    new SendOrPostCallback(this.OnListModelItemChildrenOperationCompleted);
            }

            this.InvokeAsync(
                "ListModelItemChildren", 
                new object[] { Model, ModelItemID, Recursive }, 
                this.ListModelItemChildrenOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The list model perspectives.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tModelPerspectives", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("ModelCatalogItems")]
        public ModelCatalogItem[] ListModelPerspectives(string Model)
        {
            object[] results = this.Invoke("ListModelPerspectives", new object[] { Model });
            return (ModelCatalogItem[])results[0];
        }

        /// <summary>
        /// The list model perspectives async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListModelPerspectivesAsync(string Model)
        {
            this.ListModelPerspectivesAsync(Model, null);
        }

        /// <summary>
        /// The list model perspectives async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListModelPerspectivesAsync(string Model, object userState)
        {
            if (this.ListModelPerspectivesOperationCompleted == null)
            {
                this.ListModelPerspectivesOperationCompleted =
                    new SendOrPostCallback(this.OnListModelPerspectivesOperationCompleted);
            }

            this.InvokeAsync(
                "ListModelPerspectives", new object[] { Model }, this.ListModelPerspectivesOperationCompleted, userState);
        }

        /// <summary>
        /// The list report history.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tReportHistory", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("ReportHistory")]
        public ReportHistorySnapshot[] ListReportHistory(string Report)
        {
            object[] results = this.Invoke("ListReportHistory", new object[] { Report });
            return (ReportHistorySnapshot[])results[0];
        }

        /// <summary>
        /// The list report history async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListReportHistoryAsync(string Report)
        {
            this.ListReportHistoryAsync(Report, null);
        }

        /// <summary>
        /// The list report history async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListReportHistoryAsync(string Report, object userState)
        {
            if (this.ListReportHistoryOperationCompleted == null)
            {
                this.ListReportHistoryOperationCompleted =
                    new SendOrPostCallback(this.OnListReportHistoryOperationCompleted);
            }

            this.InvokeAsync(
                "ListReportHistory", new object[] { Report }, this.ListReportHistoryOperationCompleted, userState);
        }

        /// <summary>
        /// The list roles.
        /// </summary>
        /// <param name="SecurityScope">
        /// The Security Scope.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tRoles", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Roles")]
        public Role[] ListRoles(SecurityScopeEnum SecurityScope)
        {
            object[] results = this.Invoke("ListRoles", new object[] { SecurityScope });
            return (Role[])results[0];
        }

        /// <summary>
        /// The list roles async.
        /// </summary>
        /// <param name="SecurityScope">
        /// The Security Scope.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListRolesAsync(SecurityScopeEnum SecurityScope)
        {
            this.ListRolesAsync(SecurityScope, null);
        }

        /// <summary>
        /// The list roles async.
        /// </summary>
        /// <param name="SecurityScope">
        /// The Security Scope.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListRolesAsync(SecurityScopeEnum SecurityScope, object userState)
        {
            if (this.ListRolesOperationCompleted == null)
            {
                this.ListRolesOperationCompleted = new SendOrPostCallback(this.OnListRolesOperationCompleted);
            }

            this.InvokeAsync("ListRoles", new object[] { SecurityScope }, this.ListRolesOperationCompleted, userState);
        }

        /// <summary>
        /// The list scheduled reports.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tScheduledReports", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Reports")]
        public CatalogItem[] ListScheduledReports(string ScheduleID)
        {
            object[] results = this.Invoke("ListScheduledReports", new object[] { ScheduleID });
            return (CatalogItem[])results[0];
        }

        /// <summary>
        /// The list scheduled reports async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListScheduledReportsAsync(string ScheduleID)
        {
            this.ListScheduledReportsAsync(ScheduleID, null);
        }

        /// <summary>
        /// The list scheduled reports async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListScheduledReportsAsync(string ScheduleID, object userState)
        {
            if (this.ListScheduledReportsOperationCompleted == null)
            {
                this.ListScheduledReportsOperationCompleted =
                    new SendOrPostCallback(this.OnListScheduledReportsOperationCompleted);
            }

            this.InvokeAsync(
                "ListScheduledReports", 
                new object[] { ScheduleID }, 
                this.ListScheduledReportsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The list schedules.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tSchedules", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Schedules")]
        public Schedule[] ListSchedules()
        {
            object[] results = this.Invoke("ListSchedules", new object[0]);
            return (Schedule[])results[0];
        }

        /// <summary>
        /// The list schedules async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void ListSchedulesAsync()
        {
            this.ListSchedulesAsync(null);
        }

        /// <summary>
        /// The list schedules async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListSchedulesAsync(object userState)
        {
            if (this.ListSchedulesOperationCompleted == null)
            {
                this.ListSchedulesOperationCompleted = new SendOrPostCallback(this.OnListSchedulesOperationCompleted);
            }

            this.InvokeAsync("ListSchedules", new object[0], this.ListSchedulesOperationCompleted, userState);
        }

        /// <summary>
        /// The list secure methods.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tSecureMethods", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public string[] ListSecureMethods()
        {
            object[] results = this.Invoke("ListSecureMethods", new object[0]);
            return (string[])results[0];
        }

        /// <summary>
        /// The list secure methods async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void ListSecureMethodsAsync()
        {
            this.ListSecureMethodsAsync(null);
        }

        /// <summary>
        /// The list secure methods async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListSecureMethodsAsync(object userState)
        {
            if (this.ListSecureMethodsOperationCompleted == null)
            {
                this.ListSecureMethodsOperationCompleted =
                    new SendOrPostCallback(this.OnListSecureMethodsOperationCompleted);
            }

            this.InvokeAsync("ListSecureMethods", new object[0], this.ListSecureMethodsOperationCompleted, userState);
        }

        /// <summary>
        /// The list subscriptions.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Owner">
        /// The Owner.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tSubscriptions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("SubscriptionItems")]
        public Subscription[] ListSubscriptions(string Report, string Owner)
        {
            object[] results = this.Invoke("ListSubscriptions", new object[] { Report, Owner });
            return (Subscription[])results[0];
        }

        /// <summary>
        /// The list subscriptions async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Owner">
        /// The Owner.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListSubscriptionsAsync(string Report, string Owner)
        {
            this.ListSubscriptionsAsync(Report, Owner, null);
        }

        /// <summary>
        /// The list subscriptions async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Owner">
        /// The Owner.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListSubscriptionsAsync(string Report, string Owner, object userState)
        {
            if (this.ListSubscriptionsOperationCompleted == null)
            {
                this.ListSubscriptionsOperationCompleted =
                    new SendOrPostCallback(this.OnListSubscriptionsOperationCompleted);
            }

            this.InvokeAsync(
                "ListSubscriptions", new object[] { Report, Owner }, this.ListSubscriptionsOperationCompleted, userState);
        }

        /// <summary>
        /// The list subscriptions using data source.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" +
            "tSubscriptionsUsingDataSource", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("SubscriptionItems")]
        public Subscription[] ListSubscriptionsUsingDataSource(string DataSource)
        {
            object[] results = this.Invoke("ListSubscriptionsUsingDataSource", new object[] { DataSource });
            return (Subscription[])results[0];
        }

        /// <summary>
        /// The list subscriptions using data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListSubscriptionsUsingDataSourceAsync(string DataSource)
        {
            this.ListSubscriptionsUsingDataSourceAsync(DataSource, null);
        }

        /// <summary>
        /// The list subscriptions using data source async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListSubscriptionsUsingDataSourceAsync(string DataSource, object userState)
        {
            if (this.ListSubscriptionsUsingDataSourceOperationCompleted == null)
            {
                this.ListSubscriptionsUsingDataSourceOperationCompleted =
                    new SendOrPostCallback(this.OnListSubscriptionsUsingDataSourceOperationCompleted);
            }

            this.InvokeAsync(
                "ListSubscriptionsUsingDataSource", 
                new object[] { DataSource }, 
                this.ListSubscriptionsUsingDataSourceOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The list tasks.
        /// </summary>
        /// <param name="SecurityScope">
        /// The Security Scope.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Lis" + "tTasks", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Tasks")]
        public Task[] ListTasks(SecurityScopeEnum SecurityScope)
        {
            object[] results = this.Invoke("ListTasks", new object[] { SecurityScope });
            return (Task[])results[0];
        }

        /// <summary>
        /// The list tasks async.
        /// </summary>
        /// <param name="SecurityScope">
        /// The Security Scope.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListTasksAsync(SecurityScopeEnum SecurityScope)
        {
            this.ListTasksAsync(SecurityScope, null);
        }

        /// <summary>
        /// The list tasks async.
        /// </summary>
        /// <param name="SecurityScope">
        /// The Security Scope.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ListTasksAsync(SecurityScopeEnum SecurityScope, object userState)
        {
            if (this.ListTasksOperationCompleted == null)
            {
                this.ListTasksOperationCompleted = new SendOrPostCallback(this.OnListTasksOperationCompleted);
            }

            this.InvokeAsync("ListTasks", new object[] { SecurityScope }, this.ListTasksOperationCompleted, userState);
        }

        /// <summary>
        /// The logoff.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod("http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log" + "off", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void Logoff()
        {
            this.Invoke("Logoff", new object[0]);
        }

        /// <summary>
        /// The logoff async.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public void LogoffAsync()
        {
            this.LogoffAsync(null);
        }

        /// <summary>
        /// The logoff async.
        /// </summary>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void LogoffAsync(object userState)
        {
            if (this.LogoffOperationCompleted == null)
            {
                this.LogoffOperationCompleted = new SendOrPostCallback(this.OnLogoffOperationCompleted);
            }

            this.InvokeAsync("Logoff", new object[0], this.LogoffOperationCompleted, userState);
        }

        /// <summary>
        /// The logon user.
        /// </summary>
        /// <param name="userName">
        /// The user Name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="authority">
        /// The authority.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Log" + "onUser", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void LogonUser(string userName, string password, string authority)
        {
            this.Invoke("LogonUser", new object[] { userName, password, authority });
        }

        /// <summary>
        /// The logon user async.
        /// </summary>
        /// <param name="userName">
        /// The user Name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="authority">
        /// The authority.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void LogonUserAsync(string userName, string password, string authority)
        {
            this.LogonUserAsync(userName, password, authority, null);
        }

        /// <summary>
        /// The logon user async.
        /// </summary>
        /// <param name="userName">
        /// The user Name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="authority">
        /// The authority.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void LogonUserAsync(string userName, string password, string authority, object userState)
        {
            if (this.LogonUserOperationCompleted == null)
            {
                this.LogonUserOperationCompleted = new SendOrPostCallback(this.OnLogonUserOperationCompleted);
            }

            this.InvokeAsync(
                "LogonUser", new object[] { userName, password, authority }, this.LogonUserOperationCompleted, userState);
        }

        /// <summary>
        /// The move item.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Target">
        /// The Target.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Mov" + "eItem", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void MoveItem(string Item, string Target)
        {
            this.Invoke("MoveItem", new object[] { Item, Target });
        }

        /// <summary>
        /// The move item async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Target">
        /// The Target.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void MoveItemAsync(string Item, string Target)
        {
            this.MoveItemAsync(Item, Target, null);
        }

        /// <summary>
        /// The move item async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Target">
        /// The Target.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void MoveItemAsync(string Item, string Target, object userState)
        {
            if (this.MoveItemOperationCompleted == null)
            {
                this.MoveItemOperationCompleted = new SendOrPostCallback(this.OnMoveItemOperationCompleted);
            }

            this.InvokeAsync("MoveItem", new object[] { Item, Target }, this.MoveItemOperationCompleted, userState);
        }

        /// <summary>
        /// The pause schedule.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Pau" + "seSchedule", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void PauseSchedule(string ScheduleID)
        {
            this.Invoke("PauseSchedule", new object[] { ScheduleID });
        }

        /// <summary>
        /// The pause schedule async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void PauseScheduleAsync(string ScheduleID)
        {
            this.PauseScheduleAsync(ScheduleID, null);
        }

        /// <summary>
        /// The pause schedule async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void PauseScheduleAsync(string ScheduleID, object userState)
        {
            if (this.PauseScheduleOperationCompleted == null)
            {
                this.PauseScheduleOperationCompleted = new SendOrPostCallback(this.OnPauseScheduleOperationCompleted);
            }

            this.InvokeAsync(
                "PauseSchedule", new object[] { ScheduleID }, this.PauseScheduleOperationCompleted, userState);
        }

        /// <summary>
        /// The prepare query.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="DataSet">
        /// The Data Set.
        /// </param>
        /// <param name="Changed">
        /// The Changed.
        /// </param>
        /// <param name="ParameterNames">
        /// The Parameter Names.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Pre" + "pareQuery", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlElement("DataSettings")]
        public DataSetDefinition PrepareQuery(
            DataSource DataSource, DataSetDefinition DataSet, out bool Changed, out string[] ParameterNames)
        {
            object[] results = this.Invoke("PrepareQuery", new object[] { DataSource, DataSet });
            Changed = (bool)results[1];
            ParameterNames = (string[])results[2];
            return (DataSetDefinition)results[0];
        }

        /// <summary>
        /// The prepare query async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="DataSet">
        /// The Data Set.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void PrepareQueryAsync(DataSource DataSource, DataSetDefinition DataSet)
        {
            this.PrepareQueryAsync(DataSource, DataSet, null);
        }

        /// <summary>
        /// The prepare query async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="DataSet">
        /// The Data Set.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void PrepareQueryAsync(DataSource DataSource, DataSetDefinition DataSet, object userState)
        {
            if (this.PrepareQueryOperationCompleted == null)
            {
                this.PrepareQueryOperationCompleted = new SendOrPostCallback(this.OnPrepareQueryOperationCompleted);
            }

            this.InvokeAsync(
                "PrepareQuery", new object[] { DataSource, DataSet }, this.PrepareQueryOperationCompleted, userState);
        }

        /// <summary>
        /// The regenerate model.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Reg" + "enerateModel", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Warnings")]
        public Warning[] RegenerateModel(string Model)
        {
            object[] results = this.Invoke("RegenerateModel", new object[] { Model });
            return (Warning[])results[0];
        }

        /// <summary>
        /// The regenerate model async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void RegenerateModelAsync(string Model)
        {
            this.RegenerateModelAsync(Model, null);
        }

        /// <summary>
        /// The regenerate model async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void RegenerateModelAsync(string Model, object userState)
        {
            if (this.RegenerateModelOperationCompleted == null)
            {
                this.RegenerateModelOperationCompleted = new SendOrPostCallback(
                    this.OnRegenerateModelOperationCompleted);
            }

            this.InvokeAsync(
                "RegenerateModel", new object[] { Model }, this.RegenerateModelOperationCompleted, userState);
        }

        /// <summary>
        /// The remove all model item policies.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Rem" +
            "oveAllModelItemPolicies", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void RemoveAllModelItemPolicies(string Model)
        {
            this.Invoke("RemoveAllModelItemPolicies", new object[] { Model });
        }

        /// <summary>
        /// The remove all model item policies async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void RemoveAllModelItemPoliciesAsync(string Model)
        {
            this.RemoveAllModelItemPoliciesAsync(Model, null);
        }

        /// <summary>
        /// The remove all model item policies async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void RemoveAllModelItemPoliciesAsync(string Model, object userState)
        {
            if (this.RemoveAllModelItemPoliciesOperationCompleted == null)
            {
                this.RemoveAllModelItemPoliciesOperationCompleted =
                    new SendOrPostCallback(this.OnRemoveAllModelItemPoliciesOperationCompleted);
            }

            this.InvokeAsync(
                "RemoveAllModelItemPolicies", 
                new object[] { Model }, 
                this.RemoveAllModelItemPoliciesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The resume schedule.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Res" + "umeSchedule", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void ResumeSchedule(string ScheduleID)
        {
            this.Invoke("ResumeSchedule", new object[] { ScheduleID });
        }

        /// <summary>
        /// The resume schedule async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ResumeScheduleAsync(string ScheduleID)
        {
            this.ResumeScheduleAsync(ScheduleID, null);
        }

        /// <summary>
        /// The resume schedule async.
        /// </summary>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ResumeScheduleAsync(string ScheduleID, object userState)
        {
            if (this.ResumeScheduleOperationCompleted == null)
            {
                this.ResumeScheduleOperationCompleted = new SendOrPostCallback(this.OnResumeScheduleOperationCompleted);
            }

            this.InvokeAsync(
                "ResumeSchedule", new object[] { ScheduleID }, this.ResumeScheduleOperationCompleted, userState);
        }

        /// <summary>
        /// The set cache options.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="CacheReport">
        /// The Cache Report.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "CacheOptions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetCacheOptions(
            string Report, 
            bool CacheReport, 
            [XmlElement("ScheduleExpiration", typeof(ScheduleExpiration))] [XmlElement("TimeExpiration", typeof(TimeExpiration))] ExpirationDefinition Item)
        {
            this.Invoke("SetCacheOptions", new object[] { Report, CacheReport, Item });
        }

        /// <summary>
        /// The set cache options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="CacheReport">
        /// The Cache Report.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetCacheOptionsAsync(string Report, bool CacheReport, ExpirationDefinition Item)
        {
            this.SetCacheOptionsAsync(Report, CacheReport, Item, null);
        }

        /// <summary>
        /// The set cache options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="CacheReport">
        /// The Cache Report.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetCacheOptionsAsync(string Report, bool CacheReport, ExpirationDefinition Item, object userState)
        {
            if (this.SetCacheOptionsOperationCompleted == null)
            {
                this.SetCacheOptionsOperationCompleted = new SendOrPostCallback(
                    this.OnSetCacheOptionsOperationCompleted);
            }

            this.InvokeAsync(
                "SetCacheOptions", 
                new object[] { Report, CacheReport, Item }, 
                this.SetCacheOptionsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set data driven subscription properties.
        /// </summary>
        /// <param name="DataDrivenSubscriptionID">
        /// The Data Driven Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="DataRetrievalPlan">
        /// The Data Retrieval Plan.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" +
            "DataDrivenSubscriptionProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetDataDrivenSubscriptionProperties(
            string DataDrivenSubscriptionID, 
            ExtensionSettings ExtensionSettings, 
            DataRetrievalPlan DataRetrievalPlan, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValueOrFieldReference[] Parameters)
        {
            this.Invoke(
                "SetDataDrivenSubscriptionProperties", 
                new object[]
                    {
                        DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, 
                        Parameters
                    });
        }

        /// <summary>
        /// The set data driven subscription properties async.
        /// </summary>
        /// <param name="DataDrivenSubscriptionID">
        /// The Data Driven Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="DataRetrievalPlan">
        /// The Data Retrieval Plan.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetDataDrivenSubscriptionPropertiesAsync(
            string DataDrivenSubscriptionID, 
            ExtensionSettings ExtensionSettings, 
            DataRetrievalPlan DataRetrievalPlan, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValueOrFieldReference[] Parameters)
        {
            this.SetDataDrivenSubscriptionPropertiesAsync(
                DataDrivenSubscriptionID, 
                ExtensionSettings, 
                DataRetrievalPlan, 
                Description, 
                EventType, 
                MatchData, 
                Parameters, 
                null);
        }

        /// <summary>
        /// The set data driven subscription properties async.
        /// </summary>
        /// <param name="DataDrivenSubscriptionID">
        /// The Data Driven Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="DataRetrievalPlan">
        /// The Data Retrieval Plan.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetDataDrivenSubscriptionPropertiesAsync(
            string DataDrivenSubscriptionID, 
            ExtensionSettings ExtensionSettings, 
            DataRetrievalPlan DataRetrievalPlan, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValueOrFieldReference[] Parameters, 
            object userState)
        {
            if (this.SetDataDrivenSubscriptionPropertiesOperationCompleted == null)
            {
                this.SetDataDrivenSubscriptionPropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnSetDataDrivenSubscriptionPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "SetDataDrivenSubscriptionProperties", 
                new object[]
                    {
                        DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, 
                        Parameters
                    }, 
                this.SetDataDrivenSubscriptionPropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set data source contents.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "DataSourceContents", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetDataSourceContents(string DataSource, DataSourceDefinition Definition)
        {
            this.Invoke("SetDataSourceContents", new object[] { DataSource, Definition });
        }

        /// <summary>
        /// The set data source contents async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetDataSourceContentsAsync(string DataSource, DataSourceDefinition Definition)
        {
            this.SetDataSourceContentsAsync(DataSource, Definition, null);
        }

        /// <summary>
        /// The set data source contents async.
        /// </summary>
        /// <param name="DataSource">
        /// The Data Source.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetDataSourceContentsAsync(string DataSource, DataSourceDefinition Definition, object userState)
        {
            if (this.SetDataSourceContentsOperationCompleted == null)
            {
                this.SetDataSourceContentsOperationCompleted =
                    new SendOrPostCallback(this.OnSetDataSourceContentsOperationCompleted);
            }

            this.InvokeAsync(
                "SetDataSourceContents", 
                new object[] { DataSource, Definition }, 
                this.SetDataSourceContentsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set execution options.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExecutionSetting">
        /// The Execution Setting.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ExecutionOptions", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetExecutionOptions(
            string Report, 
            ExecutionSettingEnum ExecutionSetting, 
            [XmlElement("NoSchedule", typeof(NoSchedule))] [XmlElement("ScheduleDefinition", typeof(ScheduleDefinition))] [XmlElement("ScheduleReference", typeof(ScheduleReference))] ScheduleDefinitionOrReference Item)
        {
            this.Invoke("SetExecutionOptions", new object[] { Report, ExecutionSetting, Item });
        }

        /// <summary>
        /// The set execution options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExecutionSetting">
        /// The Execution Setting.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetExecutionOptionsAsync(
            string Report, ExecutionSettingEnum ExecutionSetting, ScheduleDefinitionOrReference Item)
        {
            this.SetExecutionOptionsAsync(Report, ExecutionSetting, Item, null);
        }

        /// <summary>
        /// The set execution options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="ExecutionSetting">
        /// The Execution Setting.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetExecutionOptionsAsync(
            string Report, ExecutionSettingEnum ExecutionSetting, ScheduleDefinitionOrReference Item, object userState)
        {
            if (this.SetExecutionOptionsOperationCompleted == null)
            {
                this.SetExecutionOptionsOperationCompleted =
                    new SendOrPostCallback(this.OnSetExecutionOptionsOperationCompleted);
            }

            this.InvokeAsync(
                "SetExecutionOptions", 
                new object[] { Report, ExecutionSetting, Item }, 
                this.SetExecutionOptionsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set item data sources.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="DataSources">
        /// The Data Sources.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ItemDataSources", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetItemDataSources(string Item, DataSource[] DataSources)
        {
            this.Invoke("SetItemDataSources", new object[] { Item, DataSources });
        }

        /// <summary>
        /// The set item data sources async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="DataSources">
        /// The Data Sources.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetItemDataSourcesAsync(string Item, DataSource[] DataSources)
        {
            this.SetItemDataSourcesAsync(Item, DataSources, null);
        }

        /// <summary>
        /// The set item data sources async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="DataSources">
        /// The Data Sources.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetItemDataSourcesAsync(string Item, DataSource[] DataSources, object userState)
        {
            if (this.SetItemDataSourcesOperationCompleted == null)
            {
                this.SetItemDataSourcesOperationCompleted =
                    new SendOrPostCallback(this.OnSetItemDataSourcesOperationCompleted);
            }

            this.InvokeAsync(
                "SetItemDataSources", 
                new object[] { Item, DataSources }, 
                this.SetItemDataSourcesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set model definition.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ModelDefinition", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Warnings")]
        public Warning[] SetModelDefinition(string Model, [XmlElement(DataType = "base64Binary")] byte[] Definition)
        {
            object[] results = this.Invoke("SetModelDefinition", new object[] { Model, Definition });
            return (Warning[])results[0];
        }

        /// <summary>
        /// The set model definition async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetModelDefinitionAsync(string Model, byte[] Definition)
        {
            this.SetModelDefinitionAsync(Model, Definition, null);
        }

        /// <summary>
        /// The set model definition async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetModelDefinitionAsync(string Model, byte[] Definition, object userState)
        {
            if (this.SetModelDefinitionOperationCompleted == null)
            {
                this.SetModelDefinitionOperationCompleted =
                    new SendOrPostCallback(this.OnSetModelDefinitionOperationCompleted);
            }

            this.InvokeAsync(
                "SetModelDefinition", 
                new object[] { Model, Definition }, 
                this.SetModelDefinitionOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set model drillthrough reports.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Reports">
        /// The Reports.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" +
            "ModelDrillthroughReports", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetModelDrillthroughReports(string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
        {
            this.Invoke("SetModelDrillthroughReports", new object[] { Model, ModelItemID, Reports });
        }

        /// <summary>
        /// The set model drillthrough reports async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Reports">
        /// The Reports.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetModelDrillthroughReportsAsync(
            string Model, string ModelItemID, ModelDrillthroughReport[] Reports)
        {
            this.SetModelDrillthroughReportsAsync(Model, ModelItemID, Reports, null);
        }

        /// <summary>
        /// The set model drillthrough reports async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Reports">
        /// The Reports.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetModelDrillthroughReportsAsync(
            string Model, string ModelItemID, ModelDrillthroughReport[] Reports, object userState)
        {
            if (this.SetModelDrillthroughReportsOperationCompleted == null)
            {
                this.SetModelDrillthroughReportsOperationCompleted =
                    new SendOrPostCallback(this.OnSetModelDrillthroughReportsOperationCompleted);
            }

            this.InvokeAsync(
                "SetModelDrillthroughReports", 
                new object[] { Model, ModelItemID, Reports }, 
                this.SetModelDrillthroughReportsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set model item policies.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ModelItemPolicies", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetModelItemPolicies(string Model, string ModelItemID, Policy[] Policies)
        {
            this.Invoke("SetModelItemPolicies", new object[] { Model, ModelItemID, Policies });
        }

        /// <summary>
        /// The set model item policies async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetModelItemPoliciesAsync(string Model, string ModelItemID, Policy[] Policies)
        {
            this.SetModelItemPoliciesAsync(Model, ModelItemID, Policies, null);
        }

        /// <summary>
        /// The set model item policies async.
        /// </summary>
        /// <param name="Model">
        /// The Model.
        /// </param>
        /// <param name="ModelItemID">
        /// The Model Item ID.
        /// </param>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetModelItemPoliciesAsync(string Model, string ModelItemID, Policy[] Policies, object userState)
        {
            if (this.SetModelItemPoliciesOperationCompleted == null)
            {
                this.SetModelItemPoliciesOperationCompleted =
                    new SendOrPostCallback(this.OnSetModelItemPoliciesOperationCompleted);
            }

            this.InvokeAsync(
                "SetModelItemPolicies", 
                new object[] { Model, ModelItemID, Policies }, 
                this.SetModelItemPoliciesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set policies.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "Policies", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetPolicies(string Item, Policy[] Policies)
        {
            this.Invoke("SetPolicies", new object[] { Item, Policies });
        }

        /// <summary>
        /// The set policies async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetPoliciesAsync(string Item, Policy[] Policies)
        {
            this.SetPoliciesAsync(Item, Policies, null);
        }

        /// <summary>
        /// The set policies async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetPoliciesAsync(string Item, Policy[] Policies, object userState)
        {
            if (this.SetPoliciesOperationCompleted == null)
            {
                this.SetPoliciesOperationCompleted = new SendOrPostCallback(this.OnSetPoliciesOperationCompleted);
            }

            this.InvokeAsync(
                "SetPolicies", new object[] { Item, Policies }, this.SetPoliciesOperationCompleted, userState);
        }

        /// <summary>
        /// The set properties.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "Properties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetProperties(string Item, Property[] Properties)
        {
            this.Invoke("SetProperties", new object[] { Item, Properties });
        }

        /// <summary>
        /// The set properties async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetPropertiesAsync(string Item, Property[] Properties)
        {
            this.SetPropertiesAsync(Item, Properties, null);
        }

        /// <summary>
        /// The set properties async.
        /// </summary>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetPropertiesAsync(string Item, Property[] Properties, object userState)
        {
            if (this.SetPropertiesOperationCompleted == null)
            {
                this.SetPropertiesOperationCompleted = new SendOrPostCallback(this.OnSetPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "SetProperties", new object[] { Item, Properties }, this.SetPropertiesOperationCompleted, userState);
        }

        /// <summary>
        /// The set report definition.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ReportDefinition", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("Warnings")]
        public Warning[] SetReportDefinition(string Report, [XmlElement(DataType = "base64Binary")] byte[] Definition)
        {
            object[] results = this.Invoke("SetReportDefinition", new object[] { Report, Definition });
            return (Warning[])results[0];
        }

        /// <summary>
        /// The set report definition async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportDefinitionAsync(string Report, byte[] Definition)
        {
            this.SetReportDefinitionAsync(Report, Definition, null);
        }

        /// <summary>
        /// The set report definition async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Definition">
        /// The Definition.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportDefinitionAsync(string Report, byte[] Definition, object userState)
        {
            if (this.SetReportDefinitionOperationCompleted == null)
            {
                this.SetReportDefinitionOperationCompleted =
                    new SendOrPostCallback(this.OnSetReportDefinitionOperationCompleted);
            }

            this.InvokeAsync(
                "SetReportDefinition", 
                new object[] { Report, Definition }, 
                this.SetReportDefinitionOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set report history limit.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="UseSystem">
        /// The Use System.
        /// </param>
        /// <param name="HistoryLimit">
        /// The History Limit.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ReportHistoryLimit", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetReportHistoryLimit(string Report, bool UseSystem, int HistoryLimit)
        {
            this.Invoke("SetReportHistoryLimit", new object[] { Report, UseSystem, HistoryLimit });
        }

        /// <summary>
        /// The set report history limit async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="UseSystem">
        /// The Use System.
        /// </param>
        /// <param name="HistoryLimit">
        /// The History Limit.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportHistoryLimitAsync(string Report, bool UseSystem, int HistoryLimit)
        {
            this.SetReportHistoryLimitAsync(Report, UseSystem, HistoryLimit, null);
        }

        /// <summary>
        /// The set report history limit async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="UseSystem">
        /// The Use System.
        /// </param>
        /// <param name="HistoryLimit">
        /// The History Limit.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportHistoryLimitAsync(string Report, bool UseSystem, int HistoryLimit, object userState)
        {
            if (this.SetReportHistoryLimitOperationCompleted == null)
            {
                this.SetReportHistoryLimitOperationCompleted =
                    new SendOrPostCallback(this.OnSetReportHistoryLimitOperationCompleted);
            }

            this.InvokeAsync(
                "SetReportHistoryLimit", 
                new object[] { Report, UseSystem, HistoryLimit }, 
                this.SetReportHistoryLimitOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set report history options.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="EnableManualSnapshotCreation">
        /// The Enable Manual Snapshot Creation.
        /// </param>
        /// <param name="KeepExecutionSnapshots">
        /// The Keep Execution Snapshots.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ReportHistoryOptions"
            , RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetReportHistoryOptions(
            string Report, 
            bool EnableManualSnapshotCreation, 
            bool KeepExecutionSnapshots, 
            [XmlElement("NoSchedule", typeof(NoSchedule))] [XmlElement("ScheduleDefinition", typeof(ScheduleDefinition))] [XmlElement("ScheduleReference", typeof(ScheduleReference))] ScheduleDefinitionOrReference Item)
        {
            this.Invoke(
                "SetReportHistoryOptions", 
                new object[] { Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item });
        }

        /// <summary>
        /// The set report history options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="EnableManualSnapshotCreation">
        /// The Enable Manual Snapshot Creation.
        /// </param>
        /// <param name="KeepExecutionSnapshots">
        /// The Keep Execution Snapshots.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportHistoryOptionsAsync(
            string Report, 
            bool EnableManualSnapshotCreation, 
            bool KeepExecutionSnapshots, 
            ScheduleDefinitionOrReference Item)
        {
            this.SetReportHistoryOptionsAsync(Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item, null);
        }

        /// <summary>
        /// The set report history options async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="EnableManualSnapshotCreation">
        /// The Enable Manual Snapshot Creation.
        /// </param>
        /// <param name="KeepExecutionSnapshots">
        /// The Keep Execution Snapshots.
        /// </param>
        /// <param name="Item">
        /// The Item.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportHistoryOptionsAsync(
            string Report, 
            bool EnableManualSnapshotCreation, 
            bool KeepExecutionSnapshots, 
            ScheduleDefinitionOrReference Item, 
            object userState)
        {
            if (this.SetReportHistoryOptionsOperationCompleted == null)
            {
                this.SetReportHistoryOptionsOperationCompleted =
                    new SendOrPostCallback(this.OnSetReportHistoryOptionsOperationCompleted);
            }

            this.InvokeAsync(
                "SetReportHistoryOptions", 
                new object[] { Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item }, 
                this.SetReportHistoryOptionsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set report link.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Link">
        /// The Link.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ReportLink", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetReportLink(string Report, string Link)
        {
            this.Invoke("SetReportLink", new object[] { Report, Link });
        }

        /// <summary>
        /// The set report link async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Link">
        /// The Link.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportLinkAsync(string Report, string Link)
        {
            this.SetReportLinkAsync(Report, Link, null);
        }

        /// <summary>
        /// The set report link async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Link">
        /// The Link.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportLinkAsync(string Report, string Link, object userState)
        {
            if (this.SetReportLinkOperationCompleted == null)
            {
                this.SetReportLinkOperationCompleted = new SendOrPostCallback(this.OnSetReportLinkOperationCompleted);
            }

            this.InvokeAsync(
                "SetReportLink", new object[] { Report, Link }, this.SetReportLinkOperationCompleted, userState);
        }

        /// <summary>
        /// The set report parameters.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ReportParameters", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetReportParameters(string Report, ReportParameter[] Parameters)
        {
            this.Invoke("SetReportParameters", new object[] { Report, Parameters });
        }

        /// <summary>
        /// The set report parameters async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportParametersAsync(string Report, ReportParameter[] Parameters)
        {
            this.SetReportParametersAsync(Report, Parameters, null);
        }

        /// <summary>
        /// The set report parameters async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetReportParametersAsync(string Report, ReportParameter[] Parameters, object userState)
        {
            if (this.SetReportParametersOperationCompleted == null)
            {
                this.SetReportParametersOperationCompleted =
                    new SendOrPostCallback(this.OnSetReportParametersOperationCompleted);
            }

            this.InvokeAsync(
                "SetReportParameters", 
                new object[] { Report, Parameters }, 
                this.SetReportParametersOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set resource contents.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="Contents">
        /// The Contents.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ResourceContents", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetResourceContents(
            string Resource, [XmlElement(DataType = "base64Binary")] byte[] Contents, string MimeType)
        {
            this.Invoke("SetResourceContents", new object[] { Resource, Contents, MimeType });
        }

        /// <summary>
        /// The set resource contents async.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="Contents">
        /// The Contents.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetResourceContentsAsync(string Resource, byte[] Contents, string MimeType)
        {
            this.SetResourceContentsAsync(Resource, Contents, MimeType, null);
        }

        /// <summary>
        /// The set resource contents async.
        /// </summary>
        /// <param name="Resource">
        /// The Resource.
        /// </param>
        /// <param name="Contents">
        /// The Contents.
        /// </param>
        /// <param name="MimeType">
        /// The Mime Type.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetResourceContentsAsync(string Resource, byte[] Contents, string MimeType, object userState)
        {
            if (this.SetResourceContentsOperationCompleted == null)
            {
                this.SetResourceContentsOperationCompleted =
                    new SendOrPostCallback(this.OnSetResourceContentsOperationCompleted);
            }

            this.InvokeAsync(
                "SetResourceContents", 
                new object[] { Resource, Contents, MimeType }, 
                this.SetResourceContentsOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set role properties.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Tasks">
        /// The Tasks.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "RoleProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetRoleProperties(string Name, string Description, Task[] Tasks)
        {
            this.Invoke("SetRoleProperties", new object[] { Name, Description, Tasks });
        }

        /// <summary>
        /// The set role properties async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Tasks">
        /// The Tasks.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetRolePropertiesAsync(string Name, string Description, Task[] Tasks)
        {
            this.SetRolePropertiesAsync(Name, Description, Tasks, null);
        }

        /// <summary>
        /// The set role properties async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="Tasks">
        /// The Tasks.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetRolePropertiesAsync(string Name, string Description, Task[] Tasks, object userState)
        {
            if (this.SetRolePropertiesOperationCompleted == null)
            {
                this.SetRolePropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnSetRolePropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "SetRoleProperties", 
                new object[] { Name, Description, Tasks }, 
                this.SetRolePropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set schedule properties.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="ScheduleDefinition">
        /// The Schedule Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "ScheduleProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetScheduleProperties(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
        {
            this.Invoke("SetScheduleProperties", new object[] { Name, ScheduleID, ScheduleDefinition });
        }

        /// <summary>
        /// The set schedule properties async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="ScheduleDefinition">
        /// The Schedule Definition.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSchedulePropertiesAsync(string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition)
        {
            this.SetSchedulePropertiesAsync(Name, ScheduleID, ScheduleDefinition, null);
        }

        /// <summary>
        /// The set schedule properties async.
        /// </summary>
        /// <param name="Name">
        /// The Name.
        /// </param>
        /// <param name="ScheduleID">
        /// The Schedule ID.
        /// </param>
        /// <param name="ScheduleDefinition">
        /// The Schedule Definition.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSchedulePropertiesAsync(
            string Name, string ScheduleID, ScheduleDefinition ScheduleDefinition, object userState)
        {
            if (this.SetSchedulePropertiesOperationCompleted == null)
            {
                this.SetSchedulePropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnSetSchedulePropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "SetScheduleProperties", 
                new object[] { Name, ScheduleID, ScheduleDefinition }, 
                this.SetSchedulePropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set subscription properties.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" +
            "SubscriptionProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetSubscriptionProperties(
            string SubscriptionID, 
            ExtensionSettings ExtensionSettings, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValue[] Parameters)
        {
            this.Invoke(
                "SetSubscriptionProperties", 
                new object[] { SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters });
        }

        /// <summary>
        /// The set subscription properties async.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSubscriptionPropertiesAsync(
            string SubscriptionID, 
            ExtensionSettings ExtensionSettings, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValue[] Parameters)
        {
            this.SetSubscriptionPropertiesAsync(
                SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters, null);
        }

        /// <summary>
        /// The set subscription properties async.
        /// </summary>
        /// <param name="SubscriptionID">
        /// The Subscription ID.
        /// </param>
        /// <param name="ExtensionSettings">
        /// The Extension Settings.
        /// </param>
        /// <param name="Description">
        /// The Description.
        /// </param>
        /// <param name="EventType">
        /// The Event Type.
        /// </param>
        /// <param name="MatchData">
        /// The Match Data.
        /// </param>
        /// <param name="Parameters">
        /// The Parameters.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSubscriptionPropertiesAsync(
            string SubscriptionID, 
            ExtensionSettings ExtensionSettings, 
            string Description, 
            string EventType, 
            string MatchData, 
            ParameterValue[] Parameters, 
            object userState)
        {
            if (this.SetSubscriptionPropertiesOperationCompleted == null)
            {
                this.SetSubscriptionPropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnSetSubscriptionPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "SetSubscriptionProperties", 
                new object[] { SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters }, 
                this.SetSubscriptionPropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The set system policies.
        /// </summary>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "SystemPolicies", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetSystemPolicies(Policy[] Policies)
        {
            this.Invoke("SetSystemPolicies", new object[] { Policies });
        }

        /// <summary>
        /// The set system policies async.
        /// </summary>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSystemPoliciesAsync(Policy[] Policies)
        {
            this.SetSystemPoliciesAsync(Policies, null);
        }

        /// <summary>
        /// The set system policies async.
        /// </summary>
        /// <param name="Policies">
        /// The Policies.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSystemPoliciesAsync(Policy[] Policies, object userState)
        {
            if (this.SetSystemPoliciesOperationCompleted == null)
            {
                this.SetSystemPoliciesOperationCompleted =
                    new SendOrPostCallback(this.OnSetSystemPoliciesOperationCompleted);
            }

            this.InvokeAsync(
                "SetSystemPolicies", new object[] { Policies }, this.SetSystemPoliciesOperationCompleted, userState);
        }

        /// <summary>
        /// The set system properties.
        /// </summary>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Set" + "SystemProperties", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void SetSystemProperties(Property[] Properties)
        {
            this.Invoke("SetSystemProperties", new object[] { Properties });
        }

        /// <summary>
        /// The set system properties async.
        /// </summary>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSystemPropertiesAsync(Property[] Properties)
        {
            this.SetSystemPropertiesAsync(Properties, null);
        }

        /// <summary>
        /// The set system properties async.
        /// </summary>
        /// <param name="Properties">
        /// The Properties.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void SetSystemPropertiesAsync(Property[] Properties, object userState)
        {
            if (this.SetSystemPropertiesOperationCompleted == null)
            {
                this.SetSystemPropertiesOperationCompleted =
                    new SendOrPostCallback(this.OnSetSystemPropertiesOperationCompleted);
            }

            this.InvokeAsync(
                "SetSystemProperties", 
                new object[] { Properties }, 
                this.SetSystemPropertiesOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The update report execution snapshot.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapHeader("BatchHeaderValue")]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Upd" +
            "ateReportExecutionSnapshot", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void UpdateReportExecutionSnapshot(string Report)
        {
            this.Invoke("UpdateReportExecutionSnapshot", new object[] { Report });
        }

        /// <summary>
        /// The update report execution snapshot async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void UpdateReportExecutionSnapshotAsync(string Report)
        {
            this.UpdateReportExecutionSnapshotAsync(Report, null);
        }

        /// <summary>
        /// The update report execution snapshot async.
        /// </summary>
        /// <param name="Report">
        /// The Report.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void UpdateReportExecutionSnapshotAsync(string Report, object userState)
        {
            if (this.UpdateReportExecutionSnapshotOperationCompleted == null)
            {
                this.UpdateReportExecutionSnapshotOperationCompleted =
                    new SendOrPostCallback(this.OnUpdateReportExecutionSnapshotOperationCompleted);
            }

            this.InvokeAsync(
                "UpdateReportExecutionSnapshot", 
                new object[] { Report }, 
                this.UpdateReportExecutionSnapshotOperationCompleted, 
                userState);
        }

        /// <summary>
        /// The validate extension settings.
        /// </summary>
        /// <param name="Extension">
        /// The Extension.
        /// </param>
        /// <param name="ParameterValues">
        /// The Parameter Values.
        /// </param>
        /// <remarks>
        /// </remarks>
        [SoapHeader("ServerInfoHeaderValue", Direction = SoapHeaderDirection.Out)]
        [SoapDocumentMethod(
            "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices/Val" +
            "idateExtensionSettings", 
            RequestNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            ResponseNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
            Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        [return: XmlArray("ParameterErrors")]
        public ExtensionParameter[] ValidateExtensionSettings(
            string Extension, ParameterValueOrFieldReference[] ParameterValues)
        {
            object[] results = this.Invoke("ValidateExtensionSettings", new object[] { Extension, ParameterValues });
            return (ExtensionParameter[])results[0];
        }

        /// <summary>
        /// The validate extension settings async.
        /// </summary>
        /// <param name="Extension">
        /// The Extension.
        /// </param>
        /// <param name="ParameterValues">
        /// The Parameter Values.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ValidateExtensionSettingsAsync(string Extension, ParameterValueOrFieldReference[] ParameterValues)
        {
            this.ValidateExtensionSettingsAsync(Extension, ParameterValues, null);
        }

        /// <summary>
        /// The validate extension settings async.
        /// </summary>
        /// <param name="Extension">
        /// The Extension.
        /// </param>
        /// <param name="ParameterValues">
        /// The Parameter Values.
        /// </param>
        /// <param name="userState">
        /// The user State.
        /// </param>
        /// <remarks>
        /// </remarks>
        public void ValidateExtensionSettingsAsync(
            string Extension, ParameterValueOrFieldReference[] ParameterValues, object userState)
        {
            if (this.ValidateExtensionSettingsOperationCompleted == null)
            {
                this.ValidateExtensionSettingsOperationCompleted =
                    new SendOrPostCallback(this.OnValidateExtensionSettingsOperationCompleted);
            }

            this.InvokeAsync(
                "ValidateExtensionSettings", 
                new object[] { Extension, ParameterValues }, 
                this.ValidateExtensionSettingsOperationCompleted, 
                userState);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The is local file system web service.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <returns>
        /// The is local file system web service.
        /// </returns>
        private bool IsLocalFileSystemWebService(string url)
        {
            if ((url == null) || (url == string.Empty))
            {
                return false;
            }

            Uri wsUri = new Uri(url);
            if ((wsUri.Port >= 1024) &&
                (string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The on cancel batch operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCancelBatchOperationCompleted(object arg)
        {
            if (this.CancelBatchCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CancelBatchCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on cancel job operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCancelJobOperationCompleted(object arg)
        {
            if (this.CancelJobCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CancelJobCompleted(
                    this, 
                    new CancelJobCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create batch operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateBatchOperationCompleted(object arg)
        {
            if (this.CreateBatchCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateBatchCompleted(
                    this, 
                    new CreateBatchCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create data driven subscription operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateDataDrivenSubscriptionOperationCompleted(object arg)
        {
            if (this.CreateDataDrivenSubscriptionCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateDataDrivenSubscriptionCompleted(
                    this, 
                    new CreateDataDrivenSubscriptionCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create data source operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateDataSourceOperationCompleted(object arg)
        {
            if (this.CreateDataSourceCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateDataSourceCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create folder operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateFolderOperationCompleted(object arg)
        {
            if (this.CreateFolderCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateFolderCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create linked report operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateLinkedReportOperationCompleted(object arg)
        {
            if (this.CreateLinkedReportCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateLinkedReportCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create model operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateModelOperationCompleted(object arg)
        {
            if (this.CreateModelCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateModelCompleted(
                    this, 
                    new CreateModelCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create report history snapshot operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateReportHistorySnapshotOperationCompleted(object arg)
        {
            if (this.CreateReportHistorySnapshotCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateReportHistorySnapshotCompleted(
                    this, 
                    new CreateReportHistorySnapshotCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create report operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateReportOperationCompleted(object arg)
        {
            if (this.CreateReportCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateReportCompleted(
                    this, 
                    new CreateReportCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create resource operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateResourceOperationCompleted(object arg)
        {
            if (this.CreateResourceCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateResourceCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create role operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateRoleOperationCompleted(object arg)
        {
            if (this.CreateRoleCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateRoleCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create schedule operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateScheduleOperationCompleted(object arg)
        {
            if (this.CreateScheduleCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateScheduleCompleted(
                    this, 
                    new CreateScheduleCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on create subscription operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnCreateSubscriptionOperationCompleted(object arg)
        {
            if (this.CreateSubscriptionCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.CreateSubscriptionCompleted(
                    this, 
                    new CreateSubscriptionCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on delete item operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnDeleteItemOperationCompleted(object arg)
        {
            if (this.DeleteItemCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.DeleteItemCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on delete report history snapshot operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnDeleteReportHistorySnapshotOperationCompleted(object arg)
        {
            if (this.DeleteReportHistorySnapshotCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.DeleteReportHistorySnapshotCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on delete role operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnDeleteRoleOperationCompleted(object arg)
        {
            if (this.DeleteRoleCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.DeleteRoleCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on delete schedule operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnDeleteScheduleOperationCompleted(object arg)
        {
            if (this.DeleteScheduleCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.DeleteScheduleCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on delete subscription operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnDeleteSubscriptionOperationCompleted(object arg)
        {
            if (this.DeleteSubscriptionCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.DeleteSubscriptionCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on disable data source operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnDisableDataSourceOperationCompleted(object arg)
        {
            if (this.DisableDataSourceCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.DisableDataSourceCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on enable data source operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnEnableDataSourceOperationCompleted(object arg)
        {
            if (this.EnableDataSourceCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.EnableDataSourceCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on execute batch operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnExecuteBatchOperationCompleted(object arg)
        {
            if (this.ExecuteBatchCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ExecuteBatchCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on find items operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnFindItemsOperationCompleted(object arg)
        {
            if (this.FindItemsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.FindItemsCompleted(
                    this, 
                    new FindItemsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on fire event operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnFireEventOperationCompleted(object arg)
        {
            if (this.FireEventCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.FireEventCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on flush cache operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnFlushCacheOperationCompleted(object arg)
        {
            if (this.FlushCacheCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.FlushCacheCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on generate model operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGenerateModelOperationCompleted(object arg)
        {
            if (this.GenerateModelCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GenerateModelCompleted(
                    this, 
                    new GenerateModelCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get cache options operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetCacheOptionsOperationCompleted(object arg)
        {
            if (this.GetCacheOptionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetCacheOptionsCompleted(
                    this, 
                    new GetCacheOptionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get data driven subscription properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetDataDrivenSubscriptionPropertiesOperationCompleted(object arg)
        {
            if (this.GetDataDrivenSubscriptionPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetDataDrivenSubscriptionPropertiesCompleted(
                    this, 
                    new GetDataDrivenSubscriptionPropertiesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get data source contents operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetDataSourceContentsOperationCompleted(object arg)
        {
            if (this.GetDataSourceContentsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetDataSourceContentsCompleted(
                    this, 
                    new GetDataSourceContentsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get execution options operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetExecutionOptionsOperationCompleted(object arg)
        {
            if (this.GetExecutionOptionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetExecutionOptionsCompleted(
                    this, 
                    new GetExecutionOptionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get extension settings operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetExtensionSettingsOperationCompleted(object arg)
        {
            if (this.GetExtensionSettingsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetExtensionSettingsCompleted(
                    this, 
                    new GetExtensionSettingsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get item data source prompts operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetItemDataSourcePromptsOperationCompleted(object arg)
        {
            if (this.GetItemDataSourcePromptsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetItemDataSourcePromptsCompleted(
                    this, 
                    new GetItemDataSourcePromptsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get item data sources operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetItemDataSourcesOperationCompleted(object arg)
        {
            if (this.GetItemDataSourcesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetItemDataSourcesCompleted(
                    this, 
                    new GetItemDataSourcesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get item type operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetItemTypeOperationCompleted(object arg)
        {
            if (this.GetItemTypeCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetItemTypeCompleted(
                    this, 
                    new GetItemTypeCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get model definition operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetModelDefinitionOperationCompleted(object arg)
        {
            if (this.GetModelDefinitionCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetModelDefinitionCompleted(
                    this, 
                    new GetModelDefinitionCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get model item permissions operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetModelItemPermissionsOperationCompleted(object arg)
        {
            if (this.GetModelItemPermissionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetModelItemPermissionsCompleted(
                    this, 
                    new GetModelItemPermissionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get model item policies operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetModelItemPoliciesOperationCompleted(object arg)
        {
            if (this.GetModelItemPoliciesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetModelItemPoliciesCompleted(
                    this, 
                    new GetModelItemPoliciesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get permissions operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetPermissionsOperationCompleted(object arg)
        {
            if (this.GetPermissionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetPermissionsCompleted(
                    this, 
                    new GetPermissionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get policies operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetPoliciesOperationCompleted(object arg)
        {
            if (this.GetPoliciesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetPoliciesCompleted(
                    this, 
                    new GetPoliciesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetPropertiesOperationCompleted(object arg)
        {
            if (this.GetPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetPropertiesCompleted(
                    this, 
                    new GetPropertiesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get render resource operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetRenderResourceOperationCompleted(object arg)
        {
            if (this.GetRenderResourceCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetRenderResourceCompleted(
                    this, 
                    new GetRenderResourceCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get report definition operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetReportDefinitionOperationCompleted(object arg)
        {
            if (this.GetReportDefinitionCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetReportDefinitionCompleted(
                    this, 
                    new GetReportDefinitionCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get report history limit operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetReportHistoryLimitOperationCompleted(object arg)
        {
            if (this.GetReportHistoryLimitCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetReportHistoryLimitCompleted(
                    this, 
                    new GetReportHistoryLimitCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get report history options operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetReportHistoryOptionsOperationCompleted(object arg)
        {
            if (this.GetReportHistoryOptionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetReportHistoryOptionsCompleted(
                    this, 
                    new GetReportHistoryOptionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get report link operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetReportLinkOperationCompleted(object arg)
        {
            if (this.GetReportLinkCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetReportLinkCompleted(
                    this, 
                    new GetReportLinkCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get report parameters operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetReportParametersOperationCompleted(object arg)
        {
            if (this.GetReportParametersCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetReportParametersCompleted(
                    this, 
                    new GetReportParametersCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get resource contents operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetResourceContentsOperationCompleted(object arg)
        {
            if (this.GetResourceContentsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetResourceContentsCompleted(
                    this, 
                    new GetResourceContentsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get role properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetRolePropertiesOperationCompleted(object arg)
        {
            if (this.GetRolePropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetRolePropertiesCompleted(
                    this, 
                    new GetRolePropertiesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get schedule properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetSchedulePropertiesOperationCompleted(object arg)
        {
            if (this.GetSchedulePropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetSchedulePropertiesCompleted(
                    this, 
                    new GetSchedulePropertiesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get subscription properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetSubscriptionPropertiesOperationCompleted(object arg)
        {
            if (this.GetSubscriptionPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetSubscriptionPropertiesCompleted(
                    this, 
                    new GetSubscriptionPropertiesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get system permissions operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetSystemPermissionsOperationCompleted(object arg)
        {
            if (this.GetSystemPermissionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetSystemPermissionsCompleted(
                    this, 
                    new GetSystemPermissionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get system policies operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetSystemPoliciesOperationCompleted(object arg)
        {
            if (this.GetSystemPoliciesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetSystemPoliciesCompleted(
                    this, 
                    new GetSystemPoliciesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get system properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetSystemPropertiesOperationCompleted(object arg)
        {
            if (this.GetSystemPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetSystemPropertiesCompleted(
                    this, 
                    new GetSystemPropertiesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on get user model operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnGetUserModelOperationCompleted(object arg)
        {
            if (this.GetUserModelCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.GetUserModelCompleted(
                    this, 
                    new GetUserModelCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on inherit model item parent security operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnInheritModelItemParentSecurityOperationCompleted(object arg)
        {
            if (this.InheritModelItemParentSecurityCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.InheritModelItemParentSecurityCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on inherit parent security operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnInheritParentSecurityOperationCompleted(object arg)
        {
            if (this.InheritParentSecurityCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.InheritParentSecurityCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list children operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListChildrenOperationCompleted(object arg)
        {
            if (this.ListChildrenCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListChildrenCompleted(
                    this, 
                    new ListChildrenCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list dependent items operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListDependentItemsOperationCompleted(object arg)
        {
            if (this.ListDependentItemsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListDependentItemsCompleted(
                    this, 
                    new ListDependentItemsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list events operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListEventsOperationCompleted(object arg)
        {
            if (this.ListEventsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListEventsCompleted(
                    this, 
                    new ListEventsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list extensions operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListExtensionsOperationCompleted(object arg)
        {
            if (this.ListExtensionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListExtensionsCompleted(
                    this, 
                    new ListExtensionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list jobs operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListJobsOperationCompleted(object arg)
        {
            if (this.ListJobsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListJobsCompleted(
                    this, 
                    new ListJobsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list model drillthrough reports operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListModelDrillthroughReportsOperationCompleted(object arg)
        {
            if (this.ListModelDrillthroughReportsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListModelDrillthroughReportsCompleted(
                    this, 
                    new ListModelDrillthroughReportsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list model item children operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListModelItemChildrenOperationCompleted(object arg)
        {
            if (this.ListModelItemChildrenCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListModelItemChildrenCompleted(
                    this, 
                    new ListModelItemChildrenCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list model perspectives operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListModelPerspectivesOperationCompleted(object arg)
        {
            if (this.ListModelPerspectivesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListModelPerspectivesCompleted(
                    this, 
                    new ListModelPerspectivesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list report history operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListReportHistoryOperationCompleted(object arg)
        {
            if (this.ListReportHistoryCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListReportHistoryCompleted(
                    this, 
                    new ListReportHistoryCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list roles operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListRolesOperationCompleted(object arg)
        {
            if (this.ListRolesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListRolesCompleted(
                    this, 
                    new ListRolesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list scheduled reports operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListScheduledReportsOperationCompleted(object arg)
        {
            if (this.ListScheduledReportsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListScheduledReportsCompleted(
                    this, 
                    new ListScheduledReportsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list schedules operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListSchedulesOperationCompleted(object arg)
        {
            if (this.ListSchedulesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListSchedulesCompleted(
                    this, 
                    new ListSchedulesCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list secure methods operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListSecureMethodsOperationCompleted(object arg)
        {
            if (this.ListSecureMethodsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListSecureMethodsCompleted(
                    this, 
                    new ListSecureMethodsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list subscriptions operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListSubscriptionsOperationCompleted(object arg)
        {
            if (this.ListSubscriptionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListSubscriptionsCompleted(
                    this, 
                    new ListSubscriptionsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list subscriptions using data source operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListSubscriptionsUsingDataSourceOperationCompleted(object arg)
        {
            if (this.ListSubscriptionsUsingDataSourceCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListSubscriptionsUsingDataSourceCompleted(
                    this, 
                    new ListSubscriptionsUsingDataSourceCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on list tasks operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnListTasksOperationCompleted(object arg)
        {
            if (this.ListTasksCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ListTasksCompleted(
                    this, 
                    new ListTasksCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on logoff operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnLogoffOperationCompleted(object arg)
        {
            if (this.LogoffCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.LogoffCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on logon user operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnLogonUserOperationCompleted(object arg)
        {
            if (this.LogonUserCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.LogonUserCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on move item operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnMoveItemOperationCompleted(object arg)
        {
            if (this.MoveItemCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.MoveItemCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on pause schedule operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnPauseScheduleOperationCompleted(object arg)
        {
            if (this.PauseScheduleCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.PauseScheduleCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on prepare query operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnPrepareQueryOperationCompleted(object arg)
        {
            if (this.PrepareQueryCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.PrepareQueryCompleted(
                    this, 
                    new PrepareQueryCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on regenerate model operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnRegenerateModelOperationCompleted(object arg)
        {
            if (this.RegenerateModelCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.RegenerateModelCompleted(
                    this, 
                    new RegenerateModelCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on remove all model item policies operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnRemoveAllModelItemPoliciesOperationCompleted(object arg)
        {
            if (this.RemoveAllModelItemPoliciesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.RemoveAllModelItemPoliciesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on resume schedule operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnResumeScheduleOperationCompleted(object arg)
        {
            if (this.ResumeScheduleCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ResumeScheduleCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set cache options operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetCacheOptionsOperationCompleted(object arg)
        {
            if (this.SetCacheOptionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetCacheOptionsCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set data driven subscription properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetDataDrivenSubscriptionPropertiesOperationCompleted(object arg)
        {
            if (this.SetDataDrivenSubscriptionPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetDataDrivenSubscriptionPropertiesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set data source contents operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetDataSourceContentsOperationCompleted(object arg)
        {
            if (this.SetDataSourceContentsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetDataSourceContentsCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set execution options operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetExecutionOptionsOperationCompleted(object arg)
        {
            if (this.SetExecutionOptionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetExecutionOptionsCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set item data sources operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetItemDataSourcesOperationCompleted(object arg)
        {
            if (this.SetItemDataSourcesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetItemDataSourcesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set model definition operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetModelDefinitionOperationCompleted(object arg)
        {
            if (this.SetModelDefinitionCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetModelDefinitionCompleted(
                    this, 
                    new SetModelDefinitionCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set model drillthrough reports operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetModelDrillthroughReportsOperationCompleted(object arg)
        {
            if (this.SetModelDrillthroughReportsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetModelDrillthroughReportsCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set model item policies operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetModelItemPoliciesOperationCompleted(object arg)
        {
            if (this.SetModelItemPoliciesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetModelItemPoliciesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set policies operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetPoliciesOperationCompleted(object arg)
        {
            if (this.SetPoliciesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetPoliciesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetPropertiesOperationCompleted(object arg)
        {
            if (this.SetPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetPropertiesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set report definition operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetReportDefinitionOperationCompleted(object arg)
        {
            if (this.SetReportDefinitionCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetReportDefinitionCompleted(
                    this, 
                    new SetReportDefinitionCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set report history limit operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetReportHistoryLimitOperationCompleted(object arg)
        {
            if (this.SetReportHistoryLimitCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetReportHistoryLimitCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set report history options operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetReportHistoryOptionsOperationCompleted(object arg)
        {
            if (this.SetReportHistoryOptionsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetReportHistoryOptionsCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set report link operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetReportLinkOperationCompleted(object arg)
        {
            if (this.SetReportLinkCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetReportLinkCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set report parameters operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetReportParametersOperationCompleted(object arg)
        {
            if (this.SetReportParametersCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetReportParametersCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set resource contents operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetResourceContentsOperationCompleted(object arg)
        {
            if (this.SetResourceContentsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetResourceContentsCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set role properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetRolePropertiesOperationCompleted(object arg)
        {
            if (this.SetRolePropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetRolePropertiesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set schedule properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetSchedulePropertiesOperationCompleted(object arg)
        {
            if (this.SetSchedulePropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetSchedulePropertiesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set subscription properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetSubscriptionPropertiesOperationCompleted(object arg)
        {
            if (this.SetSubscriptionPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetSubscriptionPropertiesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set system policies operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetSystemPoliciesOperationCompleted(object arg)
        {
            if (this.SetSystemPoliciesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetSystemPoliciesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on set system properties operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnSetSystemPropertiesOperationCompleted(object arg)
        {
            if (this.SetSystemPropertiesCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.SetSystemPropertiesCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on update report execution snapshot operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnUpdateReportExecutionSnapshotOperationCompleted(object arg)
        {
            if (this.UpdateReportExecutionSnapshotCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.UpdateReportExecutionSnapshotCompleted(
                    this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <summary>
        /// The on validate extension settings operation completed.
        /// </summary>
        /// <param name="arg">
        /// The arg.
        /// </param>
        private void OnValidateExtensionSettingsOperationCompleted(object arg)
        {
            if (this.ValidateExtensionSettingsCompleted != null)
            {
                InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)(arg);
                this.ValidateExtensionSettingsCompleted(
                    this, 
                    new ValidateExtensionSettingsCompletedEventArgs(
                        invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        #endregion
    }

    /// <summary>
    /// The server info header.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
        IsNullable = false)]
    public partial class ServerInfoHeader : SoapHeader
    {
        #region Constants and Fields

        /// <summary>
        /// The any attr field.
        /// </summary>
        private XmlAttribute[] anyAttrField;

        /// <summary>
        /// The report server date time field.
        /// </summary>
        private string reportServerDateTimeField;

        /// <summary>
        /// The report server edition field.
        /// </summary>
        private string reportServerEditionField;

        /// <summary>
        /// The report server version field.
        /// </summary>
        private string reportServerVersionField;

        /// <summary>
        /// The report server version number field.
        /// </summary>
        private string reportServerVersionNumberField;

        #endregion

        #region Properties

        /// <summary>
        /// The any attr.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAnyAttribute()]
        public XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }

            set
            {
                this.anyAttrField = value;
            }
        }

        /// <summary>
        /// The report server date time.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ReportServerDateTime
        {
            get
            {
                return this.reportServerDateTimeField;
            }

            set
            {
                this.reportServerDateTimeField = value;
            }
        }

        /// <summary>
        /// The report server edition.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ReportServerEdition
        {
            get
            {
                return this.reportServerEditionField;
            }

            set
            {
                this.reportServerEditionField = value;
            }
        }

        /// <summary>
        /// The report server version.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ReportServerVersion
        {
            get
            {
                return this.reportServerVersionField;
            }

            set
            {
                this.reportServerVersionField = value;
            }
        }

        /// <summary>
        /// The report server version number.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ReportServerVersionNumber
        {
            get
            {
                return this.reportServerVersionNumberField;
            }

            set
            {
                this.reportServerVersionNumberField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The model drillthrough report.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ModelDrillthroughReport
    {
        #region Constants and Fields

        /// <summary>
        /// The path field.
        /// </summary>
        private string pathField;

        /// <summary>
        /// The type field.
        /// </summary>
        private DrillthroughType typeField;

        #endregion

        #region Properties

        /// <summary>
        /// The path.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Path
        {
            get
            {
                return this.pathField;
            }

            set
            {
                this.pathField = value;
            }
        }

        /// <summary>
        /// The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DrillthroughType Type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The drillthrough type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum DrillthroughType
    {
        /// <summary>
        /// The detail.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Detail, 

        /// <summary>
        /// The list.
        /// </summary>
        /// <remarks>
        /// </remarks>
        List, 
    }

    /// <summary>
    /// The model item.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ModelItem
    {
        #region Constants and Fields

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The id field.
        /// </summary>
        private string idField;

        /// <summary>
        /// The model items field.
        /// </summary>
        private ModelItem[] modelItemsField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The type field.
        /// </summary>
        private ModelItemTypeEnum typeField;

        #endregion

        #region Properties

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ID
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        /// <summary>
        /// The model items.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ModelItem[] ModelItems
        {
            get
            {
                return this.modelItemsField;
            }

            set
            {
                this.modelItemsField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ModelItemTypeEnum Type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The model item type enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ModelItemTypeEnum
    {
        /// <summary>
        /// The model.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Model, 

        /// <summary>
        /// The entity folder.
        /// </summary>
        /// <remarks>
        /// </remarks>
        EntityFolder, 

        /// <summary>
        /// The field folder.
        /// </summary>
        /// <remarks>
        /// </remarks>
        FieldFolder, 

        /// <summary>
        /// The entity.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Entity, 

        /// <summary>
        /// The attribute.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Attribute, 

        /// <summary>
        /// The role.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Role, 
    }

    /// <summary>
    /// The model perspective.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ModelPerspective
    {
        #region Constants and Fields

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The id field.
        /// </summary>
        private string idField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        #endregion

        #region Properties

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ID
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The model catalog item.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ModelCatalogItem
    {
        #region Constants and Fields

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The model field.
        /// </summary>
        private string modelField;

        /// <summary>
        /// The perspectives field.
        /// </summary>
        private ModelPerspective[] perspectivesField;

        #endregion

        #region Properties

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The model.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Model
        {
            get
            {
                return this.modelField;
            }

            set
            {
                this.modelField = value;
            }
        }

        /// <summary>
        /// The perspectives.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ModelPerspective[] Perspectives
        {
            get
            {
                return this.perspectivesField;
            }

            set
            {
                this.perspectivesField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The policy.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Policy
    {
        #region Constants and Fields

        /// <summary>
        /// The group user name field.
        /// </summary>
        private string groupUserNameField;

        /// <summary>
        /// The roles field.
        /// </summary>
        private Role[] rolesField;

        #endregion

        #region Properties

        /// <summary>
        /// The group user name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string GroupUserName
        {
            get
            {
                return this.groupUserNameField;
            }

            set
            {
                this.groupUserNameField = value;
            }
        }

        /// <summary>
        /// The roles.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Role[] Roles
        {
            get
            {
                return this.rolesField;
            }

            set
            {
                this.rolesField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The role.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Role
    {
        #region Constants and Fields

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        #endregion

        #region Properties

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The task.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Task
    {
        #region Constants and Fields

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The task id field.
        /// </summary>
        private string taskIDField;

        #endregion

        #region Properties

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The task id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string TaskID
        {
            get
            {
                return this.taskIDField;
            }

            set
            {
                this.taskIDField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The event.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Event
    {
        #region Constants and Fields

        /// <summary>
        /// The type field.
        /// </summary>
        private string typeField;

        #endregion

        #region Properties

        /// <summary>
        /// The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The extension.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Extension
    {
        #region Constants and Fields

        /// <summary>
        /// The extension type field.
        /// </summary>
        private ExtensionTypeEnum extensionTypeField;

        /// <summary>
        /// The is model generation supported field.
        /// </summary>
        private bool isModelGenerationSupportedField;

        /// <summary>
        /// The localized name field.
        /// </summary>
        private string localizedNameField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The visible field.
        /// </summary>
        private bool visibleField;

        #endregion

        #region Properties

        /// <summary>
        /// The extension type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExtensionTypeEnum ExtensionType
        {
            get
            {
                return this.extensionTypeField;
            }

            set
            {
                this.extensionTypeField = value;
            }
        }

        /// <summary>
        /// The is model generation supported.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool IsModelGenerationSupported
        {
            get
            {
                return this.isModelGenerationSupportedField;
            }

            set
            {
                this.isModelGenerationSupportedField = value;
            }
        }

        /// <summary>
        /// The localized name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string LocalizedName
        {
            get
            {
                return this.localizedNameField;
            }

            set
            {
                this.localizedNameField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The visible.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Visible
        {
            get
            {
                return this.visibleField;
            }

            set
            {
                this.visibleField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The extension type enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ExtensionTypeEnum
    {
        /// <summary>
        /// The delivery.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Delivery, 

        /// <summary>
        /// The render.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Render, 

        /// <summary>
        /// The data.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Data, 

        /// <summary>
        /// The all.
        /// </summary>
        /// <remarks>
        /// </remarks>
        All, 
    }

    /// <summary>
    /// The subscription.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Subscription
    {
        #region Constants and Fields

        /// <summary>
        /// The active field.
        /// </summary>
        private ActiveState activeField;

        /// <summary>
        /// The delivery settings field.
        /// </summary>
        private ExtensionSettings deliverySettingsField;

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The event type field.
        /// </summary>
        private string eventTypeField;

        /// <summary>
        /// The is data driven field.
        /// </summary>
        private bool isDataDrivenField;

        /// <summary>
        /// The last executed field.
        /// </summary>
        private DateTime lastExecutedField;

        /// <summary>
        /// The last executed field specified.
        /// </summary>
        private bool lastExecutedFieldSpecified;

        /// <summary>
        /// The modified by field.
        /// </summary>
        private string modifiedByField;

        /// <summary>
        /// The modified date field.
        /// </summary>
        private DateTime modifiedDateField;

        /// <summary>
        /// The owner field.
        /// </summary>
        private string ownerField;

        /// <summary>
        /// The path field.
        /// </summary>
        private string pathField;

        /// <summary>
        /// The report field.
        /// </summary>
        private string reportField;

        /// <summary>
        /// The status field.
        /// </summary>
        private string statusField;

        /// <summary>
        /// The subscription id field.
        /// </summary>
        private string subscriptionIDField;

        /// <summary>
        /// The virtual path field.
        /// </summary>
        private string virtualPathField;

        #endregion

        #region Properties

        /// <summary>
        /// The active.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ActiveState Active
        {
            get
            {
                return this.activeField;
            }

            set
            {
                this.activeField = value;
            }
        }

        /// <summary>
        /// The delivery settings.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExtensionSettings DeliverySettings
        {
            get
            {
                return this.deliverySettingsField;
            }

            set
            {
                this.deliverySettingsField = value;
            }
        }

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The event type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string EventType
        {
            get
            {
                return this.eventTypeField;
            }

            set
            {
                this.eventTypeField = value;
            }
        }

        /// <summary>
        /// The is data driven.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool IsDataDriven
        {
            get
            {
                return this.isDataDrivenField;
            }

            set
            {
                this.isDataDrivenField = value;
            }
        }

        /// <summary>
        /// The last executed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime LastExecuted
        {
            get
            {
                return this.lastExecutedField;
            }

            set
            {
                this.lastExecutedField = value;
            }
        }

        /// <summary>
        /// The last executed specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool LastExecutedSpecified
        {
            get
            {
                return this.lastExecutedFieldSpecified;
            }

            set
            {
                this.lastExecutedFieldSpecified = value;
            }
        }

        /// <summary>
        /// The modified by.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }

            set
            {
                this.modifiedByField = value;
            }
        }

        /// <summary>
        /// The modified date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }

            set
            {
                this.modifiedDateField = value;
            }
        }

        /// <summary>
        /// The owner.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Owner
        {
            get
            {
                return this.ownerField;
            }

            set
            {
                this.ownerField = value;
            }
        }

        /// <summary>
        /// The path.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Path
        {
            get
            {
                return this.pathField;
            }

            set
            {
                this.pathField = value;
            }
        }

        /// <summary>
        /// The report.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Report
        {
            get
            {
                return this.reportField;
            }

            set
            {
                this.reportField = value;
            }
        }

        /// <summary>
        /// The status.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Status
        {
            get
            {
                return this.statusField;
            }

            set
            {
                this.statusField = value;
            }
        }

        /// <summary>
        /// The subscription id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string SubscriptionID
        {
            get
            {
                return this.subscriptionIDField;
            }

            set
            {
                this.subscriptionIDField = value;
            }
        }

        /// <summary>
        /// The virtual path.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string VirtualPath
        {
            get
            {
                return this.virtualPathField;
            }

            set
            {
                this.virtualPathField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The extension settings.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ExtensionSettings
    {
        #region Constants and Fields

        /// <summary>
        /// The extension field.
        /// </summary>
        private string extensionField;

        /// <summary>
        /// The parameter values field.
        /// </summary>
        private ParameterValueOrFieldReference[] parameterValuesField;

        #endregion

        #region Properties

        /// <summary>
        /// The extension.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }

            set
            {
                this.extensionField = value;
            }
        }

        /// <summary>
        /// The parameter values.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlArrayItem(typeof(ParameterFieldReference))]
        [XmlArrayItem(typeof(ParameterValue))]
        public ParameterValueOrFieldReference[] ParameterValues
        {
            get
            {
                return this.parameterValuesField;
            }

            set
            {
                this.parameterValuesField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The parameter field reference.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ParameterFieldReference : ParameterValueOrFieldReference
    {
        #region Constants and Fields

        /// <summary>
        /// The field alias field.
        /// </summary>
        private string fieldAliasField;

        /// <summary>
        /// The parameter name field.
        /// </summary>
        private string parameterNameField;

        #endregion

        #region Properties

        /// <summary>
        /// The field alias.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string FieldAlias
        {
            get
            {
                return this.fieldAliasField;
            }

            set
            {
                this.fieldAliasField = value;
            }
        }

        /// <summary>
        /// The parameter name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }

            set
            {
                this.parameterNameField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The parameter value or field reference.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlInclude(typeof(ParameterFieldReference))]
    [XmlInclude(typeof(ParameterValue))]
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ParameterValueOrFieldReference
    {
    }

    /// <summary>
    /// The parameter value.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ParameterValue : ParameterValueOrFieldReference
    {
        #region Constants and Fields

        /// <summary>
        /// The label field.
        /// </summary>
        private string labelField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The value field.
        /// </summary>
        private string valueField;

        #endregion

        #region Properties

        /// <summary>
        /// The label.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Label
        {
            get
            {
                return this.labelField;
            }

            set
            {
                this.labelField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The active state.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ActiveState
    {
        #region Constants and Fields

        /// <summary>
        /// The delivery extension removed field.
        /// </summary>
        private bool deliveryExtensionRemovedField;

        /// <summary>
        /// The delivery extension removed field specified.
        /// </summary>
        private bool deliveryExtensionRemovedFieldSpecified;

        /// <summary>
        /// The invalid parameter value field.
        /// </summary>
        private bool invalidParameterValueField;

        /// <summary>
        /// The invalid parameter value field specified.
        /// </summary>
        private bool invalidParameterValueFieldSpecified;

        /// <summary>
        /// The missing parameter value field.
        /// </summary>
        private bool missingParameterValueField;

        /// <summary>
        /// The missing parameter value field specified.
        /// </summary>
        private bool missingParameterValueFieldSpecified;

        /// <summary>
        /// The shared data source removed field.
        /// </summary>
        private bool sharedDataSourceRemovedField;

        /// <summary>
        /// The shared data source removed field specified.
        /// </summary>
        private bool sharedDataSourceRemovedFieldSpecified;

        /// <summary>
        /// The unknown report parameter field.
        /// </summary>
        private bool unknownReportParameterField;

        /// <summary>
        /// The unknown report parameter field specified.
        /// </summary>
        private bool unknownReportParameterFieldSpecified;

        #endregion

        #region Properties

        /// <summary>
        /// The delivery extension removed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool DeliveryExtensionRemoved
        {
            get
            {
                return this.deliveryExtensionRemovedField;
            }

            set
            {
                this.deliveryExtensionRemovedField = value;
            }
        }

        /// <summary>
        /// The delivery extension removed specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool DeliveryExtensionRemovedSpecified
        {
            get
            {
                return this.deliveryExtensionRemovedFieldSpecified;
            }

            set
            {
                this.deliveryExtensionRemovedFieldSpecified = value;
            }
        }

        /// <summary>
        /// The invalid parameter value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool InvalidParameterValue
        {
            get
            {
                return this.invalidParameterValueField;
            }

            set
            {
                this.invalidParameterValueField = value;
            }
        }

        /// <summary>
        /// The invalid parameter value specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool InvalidParameterValueSpecified
        {
            get
            {
                return this.invalidParameterValueFieldSpecified;
            }

            set
            {
                this.invalidParameterValueFieldSpecified = value;
            }
        }

        /// <summary>
        /// The missing parameter value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool MissingParameterValue
        {
            get
            {
                return this.missingParameterValueField;
            }

            set
            {
                this.missingParameterValueField = value;
            }
        }

        /// <summary>
        /// The missing parameter value specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool MissingParameterValueSpecified
        {
            get
            {
                return this.missingParameterValueFieldSpecified;
            }

            set
            {
                this.missingParameterValueFieldSpecified = value;
            }
        }

        /// <summary>
        /// The shared data source removed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool SharedDataSourceRemoved
        {
            get
            {
                return this.sharedDataSourceRemovedField;
            }

            set
            {
                this.sharedDataSourceRemovedField = value;
            }
        }

        /// <summary>
        /// The shared data source removed specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool SharedDataSourceRemovedSpecified
        {
            get
            {
                return this.sharedDataSourceRemovedFieldSpecified;
            }

            set
            {
                this.sharedDataSourceRemovedFieldSpecified = value;
            }
        }

        /// <summary>
        /// The unknown report parameter.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool UnknownReportParameter
        {
            get
            {
                return this.unknownReportParameterField;
            }

            set
            {
                this.unknownReportParameterField = value;
            }
        }

        /// <summary>
        /// The unknown report parameter specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool UnknownReportParameterSpecified
        {
            get
            {
                return this.unknownReportParameterFieldSpecified;
            }

            set
            {
                this.unknownReportParameterFieldSpecified = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The extension parameter.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ExtensionParameter
    {
        #region Constants and Fields

        /// <summary>
        /// The display name field.
        /// </summary>
        private string displayNameField;

        /// <summary>
        /// The encrypted field.
        /// </summary>
        private bool encryptedField;

        /// <summary>
        /// The error field.
        /// </summary>
        private string errorField;

        /// <summary>
        /// The is password field.
        /// </summary>
        private bool isPasswordField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The read only field.
        /// </summary>
        private bool readOnlyField;

        /// <summary>
        /// The required field.
        /// </summary>
        private bool requiredField;

        /// <summary>
        /// The required field specified.
        /// </summary>
        private bool requiredFieldSpecified;

        /// <summary>
        /// The valid values field.
        /// </summary>
        private ValidValue[] validValuesField;

        /// <summary>
        /// The value field.
        /// </summary>
        private string valueField;

        #endregion

        #region Properties

        /// <summary>
        /// The display name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }

            set
            {
                this.displayNameField = value;
            }
        }

        /// <summary>
        /// The encrypted.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Encrypted
        {
            get
            {
                return this.encryptedField;
            }

            set
            {
                this.encryptedField = value;
            }
        }

        /// <summary>
        /// The error.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Error
        {
            get
            {
                return this.errorField;
            }

            set
            {
                this.errorField = value;
            }
        }

        /// <summary>
        /// The is password.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool IsPassword
        {
            get
            {
                return this.isPasswordField;
            }

            set
            {
                this.isPasswordField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The read only.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool ReadOnly
        {
            get
            {
                return this.readOnlyField;
            }

            set
            {
                this.readOnlyField = value;
            }
        }

        /// <summary>
        /// The required.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Required
        {
            get
            {
                return this.requiredField;
            }

            set
            {
                this.requiredField = value;
            }
        }

        /// <summary>
        /// The required specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool RequiredSpecified
        {
            get
            {
                return this.requiredFieldSpecified;
            }

            set
            {
                this.requiredFieldSpecified = value;
            }
        }

        /// <summary>
        /// The valid values.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlArrayItem("Value")]
        public ValidValue[] ValidValues
        {
            get
            {
                return this.validValuesField;
            }

            set
            {
                this.validValuesField = value;
            }
        }

        /// <summary>
        /// The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The valid value.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ValidValue
    {
        #region Constants and Fields

        /// <summary>
        /// The label field.
        /// </summary>
        private string labelField;

        /// <summary>
        /// The value field.
        /// </summary>
        private string valueField;

        #endregion

        #region Properties

        /// <summary>
        /// The label.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Label
        {
            get
            {
                return this.labelField;
            }

            set
            {
                this.labelField = value;
            }
        }

        /// <summary>
        /// The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The query definition.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class QueryDefinition
    {
        #region Constants and Fields

        /// <summary>
        /// The command text field.
        /// </summary>
        private string commandTextField;

        /// <summary>
        /// The command type field.
        /// </summary>
        private string commandTypeField;

        /// <summary>
        /// The timeout field.
        /// </summary>
        private int timeoutField;

        /// <summary>
        /// The timeout field specified.
        /// </summary>
        private bool timeoutFieldSpecified;

        #endregion

        #region Properties

        /// <summary>
        /// The command text.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string CommandText
        {
            get
            {
                return this.commandTextField;
            }

            set
            {
                this.commandTextField = value;
            }
        }

        /// <summary>
        /// The command type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string CommandType
        {
            get
            {
                return this.commandTypeField;
            }

            set
            {
                this.commandTypeField = value;
            }
        }

        /// <summary>
        /// The timeout.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int Timeout
        {
            get
            {
                return this.timeoutField;
            }

            set
            {
                this.timeoutField = value;
            }
        }

        /// <summary>
        /// The timeout specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool TimeoutSpecified
        {
            get
            {
                return this.timeoutFieldSpecified;
            }

            set
            {
                this.timeoutFieldSpecified = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The field.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Field
    {
        #region Constants and Fields

        /// <summary>
        /// The alias field.
        /// </summary>
        private string aliasField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        #endregion

        #region Properties

        /// <summary>
        /// The alias.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Alias
        {
            get
            {
                return this.aliasField;
            }

            set
            {
                this.aliasField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The data set definition.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataSetDefinition
    {
        #region Constants and Fields

        /// <summary>
        /// The accent sensitivity field.
        /// </summary>
        private SensitivityEnum accentSensitivityField;

        /// <summary>
        /// The accent sensitivity field specified.
        /// </summary>
        private bool accentSensitivityFieldSpecified;

        /// <summary>
        /// The case sensitivity field.
        /// </summary>
        private SensitivityEnum caseSensitivityField;

        /// <summary>
        /// The case sensitivity field specified.
        /// </summary>
        private bool caseSensitivityFieldSpecified;

        /// <summary>
        /// The collation field.
        /// </summary>
        private string collationField;

        /// <summary>
        /// The fields field.
        /// </summary>
        private Field[] fieldsField;

        /// <summary>
        /// The kanatype sensitivity field.
        /// </summary>
        private SensitivityEnum kanatypeSensitivityField;

        /// <summary>
        /// The kanatype sensitivity field specified.
        /// </summary>
        private bool kanatypeSensitivityFieldSpecified;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The query field.
        /// </summary>
        private QueryDefinition queryField;

        /// <summary>
        /// The width sensitivity field.
        /// </summary>
        private SensitivityEnum widthSensitivityField;

        /// <summary>
        /// The width sensitivity field specified.
        /// </summary>
        private bool widthSensitivityFieldSpecified;

        #endregion

        #region Properties

        /// <summary>
        /// The accent sensitivity.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public SensitivityEnum AccentSensitivity
        {
            get
            {
                return this.accentSensitivityField;
            }

            set
            {
                this.accentSensitivityField = value;
            }
        }

        /// <summary>
        /// The accent sensitivity specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool AccentSensitivitySpecified
        {
            get
            {
                return this.accentSensitivityFieldSpecified;
            }

            set
            {
                this.accentSensitivityFieldSpecified = value;
            }
        }

        /// <summary>
        /// The case sensitivity.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public SensitivityEnum CaseSensitivity
        {
            get
            {
                return this.caseSensitivityField;
            }

            set
            {
                this.caseSensitivityField = value;
            }
        }

        /// <summary>
        /// The case sensitivity specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool CaseSensitivitySpecified
        {
            get
            {
                return this.caseSensitivityFieldSpecified;
            }

            set
            {
                this.caseSensitivityFieldSpecified = value;
            }
        }

        /// <summary>
        /// The collation.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Collation
        {
            get
            {
                return this.collationField;
            }

            set
            {
                this.collationField = value;
            }
        }

        /// <summary>
        /// The fields.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Field[] Fields
        {
            get
            {
                return this.fieldsField;
            }

            set
            {
                this.fieldsField = value;
            }
        }

        /// <summary>
        /// The kanatype sensitivity.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public SensitivityEnum KanatypeSensitivity
        {
            get
            {
                return this.kanatypeSensitivityField;
            }

            set
            {
                this.kanatypeSensitivityField = value;
            }
        }

        /// <summary>
        /// The kanatype sensitivity specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool KanatypeSensitivitySpecified
        {
            get
            {
                return this.kanatypeSensitivityFieldSpecified;
            }

            set
            {
                this.kanatypeSensitivityFieldSpecified = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The query.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public QueryDefinition Query
        {
            get
            {
                return this.queryField;
            }

            set
            {
                this.queryField = value;
            }
        }

        /// <summary>
        /// The width sensitivity.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public SensitivityEnum WidthSensitivity
        {
            get
            {
                return this.widthSensitivityField;
            }

            set
            {
                this.widthSensitivityField = value;
            }
        }

        /// <summary>
        /// The width sensitivity specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool WidthSensitivitySpecified
        {
            get
            {
                return this.widthSensitivityFieldSpecified;
            }

            set
            {
                this.widthSensitivityFieldSpecified = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The sensitivity enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum SensitivityEnum
    {
        /// <summary>
        /// The true.
        /// </summary>
        /// <remarks>
        /// </remarks>
        True, 

        /// <summary>
        /// The false.
        /// </summary>
        /// <remarks>
        /// </remarks>
        False, 

        /// <summary>
        /// The auto.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Auto, 
    }

    /// <summary>
    /// The data retrieval plan.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataRetrievalPlan
    {
        #region Constants and Fields

        /// <summary>
        /// The data set field.
        /// </summary>
        private DataSetDefinition dataSetField;

        /// <summary>
        /// The item field.
        /// </summary>
        private DataSourceDefinitionOrReference itemField;

        #endregion

        #region Properties

        /// <summary>
        /// The data set.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DataSetDefinition DataSet
        {
            get
            {
                return this.dataSetField;
            }

            set
            {
                this.dataSetField = value;
            }
        }

        /// <summary>
        /// The item.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("DataSourceDefinition", typeof(DataSourceDefinition))]
        [XmlElement("DataSourceReference", typeof(DataSourceReference))]
        [XmlElement("InvalidDataSourceReference", typeof(InvalidDataSourceReference))]
        public DataSourceDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }

            set
            {
                this.itemField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The data source definition.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataSourceDefinition : DataSourceDefinitionOrReference
    {
        #region Constants and Fields

        /// <summary>
        /// The connect string field.
        /// </summary>
        private string connectStringField;

        /// <summary>
        /// The credential retrieval field.
        /// </summary>
        private CredentialRetrievalEnum credentialRetrievalField;

        /// <summary>
        /// The enabled field.
        /// </summary>
        private bool enabledField;

        /// <summary>
        /// The enabled field specified.
        /// </summary>
        private bool enabledFieldSpecified;

        /// <summary>
        /// The extension field.
        /// </summary>
        private string extensionField;

        /// <summary>
        /// The impersonate user field.
        /// </summary>
        private bool impersonateUserField;

        /// <summary>
        /// The impersonate user field specified.
        /// </summary>
        private bool impersonateUserFieldSpecified;

        /// <summary>
        /// The original connect string expression based field.
        /// </summary>
        private bool originalConnectStringExpressionBasedField;

        /// <summary>
        /// The password field.
        /// </summary>
        private string passwordField;

        /// <summary>
        /// The prompt field.
        /// </summary>
        private string promptField;

        /// <summary>
        /// The use original connect string field.
        /// </summary>
        private bool useOriginalConnectStringField;

        /// <summary>
        /// The user name field.
        /// </summary>
        private string userNameField;

        /// <summary>
        /// The windows credentials field.
        /// </summary>
        private bool windowsCredentialsField;

        #endregion

        #region Properties

        /// <summary>
        /// The connect string.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ConnectString
        {
            get
            {
                return this.connectStringField;
            }

            set
            {
                this.connectStringField = value;
            }
        }

        /// <summary>
        /// The credential retrieval.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public CredentialRetrievalEnum CredentialRetrieval
        {
            get
            {
                return this.credentialRetrievalField;
            }

            set
            {
                this.credentialRetrievalField = value;
            }
        }

        /// <summary>
        /// The enabled.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }

            set
            {
                this.enabledField = value;
            }
        }

        /// <summary>
        /// The enabled specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool EnabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }

            set
            {
                this.enabledFieldSpecified = value;
            }
        }

        /// <summary>
        /// The extension.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }

            set
            {
                this.extensionField = value;
            }
        }

        /// <summary>
        /// The impersonate user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool ImpersonateUser
        {
            get
            {
                return this.impersonateUserField;
            }

            set
            {
                this.impersonateUserField = value;
            }
        }

        /// <summary>
        /// The impersonate user specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool ImpersonateUserSpecified
        {
            get
            {
                return this.impersonateUserFieldSpecified;
            }

            set
            {
                this.impersonateUserFieldSpecified = value;
            }
        }

        /// <summary>
        /// The original connect string expression based.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool OriginalConnectStringExpressionBased
        {
            get
            {
                return this.originalConnectStringExpressionBasedField;
            }

            set
            {
                this.originalConnectStringExpressionBasedField = value;
            }
        }

        /// <summary>
        /// The password.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Password
        {
            get
            {
                return this.passwordField;
            }

            set
            {
                this.passwordField = value;
            }
        }

        /// <summary>
        /// The prompt.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }

            set
            {
                this.promptField = value;
            }
        }

        /// <summary>
        /// The use original connect string.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool UseOriginalConnectString
        {
            get
            {
                return this.useOriginalConnectStringField;
            }

            set
            {
                this.useOriginalConnectStringField = value;
            }
        }

        /// <summary>
        /// The user name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }

            set
            {
                this.userNameField = value;
            }
        }

        /// <summary>
        /// The windows credentials.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool WindowsCredentials
        {
            get
            {
                return this.windowsCredentialsField;
            }

            set
            {
                this.windowsCredentialsField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The credential retrieval enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum CredentialRetrievalEnum
    {
        /// <summary>
        /// The prompt.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Prompt, 

        /// <summary>
        /// The store.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Store, 

        /// <summary>
        /// The integrated.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Integrated, 

        /// <summary>
        /// The none.
        /// </summary>
        /// <remarks>
        /// </remarks>
        None, 
    }

    /// <summary>
    /// The data source definition or reference.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlInclude(typeof(InvalidDataSourceReference))]
    [XmlInclude(typeof(DataSourceReference))]
    [XmlInclude(typeof(DataSourceDefinition))]
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataSourceDefinitionOrReference
    {
    }

    /// <summary>
    /// The invalid data source reference.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class InvalidDataSourceReference : DataSourceDefinitionOrReference
    {
    }

    /// <summary>
    /// The data source reference.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataSourceReference : DataSourceDefinitionOrReference
    {
        #region Constants and Fields

        /// <summary>
        /// The reference field.
        /// </summary>
        private string referenceField;

        #endregion

        #region Properties

        /// <summary>
        /// The reference.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }

            set
            {
                this.referenceField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The schedule.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Schedule
    {
        #region Constants and Fields

        /// <summary>
        /// The creator field.
        /// </summary>
        private string creatorField;

        /// <summary>
        /// The definition field.
        /// </summary>
        private ScheduleDefinition definitionField;

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The last run time field.
        /// </summary>
        private DateTime lastRunTimeField;

        /// <summary>
        /// The last run time field specified.
        /// </summary>
        private bool lastRunTimeFieldSpecified;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The next run time field.
        /// </summary>
        private DateTime nextRunTimeField;

        /// <summary>
        /// The next run time field specified.
        /// </summary>
        private bool nextRunTimeFieldSpecified;

        /// <summary>
        /// The references present field.
        /// </summary>
        private bool referencesPresentField;

        /// <summary>
        /// The schedule id field.
        /// </summary>
        private string scheduleIDField;

        /// <summary>
        /// The state field.
        /// </summary>
        private ScheduleStateEnum stateField;

        #endregion

        #region Properties

        /// <summary>
        /// The creator.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Creator
        {
            get
            {
                return this.creatorField;
            }

            set
            {
                this.creatorField = value;
            }
        }

        /// <summary>
        /// The definition.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ScheduleDefinition Definition
        {
            get
            {
                return this.definitionField;
            }

            set
            {
                this.definitionField = value;
            }
        }

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The last run time.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime LastRunTime
        {
            get
            {
                return this.lastRunTimeField;
            }

            set
            {
                this.lastRunTimeField = value;
            }
        }

        /// <summary>
        /// The last run time specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool LastRunTimeSpecified
        {
            get
            {
                return this.lastRunTimeFieldSpecified;
            }

            set
            {
                this.lastRunTimeFieldSpecified = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The next run time.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime NextRunTime
        {
            get
            {
                return this.nextRunTimeField;
            }

            set
            {
                this.nextRunTimeField = value;
            }
        }

        /// <summary>
        /// The next run time specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool NextRunTimeSpecified
        {
            get
            {
                return this.nextRunTimeFieldSpecified;
            }

            set
            {
                this.nextRunTimeFieldSpecified = value;
            }
        }

        /// <summary>
        /// The references present.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool ReferencesPresent
        {
            get
            {
                return this.referencesPresentField;
            }

            set
            {
                this.referencesPresentField = value;
            }
        }

        /// <summary>
        /// The schedule id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ScheduleID
        {
            get
            {
                return this.scheduleIDField;
            }

            set
            {
                this.scheduleIDField = value;
            }
        }

        /// <summary>
        /// The state.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ScheduleStateEnum State
        {
            get
            {
                return this.stateField;
            }

            set
            {
                this.stateField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The schedule definition.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ScheduleDefinition : ScheduleDefinitionOrReference
    {
        #region Constants and Fields

        /// <summary>
        /// The end date field.
        /// </summary>
        private DateTime endDateField;

        /// <summary>
        /// The end date field specified.
        /// </summary>
        private bool endDateFieldSpecified;

        /// <summary>
        /// The item field.
        /// </summary>
        private RecurrencePattern itemField;

        /// <summary>
        /// The start date time field.
        /// </summary>
        private DateTime startDateTimeField;

        #endregion

        #region Properties

        /// <summary>
        /// The end date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }

            set
            {
                this.endDateField = value;
            }
        }

        /// <summary>
        /// The end date specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }

            set
            {
                this.endDateFieldSpecified = value;
            }
        }

        /// <summary>
        /// The item.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("DailyRecurrence", typeof(DailyRecurrence))]
        [XmlElement("MinuteRecurrence", typeof(MinuteRecurrence))]
        [XmlElement("MonthlyDOWRecurrence", typeof(MonthlyDOWRecurrence))]
        [XmlElement("MonthlyRecurrence", typeof(MonthlyRecurrence))]
        [XmlElement("WeeklyRecurrence", typeof(WeeklyRecurrence))]
        public RecurrencePattern Item
        {
            get
            {
                return this.itemField;
            }

            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        /// The start date time.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }

            set
            {
                this.startDateTimeField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The daily recurrence.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DailyRecurrence : RecurrencePattern
    {
        #region Constants and Fields

        /// <summary>
        /// The days interval field.
        /// </summary>
        private int daysIntervalField;

        #endregion

        #region Properties

        /// <summary>
        /// The days interval.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int DaysInterval
        {
            get
            {
                return this.daysIntervalField;
            }

            set
            {
                this.daysIntervalField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The recurrence pattern.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlInclude(typeof(MonthlyDOWRecurrence))]
    [XmlInclude(typeof(MonthlyRecurrence))]
    [XmlInclude(typeof(DailyRecurrence))]
    [XmlInclude(typeof(WeeklyRecurrence))]
    [XmlInclude(typeof(MinuteRecurrence))]
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class RecurrencePattern
    {
    }

    /// <summary>
    /// The monthly dow recurrence.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class MonthlyDOWRecurrence : RecurrencePattern
    {
        #region Constants and Fields

        /// <summary>
        /// The days of week field.
        /// </summary>
        private DaysOfWeekSelector daysOfWeekField;

        /// <summary>
        /// The months of year field.
        /// </summary>
        private MonthsOfYearSelector monthsOfYearField;

        /// <summary>
        /// The which week field.
        /// </summary>
        private WeekNumberEnum whichWeekField;

        /// <summary>
        /// The which week field specified.
        /// </summary>
        private bool whichWeekFieldSpecified;

        #endregion

        #region Properties

        /// <summary>
        /// The days of week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DaysOfWeekSelector DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }

            set
            {
                this.daysOfWeekField = value;
            }
        }

        /// <summary>
        /// The months of year.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public MonthsOfYearSelector MonthsOfYear
        {
            get
            {
                return this.monthsOfYearField;
            }

            set
            {
                this.monthsOfYearField = value;
            }
        }

        /// <summary>
        /// The which week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public WeekNumberEnum WhichWeek
        {
            get
            {
                return this.whichWeekField;
            }

            set
            {
                this.whichWeekField = value;
            }
        }

        /// <summary>
        /// The which week specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool WhichWeekSpecified
        {
            get
            {
                return this.whichWeekFieldSpecified;
            }

            set
            {
                this.whichWeekFieldSpecified = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The week number enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum WeekNumberEnum
    {
        /// <summary>
        /// The first week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        FirstWeek, 

        /// <summary>
        /// The second week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        SecondWeek, 

        /// <summary>
        /// The third week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        ThirdWeek, 

        /// <summary>
        /// The fourth week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        FourthWeek, 

        /// <summary>
        /// The last week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        LastWeek, 
    }

    /// <summary>
    /// The days of week selector.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DaysOfWeekSelector
    {
        #region Constants and Fields

        /// <summary>
        /// The friday field.
        /// </summary>
        private bool fridayField;

        /// <summary>
        /// The monday field.
        /// </summary>
        private bool mondayField;

        /// <summary>
        /// The saturday field.
        /// </summary>
        private bool saturdayField;

        /// <summary>
        /// The sunday field.
        /// </summary>
        private bool sundayField;

        /// <summary>
        /// The thursday field.
        /// </summary>
        private bool thursdayField;

        /// <summary>
        /// The tuesday field.
        /// </summary>
        private bool tuesdayField;

        /// <summary>
        /// The wednesday field.
        /// </summary>
        private bool wednesdayField;

        #endregion

        #region Properties

        /// <summary>
        /// The friday.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Friday
        {
            get
            {
                return this.fridayField;
            }

            set
            {
                this.fridayField = value;
            }
        }

        /// <summary>
        /// The monday.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Monday
        {
            get
            {
                return this.mondayField;
            }

            set
            {
                this.mondayField = value;
            }
        }

        /// <summary>
        /// The saturday.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Saturday
        {
            get
            {
                return this.saturdayField;
            }

            set
            {
                this.saturdayField = value;
            }
        }

        /// <summary>
        /// The sunday.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Sunday
        {
            get
            {
                return this.sundayField;
            }

            set
            {
                this.sundayField = value;
            }
        }

        /// <summary>
        /// The thursday.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Thursday
        {
            get
            {
                return this.thursdayField;
            }

            set
            {
                this.thursdayField = value;
            }
        }

        /// <summary>
        /// The tuesday.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Tuesday
        {
            get
            {
                return this.tuesdayField;
            }

            set
            {
                this.tuesdayField = value;
            }
        }

        /// <summary>
        /// The wednesday.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Wednesday
        {
            get
            {
                return this.wednesdayField;
            }

            set
            {
                this.wednesdayField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The months of year selector.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class MonthsOfYearSelector
    {
        #region Constants and Fields

        /// <summary>
        /// The april field.
        /// </summary>
        private bool aprilField;

        /// <summary>
        /// The august field.
        /// </summary>
        private bool augustField;

        /// <summary>
        /// The december field.
        /// </summary>
        private bool decemberField;

        /// <summary>
        /// The february field.
        /// </summary>
        private bool februaryField;

        /// <summary>
        /// The january field.
        /// </summary>
        private bool januaryField;

        /// <summary>
        /// The july field.
        /// </summary>
        private bool julyField;

        /// <summary>
        /// The june field.
        /// </summary>
        private bool juneField;

        /// <summary>
        /// The march field.
        /// </summary>
        private bool marchField;

        /// <summary>
        /// The may field.
        /// </summary>
        private bool mayField;

        /// <summary>
        /// The november field.
        /// </summary>
        private bool novemberField;

        /// <summary>
        /// The october field.
        /// </summary>
        private bool octoberField;

        /// <summary>
        /// The september field.
        /// </summary>
        private bool septemberField;

        #endregion

        #region Properties

        /// <summary>
        /// The april.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool April
        {
            get
            {
                return this.aprilField;
            }

            set
            {
                this.aprilField = value;
            }
        }

        /// <summary>
        /// The august.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool August
        {
            get
            {
                return this.augustField;
            }

            set
            {
                this.augustField = value;
            }
        }

        /// <summary>
        /// The december.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool December
        {
            get
            {
                return this.decemberField;
            }

            set
            {
                this.decemberField = value;
            }
        }

        /// <summary>
        /// The february.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool February
        {
            get
            {
                return this.februaryField;
            }

            set
            {
                this.februaryField = value;
            }
        }

        /// <summary>
        /// The january.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool January
        {
            get
            {
                return this.januaryField;
            }

            set
            {
                this.januaryField = value;
            }
        }

        /// <summary>
        /// The july.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool July
        {
            get
            {
                return this.julyField;
            }

            set
            {
                this.julyField = value;
            }
        }

        /// <summary>
        /// The june.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool June
        {
            get
            {
                return this.juneField;
            }

            set
            {
                this.juneField = value;
            }
        }

        /// <summary>
        /// The march.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool March
        {
            get
            {
                return this.marchField;
            }

            set
            {
                this.marchField = value;
            }
        }

        /// <summary>
        /// The may.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool May
        {
            get
            {
                return this.mayField;
            }

            set
            {
                this.mayField = value;
            }
        }

        /// <summary>
        /// The november.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool November
        {
            get
            {
                return this.novemberField;
            }

            set
            {
                this.novemberField = value;
            }
        }

        /// <summary>
        /// The october.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool October
        {
            get
            {
                return this.octoberField;
            }

            set
            {
                this.octoberField = value;
            }
        }

        /// <summary>
        /// The september.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool September
        {
            get
            {
                return this.septemberField;
            }

            set
            {
                this.septemberField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The monthly recurrence.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class MonthlyRecurrence : RecurrencePattern
    {
        #region Constants and Fields

        /// <summary>
        /// The days field.
        /// </summary>
        private string daysField;

        /// <summary>
        /// The months of year field.
        /// </summary>
        private MonthsOfYearSelector monthsOfYearField;

        #endregion

        #region Properties

        /// <summary>
        /// The days.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Days
        {
            get
            {
                return this.daysField;
            }

            set
            {
                this.daysField = value;
            }
        }

        /// <summary>
        /// The months of year.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public MonthsOfYearSelector MonthsOfYear
        {
            get
            {
                return this.monthsOfYearField;
            }

            set
            {
                this.monthsOfYearField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The weekly recurrence.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class WeeklyRecurrence : RecurrencePattern
    {
        #region Constants and Fields

        /// <summary>
        /// The days of week field.
        /// </summary>
        private DaysOfWeekSelector daysOfWeekField;

        /// <summary>
        /// The weeks interval field.
        /// </summary>
        private int weeksIntervalField;

        /// <summary>
        /// The weeks interval field specified.
        /// </summary>
        private bool weeksIntervalFieldSpecified;

        #endregion

        #region Properties

        /// <summary>
        /// The days of week.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DaysOfWeekSelector DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }

            set
            {
                this.daysOfWeekField = value;
            }
        }

        /// <summary>
        /// The weeks interval.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int WeeksInterval
        {
            get
            {
                return this.weeksIntervalField;
            }

            set
            {
                this.weeksIntervalField = value;
            }
        }

        /// <summary>
        /// The weeks interval specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool WeeksIntervalSpecified
        {
            get
            {
                return this.weeksIntervalFieldSpecified;
            }

            set
            {
                this.weeksIntervalFieldSpecified = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The minute recurrence.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class MinuteRecurrence : RecurrencePattern
    {
        #region Constants and Fields

        /// <summary>
        /// The minutes interval field.
        /// </summary>
        private int minutesIntervalField;

        #endregion

        #region Properties

        /// <summary>
        /// The minutes interval.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int MinutesInterval
        {
            get
            {
                return this.minutesIntervalField;
            }

            set
            {
                this.minutesIntervalField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The schedule definition or reference.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlInclude(typeof(NoSchedule))]
    [XmlInclude(typeof(ScheduleReference))]
    [XmlInclude(typeof(ScheduleDefinition))]
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ScheduleDefinitionOrReference
    {
    }

    /// <summary>
    /// The no schedule.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class NoSchedule : ScheduleDefinitionOrReference
    {
    }

    /// <summary>
    /// The schedule reference.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ScheduleReference : ScheduleDefinitionOrReference
    {
        #region Constants and Fields

        /// <summary>
        /// The definition field.
        /// </summary>
        private ScheduleDefinition definitionField;

        /// <summary>
        /// The schedule id field.
        /// </summary>
        private string scheduleIDField;

        #endregion

        #region Properties

        /// <summary>
        /// The definition.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ScheduleDefinition Definition
        {
            get
            {
                return this.definitionField;
            }

            set
            {
                this.definitionField = value;
            }
        }

        /// <summary>
        /// The schedule id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ScheduleID
        {
            get
            {
                return this.scheduleIDField;
            }

            set
            {
                this.scheduleIDField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The schedule state enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ScheduleStateEnum
    {
        /// <summary>
        /// The ready.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Ready, 

        /// <summary>
        /// The running.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Running, 

        /// <summary>
        /// The paused.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Paused, 

        /// <summary>
        /// The expired.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Expired, 

        /// <summary>
        /// The failing.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Failing, 
    }

    /// <summary>
    /// The report history snapshot.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ReportHistorySnapshot
    {
        #region Constants and Fields

        /// <summary>
        /// The creation date field.
        /// </summary>
        private DateTime creationDateField;

        /// <summary>
        /// The history id field.
        /// </summary>
        private string historyIDField;

        /// <summary>
        /// The size field.
        /// </summary>
        private int sizeField;

        #endregion

        #region Properties

        /// <summary>
        /// The creation date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }

            set
            {
                this.creationDateField = value;
            }
        }

        /// <summary>
        /// The history id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string HistoryID
        {
            get
            {
                return this.historyIDField;
            }

            set
            {
                this.historyIDField = value;
            }
        }

        /// <summary>
        /// The size.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int Size
        {
            get
            {
                return this.sizeField;
            }

            set
            {
                this.sizeField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The data source prompt.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataSourcePrompt
    {
        #region Constants and Fields

        /// <summary>
        /// The data source id field.
        /// </summary>
        private string dataSourceIDField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The prompt field.
        /// </summary>
        private string promptField;

        #endregion

        #region Properties

        /// <summary>
        /// The data source id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string DataSourceID
        {
            get
            {
                return this.dataSourceIDField;
            }

            set
            {
                this.dataSourceIDField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The prompt.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }

            set
            {
                this.promptField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The data source.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataSource
    {
        #region Constants and Fields

        /// <summary>
        /// The item field.
        /// </summary>
        private DataSourceDefinitionOrReference itemField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        #endregion

        #region Properties

        /// <summary>
        /// The item.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("DataSourceDefinition", typeof(DataSourceDefinition))]
        [XmlElement("DataSourceReference", typeof(DataSourceReference))]
        [XmlElement("InvalidDataSourceReference", typeof(InvalidDataSourceReference))]
        public DataSourceDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }

            set
            {
                this.itemField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The job.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Job
    {
        #region Constants and Fields

        /// <summary>
        /// The action field.
        /// </summary>
        private JobActionEnum actionField;

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The job id field.
        /// </summary>
        private string jobIDField;

        /// <summary>
        /// The machine field.
        /// </summary>
        private string machineField;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The path field.
        /// </summary>
        private string pathField;

        /// <summary>
        /// The start date time field.
        /// </summary>
        private DateTime startDateTimeField;

        /// <summary>
        /// The status field.
        /// </summary>
        private JobStatusEnum statusField;

        /// <summary>
        /// The type field.
        /// </summary>
        private JobTypeEnum typeField;

        /// <summary>
        /// The user field.
        /// </summary>
        private string userField;

        #endregion

        #region Properties

        /// <summary>
        /// The action.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public JobActionEnum Action
        {
            get
            {
                return this.actionField;
            }

            set
            {
                this.actionField = value;
            }
        }

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The job id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string JobID
        {
            get
            {
                return this.jobIDField;
            }

            set
            {
                this.jobIDField = value;
            }
        }

        /// <summary>
        /// The machine.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Machine
        {
            get
            {
                return this.machineField;
            }

            set
            {
                this.machineField = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The path.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Path
        {
            get
            {
                return this.pathField;
            }

            set
            {
                this.pathField = value;
            }
        }

        /// <summary>
        /// The start date time.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }

            set
            {
                this.startDateTimeField = value;
            }
        }

        /// <summary>
        /// The status.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public JobStatusEnum Status
        {
            get
            {
                return this.statusField;
            }

            set
            {
                this.statusField = value;
            }
        }

        /// <summary>
        /// The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public JobTypeEnum Type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        /// <summary>
        /// The user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string User
        {
            get
            {
                return this.userField;
            }

            set
            {
                this.userField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The job action enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum JobActionEnum
    {
        /// <summary>
        /// The render.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Render, 

        /// <summary>
        /// The snapshot creation.
        /// </summary>
        /// <remarks>
        /// </remarks>
        SnapshotCreation, 

        /// <summary>
        /// The report history creation.
        /// </summary>
        /// <remarks>
        /// </remarks>
        ReportHistoryCreation, 

        /// <summary>
        /// The execute query.
        /// </summary>
        /// <remarks>
        /// </remarks>
        ExecuteQuery, 
    }

    /// <summary>
    /// The job type enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum JobTypeEnum
    {
        /// <summary>
        /// The user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        User, 

        /// <summary>
        /// The system.
        /// </summary>
        /// <remarks>
        /// </remarks>
        System, 
    }

    /// <summary>
    /// The job status enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum JobStatusEnum
    {
        /// <summary>
        /// The new.
        /// </summary>
        /// <remarks>
        /// </remarks>
        New, 

        /// <summary>
        /// The running.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Running, 

        /// <summary>
        /// The cancel requested.
        /// </summary>
        /// <remarks>
        /// </remarks>
        CancelRequested, 
    }

    /// <summary>
    /// The expiration definition.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlInclude(typeof(TimeExpiration))]
    [XmlInclude(typeof(ScheduleExpiration))]
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ExpirationDefinition
    {
    }

    /// <summary>
    /// The time expiration.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class TimeExpiration : ExpirationDefinition
    {
        #region Constants and Fields

        /// <summary>
        /// The minutes field.
        /// </summary>
        private int minutesField;

        #endregion

        #region Properties

        /// <summary>
        /// The minutes.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int Minutes
        {
            get
            {
                return this.minutesField;
            }

            set
            {
                this.minutesField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The schedule expiration.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ScheduleExpiration : ExpirationDefinition
    {
        #region Constants and Fields

        /// <summary>
        /// The item field.
        /// </summary>
        private ScheduleDefinitionOrReference itemField;

        #endregion

        #region Properties

        /// <summary>
        /// The item.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("ScheduleDefinition", typeof(ScheduleDefinition))]
        [XmlElement("ScheduleReference", typeof(ScheduleReference))]
        public ScheduleDefinitionOrReference Item
        {
            get
            {
                return this.itemField;
            }

            set
            {
                this.itemField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The report parameter.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class ReportParameter
    {
        #region Constants and Fields

        /// <summary>
        /// The allow blank field.
        /// </summary>
        private bool allowBlankField;

        /// <summary>
        /// The allow blank field specified.
        /// </summary>
        private bool allowBlankFieldSpecified;

        /// <summary>
        /// The default values field.
        /// </summary>
        private string[] defaultValuesField;

        /// <summary>
        /// The default values query based field.
        /// </summary>
        private bool defaultValuesQueryBasedField;

        /// <summary>
        /// The default values query based field specified.
        /// </summary>
        private bool defaultValuesQueryBasedFieldSpecified;

        /// <summary>
        /// The dependencies field.
        /// </summary>
        private string[] dependenciesField;

        /// <summary>
        /// The error message field.
        /// </summary>
        private string errorMessageField;

        /// <summary>
        /// The multi value field.
        /// </summary>
        private bool multiValueField;

        /// <summary>
        /// The multi value field specified.
        /// </summary>
        private bool multiValueFieldSpecified;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The nullable field.
        /// </summary>
        private bool nullableField;

        /// <summary>
        /// The nullable field specified.
        /// </summary>
        private bool nullableFieldSpecified;

        /// <summary>
        /// The prompt field.
        /// </summary>
        private string promptField;

        /// <summary>
        /// The prompt user field.
        /// </summary>
        private bool promptUserField;

        /// <summary>
        /// The prompt user field specified.
        /// </summary>
        private bool promptUserFieldSpecified;

        /// <summary>
        /// The query parameter field.
        /// </summary>
        private bool queryParameterField;

        /// <summary>
        /// The query parameter field specified.
        /// </summary>
        private bool queryParameterFieldSpecified;

        /// <summary>
        /// The state field.
        /// </summary>
        private ParameterStateEnum stateField;

        /// <summary>
        /// The state field specified.
        /// </summary>
        private bool stateFieldSpecified;

        /// <summary>
        /// The type field.
        /// </summary>
        private ParameterTypeEnum typeField;

        /// <summary>
        /// The type field specified.
        /// </summary>
        private bool typeFieldSpecified;

        /// <summary>
        /// The valid values field.
        /// </summary>
        private ValidValue[] validValuesField;

        /// <summary>
        /// The valid values query based field.
        /// </summary>
        private bool validValuesQueryBasedField;

        /// <summary>
        /// The valid values query based field specified.
        /// </summary>
        private bool validValuesQueryBasedFieldSpecified;

        #endregion

        #region Properties

        /// <summary>
        /// The allow blank.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool AllowBlank
        {
            get
            {
                return this.allowBlankField;
            }

            set
            {
                this.allowBlankField = value;
            }
        }

        /// <summary>
        /// The allow blank specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool AllowBlankSpecified
        {
            get
            {
                return this.allowBlankFieldSpecified;
            }

            set
            {
                this.allowBlankFieldSpecified = value;
            }
        }

        /// <summary>
        /// The default values.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlArrayItem("Value")]
        public string[] DefaultValues
        {
            get
            {
                return this.defaultValuesField;
            }

            set
            {
                this.defaultValuesField = value;
            }
        }

        /// <summary>
        /// The default values query based.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool DefaultValuesQueryBased
        {
            get
            {
                return this.defaultValuesQueryBasedField;
            }

            set
            {
                this.defaultValuesQueryBasedField = value;
            }
        }

        /// <summary>
        /// The default values query based specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool DefaultValuesQueryBasedSpecified
        {
            get
            {
                return this.defaultValuesQueryBasedFieldSpecified;
            }

            set
            {
                this.defaultValuesQueryBasedFieldSpecified = value;
            }
        }

        /// <summary>
        /// The dependencies.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlArrayItem("Dependency")]
        public string[] Dependencies
        {
            get
            {
                return this.dependenciesField;
            }

            set
            {
                this.dependenciesField = value;
            }
        }

        /// <summary>
        /// The error message.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }

            set
            {
                this.errorMessageField = value;
            }
        }

        /// <summary>
        /// The multi value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool MultiValue
        {
            get
            {
                return this.multiValueField;
            }

            set
            {
                this.multiValueField = value;
            }
        }

        /// <summary>
        /// The multi value specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool MultiValueSpecified
        {
            get
            {
                return this.multiValueFieldSpecified;
            }

            set
            {
                this.multiValueFieldSpecified = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The nullable.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }

            set
            {
                this.nullableField = value;
            }
        }

        /// <summary>
        /// The nullable specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool NullableSpecified
        {
            get
            {
                return this.nullableFieldSpecified;
            }

            set
            {
                this.nullableFieldSpecified = value;
            }
        }

        /// <summary>
        /// The prompt.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }

            set
            {
                this.promptField = value;
            }
        }

        /// <summary>
        /// The prompt user.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool PromptUser
        {
            get
            {
                return this.promptUserField;
            }

            set
            {
                this.promptUserField = value;
            }
        }

        /// <summary>
        /// The prompt user specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool PromptUserSpecified
        {
            get
            {
                return this.promptUserFieldSpecified;
            }

            set
            {
                this.promptUserFieldSpecified = value;
            }
        }

        /// <summary>
        /// The query parameter.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool QueryParameter
        {
            get
            {
                return this.queryParameterField;
            }

            set
            {
                this.queryParameterField = value;
            }
        }

        /// <summary>
        /// The query parameter specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool QueryParameterSpecified
        {
            get
            {
                return this.queryParameterFieldSpecified;
            }

            set
            {
                this.queryParameterFieldSpecified = value;
            }
        }

        /// <summary>
        /// The state.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ParameterStateEnum State
        {
            get
            {
                return this.stateField;
            }

            set
            {
                this.stateField = value;
            }
        }

        /// <summary>
        /// The state specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool StateSpecified
        {
            get
            {
                return this.stateFieldSpecified;
            }

            set
            {
                this.stateFieldSpecified = value;
            }
        }

        /// <summary>
        /// The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ParameterTypeEnum Type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        /// <summary>
        /// The type specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }

            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <summary>
        /// The valid values.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ValidValue[] ValidValues
        {
            get
            {
                return this.validValuesField;
            }

            set
            {
                this.validValuesField = value;
            }
        }

        /// <summary>
        /// The valid values query based.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool ValidValuesQueryBased
        {
            get
            {
                return this.validValuesQueryBasedField;
            }

            set
            {
                this.validValuesQueryBasedField = value;
            }
        }

        /// <summary>
        /// The valid values query based specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool ValidValuesQueryBasedSpecified
        {
            get
            {
                return this.validValuesQueryBasedFieldSpecified;
            }

            set
            {
                this.validValuesQueryBasedFieldSpecified = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The parameter type enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ParameterTypeEnum
    {
        /// <summary>
        /// The boolean.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Boolean, 

        /// <summary>
        /// The date time.
        /// </summary>
        /// <remarks>
        /// </remarks>
        DateTime, 

        /// <summary>
        /// The integer.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Integer, 

        /// <summary>
        /// The float.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Float, 

        /// <summary>
        /// The string.
        /// </summary>
        /// <remarks>
        /// </remarks>
        String, 
    }

    /// <summary>
    /// The parameter state enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ParameterStateEnum
    {
        /// <summary>
        /// The has valid value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        HasValidValue, 

        /// <summary>
        /// The missing valid value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        MissingValidValue, 

        /// <summary>
        /// The has outstanding dependencies.
        /// </summary>
        /// <remarks>
        /// </remarks>
        HasOutstandingDependencies, 

        /// <summary>
        /// The dynamic values unavailable.
        /// </summary>
        /// <remarks>
        /// </remarks>
        DynamicValuesUnavailable, 
    }

    /// <summary>
    /// The data source credentials.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class DataSourceCredentials
    {
        #region Constants and Fields

        /// <summary>
        /// The data source name field.
        /// </summary>
        private string dataSourceNameField;

        /// <summary>
        /// The password field.
        /// </summary>
        private string passwordField;

        /// <summary>
        /// The user name field.
        /// </summary>
        private string userNameField;

        #endregion

        #region Properties

        /// <summary>
        /// The data source name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string DataSourceName
        {
            get
            {
                return this.dataSourceNameField;
            }

            set
            {
                this.dataSourceNameField = value;
            }
        }

        /// <summary>
        /// The password.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Password
        {
            get
            {
                return this.passwordField;
            }

            set
            {
                this.passwordField = value;
            }
        }

        /// <summary>
        /// The user name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }

            set
            {
                this.userNameField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The warning.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Warning
    {
        #region Constants and Fields

        /// <summary>
        /// The code field.
        /// </summary>
        private string codeField;

        /// <summary>
        /// The message field.
        /// </summary>
        private string messageField;

        /// <summary>
        /// The object name field.
        /// </summary>
        private string objectNameField;

        /// <summary>
        /// The object type field.
        /// </summary>
        private string objectTypeField;

        /// <summary>
        /// The severity field.
        /// </summary>
        private string severityField;

        #endregion

        #region Properties

        /// <summary>
        /// The code.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Code
        {
            get
            {
                return this.codeField;
            }

            set
            {
                this.codeField = value;
            }
        }

        /// <summary>
        /// The message.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Message
        {
            get
            {
                return this.messageField;
            }

            set
            {
                this.messageField = value;
            }
        }

        /// <summary>
        /// The object name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ObjectName
        {
            get
            {
                return this.objectNameField;
            }

            set
            {
                this.objectNameField = value;
            }
        }

        /// <summary>
        /// The object type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ObjectType
        {
            get
            {
                return this.objectTypeField;
            }

            set
            {
                this.objectTypeField = value;
            }
        }

        /// <summary>
        /// The severity.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Severity
        {
            get
            {
                return this.severityField;
            }

            set
            {
                this.severityField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The catalog item.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class CatalogItem
    {
        #region Constants and Fields

        /// <summary>
        /// The created by field.
        /// </summary>
        private string createdByField;

        /// <summary>
        /// The creation date field.
        /// </summary>
        private DateTime creationDateField;

        /// <summary>
        /// The creation date field specified.
        /// </summary>
        private bool creationDateFieldSpecified;

        /// <summary>
        /// The description field.
        /// </summary>
        private string descriptionField;

        /// <summary>
        /// The execution date field.
        /// </summary>
        private DateTime executionDateField;

        /// <summary>
        /// The execution date field specified.
        /// </summary>
        private bool executionDateFieldSpecified;

        /// <summary>
        /// The hidden field.
        /// </summary>
        private bool hiddenField;

        /// <summary>
        /// The hidden field specified.
        /// </summary>
        private bool hiddenFieldSpecified;

        /// <summary>
        /// The id field.
        /// </summary>
        private string idField;

        /// <summary>
        /// The mime type field.
        /// </summary>
        private string mimeTypeField;

        /// <summary>
        /// The modified by field.
        /// </summary>
        private string modifiedByField;

        /// <summary>
        /// The modified date field.
        /// </summary>
        private DateTime modifiedDateField;

        /// <summary>
        /// The modified date field specified.
        /// </summary>
        private bool modifiedDateFieldSpecified;

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The path field.
        /// </summary>
        private string pathField;

        /// <summary>
        /// The size field.
        /// </summary>
        private int sizeField;

        /// <summary>
        /// The size field specified.
        /// </summary>
        private bool sizeFieldSpecified;

        /// <summary>
        /// The type field.
        /// </summary>
        private ItemTypeEnum typeField;

        /// <summary>
        /// The virtual path field.
        /// </summary>
        private string virtualPathField;

        #endregion

        #region Properties

        /// <summary>
        /// The created by.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string CreatedBy
        {
            get
            {
                return this.createdByField;
            }

            set
            {
                this.createdByField = value;
            }
        }

        /// <summary>
        /// The creation date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }

            set
            {
                this.creationDateField = value;
            }
        }

        /// <summary>
        /// The creation date specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }

            set
            {
                this.creationDateFieldSpecified = value;
            }
        }

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }

            set
            {
                this.descriptionField = value;
            }
        }

        /// <summary>
        /// The execution date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime ExecutionDate
        {
            get
            {
                return this.executionDateField;
            }

            set
            {
                this.executionDateField = value;
            }
        }

        /// <summary>
        /// The execution date specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool ExecutionDateSpecified
        {
            get
            {
                return this.executionDateFieldSpecified;
            }

            set
            {
                this.executionDateFieldSpecified = value;
            }
        }

        /// <summary>
        /// The hidden.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Hidden
        {
            get
            {
                return this.hiddenField;
            }

            set
            {
                this.hiddenField = value;
            }
        }

        /// <summary>
        /// The hidden specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool HiddenSpecified
        {
            get
            {
                return this.hiddenFieldSpecified;
            }

            set
            {
                this.hiddenFieldSpecified = value;
            }
        }

        /// <summary>
        /// The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ID
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        /// <summary>
        /// The mime type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }

            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <summary>
        /// The modified by.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }

            set
            {
                this.modifiedByField = value;
            }
        }

        /// <summary>
        /// The modified date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateTime ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }

            set
            {
                this.modifiedDateField = value;
            }
        }

        /// <summary>
        /// The modified date specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool ModifiedDateSpecified
        {
            get
            {
                return this.modifiedDateFieldSpecified;
            }

            set
            {
                this.modifiedDateFieldSpecified = value;
            }
        }

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The path.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Path
        {
            get
            {
                return this.pathField;
            }

            set
            {
                this.pathField = value;
            }
        }

        /// <summary>
        /// The size.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int Size
        {
            get
            {
                return this.sizeField;
            }

            set
            {
                this.sizeField = value;
            }
        }

        /// <summary>
        /// The size specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool SizeSpecified
        {
            get
            {
                return this.sizeFieldSpecified;
            }

            set
            {
                this.sizeFieldSpecified = value;
            }
        }

        /// <summary>
        /// The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ItemTypeEnum Type
        {
            get
            {
                return this.typeField;
            }

            set
            {
                this.typeField = value;
            }
        }

        /// <summary>
        /// The virtual path.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string VirtualPath
        {
            get
            {
                return this.virtualPathField;
            }

            set
            {
                this.virtualPathField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The item type enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ItemTypeEnum
    {
        /// <summary>
        /// The unknown.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Unknown, 

        /// <summary>
        /// The folder.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Folder, 

        /// <summary>
        /// The report.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Report, 

        /// <summary>
        /// The resource.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Resource, 

        /// <summary>
        /// The linked report.
        /// </summary>
        /// <remarks>
        /// </remarks>
        LinkedReport, 

        /// <summary>
        /// The data source.
        /// </summary>
        /// <remarks>
        /// </remarks>
        DataSource, 

        /// <summary>
        /// The model.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Model, 
    }

    /// <summary>
    /// The property.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlInclude(typeof(SearchCondition))]
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class Property
    {
        #region Constants and Fields

        /// <summary>
        /// The name field.
        /// </summary>
        private string nameField;

        /// <summary>
        /// The value field.
        /// </summary>
        private string valueField;

        #endregion

        #region Properties

        /// <summary>
        /// The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Name
        {
            get
            {
                return this.nameField;
            }

            set
            {
                this.nameField = value;
            }
        }

        /// <summary>
        /// The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The search condition.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public partial class SearchCondition : Property
    {
        #region Constants and Fields

        /// <summary>
        /// The condition field.
        /// </summary>
        private ConditionEnum conditionField;

        /// <summary>
        /// The condition field specified.
        /// </summary>
        private bool conditionFieldSpecified;

        #endregion

        #region Properties

        /// <summary>
        /// The condition.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ConditionEnum Condition
        {
            get
            {
                return this.conditionField;
            }

            set
            {
                this.conditionField = value;
            }
        }

        /// <summary>
        /// The condition specified.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlIgnore()]
        public bool ConditionSpecified
        {
            get
            {
                return this.conditionFieldSpecified;
            }

            set
            {
                this.conditionFieldSpecified = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The condition enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ConditionEnum
    {
        /// <summary>
        /// The contains.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Contains, 

        /// <summary>
        /// The equals.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Equals, 
    }

    /// <summary>
    /// The batch header.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
        IsNullable = false)]
    public partial class BatchHeader : SoapHeader
    {
        #region Constants and Fields

        /// <summary>
        /// The any attr field.
        /// </summary>
        private XmlAttribute[] anyAttrField;

        /// <summary>
        /// The batch id field.
        /// </summary>
        private string batchIDField;

        #endregion

        #region Properties

        /// <summary>
        /// The any attr.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAnyAttribute()]
        public XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }

            set
            {
                this.anyAttrField = value;
            }
        }

        /// <summary>
        /// The batch id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string BatchID
        {
            get
            {
                return this.batchIDField;
            }

            set
            {
                this.batchIDField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The item namespace header.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    [XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", 
        IsNullable = false)]
    public partial class ItemNamespaceHeader : SoapHeader
    {
        #region Constants and Fields

        /// <summary>
        /// The any attr field.
        /// </summary>
        private XmlAttribute[] anyAttrField;

        /// <summary>
        /// The item namespace field.
        /// </summary>
        private ItemNamespaceEnum itemNamespaceField;

        #endregion

        #region Properties

        /// <summary>
        /// The any attr.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAnyAttribute()]
        public XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }

            set
            {
                this.anyAttrField = value;
            }
        }

        /// <summary>
        /// The item namespace.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ItemNamespaceEnum ItemNamespace
        {
            get
            {
                return this.itemNamespaceField;
            }

            set
            {
                this.itemNamespaceField = value;
            }
        }

        #endregion
    }

    /// <summary>
    /// The item namespace enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ItemNamespaceEnum
    {
        /// <summary>
        /// The path based.
        /// </summary>
        /// <remarks>
        /// </remarks>
        PathBased, 

        /// <summary>
        /// The guid based.
        /// </summary>
        /// <remarks>
        /// </remarks>
        GUIDBased, 
    }

    /// <summary>
    /// The execution setting enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum ExecutionSettingEnum
    {
        /// <summary>
        /// The live.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Live, 

        /// <summary>
        /// The snapshot.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Snapshot, 
    }

    /// <summary>
    /// The boolean operator enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum BooleanOperatorEnum
    {
        /// <summary>
        /// The and.
        /// </summary>
        /// <remarks>
        /// </remarks>
        And, 

        /// <summary>
        /// The or.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Or, 
    }

    /// <summary>
    /// The security scope enum.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Xml", "2.0.50727.3082")]
    [Serializable()]
    [XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
    public enum SecurityScopeEnum
    {
        /// <summary>
        /// The system.
        /// </summary>
        /// <remarks>
        /// </remarks>
        System, 

        /// <summary>
        /// The catalog.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Catalog, 

        /// <summary>
        /// The model.
        /// </summary>
        /// <remarks>
        /// </remarks>
        Model, 

        /// <summary>
        /// The all.
        /// </summary>
        /// <remarks>
        /// </remarks>
        All, 
    }

    /// <summary>
    /// The list secure methods completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListSecureMethodsCompletedEventHandler(object sender, ListSecureMethodsCompletedEventArgs e);

    /// <summary>
    /// The list secure methods completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListSecureMethodsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSecureMethodsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListSecureMethodsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create batch completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateBatchCompletedEventHandler(object sender, CreateBatchCompletedEventArgs e);

    /// <summary>
    /// The create batch completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CreateBatchCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CreateBatchCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The cancel batch completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CancelBatchCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The execute batch completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ExecuteBatchCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get system properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetSystemPropertiesCompletedEventHandler(object sender, GetSystemPropertiesCompletedEventArgs e
        );

    /// <summary>
    /// The get system properties completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetSystemPropertiesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSystemPropertiesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetSystemPropertiesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Property[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Property[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set system properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetSystemPropertiesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The delete item completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void DeleteItemCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The move item completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void MoveItemCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The list children completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListChildrenCompletedEventHandler(object sender, ListChildrenCompletedEventArgs e);

    /// <summary>
    /// The list children completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListChildrenCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChildrenCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListChildrenCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CatalogItem[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list dependent items completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListDependentItemsCompletedEventHandler(object sender, ListDependentItemsCompletedEventArgs e);

    /// <summary>
    /// The list dependent items completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListDependentItemsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDependentItemsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListDependentItemsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CatalogItem[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetPropertiesCompletedEventHandler(object sender, GetPropertiesCompletedEventArgs e);

    /// <summary>
    /// The get properties completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetPropertiesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPropertiesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetPropertiesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Property[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Property[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetPropertiesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get item type completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetItemTypeCompletedEventHandler(object sender, GetItemTypeCompletedEventArgs e);

    /// <summary>
    /// The get item type completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetItemTypeCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetItemTypeCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetItemTypeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ItemTypeEnum Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ItemTypeEnum)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create folder completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateFolderCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The create report completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateReportCompletedEventHandler(object sender, CreateReportCompletedEventArgs e);

    /// <summary>
    /// The create report completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CreateReportCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReportCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CreateReportCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Warning[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get report definition completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetReportDefinitionCompletedEventHandler(object sender, GetReportDefinitionCompletedEventArgs e
        );

    /// <summary>
    /// The get report definition completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetReportDefinitionCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportDefinitionCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetReportDefinitionCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public byte[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (byte[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set report definition completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetReportDefinitionCompletedEventHandler(object sender, SetReportDefinitionCompletedEventArgs e
        );

    /// <summary>
    /// The set report definition completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class SetReportDefinitionCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SetReportDefinitionCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal SetReportDefinitionCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Warning[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create resource completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateResourceCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The set resource contents completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetResourceContentsCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get resource contents completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetResourceContentsCompletedEventHandler(object sender, GetResourceContentsCompletedEventArgs e
        );

    /// <summary>
    /// The get resource contents completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetResourceContentsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResourceContentsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetResourceContentsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The mime type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string MimeType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public byte[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (byte[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get report parameters completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetReportParametersCompletedEventHandler(object sender, GetReportParametersCompletedEventArgs e
        );

    /// <summary>
    /// The get report parameters completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetReportParametersCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportParametersCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetReportParametersCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ReportParameter[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ReportParameter[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set report parameters completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetReportParametersCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The create linked report completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateLinkedReportCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get report link completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetReportLinkCompletedEventHandler(object sender, GetReportLinkCompletedEventArgs e);

    /// <summary>
    /// The get report link completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetReportLinkCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportLinkCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetReportLinkCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set report link completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetReportLinkCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get render resource completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetRenderResourceCompletedEventHandler(object sender, GetRenderResourceCompletedEventArgs e);

    /// <summary>
    /// The get render resource completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetRenderResourceCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRenderResourceCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetRenderResourceCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The mime type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string MimeType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public byte[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (byte[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set execution options completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetExecutionOptionsCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get execution options completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetExecutionOptionsCompletedEventHandler(object sender, GetExecutionOptionsCompletedEventArgs e
        );

    /// <summary>
    /// The get execution options completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetExecutionOptionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExecutionOptionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetExecutionOptionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The item.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ScheduleDefinitionOrReference Item
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ScheduleDefinitionOrReference)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExecutionSettingEnum Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ExecutionSettingEnum)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set cache options completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetCacheOptionsCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get cache options completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetCacheOptionsCompletedEventHandler(object sender, GetCacheOptionsCompletedEventArgs e);

    /// <summary>
    /// The get cache options completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetCacheOptionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCacheOptionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetCacheOptionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The item.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExpirationDefinition Item
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ExpirationDefinition)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The update report execution snapshot completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void UpdateReportExecutionSnapshotCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The flush cache completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void FlushCacheCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The list jobs completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListJobsCompletedEventHandler(object sender, ListJobsCompletedEventArgs e);

    /// <summary>
    /// The list jobs completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListJobsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListJobsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Job[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Job[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The cancel job completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CancelJobCompletedEventHandler(object sender, CancelJobCompletedEventArgs e);

    /// <summary>
    /// The cancel job completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CancelJobCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelJobCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CancelJobCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create data source completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateDataSourceCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get data source contents completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetDataSourceContentsCompletedEventHandler(
        object sender, GetDataSourceContentsCompletedEventArgs e);

    /// <summary>
    /// The get data source contents completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetDataSourceContentsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDataSourceContentsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetDataSourceContentsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DataSourceDefinition Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (DataSourceDefinition)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set data source contents completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetDataSourceContentsCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The enable data source completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void EnableDataSourceCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The disable data source completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void DisableDataSourceCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The set item data sources completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetItemDataSourcesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get item data sources completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetItemDataSourcesCompletedEventHandler(object sender, GetItemDataSourcesCompletedEventArgs e);

    /// <summary>
    /// The get item data sources completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetItemDataSourcesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetItemDataSourcesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetItemDataSourcesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DataSource[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (DataSource[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get item data source prompts completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetItemDataSourcePromptsCompletedEventHandler(
        object sender, GetItemDataSourcePromptsCompletedEventArgs e);

    /// <summary>
    /// The get item data source prompts completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetItemDataSourcePromptsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetItemDataSourcePromptsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetItemDataSourcePromptsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DataSourcePrompt[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (DataSourcePrompt[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create report history snapshot completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateReportHistorySnapshotCompletedEventHandler(
        object sender, CreateReportHistorySnapshotCompletedEventArgs e);

    /// <summary>
    /// The create report history snapshot completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CreateReportHistorySnapshotCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReportHistorySnapshotCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CreateReportHistorySnapshotCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        /// <summary>
        /// The warnings.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Warning[] Warnings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Warning[])this.results[1];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set report history options completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetReportHistoryOptionsCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get report history options completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetReportHistoryOptionsCompletedEventHandler(
        object sender, GetReportHistoryOptionsCompletedEventArgs e);

    /// <summary>
    /// The get report history options completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetReportHistoryOptionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportHistoryOptionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetReportHistoryOptionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The item.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ScheduleDefinitionOrReference Item
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ScheduleDefinitionOrReference)this.results[2];
            }
        }

        /// <summary>
        /// The keep execution snapshots.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool KeepExecutionSnapshots
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set report history limit completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetReportHistoryLimitCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get report history limit completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetReportHistoryLimitCompletedEventHandler(
        object sender, GetReportHistoryLimitCompletedEventArgs e);

    /// <summary>
    /// The get report history limit completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetReportHistoryLimitCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportHistoryLimitCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetReportHistoryLimitCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The is system.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool IsSystem
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (int)this.results[0];
            }
        }

        /// <summary>
        /// The system limit.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public int SystemLimit
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (int)this.results[2];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list report history completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListReportHistoryCompletedEventHandler(object sender, ListReportHistoryCompletedEventArgs e);

    /// <summary>
    /// The list report history completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListReportHistoryCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListReportHistoryCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListReportHistoryCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ReportHistorySnapshot[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ReportHistorySnapshot[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The delete report history snapshot completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void DeleteReportHistorySnapshotCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The find items completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void FindItemsCompletedEventHandler(object sender, FindItemsCompletedEventArgs e);

    /// <summary>
    /// The find items completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class FindItemsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindItemsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal FindItemsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CatalogItem[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create schedule completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateScheduleCompletedEventHandler(object sender, CreateScheduleCompletedEventArgs e);

    /// <summary>
    /// The create schedule completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CreateScheduleCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduleCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CreateScheduleCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The delete schedule completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void DeleteScheduleCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The set schedule properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetSchedulePropertiesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get schedule properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetSchedulePropertiesCompletedEventHandler(
        object sender, GetSchedulePropertiesCompletedEventArgs e);

    /// <summary>
    /// The get schedule properties completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetSchedulePropertiesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSchedulePropertiesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetSchedulePropertiesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Schedule Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Schedule)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list scheduled reports completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListScheduledReportsCompletedEventHandler(
        object sender, ListScheduledReportsCompletedEventArgs e);

    /// <summary>
    /// The list scheduled reports completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListScheduledReportsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListScheduledReportsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListScheduledReportsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public CatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (CatalogItem[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list schedules completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListSchedulesCompletedEventHandler(object sender, ListSchedulesCompletedEventArgs e);

    /// <summary>
    /// The list schedules completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListSchedulesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSchedulesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListSchedulesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Schedule[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Schedule[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The pause schedule completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void PauseScheduleCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The resume schedule completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ResumeScheduleCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The create subscription completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateSubscriptionCompletedEventHandler(object sender, CreateSubscriptionCompletedEventArgs e);

    /// <summary>
    /// The create subscription completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CreateSubscriptionCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CreateSubscriptionCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create data driven subscription completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateDataDrivenSubscriptionCompletedEventHandler(
        object sender, CreateDataDrivenSubscriptionCompletedEventArgs e);

    /// <summary>
    /// The create data driven subscription completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CreateDataDrivenSubscriptionCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDataDrivenSubscriptionCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CreateDataDrivenSubscriptionCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set subscription properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetSubscriptionPropertiesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The set data driven subscription properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetDataDrivenSubscriptionPropertiesCompletedEventHandler(
        object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get subscription properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetSubscriptionPropertiesCompletedEventHandler(
        object sender, GetSubscriptionPropertiesCompletedEventArgs e);

    /// <summary>
    /// The get subscription properties completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetSubscriptionPropertiesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionPropertiesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetSubscriptionPropertiesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The active.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ActiveState Active
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ActiveState)this.results[3];
            }
        }

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[2];
            }
        }

        /// <summary>
        /// The event type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string EventType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[5];
            }
        }

        /// <summary>
        /// The extension settings.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExtensionSettings ExtensionSettings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ExtensionSettings)this.results[1];
            }
        }

        /// <summary>
        /// The match data.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string MatchData
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[6];
            }
        }

        /// <summary>
        /// The parameters.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ParameterValue[] Parameters
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ParameterValue[])this.results[7];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        /// <summary>
        /// The status.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Status
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[4];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get data driven subscription properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetDataDrivenSubscriptionPropertiesCompletedEventHandler(
        object sender, GetDataDrivenSubscriptionPropertiesCompletedEventArgs e);

    /// <summary>
    /// The get data driven subscription properties completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetDataDrivenSubscriptionPropertiesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDataDrivenSubscriptionPropertiesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetDataDrivenSubscriptionPropertiesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The active.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ActiveState Active
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ActiveState)this.results[4];
            }
        }

        /// <summary>
        /// The data retrieval plan.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DataRetrievalPlan DataRetrievalPlan
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (DataRetrievalPlan)this.results[2];
            }
        }

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[3];
            }
        }

        /// <summary>
        /// The event type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string EventType
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[6];
            }
        }

        /// <summary>
        /// The extension settings.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExtensionSettings ExtensionSettings
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ExtensionSettings)this.results[1];
            }
        }

        /// <summary>
        /// The match data.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string MatchData
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[7];
            }
        }

        /// <summary>
        /// The parameters.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ParameterValueOrFieldReference[] Parameters
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ParameterValueOrFieldReference[])this.results[8];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[0];
            }
        }

        /// <summary>
        /// The status.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Status
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[5];
            }
        }

        #endregion
    }

    /// <summary>
    /// The delete subscription completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void DeleteSubscriptionCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The prepare query completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void PrepareQueryCompletedEventHandler(object sender, PrepareQueryCompletedEventArgs e);

    /// <summary>
    /// The prepare query completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class PrepareQueryCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareQueryCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal PrepareQueryCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The changed.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool Changed
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[1];
            }
        }

        /// <summary>
        /// The parameter names.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string[] ParameterNames
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string[])this.results[2];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DataSetDefinition Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (DataSetDefinition)this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get extension settings completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetExtensionSettingsCompletedEventHandler(
        object sender, GetExtensionSettingsCompletedEventArgs e);

    /// <summary>
    /// The get extension settings completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetExtensionSettingsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionSettingsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetExtensionSettingsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExtensionParameter[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ExtensionParameter[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The validate extension settings completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ValidateExtensionSettingsCompletedEventHandler(
        object sender, ValidateExtensionSettingsCompletedEventArgs e);

    /// <summary>
    /// The validate extension settings completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ValidateExtensionSettingsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateExtensionSettingsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ValidateExtensionSettingsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ExtensionParameter[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ExtensionParameter[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list subscriptions completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListSubscriptionsCompletedEventHandler(object sender, ListSubscriptionsCompletedEventArgs e);

    /// <summary>
    /// The list subscriptions completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListSubscriptionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListSubscriptionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Subscription[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Subscription[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list subscriptions using data source completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListSubscriptionsUsingDataSourceCompletedEventHandler(
        object sender, ListSubscriptionsUsingDataSourceCompletedEventArgs e);

    /// <summary>
    /// The list subscriptions using data source completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListSubscriptionsUsingDataSourceCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionsUsingDataSourceCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListSubscriptionsUsingDataSourceCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Subscription[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Subscription[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list extensions completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListExtensionsCompletedEventHandler(object sender, ListExtensionsCompletedEventArgs e);

    /// <summary>
    /// The list extensions completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListExtensionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExtensionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListExtensionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Extension[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Extension[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list events completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListEventsCompletedEventHandler(object sender, ListEventsCompletedEventArgs e);

    /// <summary>
    /// The list events completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListEventsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEventsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListEventsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Event[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Event[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The fire event completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void FireEventCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The list tasks completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListTasksCompletedEventHandler(object sender, ListTasksCompletedEventArgs e);

    /// <summary>
    /// The list tasks completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListTasksCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTasksCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListTasksCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Task[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Task[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list roles completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListRolesCompletedEventHandler(object sender, ListRolesCompletedEventArgs e);

    /// <summary>
    /// The list roles completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListRolesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRolesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListRolesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Role[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Role[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The create role completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateRoleCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The delete role completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void DeleteRoleCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get role properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetRolePropertiesCompletedEventHandler(object sender, GetRolePropertiesCompletedEventArgs e);

    /// <summary>
    /// The get role properties completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetRolePropertiesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRolePropertiesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetRolePropertiesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The description.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string Description
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Task[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Task[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set role properties completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetRolePropertiesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get system policies completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetSystemPoliciesCompletedEventHandler(object sender, GetSystemPoliciesCompletedEventArgs e);

    /// <summary>
    /// The get system policies completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetSystemPoliciesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSystemPoliciesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetSystemPoliciesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Policy[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Policy[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set system policies completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetSystemPoliciesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get policies completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetPoliciesCompletedEventHandler(object sender, GetPoliciesCompletedEventArgs e);

    /// <summary>
    /// The get policies completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetPoliciesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPoliciesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetPoliciesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The inherit parent.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool InheritParent
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Policy[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Policy[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set policies completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetPoliciesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The inherit parent security completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void InheritParentSecurityCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The get system permissions completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetSystemPermissionsCompletedEventHandler(
        object sender, GetSystemPermissionsCompletedEventArgs e);

    /// <summary>
    /// The get system permissions completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetSystemPermissionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSystemPermissionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetSystemPermissionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get permissions completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetPermissionsCompletedEventHandler(object sender, GetPermissionsCompletedEventArgs e);

    /// <summary>
    /// The get permissions completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetPermissionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPermissionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetPermissionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The logon user completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void LogonUserCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The logoff completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void LogoffCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The create model completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void CreateModelCompletedEventHandler(object sender, CreateModelCompletedEventArgs e);

    /// <summary>
    /// The create model completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class CreateModelCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal CreateModelCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Warning[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get model definition completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetModelDefinitionCompletedEventHandler(object sender, GetModelDefinitionCompletedEventArgs e);

    /// <summary>
    /// The get model definition completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetModelDefinitionCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelDefinitionCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetModelDefinitionCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public byte[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (byte[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set model definition completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetModelDefinitionCompletedEventHandler(object sender, SetModelDefinitionCompletedEventArgs e);

    /// <summary>
    /// The set model definition completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class SetModelDefinitionCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SetModelDefinitionCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal SetModelDefinitionCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Warning[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list model perspectives completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListModelPerspectivesCompletedEventHandler(
        object sender, ListModelPerspectivesCompletedEventArgs e);

    /// <summary>
    /// The list model perspectives completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListModelPerspectivesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelPerspectivesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListModelPerspectivesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ModelCatalogItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ModelCatalogItem[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get user model completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetUserModelCompletedEventHandler(object sender, GetUserModelCompletedEventArgs e);

    /// <summary>
    /// The get user model completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetUserModelCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserModelCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetUserModelCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public byte[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (byte[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The list model item children completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListModelItemChildrenCompletedEventHandler(
        object sender, ListModelItemChildrenCompletedEventArgs e);

    /// <summary>
    /// The list model item children completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListModelItemChildrenCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelItemChildrenCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListModelItemChildrenCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ModelItem[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ModelItem[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get model item permissions completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetModelItemPermissionsCompletedEventHandler(
        object sender, GetModelItemPermissionsCompletedEventArgs e);

    /// <summary>
    /// The get model item permissions completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetModelItemPermissionsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelItemPermissionsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetModelItemPermissionsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (string[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The get model item policies completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetModelItemPoliciesCompletedEventHandler(
        object sender, GetModelItemPoliciesCompletedEventArgs e);

    /// <summary>
    /// The get model item policies completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GetModelItemPoliciesCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelItemPoliciesCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GetModelItemPoliciesCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The inherit parent.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public bool InheritParent
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (bool)this.results[1];
            }
        }

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Policy[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Policy[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The set model item policies completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetModelItemPoliciesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The inherit model item parent security completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void InheritModelItemParentSecurityCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The remove all model item policies completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void RemoveAllModelItemPoliciesCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The set model drillthrough reports completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void SetModelDrillthroughReportsCompletedEventHandler(object sender, AsyncCompletedEventArgs e);

    /// <summary>
    /// The list model drillthrough reports completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void ListModelDrillthroughReportsCompletedEventHandler(
        object sender, ListModelDrillthroughReportsCompletedEventArgs e);

    /// <summary>
    /// The list model drillthrough reports completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class ListModelDrillthroughReportsCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelDrillthroughReportsCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal ListModelDrillthroughReportsCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public ModelDrillthroughReport[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (ModelDrillthroughReport[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The generate model completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void GenerateModelCompletedEventHandler(object sender, GenerateModelCompletedEventArgs e);

    /// <summary>
    /// The generate model completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class GenerateModelCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateModelCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal GenerateModelCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Warning[])this.results[0];
            }
        }

        #endregion
    }

    /// <summary>
    /// The regenerate model completed event handler.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    public delegate void RegenerateModelCompletedEventHandler(object sender, RegenerateModelCompletedEventArgs e);

    /// <summary>
    /// The regenerate model completed event args.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class RegenerateModelCompletedEventArgs : AsyncCompletedEventArgs
    {
        #region Constants and Fields

        /// <summary>
        /// The results.
        /// </summary>
        private object[] results;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RegenerateModelCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="exception">
        /// The exception.
        /// </param>
        /// <param name="cancelled">
        /// The cancelled.
        /// </param>
        /// <param name="userState">
        /// The user state.
        /// </param>
        internal RegenerateModelCompletedEventArgs(
            object[] results, Exception exception, bool cancelled, object userState)
            : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The result.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public Warning[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return (Warning[])this.results[0];
            }
        }

        #endregion
    }
}

#pragma warning restore 1591