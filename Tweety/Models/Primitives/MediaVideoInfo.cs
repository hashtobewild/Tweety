using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Video Info structure for extra media info
    /// </summary>
    public class MediaVideoInfo
    {
        /// <summary>
        /// Gets or sets the native aspect ratio.
        /// </summary>
        /// <value>
        /// The aspect ratio.
        /// </value>
        [JsonProperty("aspect_ratio")]
        public List<int> AspectRatio { get; set; }

        /// <summary>
        /// Gets or sets the duration in milliseconds.
        /// </summary>
        /// <value>
        /// The duration millis.
        /// </value>
        [JsonProperty("duration_millis")]
        public long DurationMillis { get; set; }

        /// <summary>
        /// Gets or sets the video variants.
        /// </summary>
        /// <value>
        /// The variants.
        /// </value>
        [JsonProperty("variants")]
        public List<VideoVariant> Variants { get; set; }
    }
}