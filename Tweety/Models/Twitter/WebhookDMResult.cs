using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents the result of a direct message webhook
    /// </summary>
    public class WebhookDMResult
    {
        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>
        /// The events.
        /// </value>
        [JsonProperty("direct_message_events")]
        public List<DMEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        [JsonProperty("users")]
        public Dictionary<string, TwitterUser> Users { get; set; }

        /// <summary>
        /// Performs an implicit conversion from <see cref="WebhookDMResult"/> to <see cref="DirectMessageEvent"/>.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator DirectMessageEvent(WebhookDMResult result)
        {
            DirectMessageEvent dmEvent = new DirectMessageEvent();

            DMEvent tdmEvent = result.Events.First();

            dmEvent.Id = tdmEvent.Id;
            dmEvent.Created = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(tdmEvent.CreatedTimestamp);
            dmEvent.Type = tdmEvent.Type == "message_create" ? TwitterEventType.MessageCreate : TwitterEventType.Unknown;

            dmEvent.MessageEntities = tdmEvent.MessageCreate?.MessageData?.Entities;
            if (tdmEvent.MessageCreate.MessageData.Attachment != null)
            {
                dmEvent.MessageEntities.Media = new List<MediaEntity>();
                dmEvent.MessageEntities.Media.Add(tdmEvent.MessageCreate.MessageData.Attachment.Media);
            }

            dmEvent.MessageText = tdmEvent.MessageCreate?.MessageData?.Text;
            dmEvent.Recipient = result.Users.Where(u => u.Value.Id == tdmEvent.MessageCreate.Target.RecipientId)?.FirstOrDefault().Value;
            dmEvent.Sender = result.Users.Where(u => u.Value.Id == tdmEvent.MessageCreate.SenderId)?.FirstOrDefault().Value;

            return dmEvent;
        }
    }
}