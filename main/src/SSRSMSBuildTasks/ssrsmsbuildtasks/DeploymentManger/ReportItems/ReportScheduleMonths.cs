// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportScheduleMonths.cs" company="SSRSMSBuildTasks Development Team">
//   Copyright (c) 2009
// </copyright>
// <summary>
//   TODO: Update summary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ssrsmsbuildtasks.DeploymentManger.ReportItems
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ReportScheduleMonths
    {
        #region Constructors and Destructors

        /// <summary>
        ///   Initializes a new instance of the <see cref="ReportScheduleMonths" /> class.
        /// </summary>
        public ReportScheduleMonths()
        {
            this.Jan = false;
            this.Feb = false;
            this.Mar = false;
            this.Apr = false;
            this.May = false;
            this.Jun = false;
            this.Jul = false;
            this.Aug = false;
            this.Sep = false;
            this.Oct = false;
            this.Nov = false;
            this.Dec = false;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is apr.
        /// </summary>
        /// <value><c>true</c> if April; otherwise, <c>false</c>.</value>
        public bool Apr { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is aug.
        /// </summary>
        /// <value><c>true</c> if August; otherwise, <c>false</c>.</value>
        public bool Aug { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is dec.
        /// </summary>
        /// <value><c>true</c> if December; otherwise, <c>false</c>.</value>
        public bool Dec { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is feb.
        /// </summary>
        /// <value><c>true</c> if February; otherwise, <c>false</c>.</value>
        public bool Feb { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is jan.
        /// </summary>
        /// <value><c>true</c> if January; otherwise, <c>false</c>.</value>
        public bool Jan { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is jul.
        /// </summary>
        /// <value><c>true</c> if July; otherwise, <c>false</c>.</value>
        public bool Jul { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is jun.
        /// </summary>
        /// <value><c>true</c> if June; otherwise, <c>false</c>.</value>
        public bool Jun { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is mar.
        /// </summary>
        /// <value><c>true</c> if March; otherwise, <c>false</c>.</value>
        public bool Mar { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is may.
        /// </summary>
        /// <value><c>true</c> if May; otherwise, <c>false</c>.</value>
        public bool May { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is nov.
        /// </summary>
        /// <value><c>true</c> if November; otherwise, <c>false</c>.</value>
        public bool Nov { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is oct.
        /// </summary>
        /// <value><c>true</c> if October; otherwise, <c>false</c>.</value>
        public bool Oct { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is sep.
        /// </summary>
        /// <value><c>true</c> if September; otherwise, <c>false</c>.</value>
        public bool Sep { get; set; }

        #endregion
    }
}