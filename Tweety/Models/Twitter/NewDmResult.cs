using Newtonsoft.Json;
using Tweety.Models.Events;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents the result of a twitter direct message
    /// </summary>
    public class NewDmResult
    {
        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        /// <value>
        /// The event.
        /// </value>
        [JsonProperty("@event")]
        public DirectMessageEvent @event { get; set; }
    }
}