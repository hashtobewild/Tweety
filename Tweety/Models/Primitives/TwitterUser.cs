using Newtonsoft.Json;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Represents an abridged twitter user entity
    /// </summary>
    public class TwitterUser
    {
        /// <summary>
        /// Gets or sets the created timestamp.
        /// </summary>
        /// <value>
        /// The created timestamp.
        /// </value>
        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the followers count.
        /// </summary>
        /// <value>
        /// The followers count.
        /// </value>
        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        /// <summary>
        /// Gets or sets the friends count.
        /// </summary>
        /// <value>
        /// The friends count.
        /// </value>
        [JsonProperty("friends_count")]
        public int FriendsCount { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is protected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is protected; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("_protected")]
        public bool IsProtected { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is verified.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is verified; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("verified")]
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the profile image.
        /// </summary>
        /// <value>
        /// The profile image.
        /// </value>
        [JsonProperty("profile_image_url")]
        public string ProfileImage { get; set; }

        /// <summary>
        /// Gets or sets the profile image HTTPS.
        /// </summary>
        /// <value>
        /// The profile image HTTPS.
        /// </value>
        [JsonProperty("profile_image_url_https")]
        public string ProfileImageHttps { get; set; }

        /// <summary>
        /// Gets or sets the screen name of the user.
        /// </summary>
        /// <value>
        /// The screen name of the user.
        /// </value>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }
        /// <summary>
        /// Gets or sets the statuses count.
        /// </summary>
        /// <value>
        /// The statuses count.
        /// </value>
        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}