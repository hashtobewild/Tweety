using System;

namespace Tweety.Models.Primitives
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