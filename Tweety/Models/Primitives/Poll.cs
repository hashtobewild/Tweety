using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// The entities section will contain a polls array containing a single poll object if the Tweet contains a poll. If no poll is included, there will be no polls array in the entities section.
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#polls
    /// </summary>
    public class Poll
    {
        /// <summary>
        /// Duration of poll in minutes.
        /// </summary>
        /// <value>
        /// The duration minutes.
        /// </value>
        [JsonProperty("duration_minutes")]
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Time stamp (UTC) of when poll ends.
        /// </summary>
        /// <value>
        /// The end datetime.
        /// </value>
        [JsonProperty("end_datetime")]
        public string EndDatetime { get; set; }

        /// <summary>
        /// An array of options, each having a poll position, and the text for that position.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        [JsonProperty("options")]
        public List<Option> Options { get; set; }
    }
}