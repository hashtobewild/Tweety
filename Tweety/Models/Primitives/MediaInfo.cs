using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// When an advertiser chooses to limit video playback to just Twitter owned and operated platforms, the video_info object will be replaced with an additional_media_info object.
    /// The additional_media_info will contain additional media info provided by the publisher, such as title, description and embeddable flag. Video content is made available only to Twitter official clients when embeddable=false. In this case, all video URLs provided in the payload will be Twitter-based, so the user can open the video in a Twitter owned property by clicking the link.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/extended-entities-object
    /// </summary>
    public class MediaInfo
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="MediaInfo"/> is embeddable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if embeddable; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("embeddable")]
        public bool Embeddable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="MediaInfo"/> is monetizable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if monetizable; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("monetizable")]
        public bool Monetizable { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}