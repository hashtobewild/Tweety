using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Place object
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/geo-objects#coordinates-dictionary
    /// </summary>
    public class Place
    {
        /// <summary>
        /// When using PowerTrack, 30-Day and Full-Archive Search APIs, and Volume Streams this hash is null.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        [JsonProperty("attributes")]
        public Dictionary<string, dynamic> Attributes { get; set; }

        /// <summary>
        /// A bounding box of coordinates which encloses this place.
        /// </summary>
        /// <value>
        /// The bounding box.
        /// </value>
        [JsonProperty("bounding_box")]
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// Name of the country containing this place.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Shortened country code representing the country containing this place.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Full human-readable representation of the place’s name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// ID representing this place. Note that this is represented as a string, not an integer.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Short human-readable representation of the place’s name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of location represented by this place.
        /// </summary>
        /// <value>
        /// The type of the place.
        /// </value>
        [JsonProperty("place_type")]
        public string PlaceType { get; set; }

        /// <summary>
        /// URL representing the location of additional place metadata for this place.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}