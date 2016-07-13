namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an XDAS account.
    /// </summary>
    public partial class Account
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Account"/>.
        /// </summary>
        public Account()
        {

        }

        /// <summary>
        /// A (URL) reference to the authority managing this account.
        /// </summary>
        public virtual string Domain { get; set; }

        /// <summary>
        /// A human-readable account name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// A machine-readable unique account identifier value.
        /// </summary>
        public virtual int? Id { get; set; }
    }
}