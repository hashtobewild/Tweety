using Newtonsoft.Json;
using System;
using Tweety.Models.Primitives;

namespace Tweety.Models.Events
{
    /// <summary>
    /// The base favorite event type
    /// </summary>
    public class FavoriteEvent
    {
        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the favorited status.
        /// </summary>
        /// <value>
        /// The favorited status.
        /// </value>
        [JsonProperty("favorited_status")]
        public TweetObject FavoritedStatus { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp (unix epoch).
        /// </summary>
        /// <value>
        /// The timestamp ms.
        /// </value>
        [JsonProperty("timestamp_ms")]
        public long TimestampMs { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [JsonProperty("user")]
        public TwitterUser User { get; set; }
    }
}