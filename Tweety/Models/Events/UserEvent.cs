using Newtonsoft.Json;

namespace Tweety.Models.Events
{
    /// <summary>
    /// The  user event object
    /// </summary>
    public class UserEvent
    {
        /// <summary>
        /// Gets or sets the revoke event.
        /// </summary>
        /// <value>
        /// The revoke event.
        /// </value>
        [JsonProperty("revoke")]
        public RevokeEvent Revoke { get; set; }
    }
}