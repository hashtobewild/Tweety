using Newtonsoft.Json;
using System.Collections.Generic;
using Tweety.Models.Primatives;
using Tweety.Models.Twitter;

namespace Tweety.Models.Primitives
{
    /// <summary>
    /// Represents a twitter message create entity
    /// https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/tweet-object
    /// </summary>
    public class Tweet
    {
        /// <summary>
        /// Nullable. Represents the geographic location of this Tweet as reported by the user or client application. The inner coordinates array is formatted as geoJSON (longitude first, then latitude).
        /// </summary>
        /// <value>
        /// The coordinates.
        /// </value>
        [JsonProperty("coordinates")]
        public GeoCoordinates Coordinates { get; set; }

        /// <summary>
        /// UTC time when this Tweet was created.
        /// </summary>
        /// <value>
        /// The created at time.
        /// </value>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Perspectival Only surfaces on methods supporting the include_my_retweet parameter, when set to true. Details the Tweet ID of the user’s own retweet (if existent) of this Tweet.
        /// </summary>
        /// <value>
        /// The current user retweet.
        /// </value>
        [JsonProperty("current_user_retweet")]
        public CurrentUserRetweet CurrentUserRetweet { get; set; }

        /// <summary>
        /// Entities which have been parsed out of the text of the Tweet. Additionally see Entities in Twitter Objects .
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        [JsonProperty("entities")]
        public Entities Entities { get; set; }

        /// <summary>
        /// When between one and four native photos or one video or one animated GIF are in Tweet, contains an array 'media' metadata. Additionally see Entities in Twitter Objects .
        /// </summary>
        /// <value>
        /// The extended entities.
        /// </value>
        [JsonProperty("extended_entities")]
        public ExtendedEntities ExtendedEntities { get; set; }

        /// <summary>
        /// Nullable. Indicates approximately how many times this Tweet has been liked by Twitter users.
        /// </summary>
        /// <value>
        /// The favorite count.
        /// </value>
        [JsonProperty("favorite_count")]
        public int FavoriteCount { get; set; }

        /// <summary>
        /// Nullable. Indicates whether this Tweet has been liked by the authenticating user.
        /// </summary>
        /// <value>
        ///   <c>true</c> if favorited; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        /// <summary>
        /// Indicates the maximum value of the filter_level parameter which may be used and still stream this Tweet. So a value of medium will be streamed on none, low, and medium streams.
        /// </summary>
        /// <value>
        /// The filter level.
        /// </value>
        [JsonProperty("filter_level")]
        public string FilterLevel { get; set; }

