using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// The deletion status object used in tweet delete events
    /// </summary>
    public class DeleteStatus
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}