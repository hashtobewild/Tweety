using Newtonsoft.Json;
using System.Collections.Generic;
using Tweety.Models.Events;
using Tweety.Models.Primitives;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Account Activity API:
    /// Direct message status with the user and target.
    /// https://developer.twitter.com/en/docs/accounts-and-users/subscribe-account-activity/guides/account-activity-data-objects
    /// direct_message_events
    /// </summary>
    public class TweetDirectMessageEvents
    {
        /// <summary>
        /// Gets or sets the apps.
        /// </summary>
        /// <value>
        /// The apps.
        /// </value>
        [JsonProperty("apps")]
        public Dictionary<string, AppData> Apps { get; set; }

        /// <summary>
        /// Gets or sets the tweet events.
        /// </summary>
        /// <value>
        /// The tweet events.
        /// </value>
        [JsonProperty("direct_message_events")]
        public List<DirectMessageEvent> DirectMessageEvents { get; set; }

        /// <summary>
        /// Gets or sets the for user (recipient) identifier.
        /// </summary>
        /// <value>
        /// For user identifier.
        /// </value>
        [JsonProperty("for_user_id")]
        public string ForUserId { get; set; }

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