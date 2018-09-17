using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// A wrapper for the user event payload
    /// </summary>
    public class UserEventWrapper
    {
        /// <summary>
        /// Gets or sets the user event.
        /// </summary>
        /// <value>
        /// The user event.
        /// </value>
        [JsonProperty("user_event")]
        public UserEvent UserEvent { get; set; }
    }
}