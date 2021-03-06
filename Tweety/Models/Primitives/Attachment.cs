﻿using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Represents a twitter attachment
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        /// <value>
        /// The media.
        /// </value>
        [JsonProperty("media")]
        public Media Media { get; set; }

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