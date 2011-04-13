// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RSHelper.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Static class with reuseable functions for reporting services
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks
{
    #region using directive

    using Microsoft.Build.Framework;

    using ssrsmsbuildtasks.DeploymentManger;

    #endregion

    /// <summary>
    /// Static class with reuseable functions for reporting services
    /// </summary>
    internal static class RSBuildHelper
    {
        #region Public Methods

        /// <summary>
        /// The send report message.
        /// </summary>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
        /// <param name="buildEngine">
        /// The build engine.
        /// </param>
        /// <param name="senderName">
        /// The sender name.
        /// </param>
        public static void SendDeploymentMangerMessage(
            DeploymentMangerMessageEventArgs eventArgs, IBuildEngine buildEngine, string senderName)
        {
            switch (eventArgs.ReportMessageType)
            {
                case DeploymentMangerMessageType.Information:
                    buildEngine.LogMessageEvent(
                        new BuildMessageEventArgs(eventArgs.Message, string.Empty, senderName, MessageImportance.Normal));
                    break;
                case DeploymentMangerMessageType.Warning:
                    buildEngine.LogWarningEvent(
                        new BuildWarningEventArgs(
                            "Reporting", 
                            eventArgs.Method, 
                            buildEngine.ProjectFileOfTaskNode, 
                            buildEngine.LineNumberOfTaskNode, 
                            buildEngine.ColumnNumberOfTaskNode, 
                            0, 
                            0, 
                            eventArgs.Message, 
                            string.Empty, 
                            senderName));
                    break;
                case DeploymentMangerMessageType.Error:

                    buildEngine.LogErrorEvent(
                        new BuildErrorEventArgs(
                            "Reporting",
                            eventArgs.Method, 
                            buildEngine.ProjectFileOfTaskNode, 
                            buildEngine.LineNumberOfTaskNode, 
                            buildEngine.ColumnNumberOfTaskNode, 
                            0, 
                            0, 
                            eventArgs.Message, 
                            string.Empty, 
                            senderName));
                    break;
            }
        }

        #endregion
    }
}