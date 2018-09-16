using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class SymbolEntity
    {
        /// <summary>
        /// Gets or sets the indices.
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}