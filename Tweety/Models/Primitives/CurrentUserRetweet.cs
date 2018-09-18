using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Perspectival Only surfaces on methods supporting the include_my_retweet parameter, when set to true. Details the Tweet ID of the user’s own retweet (if existent) of this Tweet. 
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/tweet-object
    /// </summary>
    public class CurrentUserRetweet
    {
        /// <summary>
        /// Gets or sets the tweet identifier of the user.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the tweet identifier string.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        [JsonProperty("id_str")]
        public long IdString { get; set; }
    }
}