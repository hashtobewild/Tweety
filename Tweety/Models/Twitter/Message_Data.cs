using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    ///
    /// </summary>
    public class Message_Data
    {
        /// <summary>
        /// Gets or sets the attachment.
        /// </summary>
        /// <value>
        /// The attachment.
        /// </value>
        [JsonProperty("attachment")]
        public Attachment Attachment { get; set; }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        [JsonProperty("entities")]
        public TwitterEntities Entities { get; set; }

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