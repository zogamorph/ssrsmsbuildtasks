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
    #region Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ssrsmsbuildtasks.DeploymentManger.ReportItems;
    
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
                        new BuildMessageEventArgs(eventArgs.Message, String.Empty, senderName, MessageImportance.Normal));
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
                            String.Empty,
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
                            String.Empty,
                            senderName));
                    break;
            }
        }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <param name="dictionary">The dictionary.</param>
        /// <param name="paramtersString">The paramters string.</param>
        /// <param name="subsrptionDeliveryMethodOptions">The subsrption delivery method options.</param>
        public static void GetParameters(Dictionary<string, string> dictionary, string paramtersString, SubsrptionDeliveryMethodOptions subsrptionDeliveryMethodOptions)
        {
            List<string> toList = new List<string>();
            if (!string.IsNullOrEmpty(paramtersString))
            {
                foreach (string paramterString in paramtersString.Split(new[] { ';' }))
                {
                    string[] paramter = paramterString.Split(new[] { '=' });

                    if (subsrptionDeliveryMethodOptions == SubsrptionDeliveryMethodOptions.EMail)
                    {
                        if (paramter[0].ToUpper() == "TO" || (paramter.Length== 1 && toList.Count > 0))
                        {
                            toList.Add(paramter[paramter.Length-1]);
                            continue;
                        }

                    }

                    dictionary.Add(paramter[0], paramter[1]);
                }

                if (subsrptionDeliveryMethodOptions == SubsrptionDeliveryMethodOptions.EMail && toList.Count > 0)
                {
                    dictionary.Add("TO", toList.Aggregate((s1, s2) => s1 + ";" + s2));
                }
            }
        }

        /// <summary>
        /// Deliveries the method option.
        /// </summary>
        /// <param name="deliveryMethod">The delivery method.</param>
        /// <returns>The Subsrption Delivery Method Options value</returns>
        /// <exception cref="ArgumentException"><c>ArgumentException</c>.</exception>
        public static SubsrptionDeliveryMethodOptions DeliveryMethodOption(string deliveryMethod)
        {
            switch (deliveryMethod.ToUpper())
            {
                case "FILE": return SubsrptionDeliveryMethodOptions.File;
                case "EMAIL": return SubsrptionDeliveryMethodOptions.EMail;
                default: throw new ArgumentException(String.Format("{0} Invaild Delivery Method Option: File or EMail", deliveryMethod));
            }
        }

        #endregion
    }
}