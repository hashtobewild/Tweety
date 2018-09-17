﻿using Newtonsoft.Json;
using System;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// A base class for inter user events
    /// </summary>
    public class BaseUserEvent
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
        /// Gets or sets the type of the event.
        /// </summary>
        /// <value>
        /// The type of the event.
        /// </value>
        [JsonProperty("type")]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonProperty("source")]
        public UserObject Source { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        [JsonProperty("target")]
        public UserObject Target { get; set; }
    }
}