        /// <summary>
        /// The integer representation of the unique identifier for this Tweet. This number is greater than 53 bits and some programming languages may have difficulty/silent defects in interpreting it. Using a signed 64 bit integer for storing this identifier is safe. Use id_str for fetching the identifier to stay on the safe side. See Twitter IDs, JSON and Snowflake
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The string representation of the unique identifier for this Tweet. Implementations should use this rather than the large integer in id.
        /// </summary>
        /// <value>
        /// The identifier string.
        /// </value>
        [JsonProperty("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// Nullable. If the represented Tweet is a reply, this field will contain the screen name of the original Tweet’s author.
        /// </summary>
        /// <value>
        /// The name of the in reply to screen.
        /// </value>
        [JsonProperty("in_reply_to_screen_name")]
        public string InReplyToScreenName { get; set; }

        /// <summary>
        /// Nullable. If the represented Tweet is a reply, this field will contain the integer representation of the original Tweet’s ID.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [in reply to status identifier]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("in_reply_to_status_id")]
        public long? InReplyToStatusId { get; set; }

        /// <summary>
        /// Nullable. If the represented Tweet is a reply, this field will contain the string representation of the original Tweet’s ID.
        /// </summary>
        /// <value>
        /// The in reply to status identifier string.
        /// </value>
        [JsonProperty("in_reply_to_status_id_str")]
        public string InReplyToStatusIdString { get; set; }

        /// <summary>
        /// Nullable. If the represented Tweet is a reply, this field will contain the integer representation of the original Tweet’s author ID. This will not necessarily always be the user directly mentioned in the Tweet.
        /// </summary>
        /// <value>
        /// The in reply to user identifier.
        /// </value>
        [JsonProperty("in_reply_to_user_id")]
        public long? InReplyToUserId { get; set; }

        /// <summary>
        /// Nullable. If the represented Tweet is a reply, this field will contain the string representation of the original Tweet’s author ID. This will not necessarily always be the user directly mentioned in the Tweet.
        /// </summary>
        /// <value>
        /// The in reply to user identifier string.
        /// </value>
        [JsonProperty("in_reply_to_user_id_str")]
        public string InReplyToUserIdString { get; set; }

        /// <summary>
        /// Indicates whether this is a Quoted Tweet.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is quote status; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("is_quote_status")]
        public bool IsQuoteStatus { get; set; }

        /// <summary>
        /// Nullable. When present, indicates a BCP 47 language identifier corresponding to the machine-detected language of the Tweet text, or und if no language could be detected.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        [JsonProperty("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Present in filtered products such as Twitter Search and PowerTrack. Provides the id and tag associated with the rule that matched the Tweet. With PowerTrack, more than one rule can match a Tweet.
        /// </summary>
        /// <value>
        /// The matching rules.
        /// </value>
        [JsonProperty("matching_rules")]
        public string MatchingRules { get; set; }

        /// <summary>
        /// Nullable When present, indicates that the tweet is associated (but not necessarily originating from) a Place .
        /// </summary>
        /// <value>
        /// The place.
        /// </value>
        [JsonProperty("place")]
        public Place Place { get; set; }

        /// <summary>
        /// Nullable. This field only surfaces when a Tweet contains a link. The meaning of the field doesn’t pertain to the Tweet content itself, but instead it is an indicator that the URL contained in the Tweet may contain content or media identified as sensitive content.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [possibly sensitive]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("possibly_sensitive")]
        public bool PossiblySensitive { get; set; }

        /// <summary>
        /// Nullable. Indicates approximately how many times this Tweet has been quoted by Twitter users.
        /// </summary>
        /// <value>
        /// The quote count.
        /// </value>
        [JsonProperty("quote_count")]
        public int QuoteCount { get; set; }

        /// <summary>
        /// This field only surfaces when the Tweet is a quote Tweet. This attribute contains the Tweet object of the original Tweet that was quoted.
        /// </summary>
        /// <value>
        /// The quoted status.
        /// </value>
        [JsonProperty("quoted_status")]
        public Tweet QuotedStatus { get; set; }

        /// <summary>
        /// This field only surfaces when the Tweet is a quote Tweet. This field contains the integer value Tweet ID of the quoted Tweet. Example:
        /// </summary>
        /// <value>
        /// The quoted status identifier.
        /// </value>
        [JsonProperty("quoted_status_id")]
        public long QuotedStatusId { get; set; }

        /// <summary>
        /// This field only surfaces when the Tweet is a quote Tweet. This is the string representation Tweet ID of the quoted Tweet.
        /// </summary>
        /// <value>
        /// The quoted status identifier string.
        /// </value>
        [JsonProperty("quoted_status_id_str")]
        public string QuotedStatusIdString { get; set; }

        /// <summary>
        /// Number of times this Tweet has been replied to.
        /// </summary>
        /// <value>
        /// The reply count.
        /// </value>
        [JsonProperty("reply_count")]
        public int ReplyCount { get; set; }

        /// <summary>
        /// Number of times this Tweet has been retweeted.
        /// </summary>
        /// <value>
        /// The retweet count.
        /// </value>
        [JsonProperty("retweet_count")]
        public int RetweetCount { get; set; }

        /// <summary>
        /// Indicates whether this Tweet has been Retweeted by the authenticating user.
        /// </summary>
        /// <value>
        ///   <c>true</c> if retweeted; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("retweeted")]
        public bool Retweeted { get; set; }

        /// <summary>
        /// Users can amplify the broadcast of Tweets authored by other users by retweeting . Retweets can be distinguished from typical Tweets by the existence of a retweeted_status attribute. This attribute contains a representation of the original Tweet that was retweeted. Note that retweets of retweets do not show representations of the intermediary retweet, but only the original Tweet. (Users can also unretweet a retweet they created by deleting their retweet.)
        /// </summary>
        /// <value>
        /// The retweeted status.
        /// </value>
        [JsonProperty("retweeted_status")]
        public Tweet RetweetedStatus { get; set; }

        /// <summary>
        /// A set of key-value pairs indicating the intended contextual delivery of the containing Tweet. Currently used by Twitter’s Promoted Products.
        /// </summary>
        /// <value>
        /// The scopes.
        /// </value>
        [JsonProperty("scopes")]
        public Dictionary<string, dynamic> Scopes { get; set; }

        /// <summary>
        /// Utility used to post the Tweet, as an HTML-formatted string. Tweets from the Twitter website have a source value of web.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The actual UTF-8 text of the status update. See twitter-text for details on what characters are currently considered valid.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Indicates whether the value of the text parameter was truncated, for example, as a result of a retweet exceeding the original Tweet text length limit of 140 characters. Truncated text will end in ellipsis, like this ... Since Twitter now rejects long Tweets vs truncating them, the large majority of Tweets will have this set to false . Note that while native retweets may have their toplevel text property shortened, the original text will be available under the retweeted_status object and the truncated parameter will be set to the value of the original status (in most cases, false ).
        /// </summary>
        /// <value>
        ///   <c>true</c> if truncated; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        /// <summary>
        /// The user who posted this Tweet. See User data dictionary for complete list of attributes.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// When present and set to “true”, it indicates that this piece of content has been withheld due to a DMCA complaint
        /// </summary>
        /// <value>
        ///   <c>true</c> if [withheld copyright]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("withheld_copyright")]
        public bool WithheldCopyright { get; set; }

        /// <summary>
        /// When present, indicates a list of uppercase two-letter country codes this content is withheld from. Twitter supports the following non-country values for this field:“XX” - Content is withheld in all countries “XY” - Content is withheld due to a DMCA request.
        /// </summary>
        /// <value>
        /// The withheld in countries.
        /// </value>
        [JsonProperty("withheld_in_countries")]
        public List<string> WithheldInCountries { get; set; }

        /// <summary>
        /// When present, indicates whether the content being withheld is the “status” or a “user.”
        /// </summary>
        /// <value>
        ///   <c>true</c> if [withheld scope]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("withheld_scope")]
        public bool WithheldScope { get; set; }
    }
}