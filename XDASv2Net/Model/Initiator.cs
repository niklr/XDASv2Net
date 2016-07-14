using System.Collections.Generic;

namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an XDAS initiator.
    /// </summary>
    public partial class Initiator
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Initiator"/>.
        /// </summary>
        public Initiator()
        {

        }

        /// <summary>
        /// The account of the user or entity that initiated the event.
        /// </summary>
        public virtual Account Account { get; set; }

        /// <summary>
        /// The entity (system) from which the event was triggered.
        /// </summary>
        public virtual Entity Entity { get; set; }

        /// <summary>
        /// Attribute/value assertions about an identity.
        /// </summary>
        public virtual object Assertions { get; set; }
    }
}