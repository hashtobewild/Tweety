using Newtonsoft.Json;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// App identifier object
    /// </summary>
    public class AppIdentifier
    {
        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
    }
}