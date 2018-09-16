using System;

namespace Tweety.Models
{
    /// <summary>
    ///
    /// </summary>
    public class TwitterEvent
    {
        /// <summary>
        /// Gets the created.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        public DateTime Created { get; internal set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public TwitterEventType Type { get; internal set; }
    }
}