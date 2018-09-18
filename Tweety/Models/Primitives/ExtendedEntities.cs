using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    ///
    /// </summary>
    public class ExtendedEntities
    {
        /// <summary>
        /// Represents media elements uploaded with the Tweet.
        /// </summary>
        /// <value>
        /// The media.
        /// </value>
        [JsonProperty("media")]
        public List<Media> Media { get; set; }
    }
}