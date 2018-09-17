using Newtonsoft.Json;
using System;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Tweet deletion event object
    /// </summary>
    public class DeleteEvent
    {
        /// <summary>
        /// Gets or sets the deletion status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonProperty("status")]
        public DeleteStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the timestamp in ms.
        /// </summary>
        /// <value>
        /// The timestamp ms.
        /// </value>
        [JsonProperty("timestamp_ms")]
        public DateTime TimestampMs { get; set; }
    }
}