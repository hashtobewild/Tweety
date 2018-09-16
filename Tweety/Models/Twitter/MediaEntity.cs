using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class MediaEntity
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
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier string.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        [JsonProperty("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// Gets or sets the indices.
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        /// <summary>
        /// Gets or sets the media URL.
        /// </summary>
        /// <value>
        /// The media URL.
        /// </value>
        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        /// <summary>
        /// Gets or sets the media URL HTTPS.
        /// </summary>
        /// <value>
        /// The media URL HTTPS.
        /// </value>
        [JsonProperty("media_url_https")]
        public string MediaUrlHttps { get; set; }

        /// <summary>
        /// Gets or sets the sizes.
        /// </summary>
        /// <value>
        /// The sizes.
        /// </value>
        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; }

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