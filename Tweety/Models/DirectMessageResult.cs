﻿using System;

namespace Tweety.Models
{
    /// <summary>
    /// The result of sending a new direct message.
    /// </summary>
    public class DirectMessageResult
    {
        /// <summary>
        /// Created Timestamp.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Message Id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The sent message text.
        /// </summary>
        public string MessageText { get; set; }

        /// <summary>
        /// The Twitter User Id who the message was sent to.
        /// </summary>
        public string RecipientId { get; set; }

        /// <summary>
        /// The Twitter User Id who sent the message.
        /// </summary>
        public string SenderId { get; set; }
    }
}