using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Account Activity API:
    /// Notice of deleted Tweets to make it easier to maintain compliance
    /// https://developer.twitter.com/en/docs/accounts-and-users/subscribe-account-activity/guides/account-activity-data-objects
    /// tweet_delete_events
    /// </summary>
    public class TweetDeletedEvents
    {
        /// <summary>
        /// Gets or sets the tweet events.
        /// </summary>
        /// <value>
        /// The tweet events.
        /// </value>
        [JsonProperty("tweet_delete_events")]
        public DeleteEvent[] DeletedEvents { get; set; }

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