// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerMessageType.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Report Server Messages Types.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
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
}