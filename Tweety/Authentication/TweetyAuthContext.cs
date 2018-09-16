namespace Tweety.Authentication
{
    /// <summary>
    /// Required for any action, this represents the current user context.
    /// </summary>
    public class TweetyAuthContext
    {
        /// <summary>
        /// Gets or sets the access secret.
        /// </summary>
        /// <value>
        /// The access secret.
        /// </value>
        public string AccessSecret { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>
        /// The access token.
        /// </value>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the consumer key.
        /// </summary>
        /// <value>
        /// The consumer key.
        /// </value>
        public string ConsumerKey { get; set; }

        /// <summary>
        /// Gets or sets the consumer secret.
        /// </summary>
        /// <value>
        /// The consumer secret.
        /// </value>
        public string ConsumerSecret { get; set; }
        /// <summary>
        /// Check if the current auth context is valid or not.
        /// Null or Empty value for one on the auth properties will return false.
        /// </summary>
        public bool IsValid => !string.IsNullOrEmpty(ConsumerKey) && !string.IsNullOrEmpty(ConsumerSecret) && !string.IsNullOrEmpty(AccessToken) && !string.IsNullOrEmpty(AccessSecret);
    }
}