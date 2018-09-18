using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Represents a twitter url entity
    /// </summary>
    public class URL
    {
        /// <summary>
        /// URL pasted/typed into Tweet.
        /// </summary>
        /// <value>
        /// The display URL.
        /// </value>
        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        /// <summary>
        /// Expanded version of `` display_url`` .
        /// </summary>
        /// <value>
        /// The expanded URL.
        /// </value>
        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        /// <summary>
        /// An array of integers representing offsets within the Tweet text where the URL begins and ends. The first integer represents the location of the first character of the URL in the Tweet text. The second integer represents the location of the first non-URL character after the end of the URL.
        /// </summary>
        /// <value>
        /// The indices.
        /// </value>
        [JsonProperty("indices")]
        public List<int> Indices { get; set; }

        /// <summary>
        /// Gets or sets the unwound url properties.
        /// </summary>
        /// <value>
        /// The unwound.
        /// </value>
        [JsonProperty("unwound")]
        public Unwind Unwound { get; set; }

        /// <summary>
        /// Wrapped URL, corresponding to the value embedded directly into the raw Tweet text, and the values for the indices parameter.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}