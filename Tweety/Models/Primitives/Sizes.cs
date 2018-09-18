using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// All Tweets with native media (photos, video, and GIFs) will include a set of ‘thumb’, ‘small’, ‘medium’, and ‘large’ sizes with height and width pixel sizes.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#size
    /// </summary>
    public class Sizes
    {
        /// <summary>
        /// Information for a large-sized version of the media.
        /// </summary>
        /// <value>
        /// The large.
        /// </value>
        [JsonProperty("large")]
        public Size Large { get; set; }

        /// <summary>
        /// Information for a medium-sized version of the media.
        /// </summary>
        /// <value>
        /// The medium.
        /// </value>
        [JsonProperty("medium")]
        public Size Medium { get; set; }

        /// <summary>
        /// Information for a small-sized version of the media.
        /// </summary>
        /// <value>
        /// The small.
        /// </value>
        [JsonProperty("small")]
        public Size Small { get; set; }

        /// <summary>
        /// Information for a thumbnail-sized version of the media. 
        /// </summary>
        /// <value>
        /// The thumb.
        /// </value>
        [JsonProperty("thumb")]
        public Size Thumb { get; set; }
    }
}