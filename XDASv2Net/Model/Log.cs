namespace XDASv2Net.Model
{
    /// <summary>
    /// Client-specified logging attributes.
    /// </summary>
    public partial class Log
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Log"/>.
        /// </summary>
        public Log()
        {

        }

        public int? Severity { get; set; }

        public int? Priority { get; set; }

        public int? Facility { get; set; }
    }
}