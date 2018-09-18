using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primatives
{
    /// <summary>
    /// Coordinates object.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/geo-objects#coordinates-dictionary
    /// </summary>
    public class GeoCoordinates
    {
        /// <summary>
        /// The longitude and latitude of the Tweet’s location, as a collection in the form [longitude, latitude].
        /// </summary>
        /// <value>
        /// The coordinates.
        /// </value>
        [JsonProperty("coordinates")]
        public List<float> Coordinates { get; set; }

        /// <summary>
        /// The type of data encoded in the coordinates property. This will be “Point” for Tweet coordinates fields. 
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; }

    }
}