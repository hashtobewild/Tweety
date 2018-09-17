using Newtonsoft.Json;
using System;
using Tweety.Models.Primitives;

namespace Tweety.Models.Events
{
    /// <summary>
    /// Represents a direct message event
    /// </summary>
    public class DirectMessageEvent
    {
        /// <summary>
        /// Gets or sets the created timestamp.
        /// </summary>
        /// <value>
        /// The created timestamp.
        /// </value>
        [JsonProperty("created_timestamp")]
        public DateTime CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the message create.
        /// </summary>
        /// <value>
        /// The message create.
        /// </value>
        [JsonProperty("message_create")]
        public Message MessageCreate { get; set; }

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