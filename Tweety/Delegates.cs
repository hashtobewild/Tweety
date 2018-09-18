using System;
using System.Collections.Generic;
using System.Text;
using Tweety.Models.Payloads;

namespace Tweety
{
    /// <summary>
    /// The delegate for an event emitted when a block event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void BlockEventReceivedEventHandler(Object sender, TweetBlockEvents e);
    /// <summary>
    /// The delegate for an event emitted when a create event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void CreateEventReceivedEventHandler(Object sender, TweetCreateEvents e);
    /// <summary>
    /// The delegate for an event emitted when a delete event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void DeleteEventReceivedEventHandler(Object sender, TweetDeletedEvents e);
    /// <summary>
    /// The delegate for an event emitted when a direct message event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void DirectMessageEventReceivedEventHandler(Object sender, TweetDirectMessageEvents e);
    /// <summary>
    /// The delegate for an event emitted when a direct message typing event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void DirectMessageIndicateTypingEventReceivedEventHandler(Object sender, TweetDirectMessageIndicateTypingEvents e);
    /// <summary>
    /// The delegate for an event emitted when a direct message mark read event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void DirectMessageMarkReadEventReceivedEventHandler(Object sender, TweetDirectMessageMarkReadEvents e);
    /// <summary>
    /// The delegate for an event emitted when a favorited event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void FavoriteEventReceivedEventHandler(Object sender, TweetFavoriteEvents e);
    /// <summary>
    /// The delegate for an event emitted when a follow event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void FollowEventReceivedEventHandler(Object sender, TweetFollowEvents e);
    /// <summary>
    /// The delegate for an event emitted when a mute event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void MuteEventReceivedEventHandler(Object sender, TweetMuteEvents e);
    /// <summary>
    /// The delegate for an event emitted when a user event is received
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event parameters.</param>
    public delegate void UserEventReceivedEventHandler(Object sender, TweetUserEvent e);
}
