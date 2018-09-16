using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class NewEvent_MessageCreate
    {
        /// <summary>
        /// Gets or sets the message data.
        /// </summary>
        /// <value>
        /// The message data.
        /// </value>
        [JsonProperty("message_data")]
        public NewEvent_MessageData MessageData { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        [JsonProperty("target")]
        public Target Target { get; set; }
    }
}