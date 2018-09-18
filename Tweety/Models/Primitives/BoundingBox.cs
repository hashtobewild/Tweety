using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Bounding box object used for twitter places.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/geo-objects#coordinates-dictionary
    /// </summary>
    public class BoundingBox
    {
        /// <summary>
        /// A series of longitude and latitude points, defining a box which will contain the Place entity this bounding box is related to. Each point is an array in the form of [longitude, latitude]. Points are grouped into an array per bounding box. Bounding box arrays are wrapped in one additional array to be compatible with the polygon notation.
        /// </summary>
        /// <value>
        /// The coordinates.
        /// </value>
        [JsonProperty("coordinates")]
        public List<List<List<float>>> Coordinates { get; set; }

        /// <summary>
        /// The type of data encoded in the coordinates property. This will be “Polygon” for bounding boxes and “Pointn” for Tweets with exact coordinates.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}