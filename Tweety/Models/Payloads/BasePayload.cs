using Newtonsoft.Json;
using System.Collections.Generic;
using Tweety.Models.Events;

namespace Tweety.Models.Payloads
{
    /// <summary>
    /// Account Activity API:
    /// Block event with the user and target.
    /// https://developer.twitter.com/en/docs/accounts-and-users/subscribe-account-activity/guides/account-activity-data-objects
    /// block_events
    /// </summary>
    public class BasePayload
    {
        /// <summary>
        /// Gets or sets the json source (the original payload).
        /// </summary>
        /// <value>
        /// The json source.
        /// </value>
        public List<BaseUserEvent> JsonSource { get; set; }

        /// <summary>
        /// Gets or sets the for user (recipient) identifier.
        /// </summary>
        /// <value>
        /// For user identifier.
        /// </value>
        [JsonProperty("for_user_id")]
        public string ForUserId { get; set; }
    }
}