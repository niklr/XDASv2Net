using System.Collections.Generic;

namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an XDAS target.
    /// </summary>
    public partial class Target
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Target"/>.
        /// </summary>
        public Target()
        {

        }

        /// <summary>
        /// In case the target is an account, the account fields should be filled in.
        /// </summary>
        public virtual Account Account { get; set; }

        /// <summary>
        /// The entity (system) the event targets. E.g. If an admin creates a new account in IDM, IDM is the target entity.
        /// </summary>
        public virtual Entity Entity { get; set; }

        /// <summary>
        /// A set attribute/value pairs describing the target object.
        /// </summary>
        public virtual Dictionary<string, string> Data { get; set; }
    }
}