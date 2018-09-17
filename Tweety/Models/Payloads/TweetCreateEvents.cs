using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Account Activity API:
    /// Tweet status payload when any of the following actions are taken by or to the subscription user: Tweets, Retweets, Replies, @mentions, QuoteTweets
    /// https://developer.twitter.com/en/docs/accounts-and-users/subscribe-account-activity/guides/account-activity-data-objects
    /// tweet_create_events (Tweets, Retweets, Replies, @mentions, QuoteTweets)
    /// </summary>
    public class TweetCreateEvents
    {
        /// <summary>
        /// Gets or sets the tweet create events.
        /// </summary>
        /// <value>
        /// The tweet create events.
        /// </value>
        [JsonProperty("tweet_create_events")]
        public TweetObject[] CreateEvents { get; set; }

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