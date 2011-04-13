// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerMessageEventArgs.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Server Messages Types.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    #region using directive

    using System;

    #endregion

    /// <summary>
    /// Report Server Messages Types.
    /// </summary>
    public enum DeploymentMangerMessageType
    {
        /// <summary>
        ///   Error when any expections happen.
        /// </summary>
        Error = 0, 

        /// <summary>
        ///   Information messages.
        /// </summary>
        Information, 

        /// <summary>
        ///   Warning messages.
        /// </summary>
        Warning
    }

    /// <summary>
    /// Deployment Manger Message Event Args
    /// </summary>
    public class DeploymentMangerMessageEventArgs : EventArgs
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentMangerMessageEventArgs"/> class.
        /// </summary>
        /// <param name="reportMessageType">
        /// Type of the report message.
        /// </param>
        /// <param name="method">
        /// The method.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public DeploymentMangerMessageEventArgs(
            DeploymentMangerMessageType reportMessageType, string method, string message)
        {
            this.ReportMessageType = reportMessageType;
            this.Method = method;
            this.Message = message;
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        ///   Gets or sets the method.
        /// </summary>
        /// <value>The method.</value>
        public string Method { get; set; }

        /// <summary>
        ///   Gets or sets the type of the report message.
        /// </summary>
        /// <value>The type of the report message.</value>
        public DeploymentMangerMessageType ReportMessageType { get; set; }

        #endregion
    }
}