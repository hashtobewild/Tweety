using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// User identifier object
    /// </summary>
    public class UserIdentifier
    {
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