using System;

namespace Tweety
{
    /// <summary>
    /// Exception thrown by Tweety.
    /// </summary>
    public class TweetyException : Exception
    {
        internal TweetyException(string message) : base(message)
        {
        }
    }
}