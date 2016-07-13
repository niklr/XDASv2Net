namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an XDAS observer.
    /// </summary>
    public partial class Observer
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Observer"/>.
        /// </summary>
        public Observer()
        {

        }

        /// <summary>
        /// The account of the user or service that is observing the event.
        /// </summary>
        public virtual Account Account { get; set; }

        /// <summary>
        /// The entity that is observing the event. In many cases this will be the target service itself.
        /// </summary>
        public virtual Entity Entity { get; set; }
    }
}