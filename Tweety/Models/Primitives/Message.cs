using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Represents a twitter message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Gets or sets the message data.
        /// </summary>
        /// <value>
        /// The message data.
        /// </value>
        [JsonProperty("message_data")]
        public MessageData MessageData { get; set; }

        /// <summary>
        /// Gets or sets the sender identifier.
        /// </summary>
        /// <value>
        /// The sender identifier.
        /// </value>
        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        /// <summary>
        /// Gets or sets the source application identifier.
        /// </summary>
        /// <value>
        /// The source application identifier.
        /// </value>
        [JsonProperty("source_app_id")]
        public string SourceAppId { get; set; }

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