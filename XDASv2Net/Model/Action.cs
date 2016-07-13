using System.ComponentModel.DataAnnotations;
using XDASv2Net.Attributes;

namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an XDAS action.
    /// </summary>
    public partial class Action
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Action"/>.
        /// </summary>
        public Action()
        {

        }

        /// <summary>
        /// The event identifier in standard XDASv2 taxonomy.
        /// </summary>
        [Required, ValidateObject]
        public virtual Event Event { get; set; }

        /// <summary>
        /// Describes the actual domain specific event that has occurred.
        /// </summary>
        public virtual SubEvent SubEvent { get; set; }

        /// <summary>
        /// Client-specified logging attributes.
        /// </summary>
        public virtual Log Log { get; set; }

        /// <summary>
        /// The time the event occurred.
        /// </summary>
        [Required, ValidateObject]
        public virtual Time Time { get; set; }

        /// <summary>
        /// The XDASv2 taxonomy outcome identifier.
        /// 
        /// The outcome code is a hierarchical numeric value much like the event code. Outcome codes indicate
        /// success or a failure class and reason.The success hierarchy is encapsulated by the 0.x sub-arc.
        /// Failure classes are represented by the 1.x hierarchy.Denial codes are represented by the 2.x hierarchy.
        /// </summary>
        [Required]
        [RegularExpression(@"^[0-9]+(\.[0-9]+)*$", ErrorMessage = "Invalid outcome code.")]
        public virtual string Outcome { get; set; }

        /// <summary>
        /// The XDASv2 taxonomy outcome identifier.
        /// 
        /// The outcome code is a hierarchical numeric value much like the event code. Outcome codes indicate
        /// success or a failure class and reason.The success hierarchy is encapsulated by the 0.x sub-arc.
        /// Failure classes are represented by the 1.x hierarchy.Denial codes are represented by the 2.x hierarchy.
        /// </summary>
        [Required]
        [RegularExpression(@"^[0-9]+(\.[0-9]+)*$", ErrorMessage = "Invalid extended outcome code.")]
        public virtual string ExtendedOutcome { get; set; }
    }
}