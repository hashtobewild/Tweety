using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class TwitterSizeMedium
    {
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [JsonProperty("h")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the resize.
        /// </summary>
        /// <value>
        /// The resize.
        /// </value>
        [JsonProperty("resize")]
        public string Resize { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [JsonProperty("w")]
        public int Width { get; set; }
    }
}