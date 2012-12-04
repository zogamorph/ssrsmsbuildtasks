// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateReportSchedule.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   Creates Report Server Shared Schedule
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.RS2008R2
{
    #region Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Microsoft.Build.Framework;
    using Microsoft.Build.Utilities;

    using ssrsmsbuildtasks.DeploymentManger;
    using ssrsmsbuildtasks.DeploymentManger.ReportItems;

    #endregion

    /// <summary>
    /// Creates Report Server Shared Schedule 
    /// </summary>
    public class CreateReportSchedule : Task
    {
        #region Constants and Fields

        /// <summary>
        /// The vaild days of week.
        /// </summary>
        private readonly List<string> vaildDaysOfWeek;

        /// <summary>
        /// The vaild months of year.
        /// </summary>
        private readonly List<string> vaildMonthsOfYear;

        /// <summary>
        /// The vaild schedule recurrence.
        /// </summary>
        private readonly List<string> vaildScheduleRecurrence;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReportSchedule"/> class.
        /// </summary>
        public CreateReportSchedule()
        {
            this.vaildScheduleRecurrence = new List<string>() { "Min", "Daily", "Weekly", "Monthly", "MonthlyDOW" };
            this.vaildDaysOfWeek = new List<string>() { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            this.vaildMonthsOfYear = new List<string>()
                {
                    "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" 
                };
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets ReportingSite.
        /// </summary>
        public string ReportingSite { get; set; }

        /// <summary>
        ///   Gets or sets the report schedules.
        /// </summary>
        /// <value>The report schedules.</value>
        /// <remarks>
        ///   Name of the report schedules is set by the Include
        ///   Creating a data source requires the following meta data: 
        ///   StartDateTime - The Starting datetime of the schedules.
        ///   ScheduleRecurrence - The schedule recurrence valid options are: "Min", "Daily", "Weekly", "Monthly", "MonthlyDOW" 
        ///   Interval - Interval of for the recurrence Min requires HH:MM, Daily requires the nuober days,  Monthly requires the days of the month to run it on 6, 10-14, 20
        ///    optional for  Weekly a number of weekly interval
        ///    and for MonthlyDOW which week to run the schedule 1st, 2nd, 3rd, 4th, Last
        ///   MonthsOfYear - Months of the year to run the "Monthly", "MonthlyDOW" Recurrence: Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec
        ///   DaysOfWeek  - Days of the week to run the  "Weekly", "MonthlyDOW" Recurrence: Mon, Tue, Wed, Thu, Fri, Sat, Sun
        ///  The optional meta data 
        ///     EndDateTime - for setting the EndDateTime of the schedule
        /// </remarks>
        [Required]
        public ITaskItem[] ReportSchedules { get; set; }

        /// <summary>
        ///   Gets or sets the report server URL.
        /// </summary>
        /// <value>The report server URL.</value>
        [Required]
        public string ReportServerURL { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The execute.
        /// </summary>
        /// <returns>
        /// The execute.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <exception cref="FormatException">
        /// </exception>
        public override bool Execute()
        {
            R2DeploymentManger r2DeploymentManger = new R2DeploymentManger(this.ReportServerURL);
            r2DeploymentManger.DeploymentMangerMessages += this.deploymentMangerMessages;
            ReportSchedule[] reportSchedules = new ReportSchedule[this.ReportSchedules.Length];
            string invaildReportScheduleMessage;
            DateTime reportScheduleDateTime;

            try
            {
                for (int index = 0; index < this.ReportSchedules.Length; index++)
                {
                    if (!this.isVaildReportSchedule(this.ReportSchedules[index], out invaildReportScheduleMessage))
                    {
                        throw new Exception(invaildReportScheduleMessage);
                    }

                    reportSchedules[index] = new ReportSchedule();
                    reportSchedules[index].Name = this.ReportSchedules[index].ItemSpec;

                    if (
                        !DateTime.TryParse(
                             this.ReportSchedules[index].GetMetadata("StartDateTime"), out reportScheduleDateTime))
                    {
                        throw new FormatException(
                            string.Format(
                                "Report Schedule {0} StartDateTime is not vaild ", this.ReportSchedules[index].ItemSpec));
                    }

                    reportSchedules[index].StartDateTime = reportScheduleDateTime;

                    if (!string.IsNullOrEmpty(this.ReportSchedules[index].GetMetadata("EndDateTime")))
                    {
                        if (
                            !DateTime.TryParse(
                                 this.ReportSchedules[index].GetMetadata("EndDateTime"), out reportScheduleDateTime))
                        {
                            throw new FormatException(
                                string.Format(
                                    "Report Schedule {0} EndDateTime is not vaild ", 
                                    this.ReportSchedules[index].ItemSpec));
                        }

                        reportSchedules[index].EndDateTime = reportScheduleDateTime;
                    }

                    reportSchedules[index].ScheduleRecurrence =
                        (ScheduleRecurrenceOptions)
                        Enum.Parse(
                            typeof(ScheduleRecurrenceOptions), 
                            this.ReportSchedules[index].GetMetadata("ScheduleRecurrence"), 
                            true);

                    switch (reportSchedules[index].ScheduleRecurrence)
                    {
                        case ScheduleRecurrenceOptions.Min:
                        case ScheduleRecurrenceOptions.Daily:
                            reportSchedules[index].Interval = this.ReportSchedules[index].GetMetadata("Interval");
                            break;
                        case ScheduleRecurrenceOptions.Weekly:
                            this.GetDaysOfWeek(
                                reportSchedules[index].Days, this.ReportSchedules[index].GetMetadata("DaysOfWeek"));
                            if (!string.IsNullOrEmpty(this.ReportSchedules[index].GetMetadata("Interval")))
                            {
                                reportSchedules[index].Interval = this.ReportSchedules[index].GetMetadata("Interval");
                            }

                            break;
                        case ScheduleRecurrenceOptions.Monthly:
                            this.GetMonthsOfYear(
                                reportSchedules[index].Months, this.ReportSchedules[index].GetMetadata("MonthsOfYear"));
                            if (!string.IsNullOrEmpty(this.ReportSchedules[index].GetMetadata("Interval")))
                            {
                                reportSchedules[index].Interval = this.ReportSchedules[index].GetMetadata("Interval");
                            }

                            break;
                        case ScheduleRecurrenceOptions.MonthlyDOW:
                            this.GetDaysOfWeek(
                                reportSchedules[index].Days, this.ReportSchedules[index].GetMetadata("DaysOfWeek"));
                            this.GetMonthsOfYear(
                                reportSchedules[index].Months, this.ReportSchedules[index].GetMetadata("MonthsOfYear"));
                            if (!string.IsNullOrEmpty(this.ReportSchedules[index].GetMetadata("Interval")))
                            {
                                reportSchedules[index].Interval = this.ReportSchedules[index].GetMetadata("Interval");
                            }

                            break;
                    }
                }

                return r2DeploymentManger.CreateSchedules(reportSchedules, this.ReportingSite);
            }
            catch (Exception ex)
            {
                this.BuildEngine.LogErrorEvent(
                    new BuildErrorEventArgs(
                        "Reporting", 
                        "CreateReportSchedule", 
                        this.BuildEngine.ProjectFileOfTaskNode, 
                        this.BuildEngine.LineNumberOfTaskNode, 
                        this.BuildEngine.ColumnNumberOfTaskNode, 
                        0, 
                        0, 
                        ex.Message, 
                        string.Empty, 
                        this.ToString()));
                return false;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The reporting services message.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
        private void deploymentMangerMessages(object sender, DeploymentMangerMessageEventArgs eventArgs)
        {
            RSBuildHelper.SendDeploymentMangerMessage(eventArgs, this.BuildEngine, this.ToString());
        }

        /// <summary>
        /// Gets the days of week.
        /// </summary>
        /// <param name="days">
        /// The of week string.
        /// </param>
        /// <param name="daysOfWeekString">
        /// The days of week string.
        /// </param>
        private void GetDaysOfWeek(ReportScheduleWeekDays days, string daysOfWeekString)
        {
            foreach (string dayOfWeek in daysOfWeekString.Split(';'))
            {
                switch (dayOfWeek)
                {
                    case "Mon":
                        days.Mon = true;
                        break;
                    case "Tue":
                        days.Tue = true;
                        break;
                    case "Wed":
                        days.Wed = true;
                        break;
                    case "Thu":
                        days.Thu = true;
                        break;
                    case "Fri":
                        days.Fri = true;
                        break;
                    case "Sat":
                        days.Sat = true;
                        break;
                    case "Sun":
                        days.Sun = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the months of year.
        /// </summary>
        /// <param name="months">
        /// The months.
        /// </param>
        /// <param name="monthsOfYearString">
        /// The months of year string.
        /// </param>
        private void GetMonthsOfYear(ReportScheduleMonths months, string monthsOfYearString)
        {
            foreach (string monthOfYear in monthsOfYearString.Split(';'))
            {
                switch (monthOfYear)
                {
                    case "Jan":
                        months.Jan = true;
                        break;
                    case "Feb":
                        months.Feb = true;
                        break;
                    case "Mar":
                        months.Mar = true;
                        break;
                    case "Apr":
                        months.Apr = true;
                        break;
                    case "May":
                        months.May = true;
                        break;
                    case "Jun":
                        months.Jun = true;
                        break;
                    case "Jul":
                        months.Jul = true;
                        break;
                    case "Aug":
                        months.Aug = true;
                        break;
                    case "Sep":
                        months.Sep = true;
                        break;
                    case "Oct":
                        months.Oct = true;
                        break;
                    case "Nov":
                        months.Nov = true;
                        break;
                    case "Dec":
                        months.Dec = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Determines whether the specified report schedule has interval.
        /// </summary>
        /// <param name="reportSchedule">
        /// The report schedule.
        /// </param>
        /// <param name="invalidReportScheduleMessageStringBuilder">
        /// The invalid report schedule message string builder.
        /// </param>
        /// <returns>
        /// <c>true</c> if the specified report schedule has interval; otherwise, <c>false</c>.
        /// </returns>
        private bool hasInterval(ITaskItem reportSchedule, StringBuilder invalidReportScheduleMessageStringBuilder)
        {
            bool isVaild = true;
            if (string.IsNullOrEmpty(reportSchedule.GetMetadata("Interval")))
            {
                isVaild = false;
                invalidReportScheduleMessageStringBuilder.AppendLine(
                    string.Format("{0}:Missing Interval Metadata", reportSchedule.ItemSpec));
            }

            return isVaild;
        }

        /// <summary>
        /// Determines whether [has vaild day of week] [the specified report schedule].
        /// </summary>
        /// <param name="reportSchedule">
        /// The report schedule.
        /// </param>
        /// <param name="invalidReportScheduleMessageStringBuilder">
        /// The invalid report schedule message string builder.
        /// </param>
        /// <param name="recurrenceName">
        /// Name of the recurrence.
        /// </param>
        /// <returns>
        /// <c>true</c> if [has vaild day of week] [the specified report schedule]; otherwise, <c>false</c>.
        /// </returns>
        private bool hasVaildDayOfWeek(
            ITaskItem reportSchedule, StringBuilder invalidReportScheduleMessageStringBuilder, string recurrenceName)
        {
            bool isVaild = true;
            if (string.IsNullOrEmpty(reportSchedule.GetMetadata("DaysOfWeek")))
            {
                isVaild = false;
                invalidReportScheduleMessageStringBuilder.AppendLine(
                    string.Format(
                        "{0}:Missing DaysOfWeek Metadata for {1} Recurrence", reportSchedule.ItemSpec, recurrenceName));
            }
            else
            {
                if (
                    !reportSchedule.GetMetadata("DaysOfWeek").Split(new[] { ';' }).All(
                         dayOfWeek => this.vaildDaysOfWeek.Any(e => e.Equals(dayOfWeek))))
                {
                    string vaildDaysOfWeekToString =
                        this.vaildDaysOfWeek.Aggregate(
                            (workingString, dayOfweek) => string.Format("{0},{1}", workingString, dayOfweek));
                    isVaild = false;
                    invalidReportScheduleMessageStringBuilder.AppendLine(
                        string.Format(
                            "{0}:ScheduleRecurrence is not vaild (vaild values are: {1} )", 
                            reportSchedule.ItemSpec, 
                            vaildDaysOfWeekToString));
                }
            }

            return isVaild;
        }

        /// <summary>
        /// Determines whether [has vaild months] [the specified report schedule].
        /// </summary>
        /// <param name="reportSchedule">
        /// The report schedule.
        /// </param>
        /// <param name="invalidReportScheduleMessageStringBuilder">
        /// The invalid report schedule message string builder.
        /// </param>
        /// <param name="recurrenceName">
        /// Name of the recurrence.
        /// </param>
        /// <returns>
        /// <c>true</c> if [has vaild months] [the specified report schedule]; otherwise, <c>false</c>.
        /// </returns>
        private bool hasVaildMonths(
            ITaskItem reportSchedule, StringBuilder invalidReportScheduleMessageStringBuilder, string recurrenceName)
        {
            bool isVaild = true;
            if (string.IsNullOrEmpty(reportSchedule.GetMetadata("MonthsOfYear")))
            {
                isVaild = false;
                invalidReportScheduleMessageStringBuilder.AppendLine(
                    string.Format(
                        "{0}:Missing MonthsOfYear Metadata for {1} Recurrence", reportSchedule.ItemSpec, recurrenceName));
            }
            else
            {
                if (
                    !reportSchedule.GetMetadata("MonthsOfYear").Split(new[] { ';' }).All(
                         monthOfYear => this.vaildMonthsOfYear.Any(e => e.Equals(monthOfYear))))
                {
                    string vaildMonthsOfYearToString =
                        this.vaildMonthsOfYear.Aggregate(
                            (workingString, monthOfYear) => string.Format("{0},{1}", workingString, monthOfYear));
                    isVaild = false;
                    invalidReportScheduleMessageStringBuilder.AppendLine(
                        string.Format(
                            "{0}:ScheduleRecurrence is not vaild (vaild values are: {1} )", 
                            reportSchedule.ItemSpec, 
                            vaildMonthsOfYearToString));
                }
            }

            return isVaild;
        }

        /// <summary>
        /// Determines whether [is vaild report schedule] [the specified report schedule].
        /// </summary>
        /// <param name="reportSchedule">
        /// The report schedule.
        /// </param>
        /// <param name="invaildDataourceMessage">
        /// The invaild dataource message.
        /// </param>
        /// <returns>
        /// <c>true</c> if [is vaild report schedule] [the specified report schedule]; otherwise, <c>false</c>.
        /// </returns>
        private bool isVaildReportSchedule(ITaskItem reportSchedule, out string invaildDataourceMessage)
        {
            StringBuilder invalidReportScheduleMessageStringBuilder = new StringBuilder();
            bool isVaild = true;

            if (string.IsNullOrEmpty(reportSchedule.GetMetadata("StartDateTime")))
            {
                isVaild = false;
                invalidReportScheduleMessageStringBuilder.AppendLine(
                    string.Format("{0}:Missing Folder Metadata", reportSchedule.ItemSpec));
            }

            if (string.IsNullOrEmpty(reportSchedule.GetMetadata("ScheduleRecurrence")))
            {
                isVaild = false;
                invalidReportScheduleMessageStringBuilder.AppendLine(
                    string.Format("{0}:Missing Folder Metadata", reportSchedule.ItemSpec));
            }
            else
            {
                if (!this.vaildScheduleRecurrence.Any(e => e.Equals(reportSchedule.GetMetadata("ScheduleRecurrence"))))
                {
                    string vaildScheduleRecurrenceToString =
                        this.vaildScheduleRecurrence.Aggregate(
                            (workingString, scheduleRecurrence) =>
                            string.Format("{0},{1}", workingString, scheduleRecurrence));
                    isVaild = false;
                    invalidReportScheduleMessageStringBuilder.AppendLine(
                        string.Format(
                            "{0}:ScheduleRecurrence is not vaild (vaild values are: {1} )", 
                            reportSchedule.ItemSpec, 
                            vaildScheduleRecurrenceToString));
                }

                switch (reportSchedule.GetMetadata("ScheduleRecurrence"))
                {
                    case "Min":
                    case "Daily":
                        isVaild = isVaild && this.hasInterval(reportSchedule, invalidReportScheduleMessageStringBuilder);
                        break;
                    case "Weekly":
                        isVaild = isVaild &&
                                  this.hasVaildDayOfWeek(
                                      reportSchedule, invalidReportScheduleMessageStringBuilder, "Weekly");
                        break;
                    case "Monthly":
                        isVaild = isVaild && this.hasInterval(reportSchedule, invalidReportScheduleMessageStringBuilder);
                        isVaild = isVaild &&
                                  this.hasVaildMonths(
                                      reportSchedule, invalidReportScheduleMessageStringBuilder, "Monthly");
                        break;
                    case "MonthlyDOW":
                        isVaild = isVaild &&
                                  this.hasVaildDayOfWeek(
                                      reportSchedule, invalidReportScheduleMessageStringBuilder, "MonthlyDOW");
                        isVaild = isVaild &&
                                  this.hasVaildMonths(
                                      reportSchedule, invalidReportScheduleMessageStringBuilder, "MonthlyDOW");
                        break;
                }
            }

            invaildDataourceMessage = invalidReportScheduleMessageStringBuilder.ToString();
            return isVaild;
        }

        #endregion
    }
}