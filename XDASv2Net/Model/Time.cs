using System.ComponentModel.DataAnnotations;

namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of the time.
    /// </summary>
    public partial class Time
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Time"/>.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Milliseconds since Jan 1, 1970.
        /// </summary>
        [Required]
        public virtual int Offset { get; set; }

        /// <summary>
        /// Milliseconds since last integral second.
        /// </summary>
        public virtual int? Sequence { get; set; }

        /// <summary>
        /// A tolerance value in milliseconds.
        /// </summary>
        public virtual int? Tolerance { get; set; }

        /// <summary>
        /// Percentage certainty of tolerance.
        /// </summary>
        [Range(0, 100)]
        public virtual int? Certainty { get; set; }

        /// <summary>
        /// The time source (eg., ntp://time.nist.gov).
        /// </summary>
        public virtual string Source { get; set; }

        /// <summary>
        /// A valid timezone symbol (eg., MST/MDT).
        /// </summary>
        public virtual string Zone { get; set; }
    }
}