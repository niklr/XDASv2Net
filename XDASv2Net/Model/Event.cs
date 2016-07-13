using System.ComponentModel.DataAnnotations;

namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an XDAS event.
    /// </summary>
    public partial class Event
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Event"/>.
        /// </summary>
        public Event()
        {

        }

        /// <summary>
        /// The XDASv2 taxonomy event identifier.
        /// </summary>
        [Required]
        [RegularExpression(@"^[0-9]+(\.[0-9]+)*$", ErrorMessage = "Invalid event identifier.")]
        public virtual string Id { get; set; }

        /// <summary>
        /// A short descriptive name for the specific event.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// A locally unique id to allow linking correlated events (i.e. belonging to the same event trail).
        /// </summary>
        public virtual string CorrelationId { get; set; }
    }
}