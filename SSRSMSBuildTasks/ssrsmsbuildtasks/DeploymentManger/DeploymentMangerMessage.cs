// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeploymentMangerMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Delegate to handle sending message between.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger
{
    /// <summary>
    /// Delegate to handle sending message between.
    /// </summary>
    /// <param name="sender">
    /// The sender object.
    /// </param>
    /// <param name="eventArgs">
    /// The report server message event argumnets.
    /// </param>
    public delegate void DeploymentMangerMessage(object sender, DeploymentMangerMessageEventArgs eventArgs);
}