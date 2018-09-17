using Newtonsoft.Json;
using Tweety.Models.Primitives;

namespace Tweety.Models.Events
{
    /// <summary>
    /// An event indicating direct message has been read
    /// </summary>
    public class DirectMessageMarkReadEvent
    {
        /// <summary>
        /// Gets or sets the created timestamp.
        /// </summary>
        /// <value>
        /// The created timestamp.
        /// </value>
        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the last read event identifier.
        /// </summary>
        /// <value>
        /// The last read event identifier.
        /// </value>
        [JsonProperty("last_read_event_id")]
        public string LastReadEventId { get; set; }

        /// <summary>
        /// Gets or sets the sender identifier.
        /// </summary>
        /// <value>
        /// The sender identifier.
        /// </value>
        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        [JsonProperty("target")]
        public Target Target { get; set; }
    }
}