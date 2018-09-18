using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// An object showing available sizes for the media file.
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Height in pixels of this size.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [JsonProperty("h")]
        public int Height { get; set; }

        /// <summary>
        /// Resizing method used to obtain this size. A value of fit means that the media was resized to fit one dimension, keeping its native aspect ratio. A value of crop means that the media was cropped in order to fit a specific resolution.
        /// </summary>
        /// <value>
        /// The resize.
        /// </value>
        [JsonProperty("resize")]
        public string Resize { get; set; }

        /// <summary>
        /// Width in pixels of this size.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [JsonProperty("w")]
        public int Width { get; set; }
    }
}