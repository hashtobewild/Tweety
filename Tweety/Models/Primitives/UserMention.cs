using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// The entities section will contain a user_mentions array containing an object for every user mention included in the Tweet body, and include an empty array if no user mention is present.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#mentions
    /// </summary>
    public class UserMention
    {
        /// <summary>
        /// ID of the mentioned user, as an integer
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Id of the mentioned user, as a string.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        [JsonProperty("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// An array of integers representing the offsets within the Tweet text where the user reference begins and ends. The first integer represents the location of the ‘@’ character of the user mention. The second integer represents the location of the first non-screenname character following the user mention.
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        /// <summary>
        /// Display name of the referenced user.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Screen name of the referenced user.
        /// </summary>
        /// <value>
        /// The name of the screen.
        /// </value>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }
    }
}