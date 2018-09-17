using Newtonsoft.Json;
using System;
using Tweety.Models.Primitives;

namespace Tweety.Models.Events
{
    /// <summary>
    /// Revoke events sent when a user removes application authorization and subscription is automatically deleted.
    /// </summary>
    public class RevokeEvent
    {
        /// <summary>
        /// Gets or sets the event date.
        /// </summary>
        /// <value>
        /// The event date.
        /// </value>
        [JsonProperty("date_time")]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or sets the source user.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonProperty("source")]
        public UserIdentifier Source { get; set; }

        /// <summary>
        /// Gets or sets the target app.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        [JsonProperty("target")]
        public AppIdentifier Target { get; set; }
    }
}