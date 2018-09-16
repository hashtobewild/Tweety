using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class WebhookRegistration
    {
        /// <summary>
        /// Gets or sets the created timestamp.
        /// </summary>
        /// <value>
        /// The created timestamp.
        /// </value>
        [JsonProperty("created_timestamp ")]
        public long CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Returns true if ... is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("valid")]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets the registered URL.
        /// </summary>
        /// <value>
        /// The registered URL.
        /// </value>
        [JsonProperty("url")]
        public string RegisteredUrl { get; set; }
    }
}