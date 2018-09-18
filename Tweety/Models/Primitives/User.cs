using Newtonsoft.Json;
using System.Collections.Generic;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Represents an abridged twitter user entity
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/user-object
    /// </summary>
    public class User
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
        /// Collection of Enrichment metadata derived for user. Provides the Profile Geo Enrichment metadata. See referenced documentation for more information, including JSON data dictionaries.
        /// </summary>
        /// <value>
        /// The derived.
        /// </value>
        [JsonProperty("derived")]
        public Dictionary<string, dynamic> Derived { get; set; }

        /// <summary>
        /// Nullable . The user-defined UTF-8 string describing their account.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Entities for User Objects describe URLs that appear in the user defined profile URL and description fields. They do not describe hashtags or user_mentions. Unlike Tweet entities, user entities can apply to multiple fields within its parent object — to disambiguate, you will find a parent nodes called url and description that indicate which field contains the entitized URL.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        [JsonProperty("entities")]
        public Dictionary<string, URL> Entities { get; set; }

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
        /// The integer representation of the unique identifier for this User. This number is greater than 53 bits and some programming languages may have difficulty/silent defects in interpreting it. Using a signed 64 bit integer for storing this identifier is safe. Use id_str for fetching the identifier to stay on the safe side. See Twitter IDs, JSON and Snowflake .
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The string representation of the unique identifier for this User. Implementations should use this rather than the large, possibly un-consumable integer in id.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        [JsonProperty("id_str")]
        public string IdString { get; set; }

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
        /// Nullable . The user-defined location for this account’s profile. Not necessarily a location, nor machine-parseable. This field will occasionally be fuzzily interpreted by the Search service.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// The name of the user, as they’ve defined it. Not necessarily a person’s name. Typically capped at 20 characters, but subject to change.
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
        /// When true, indicates that this user has chosen to protect their Tweets. See About Public and Protected Tweets .
        /// </summary>
        /// <value>
        ///   <c>true</c> if protected; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("protected")]
        public bool Protected { get; set; }

        /// <summary>
        /// The screen name, handle, or alias that this user identifies themselves with. screen_names are unique but subject to change. Use id_str as a user identifier whenever possible. Typically a maximum of 15 characters long, but some historical accounts may exist with longer names.
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
        /// Nullable . A URL provided by the user in association with their profile.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}