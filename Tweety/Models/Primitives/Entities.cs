using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    ///
    /// </summary>
    public class Entities
    {
        /// <summary>
        ///Represents hashtags which have been parsed out of the Tweet text.
        /// </summary>
        /// <value>
        /// The hashtags.
        /// </value>
        [JsonProperty("hashtags")]
        public List<Hashtag> Hashtags { get; set; }

        /// <summary>
        /// Represents media elements uploaded with the Tweet.
        /// </summary>
        /// <value>
        /// The media.
        /// </value>
        [JsonProperty("media")]
        public List<Media> Media { get; set; }

        /// <summary>
        /// Represents Twitter Polls included in the Tweet.
        /// </summary>
        /// <value>
        /// The polls.
        /// </value>
        [JsonProperty("polls")]
        public List<Poll> Polls { get; set; }

        /// <summary>
        /// Represents symbols, i.e. $cashtags, included in the text of the Tweet.
        /// </summary>
        /// <value>
        /// The symbols.
        /// </value>
        [JsonProperty("symbols")]
        public List<Symbol> Symbols { get; set; }

        /// <summary>
        /// Gets or sets the urls.
        /// </summary>
        /// <value>
        /// The urls.
        /// </value>
        [JsonProperty("urls")]
        public List<URL> Urls { get; set; }

        /// <summary>
        /// Represents other Twitter users mentioned in the text of the Tweet.
        /// </summary>
        /// <value>
        /// The user mentions.
        /// </value>
        [JsonProperty("user_mentions")]
        public List<UserMention> UserMentions { get; set; }
    }
}