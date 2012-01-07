// -----------------------------------------------------------------------
// <copyright file="ReportScheduleWeekDays.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    /// <summary>
    ///   TODO: Update summary.
    /// </summary>
    public class ReportScheduleWeekDays
    {
        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the <see cref="ReportScheduleWeekDays" /> class.
        /// </summary>
        public ReportScheduleWeekDays()
        {
            this.Mon = false;
            this.Tue = false;
            this.Wed = false;
            this.Thu = false;
            this.Fri = false;
            this.Sat = false;
            this.Sun = false;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleWeekDays"/> is fri.
        /// </summary>
        /// <value><c>true</c> if fri; otherwise, <c>false</c>.</value>
        public bool Fri { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleWeekDays"/> is mon.
        /// </summary>
        /// <value><c>true</c> if mon; otherwise, <c>false</c>.</value>
        public bool Mon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleWeekDays"/> is sat.
        /// </summary>
        /// <value><c>true</c> if sat; otherwise, <c>false</c>.</value>
        public bool Sat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleWeekDays"/> is sun.
        /// </summary>
        /// <value><c>true</c> if sun; otherwise, <c>false</c>.</value>
        public bool Sun { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleWeekDays"/> is thu.
        /// </summary>
        /// <value><c>true</c> if thu; otherwise, <c>false</c>.</value>
        public bool Thu { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleWeekDays"/> is tue.
        /// </summary>
        /// <value><c>true</c> if tue; otherwise, <c>false</c>.</value>
        public bool Tue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleWeekDays"/> is wed.
        /// </summary>
        /// <value><c>true</c> if wed; otherwise, <c>false</c>.</value>
        public bool Wed { get; set; }

        #endregion
    }
}