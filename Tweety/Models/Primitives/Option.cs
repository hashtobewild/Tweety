using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// A poll option
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#polls
    /// </summary>
    public class Option
    {
        /// <summary>
        /// Gets or sets the position of the option in the poll.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the option text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}