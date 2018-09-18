using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Tweety.Authentication;
using Tweety.Models.Primitives;

namespace Tweety.Webhooks
{
    /// <summary>
    /// This class will help in managing the webhook subscription.
    /// </summary>
    public class SubscriptionsManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsManager"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public SubscriptionsManager(TweetyAuthContext context)
        {
            AuthContext = context;
        }

        /// <summary>
        /// Gets or sets the authentication context.
        /// </summary>
        /// <value>
        /// The authentication context.
        /// </value>
        public TweetyAuthContext AuthContext { get; set; }

        /// <summary>
        /// Checks if the current user (from the auth context) is subscribed to a webhook by Id.
        /// </summary>
        /// <param name="webhookId">Webhook Id to check against.</param>
        /// <returns>true indicates existed subscribtion.</returns>
        public async Task<Result<bool>> CheckSubscription(string webhookId)
        {
            if (string.IsNullOrEmpty(webhookId))
            {
                throw new ArgumentException(nameof(webhookId));
            }

            //TODO: Provide a generic class to make Twitter API Requests.
            string resourceUrl = $"https://api.twitter.com/1.1/account_activity/webhooks/{webhookId}/subscriptions.json";

            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", AuthHeaderBuilder.Build(AuthContext, HttpMethod.Get, resourceUrl));
                response = await client.GetAsync(resourceUrl);
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return new Result<bool>(true);
            }
            else if (!string.IsNullOrEmpty(jsonResponse))
            {
                TwitterError err = JsonConvert.DeserializeObject<TwitterError>(jsonResponse);
                if (err.Errors.Count == 1 && err.Errors[0].Code == 34)
                {
                    // Twitter API will return : {"code":34,"message":"Sorry, that page does not exist."} if you try to check a webhook with 0 subscribers,
                    // Which means, you're not subscribed.
                    return new Result<bool>(false);
                }

                return new Result<bool>(err);
            }
            else
            {
                //TODO: Provide a way to return httpstatus code
                return new Result<bool>();
            }
        }

        /// <summary>
        /// Subscribe current user (from the auth context) to a webhook by Id.
        /// </summary>
        /// <param name="webhookId">Webhook Id to subscribe to.</param>
        /// <returns>true indicates successfull subscribtion.</returns>
        public async Task<Result<bool>> Subscribe(string webhookId)
        {
            if (string.IsNullOrEmpty(webhookId))
            {
                throw new ArgumentException(nameof(webhookId));
            }

            //TODO: Provide a generic class to make Twitter API Requests.
            string resourceUrl = $"https://api.twitter.com/1.1/account_activity/webhooks/{webhookId}/subscriptions.json";

            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", AuthHeaderBuilder.Build(AuthContext, HttpMethod.Post, resourceUrl));
                response = await client.PostAsync(resourceUrl, new StringContent(""));
            }

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return new Result<bool>(true);
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(jsonResponse))
            {
                TwitterError err = JsonConvert.DeserializeObject<TwitterError>(jsonResponse);
                return new Result<bool>(err);
            }
            else
            {
                //TODO: Provide a way to return httpstatus code
                return new Result<bool>();
            }
        }

        /// <summary>
        /// Unsubscribe current user (from the auth context) from a webhook by Id.
        /// </summary>
        /// <param name="webhookId">Webhook Id to unsubscribe from.</param>
        /// <returns>true indicates successful deletion.</returns>
        public async Task<Result<bool>> Unsubscribe(string webhookId)
        {
            if (string.IsNullOrEmpty(webhookId))
            {
                throw new ArgumentException(nameof(webhookId));
            }

            //TODO: Provide a generic class to make Twitter API Requests.
            string resourceUrl = $"https://api.twitter.com/1.1/account_activity/webhooks/{webhookId}/subscriptions.json";

            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", AuthHeaderBuilder.Build(AuthContext, HttpMethod.Delete, resourceUrl));
                response = await client.DeleteAsync(resourceUrl);
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return new Result<bool>(true);
            }
            else if (!string.IsNullOrEmpty(jsonResponse))
            {
                TwitterError err = JsonConvert.DeserializeObject<TwitterError>(jsonResponse);
                if (err.Errors.Count == 1 && err.Errors[0].Code == 34)
                {
                    // Twitter API will return : {"code":34,"message":"Sorry, that page does not exist."} if you try to check a webhook with 0 subscribers,
                    // Which means, you're not subscribed.
                    return new Result<bool>(true);
                }

                return new Result<bool>(err);
            }
            else
            {
                //TODO: Provide a way to return httpstatus code
                return new Result<bool>();
            }
        }
    }
}