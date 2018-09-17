using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents a twitter sizes entity
    /// </summary>
    public class Sizes
    {
        /// <summary>
        /// Gets or sets the large.
        /// </summary>
        /// <value>
        /// The large.
        /// </value>
        [JsonProperty("large")]
        public TwitterSizeLarge Large { get; set; }

        /// <summary>
        /// Gets or sets the medium.
        /// </summary>
        /// <value>
        /// The medium.
        /// </value>
        [JsonProperty("medium")]
        public TwitterSizeMedium Medium { get; set; }

        /// <summary>
        /// Gets or sets the small.
        /// </summary>
        /// <value>
        /// The small.
        /// </value>
        [JsonProperty("small")]
        public TwitterSizeSmall Small { get; set; }

        /// <summary>
        /// Gets or sets the thumb.
        /// </summary>
        /// <value>
        /// The thumb.
        /// </value>
        [JsonProperty("thumb")]
        public TwitterSizeThumb Thumb { get; set; }
    }
}