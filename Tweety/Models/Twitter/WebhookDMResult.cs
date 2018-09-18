using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Tweety.Models.Events;
using Tweety.Models.Primitives;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents the result of a direct message webhook
    /// </summary>
    public class WebhookDMResult
    {
        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>
        /// The events.
        /// </value>
        [JsonProperty("direct_message_events")]
        public List<DirectMessageEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        [JsonProperty("users")]
        public Dictionary<string, User> Users { get; set; }

    }
}