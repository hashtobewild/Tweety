using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Account Activity API:
    /// Block event with the user and target.
    /// https://developer.twitter.com/en/docs/accounts-and-users/subscribe-account-activity/guides/account-activity-data-objects
    /// block_events
    /// </summary>
    public class TweetBlockEvents
    {
        /// <summary>
        /// Gets or sets the tweet events.
        /// </summary>
        /// <value>
        /// The tweet events.
        /// </value>
        [JsonProperty("block_events")]
        public BaseUserEvent[] BlockEvents { get; set; }

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