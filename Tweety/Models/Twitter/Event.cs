using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents a twitter event
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets or sets the message create.
        /// </summary>
        /// <value>
        /// The message create.
        /// </value>
        [JsonProperty("message_create")]
        public NewEvent_MessageCreate MessageCreate { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}