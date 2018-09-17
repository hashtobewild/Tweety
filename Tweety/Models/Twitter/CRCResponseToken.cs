using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents the response sent to a CRC challenge
    /// </summary>
    internal class CRCResponseToken
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        [JsonProperty("response_token")]
        public string Token { get; set; }
    }
}