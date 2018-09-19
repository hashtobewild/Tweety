using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tweety.Extensions;
using Tweety.Models.Payloads;
using Tweety.Models.Primitives;
using Tweety.Models.Twitter;

namespace Tweety.Webhooks
{
    /// <summary>
    /// This class is responsible to intercept incoming requests to the server
    /// and handle them properly.
    /// </summary>
    public class WebhookInterceptor
    {
        /// <summary>
        /// Occurs when [on block received].
        /// </summary>
        public event BlockEventReceivedEventHandler OnBlockReceived;
        /// <summary>
        /// Occurs when [on create received].
        /// </summary>
        public event CreateEventReceivedEventHandler OnCreateReceived;
        /// <summary>
        /// Occurs when [on delete received].
        /// </summary>
        public event DeleteEventReceivedEventHandler OnDeleteReceived;
        /// <summary>
        /// Occurs when [on direct message received].
        /// </summary>
        public event DirectMessageEventReceivedEventHandler OnDirectMessageReceived;
        /// <summary>
        /// Occurs when [on direct message typing indicate received].
        /// </summary>
        public event DirectMessageIndicateTypingEventReceivedEventHandler OnDirectMessageTypingIndicateReceived;
        /// <summary>
        /// Occurs when [on direct message mark read received].
        /// </summary>
        public event DirectMessageMarkReadEventReceivedEventHandler OnDirectMessageMarkReadReceived;
        /// <summary>
        /// Occurs when [on favorite received].
        /// </summary>
        public event FavoriteEventReceivedEventHandler OnFavoriteReceived;
        /// <summary>
        /// Occurs when [on follow received].
        /// </summary>
        public event FollowEventReceivedEventHandler OnFollowReceived;
        /// <summary>
        /// Occurs when [on mute received].
        /// </summary>
        public event MuteEventReceivedEventHandler OnMuteReceived;
        /// <summary>
        /// Occurs when [on user event received].
        /// </summary>
        public event UserEventReceivedEventHandler OnUserEventReceived;
        /// <summary>
        /// Occurs when [on raw json received].
        /// </summary>
        public event RawJsonReceivedEventHandler OnRawJsonReceived;
                
        /// <summary>
        /// Create a new instance of <see cref="WebhookInterceptor"/> with your Twitter App Consumer Key.
        /// </summary>
        /// <param name="consumerSecret">Twitter App Consumer Key, used for hashing.</param>
        public WebhookInterceptor(string consumerSecret)
        {
            ConsumerSecret = consumerSecret;
        }

        /// <summary>
        /// Twitter App Consumer Secret.
        /// Used to Hash incoming/ outgoing data.
        /// </summary>
        public string ConsumerSecret { get; set; }

