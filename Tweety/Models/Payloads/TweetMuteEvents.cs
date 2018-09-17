using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Account Activity API:
    /// Mute event with the user and target.
    /// https://developer.twitter.com/en/docs/accounts-and-users/subscribe-account-activity/guides/account-activity-data-objects
    /// mute_events
    /// </summary>
    public class TweetMuteEvents
    {
        /// <summary>
        /// Gets or sets the for user (recipient) identifier.
        /// </summary>
        /// <value>
        /// For user identifier.
        /// </value>
        [JsonProperty("for_user_id")]
        public string ForUserId { get; set; }

        /// <summary>
        /// Gets or sets the tweet events.
        /// </summary>
        /// <value>
        /// The tweet events.
        /// </value>
        [JsonProperty("mute_events")]
        public BaseUserEvent[] MuteEvents { get; set; }
    }
}