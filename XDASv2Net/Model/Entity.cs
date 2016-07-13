namespace XDASv2Net.Model
{
    /// <summary>
    /// A representation of an addressable XDAS entity.
    /// </summary>
    public partial class Entity
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Entity"/>.
        /// </summary>
        public Entity()
        {

        }

        /// <summary>
        /// The address of the entity. For hosts this is the IP address.
        /// </summary>
        public virtual string SysAddr { get; set; }

        /// <summary>
        /// The name of the enity. For hosts this is the hostname.
        /// </summary>
        public virtual string SysName { get; set; }

        /// <summary>
        /// The service name.
        /// </summary>
        public virtual string SvcName { get; set; }

        /// <summary>
        /// The component name that exists in the service.
        /// </summary>
        public virtual string SvcComp { get; set; }
    }
}