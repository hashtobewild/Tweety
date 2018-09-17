using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Account Activity API:
    /// Follow event with the user and target.
    /// https://developer.twitter.com/en/docs/accounts-and-users/subscribe-account-activity/guides/account-activity-data-objects
    /// follow_events
    /// </summary>
    public class TweetFollowEvents
    {
        /// <summary>
        /// Gets or sets the tweet create events.
        /// </summary>
        /// <value>
        /// The tweet create events.
        /// </value>
        [JsonProperty("follow_events")]
        public BaseUserEvent[] FollowEvents { get; set; }

        /// <summary>
        /// Gets or sets the for user (recipient) identifier.
        /// </summary>
        /// <value>
        /// For user identifier.
        /// </value>
        [JsonProperty("for_user_id")]
        public string ForUserId { get; set; }
    }
}