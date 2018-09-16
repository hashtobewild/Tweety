using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class MessageCreate
    {
        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        [JsonProperty("entities")]
        public TwitterEntities Entities { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier string.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        [JsonProperty("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// Gets or sets the recipient.
        /// </summary>
        /// <value>
        /// The recipient.
        /// </value>
        [JsonProperty("recipient")]
        public TwitterFullUser Recipient { get; set; }

        /// <summary>
        /// Gets or sets the recipient identifier.
        /// </summary>
        /// <value>
        /// The recipient identifier.
        /// </value>
        [JsonProperty("recipient_id")]
        public long RecipientId { get; set; }

        /// <summary>
        /// Gets or sets the recipient identifier string.
        /// </summary>
        /// <value>
        /// The recipient identifier string.
        /// </value>
        [JsonProperty("recipient_id_str")]
        public string RecipientIdString { get; set; }

        /// <summary>
        /// Gets or sets the screen name of the recipient .
        /// </summary>
        /// <value>
        /// The name of the recipient screen.
        /// </value>
        [JsonProperty("recipient_screen_name")]
        public string RecipientScreenName { get; set; }

        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        /// <value>
        /// The sender.
        /// </value>
        [JsonProperty("sender")]
        public TwitterFullUser Sender { get; set; }

        /// <summary>
        /// Gets or sets the sender identifier.
        /// </summary>
        /// <value>
        /// The sender identifier.
        /// </value>
        [JsonProperty("sender_id")]
        public int SenderId { get; set; }

        /// <summary>
        /// Gets or sets the sender identifier string.
        /// </summary>
        /// <value>
        /// The sender identifier string.
        /// </value>
        [JsonProperty("sender_id_str")]
        public string SenderIdString { get; set; }

        /// <summary>
        /// Gets or sets the screen name of the sender .
        /// </summary>
        /// <value>
        /// The name of the sender screen.
        /// </value>
        [JsonProperty("sender_screen_name")]
        public string SenderScreenName { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}