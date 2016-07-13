using System;

namespace XDASv2Net.Attributes
{
    public class EventInformationAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of <see cref="EventInformationAttribute"/>.
        /// </summary>
        public EventInformationAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        /// <param name="eventIdentifier">The XDASv2 taxonomy event identifier.</param>
        public EventInformationAttribute(string eventIdentifier)
        {
            EventIdentifier = eventIdentifier;
        }

        /// <summary>
        /// The XDASv2 taxonomy event identifier.
        /// </summary>
        public string EventIdentifier { get; private set; }
    }
}
