using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class TwitterEntities
    {
        /// <summary>
        /// Gets or sets the hashtags.
        /// </summary>
        /// <value>
        /// The hashtags.
        /// </value>
        [JsonProperty("hashtags")]
        public List<HashtagEntity> Hashtags { get; set; }

        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        /// <value>
        /// The media.
        /// </value>
        [JsonProperty("media")]
        public List<MediaEntity> Media { get; set; }

        /// <summary>
        /// Gets or sets the symbols.
        /// </summary>
        /// <value>
        /// The symbols.
        /// </value>
        [JsonProperty("symbols")]
        public List<SymbolEntity> Symbols { get; set; }

        /// <summary>
        /// Gets or sets the urls.
        /// </summary>
        /// <value>
        /// The urls.
        /// </value>
        [JsonProperty("urls")]
        public List<UrlEntity> Urls { get; set; }

        /// <summary>
        /// Gets or sets the user mentions.
        /// </summary>
        /// <value>
        /// The user mentions.
        /// </value>
        [JsonProperty("user_mentions")]
        public List<UserMentionEntity> UserMentions { get; set; }
    }
}