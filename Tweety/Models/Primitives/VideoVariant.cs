using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    public class VideoVariant
    {
        /// <summary>
        /// Gets or sets the bitrate.
        /// </summary>
        /// <value>
        /// The bitrate.
        /// </value>
        [JsonProperty("bitrate")]
        public long Bitrate { get; set; }
        /// <summary>
        /// Gets or sets the type of the content.
        /// </summary>
        /// <value>
        /// The type of the content.
        /// </value>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }
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