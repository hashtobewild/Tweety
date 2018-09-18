using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Represents a twitter hashtag entity. The entities section will contain a hashtags array containing an object for every hashtag included in the Tweet body, and include an empty array if no hashtags are present.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#hashtags
    /// </summary>
    public class Hashtag
    {
        /// <summary>
        /// An array of integers indicating the offsets within the Tweet text where the hashtag begins and ends. The first integer represents the location of the # character in the Tweet text string. The second integer represents the location of the first character after the hashtag. Therefore the difference between the two numbers will be the length of the hashtag name plus one (for the ‘#’ character).
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public List<int> Indices { get; set; }

        /// <summary>
        /// Name of the hashtag, minus the leading ‘#’ character.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}