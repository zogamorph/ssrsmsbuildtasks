// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerMessage.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Deployment Manger Message
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    /// <summary>
    /// Deployment Manger Message
    /// </summary>
    public delegate void DeploymentMangerMessage(object sender, DeploymentMangerMessageEventArgs eventArgs);
}