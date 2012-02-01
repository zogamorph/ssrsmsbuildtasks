// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportSchedule.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Schedule Recurrence Enum
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    #region Directives

    using System;

    #endregion

    /// <summary>
    /// Schedule Recurrence Enum
    /// </summary>
    public enum ScheduleRecurrenceEnum
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

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ReportSchedule
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportSchedule"/> class.
        /// </summary>
        public ReportSchedule()
        {
            this.EndDateTime = DateTime.MinValue;
            this.StartDateTime = DateTime.Now;
            this.Days = new ReportScheduleWeekDays();
            this.Months = new ReportScheduleMonths();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the days.
        /// </summary>
        /// <value>The days.</value>
        public ReportScheduleWeekDays Days { get; private set; }

        /// <summary>
        ///   Gets or sets the end time.
        /// </summary>
        /// <value> The end time. </value>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        ///   Gets or sets the minutes interval.
        /// </summary>
        /// <value> The minutes interval. </value>
        public string Interval { get; set; }

        /// <summary>
        /// Gets or sets the months.
        /// </summary>
        /// <value>The months.</value>
        public ReportScheduleMonths Months { get; private set; }

        /// <summary>
        ///   Gets or sets the name.
        /// </summary>
        /// <value> The name. </value>
        public string Name { get; set; }

        /// <summary>
        ///   Gets or sets the schedule recurrence.
        /// </summary>
        /// <value> The schedule recurrence. </value>
        public ScheduleRecurrenceEnum ScheduleRecurrence { get; set; }

        /// <summary>
        ///   Gets or sets the start date time.
        /// </summary>
        /// <value> The start date time. </value>
        public DateTime StartDateTime { get; set; }

        #endregion
    }
}