using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents a twitter url entity
    /// </summary>
    public class UrlEntity
    {
        /// <summary>
        /// Gets or sets the display URL.
        /// </summary>
        /// <value>
        /// The display URL.
        /// </value>
        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        /// <summary>
        /// Gets or sets the expanded URL.
        /// </summary>
        /// <value>
        /// The expanded URL.
        /// </value>
        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        /// <summary>
        /// Gets or sets the indices.
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}