using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// The entities section will contain a symbols array containing an object for every $cashtag included in the Tweet body, and include an empty array if no symbol is present.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#symbols
    /// </summary>
    public class Symbol
    {
        /// <summary>
        /// An array of integers indicating the offsets within the Tweet text where the symbol/cashtag begins and ends. The first integer represents the location of the $ character in the Tweet text string. The second integer represents the location of the first character after the cashtag. Therefore the difference between the two numbers will be the length of the hashtag name plus one (for the ‘$’ character).
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public List<int> Indices { get; set; }

        /// <summary>
        /// Name of the cashhtag, minus the leading ‘$’ character.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}