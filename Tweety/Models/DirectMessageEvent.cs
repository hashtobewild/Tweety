using Tweety.Models.Twitter;

namespace Tweety.Models
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Tweety.Models.TwitterEvent" />
    public class DirectMessageEvent : TwitterEvent
    {
        /// <summary>
        /// Gets or sets the json source.
        /// </summary>
        /// <value>
        /// The json source.
        /// </value>
        public string JsonSource { get; set; }

        /// <summary>
        /// Gets or sets the message entities.
        /// </summary>
        /// <value>
        /// The message entities.
        /// </value>
        public TwitterEntities MessageEntities { get; set; }

        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        /// <value>
        /// The message text.
        /// </value>
        public string MessageText { get; set; }

        /// <summary>
        /// Gets or sets the recipient.
        /// </summary>
        /// <value>
        /// The recipient.
        /// </value>
        public TwitterUser Recipient { get; set; }

        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        /// <value>
        /// The sender.
        /// </value>
        public TwitterUser Sender { get; set; }
    }
}