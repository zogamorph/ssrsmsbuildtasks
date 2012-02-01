// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommonAssemblyInfo.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   CommonAssemblyInfo.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region Directives

using System.Reflection;

#endregion

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]

#else 

[assembly: System.Reflection.AssemblyConfiguration("Release")]

#endif

[assembly: AssemblyCompany("SSRSMSBuildTasks Development Team")]
[assembly: AssemblyProduct("SSRSMSBuildTasks")]
[assembly: AssemblyCopyright("Copyright © 2009")]