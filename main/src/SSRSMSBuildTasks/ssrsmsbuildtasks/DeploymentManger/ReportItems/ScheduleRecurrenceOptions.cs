// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScheduleRecurrenceOptions.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Schedule Recurrence Enum
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    /// <summary>
    /// Schedule Recurrence Enum
    /// </summary>
    public enum ScheduleRecurrenceOptions
    {
        /// <summary>
        ///   Minute Recurrence
        /// </summary>
        Min = 0, 

        /// <summary>
        ///   Daily Recurrence
        /// </summary>
        Daily = 1, 

        /// <summary>
        ///   Weekly Recurrence
        /// </summary>
        Weekly = 2, 

        /// <summary>
        ///   Monthly Recurrence
        /// </summary>
        Monthly = 3, 

        /// <summary>
        ///   Monthly DOW Recurrence
        /// </summary>
        MonthlyDOW = 4
    }
}