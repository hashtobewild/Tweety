using Newtonsoft.Json;
using System;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class DMEvent
    {
        /// <summary>
        /// Gets or sets the created timestamp.
        /// </summary>
        /// <value>
        /// The created timestamp.
        /// </value>
        [JsonProperty("created_timestamp")]
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
        /// Gets or sets the message create.
        /// </summary>
        /// <value>
        /// The message create.
        /// </value>
        [JsonProperty("message_create")]
        public Message MessageCreate { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// Performs an implicit conversion from <see cref="DMEvent"/> to <see cref="DirectMessageResult"/>.
        /// </summary>
        /// <param name="dmevent">The dmevent.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator DirectMessageResult(DMEvent dmevent)
        {
            DirectMessageResult res = new DirectMessageResult();
            res.Created = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(dmevent.CreatedTimestamp);
            res.Id = dmevent.Id;
            res.MessageText = dmevent.MessageCreate.MessageData.Text;
            res.RecipientId = dmevent.MessageCreate.Target.RecipientId;
            res.SenderId = dmevent.MessageCreate.SenderId;

            return res;
        }
    }
}