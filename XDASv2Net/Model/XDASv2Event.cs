using System.ComponentModel.DataAnnotations;
using XDASv2Net.Attributes;

namespace XDASv2Net.Model
{
    /// <summary>
    /// At the heart of the model is the XDASv2Event object. This object contains a locally unique id to reference this event. 
    /// It also contains the main actors of an event: the initiator, the target and the observer of the event, along with the action undertaken.
    /// </summary>
    public partial class XDASv2Event
    {
        /// <summary>
        /// Initializes a new instance of <see cref="XDASv2Event"/>.
        /// </summary>
        public XDASv2Event()
        {

        }

        /// <summary>
        /// The original source of the event, if applicable. E.g. If a given component would convert SysLog events to XDAS, that component is the source.
        /// </summary>
        public virtual string Source { get; set; }

        /// <summary>
        /// The authenticated entity or access token that causes an event.
        /// </summary>
        [Required, ValidateObject]
        public virtual Initiator Initiator { get; set; }

        /// <summary>
        /// The target object, account, data item, etc of the event.
        /// </summary>
        public virtual Target Target { get; set; }

        /// <summary>
        /// The recorder (ie., the XDASv2 service) of the event.
        /// </summary>
        [Required, ValidateObject]
        public virtual Observer Observer { get; set; }

        /// <summary>
        /// The action describes the event in a uniform manner.
        /// </summary>
        [Required, ValidateObject]
        public virtual Action Action { get; set; }
    }
}