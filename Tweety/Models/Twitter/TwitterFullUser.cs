using Newtonsoft.Json;

namespace Tweety.Models.Twitter
{
    /// <summary>
    /// Represents an unabridged twitter user object
    /// </summary>
    public class TwitterFullUser
    {
        /// <summary>
        /// Gets or sets a value indicating whether [contributors enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [contributors enabled]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("contributors_enabled")]
        public bool ContributorsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [default profile].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [default profile]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("default_profile")]
        public bool DefaultProfile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [default profile image].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [default profile image]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("default_profile_image")]
        public bool DefaultProfileImage { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        [JsonProperty("entities")]
        public TwitterEntities Entities { get; set; }

        /// <summary>
        /// Gets or sets the favourites count.
        /// </summary>
        /// <value>
        /// The favourites count.
        /// </value>
        [JsonProperty("favourites_count")]
        public int FavouritesCount { get; set; }

        /// <summary>
        /// Gets or sets the followers count.
        /// </summary>
        /// <value>
        /// The followers count.
        /// </value>
        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TwitterFullUser"/> is following.
        /// </summary>
        /// <value>
        ///   <c>true</c> if following; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("following")]
        public bool Following { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [follow request sent].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [follow request sent]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("follow_request_sent")]
        public bool FollowRequestSent { get; set; }

        /// <summary>
        /// Gets or sets the friends count.
        /// </summary>
        /// <value>
        /// The friends count.
        /// </value>
        [JsonProperty("friends_count")]
        public int FriendsCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [geo enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [geo enabled]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("geo_enabled")]
        public bool GeoEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has extended profile.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has extended profile; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("has_extended_profile")]
        public bool HasExtendedProfile { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier string.
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
        /// Gets or sets a value indicating whether this instance is translation enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is translation enabled; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_translation_enabled")]
        public bool IsTranslationEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is translator.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is translator; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_translator")]
        public bool IsTranslator { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonProperty("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or sets the listed count.
        /// </summary>
        /// <value>
        /// The listed count.
        /// </value>
        [JsonProperty("listed_count")]
        public int ListedCount { get; set; }

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
        /// Gets or sets a value indicating whether this <see cref="TwitterFullUser"/> is notifications.
        /// </summary>
        /// <value>
        ///   <c>true</c> if notifications; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("notifications")]
        public bool Notifications { get; set; }

        /// <summary>
        /// Gets or sets the color of the profile background.
        /// </summary>
        /// <value>
        /// The color of the profile background.
        /// </value>
        [JsonProperty("profile_background_color")]
        public string ProfileBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the profile background image URL.
        /// </summary>
        /// <value>
        /// The profile background image URL.
        /// </value>
        [JsonProperty("profile_background_image_url")]
        public string ProfileBackgroundImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the profile background image URL HTTPS.
        /// </summary>
        /// <value>
        /// The profile background image URL HTTPS.
        /// </value>
        [JsonProperty("profile_background_image_url_https")]
        public string ProfileBackgroundImageUrlHttps { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [profile background tile].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [profile background tile]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("profile_background_tile")]
        public bool ProfileBackgroundTile { get; set; }

        /// <summary>
        /// Gets or sets the profile banner URL.
        /// </summary>
        /// <value>
        /// The profile banner URL.
        /// </value>
        [JsonProperty("profile_banner_url")]
        public string ProfileBannerUrl { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL.
        /// </summary>
        /// <value>
        /// The profile image URL.
        /// </value>
        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL HTTPS.
        /// </summary>
        /// <value>
        /// The profile image URL HTTPS.
        /// </value>
        [JsonProperty("profile_image_url_https")]
        public string ProfileImageUrlHttps { get; set; }

        /// <summary>
        /// Gets or sets the color of the profile link.
        /// </summary>
        /// <value>
        /// The color of the profile link.
        /// </value>
        [JsonProperty("profile_link_color")]
        public string ProfileLinkColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the profile sidebar border.
        /// </summary>
        /// <value>
        /// The color of the profile sidebar border.
        /// </value>
        [JsonProperty("profile_sidebar_border_color")]
        public string ProfileSidebarBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the profile sidebar fill.
        /// </summary>
        /// <value>
        /// The color of the profile sidebar fill.
        /// </value>
        [JsonProperty("profile_sidebar_fill_color")]
        public string ProfileSidebarFillColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the profile text.
        /// </summary>
        /// <value>
        /// The color of the profile text.
        /// </value>
        [JsonProperty("profile_text_color")]
        public string ProfileTextColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [profile use background image].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [profile use background image]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("profile_use_background_image")]
        public bool ProfileUseBackgroundImage { get; set; }

        /// <summary>
        /// Gets or sets the screen name of the user.
        /// </summary>
        /// <value>
        /// The name of the screen.
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
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>
        /// The time zone.
        /// </value>
        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the type of the translator.
        /// </summary>
        /// <value>
        /// The type of the translator.
        /// </value>
        [JsonProperty("translator_type")]
        public string TranslatorType { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the UTC offset.
        /// </summary>
        /// <value>
        /// The UTC offset.
        /// </value>
        [JsonProperty("utc_offset")]
        public string UtcOffset { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TwitterFullUser"/> is verified.
        /// </summary>
        /// <value>
        ///   <c>true</c> if verified; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}