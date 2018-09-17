using Newtonsoft.Json;
using Tweety.Models.Events;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents a twitter direct message object
    /// </summary>
    public class NewDirectMessageObject
    {
        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        /// <value>
        /// The event.
        /// </value>
        [JsonProperty("@event")]
        public Event @event { get; set; }
    }
}