        /// <summary>
        /// Intercept incoming requests to the server to handle them according to Twitter Documentation, Currently:
        ///     - Challenge Response Check.
        ///     - Incoming DirectMessage.
        /// </summary>
        /// <param name="requestMessage">Thr request message object you recieved.</param>
        /// <returns>
        /// <see cref="InterceptionResult"/> Interception result.
        /// </returns>
        public async Task<InterceptionResult> InterceptIncomingRequest(HttpRequestMessage requestMessage)
        {
            if (string.IsNullOrEmpty(ConsumerSecret))
            {
                throw new TweetyException("Consumer Secret can't be null.");
            }
            else if (requestMessage.Method == HttpMethod.Get && requestMessage.RequestUri.GetParams().ContainsKey("crc_token"))
            {
                // Challenge Response Check Request:
                string crcToken = requestMessage.RequestUri.GetParams()["crc_token"];
                HttpResponseMessage response = AcceptChallenge(crcToken);
                return InterceptionResult.CreateHandled(response, requestMessage);
            }
            else if (requestMessage.Method == HttpMethod.Post && requestMessage.Headers.Contains("x-twitter-webhooks-signature"))
            {
                string payloadSignature = requestMessage.Headers.GetValues("x-twitter-webhooks-signature").First();
                string payload = await requestMessage.Content.ReadAsStringAsync();

                bool signatureMatch = IsValidTwitterPostRequest(payloadSignature, payload);
                if (!signatureMatch)
                {
                    //This is interseting, a twitter signature key 'x-twitter-webhooks-signature' is there but it's wrong..!
                    return InterceptionResult.CreateHandled(new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest), requestMessage);
                }
                else
                {
                    try
                    {
                        // Emit a raw json dump if needed
                        if (!string.IsNullOrEmpty(payload))
                        {
                            OnRawJsonReceived?.Invoke(this, payload);
                        }
                        // Instead of brute forcing the cast, do an intermediate cast to Dictionary<string, dynamic>, which should always work and lets us interogate it
                        Dictionary<string, dynamic> intermediate = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(payload);
                        if (intermediate.ContainsKey("tweet_create_events"))
                        {
                            // tweet_create_events 
                            OnCreateReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetCreateEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("favorite_events"))
                        {
                            // favorite_events
                            OnFavoriteReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetFavoriteEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("follow_events"))
                        {
                            // follow_events
                            OnFollowReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetFollowEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("block_events"))
                        {
                            // block_events
                            OnBlockReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetBlockEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("mute_events"))
                        {
                            // mute_events
                            OnMuteReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetMuteEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("user_event"))
                        {
                            // user_event
                            OnUserEventReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetUserEvent>(payload));
                        }
                        else if (intermediate.ContainsKey("direct_message_events"))
                        {
                            // direct_message_events
                            OnDirectMessageReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetDirectMessageEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("direct_message_indicate_typing_events"))
                        {
                            // direct_message_indicate_typing_events
                            OnDirectMessageTypingIndicateReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetDirectMessageIndicateTypingEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("direct_message_mark_read_events"))
                        {
                            // direct_message_mark_read_events
                            OnDirectMessageMarkReadReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetDirectMessageMarkReadEvents>(payload));
                        }
                        else if (intermediate.ContainsKey("tweet_delete_events"))
                        {
                            // tweet_delete_events
                            OnDeleteReceived?.Invoke(this, JsonConvert.DeserializeObject<TweetDeletedEvents>(payload));
                        }
                        else
                        {
                            // nafc what this is...?! Maybe someone else does... so leave it unhandled
                            return InterceptionResult.CreateUnhandled(OK(), requestMessage);
                        }
                        // Looks like it worked...
                        return InterceptionResult.CreateHandled(OK(), requestMessage);
                    }
                    catch
                    {
                        //Failed to deserialize twitter direct message,
                        //TODO: Handle in a better way.. perhaps send the json?
                        return InterceptionResult.CreateHandled(new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest), requestMessage);
                    }
                }
            }
            else
            {
                return InterceptionResult.CreateUnhandled(OK(), requestMessage);
            }
        }

        /// <summary>
        /// Oks the specified content.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        private static HttpResponseMessage OK(string content = "") => new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent(content) };

        /// <summary>
        /// Accepts the CRC challenge.
        /// </summary>
        /// <param name="crcToken">The CRC token.</param>
        /// <returns></returns>
        private HttpResponseMessage AcceptChallenge(string crcToken)
        {
            byte[] hashKeyArray = Encoding.UTF8.GetBytes(ConsumerSecret);
            byte[] crcTokenArray = Encoding.UTF8.GetBytes(crcToken);
            HMACSHA256 hmacSHA256Alog = new HMACSHA256(hashKeyArray);
            byte[] computedHash = hmacSHA256Alog.ComputeHash(crcTokenArray);
            string challengeToken = $"sha256={Convert.ToBase64String(computedHash)}";
            CRCResponseToken responseToken = new CRCResponseToken()
            {
                Token = challengeToken
            };
            string jsonResponse = JsonConvert.SerializeObject(responseToken);
            return OK(jsonResponse);
        }

        /// <summary>
        /// Determines whether [is valid twitter post request] [the specified tw webhook signature].
        /// </summary>
        /// <param name="twWebhookSignature">The tw webhook signature.</param>
        /// <param name="payload">The payload.</param>
        /// <returns>
        ///   <c>true</c> if [is valid twitter post request] [the specified tw webhook signature]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidTwitterPostRequest(string twWebhookSignature, string payload)
        {
            byte[] hashKeyArray = Encoding.UTF8.GetBytes(ConsumerSecret);
            HMACSHA256 hmacSHA256Alog = new HMACSHA256(hashKeyArray);
            byte[] computedHash = hmacSHA256Alog.ComputeHash(Encoding.UTF8.GetBytes(payload));
            string localHashedSignature = $"sha256={Convert.ToBase64String(computedHash)}";
            return localHashedSignature == twWebhookSignature;
        }
    }


}