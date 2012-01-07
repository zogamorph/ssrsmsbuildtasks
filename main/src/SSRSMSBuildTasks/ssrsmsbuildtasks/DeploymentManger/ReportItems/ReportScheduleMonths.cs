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

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is apr.
        /// </summary>
        /// <value><c>true</c> if apr; otherwise, <c>false</c>.</value>
        public bool Apr { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is aug.
        /// </summary>
        /// <value><c>true</c> if aug; otherwise, <c>false</c>.</value>
        public bool Aug { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is dec.
        /// </summary>
        /// <value><c>true</c> if dec; otherwise, <c>false</c>.</value>
        public bool Dec { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is feb.
        /// </summary>
        /// <value><c>true</c> if feb; otherwise, <c>false</c>.</value>
        public bool Feb { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is jan.
        /// </summary>
        /// <value><c>true</c> if jan; otherwise, <c>false</c>.</value>
        public bool Jan { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is jul.
        /// </summary>
        /// <value><c>true</c> if jul; otherwise, <c>false</c>.</value>
        public bool Jul { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is jun.
        /// </summary>
        /// <value><c>true</c> if jun; otherwise, <c>false</c>.</value>
        public bool Jun { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is mar.
        /// </summary>
        /// <value><c>true</c> if mar; otherwise, <c>false</c>.</value>
        public bool Mar { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is may.
        /// </summary>
        /// <value><c>true</c> if may; otherwise, <c>false</c>.</value>
        public bool May { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is nov.
        /// </summary>
        /// <value><c>true</c> if nov; otherwise, <c>false</c>.</value>
        public bool Nov { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is oct.
        /// </summary>
        /// <value><c>true</c> if oct; otherwise, <c>false</c>.</value>
        public bool Oct { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ReportScheduleMonths"/> is sep.
        /// </summary>
        /// <value><c>true</c> if sep; otherwise, <c>false</c>.</value>
        public bool Sep { get; set; }

        #endregion
    }
}