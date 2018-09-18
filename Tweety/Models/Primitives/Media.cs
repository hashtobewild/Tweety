using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// The entities section will contain a media array containing a single media object if any media object has been ‘attached’ to the Tweet. If no native media has been attached, there will be no media array in the entities. For the following reasons the extended_entities section should be used to process Tweet native media:
    /// + Media type will always indicate ‘photo’ even in cases of a video and GIF being attached to Tweet.
    /// + Even though up to four photos can be attached, only the first one will be listed in the entities section.
    /// </summary>
    public class Media
    {
        /// <summary>
        /// URL of the media to display to clients.
        /// </summary>
        /// <value>
        /// The display URL.
        /// </value>
        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        /// <summary>
        /// An expanded version of display_url. Links to the media display page.
        /// </summary>
        /// <value>
        /// The expanded URL.
        /// </value>
        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        /// <summary>
        /// ID of the media expressed as a 64-bit integer.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of the media expressed as a string.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        [JsonProperty("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// An array of integers indicating the offsets within the Tweet text where the URL begins and ends. The first integer represents the location of the first character of the URL in the Tweet text. The second integer represents the location of the first non-URL character occurring after the URL (or the end of the string if the URL is the last part of the Tweet text).
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public List<int> Indices { get; set; }

        /// <summary>
        /// An http:// URL pointing directly to the uploaded media file
        /// </summary>
        /// <value>
        /// The media URL.
        /// </value>
        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        /// <summary>
        /// An https:// URL pointing directly to the uploaded media file, for embedding on https pages.
        /// </summary>
        /// <value>
        /// The media URL HTTPS.
        /// </value>
        [JsonProperty("media_url_https")]
        public string MediaUrlHttps { get; set; }

        /// <summary>
        /// An object showing available sizes for the media file.
        /// </summary>
        /// <value>
        /// The sizes.
        /// </value>
        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }

        /// <summary>
        /// Nullable. For Tweets containing media that was originally associated with a different tweet, this ID points to the original Tweet.
        /// </summary>
        /// <value>
        /// The source status identifier.
        /// </value>
        [JsonProperty("source_status_id")]
        public long? SourceStatusId { get; set; }

        /// <summary>
        /// Nullable. For Tweets containing media that was originally associated with a different tweet, this string-based ID points to the original Tweet.
        /// </summary>
        /// <value>
        /// The source status identifier string.
        /// </value>
        [JsonProperty("source_status_id_str")]
        public long? SourceStatusIdString { get; set; }

        /// <summary>
        /// Type of uploaded media. Possible types include photo, video, and animated_gif.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Wrapped URL for the media link. This corresponds with the URL embedded directly into the raw Tweet text, and the values for the indices parameter.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the video information.
        /// </summary>
        /// <value>
        /// The video information.
        /// </value>
        [JsonProperty("video_info")]
        public MediaVideoInfo VideoInfo { get; set; }

        /// <summary>
        /// Gets or sets the additional media information.
        /// </summary>
        /// <value>
        /// The additional media information.
        /// </value>
        [JsonProperty("additional_media_info")]
        public MediaInfo AdditionalMediaInfo { get; set; }

    }
}