namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an XDAS sub event.
    /// </summary>
    public partial class SubEvent
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SubEvent"/>.
        /// </summary>
        public SubEvent()
        {

        }

        /// <summary>
        /// A short descriptive name for this event.
        /// </summary>
        public virtual string Name { get; set; }
    }
}