using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents a twitter target entity
    /// </summary>
    public class Target
    {
        /// <summary>
        /// Gets or sets the recipient identifier.
        /// </summary>
        /// <value>
        /// The recipient identifier.
        /// </value>
        [JsonProperty("recipient_id")]
        public string RecipientId { get; set; }
    }
}