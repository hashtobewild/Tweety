using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Tweety.Authentication;
using Tweety.Models.Primitives;
using Tweety.Models.Twitter;

namespace Tweety.Webhooks
{
    /// <summary>
    /// This class will help in managing the webhooks registrations.
    /// </summary>
    public class WebhooksManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksManager"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WebhooksManager(TweetyAuthContext context)
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
        /// Retrieve a list of <see cref="WebhookRegistration"/> associated with the user (from the auth context).
        /// </summary>
        /// <returns></returns>
        public async Task<Result<List<WebhookRegistration>>> GetRegisteredWebhooks()
        {
            string resourceUrl = $"https://api.twitter.com/1.1/account_activity/webhooks.json";

            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", AuthHeaderBuilder.Build(AuthContext, HttpMethod.Get, resourceUrl));

                response = await client.GetAsync(resourceUrl);
            }
            string jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<WebhookRegistration> subs = JsonConvert.DeserializeObject<List<WebhookRegistration>>(jsonResponse);
                return new Result<List<WebhookRegistration>>(subs);
            }

            if (!string.IsNullOrEmpty(jsonResponse))
            {
                TwitterError err = JsonConvert.DeserializeObject<TwitterError>(jsonResponse);
                return new Result<List<WebhookRegistration>>(err);
            }
            else
            {
                return new Result<List<WebhookRegistration>>();
            }
        }

        /// <summary>
        /// Register a new webhook url using the current user (from the auth context).
        /// </summary>
        /// <param name="url">The webhook url to register.</param>
        /// <returns></returns>
        public async Task<Result<WebhookRegistration>> RegisterWebhook(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException(nameof(url));
            }

            //TODO: Provide a generic class to make Twitter API Requests.
            string urlParam = Uri.EscapeUriString(url);
            string resourceUrl = $"https://api.twitter.com/1.1/account_activity/webhooks.json?url={urlParam}";

            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", AuthHeaderBuilder.Build(AuthContext, HttpMethod.Post, resourceUrl));

                response = await client.PostAsync(resourceUrl, new StringContent(""));
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                WebhookRegistration sub = JsonConvert.DeserializeObject<WebhookRegistration>(jsonResponse);
                return new Result<WebhookRegistration>(sub);
            }

            if (!string.IsNullOrEmpty(jsonResponse))
            {
                TwitterError err = JsonConvert.DeserializeObject<TwitterError>(jsonResponse);
                return new Result<WebhookRegistration>(err);
            }
            else
            {
                //TODO: Provide a way to return httpstatus code

                return new Result<WebhookRegistration>();
            }
        }

        /// <summary>
        /// Unregister a webhook from current user (from the auth context) by Id.
        /// </summary>
        /// <param name="webhookId">The Webhook Id to unregister.</param>
        /// <returns></returns>
        public async Task<Result<bool>> UnregisterWebhook(string webhookId)
        {
            //TODO: Provide a generic class to make Twitter API Requests.

            string resourceUrl = $"https://api.twitter.com/1.1/account_activity/webhooks/{webhookId}.json";

            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", AuthHeaderBuilder.Build(AuthContext, HttpMethod.Delete, resourceUrl));

                response = await client.DeleteAsync(resourceUrl);
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
    }
}