using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    public class NewDmResult
    {
        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        /// <value>
        /// The event.
        /// </value>
        [JsonProperty("@event")]
        public DMEvent @event { get; set; }
    }
}