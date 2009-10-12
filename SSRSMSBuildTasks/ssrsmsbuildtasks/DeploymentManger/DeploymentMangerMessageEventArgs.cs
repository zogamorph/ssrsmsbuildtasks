// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerMessageEventArgs.cs" company="">
//   
// </copyright>
// <summary>
//   Report Server Messages Types.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    #region Directives

    using System;

    #endregion

    /// <summary>
    /// Report Server Messages Types.
    /// </summary>
    public enum DeploymentMangerMessageType
    {
        /// <summary>
        /// Error when any expections happen.
        /// </summary>
        Error = 0, 

        /// <summary>
        /// Information messages.
        /// </summary>
        Information, 

        /// <summary>
        /// Warning messages.
        /// </summary>
        Warning
    }

    /// <summary>
    /// Report Server Message Args.
    /// </summary>
    public class DeploymentMangerMessageEventArgs : EventArgs
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the DeploymentMangerMessageEventArgs class. Initializes a new instance of the DeploymentMangerMessageEventArgs class. Initializes a new instance of the DeploymentMangerMessageEventArgs class. Initializes a new instance of the DeploymentMangerMessageType class. Initializes a new instance of the  class. Type of the report message.The method.The message.
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
        public DeploymentMangerMessageEventArgs(DeploymentMangerMessageType reportMessageType, string method, string message)
        {
            this.ReportMessageType = reportMessageType;
            this.Method = method;
            this.Message = message;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        /// <value>The method.</value>
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the type of the report message.
        /// </summary>
        /// <value>The type of the report message.</value>
        public DeploymentMangerMessageType ReportMessageType { get; set; }

        #endregion
    }
}