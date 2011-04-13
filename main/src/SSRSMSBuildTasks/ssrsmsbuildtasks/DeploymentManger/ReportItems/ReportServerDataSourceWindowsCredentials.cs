// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportServerDataSourceWindowsCredentials.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   This to create store windows credentials.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    /// <summary>
    /// This to create store windows credentials.
    /// </summary>
    public sealed class ReportServerDataSourceWindowsCredentials
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the ReportServerDataSourceWindowsCredentials class. Initializes a new instance of the ReportServerDataSourceWindowsCredentials class. Initializes a new instance of the ReportServerDataSourceWindowsCredentials class. Initializes a new instance of the  class. Name of the user.The pass word.
        /// </summary>
        /// <param name="userName">
        /// Name of the user.
        /// </param>
        /// <param name="passWord">
        /// The pass word.
        /// </param>
        public ReportServerDataSourceWindowsCredentials(string userName, string passWord)
        {
            this.UserName = userName;
            this.PassWord = passWord;
        }

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets the pass word.
        /// </summary>
        /// <value>The pass word.</value>
        public string PassWord { get; set; }

        /// <summary>
        ///   Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }

        #endregion
    }
}