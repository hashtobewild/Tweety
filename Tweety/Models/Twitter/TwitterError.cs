using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Tweety.Models.Twitter
{

    /// <summary>
    /// Represents a twitter error
    /// </summary>
    public class TwitterError
    {
        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Join("\n", Errors.Select(err => $"Error Code: {err.Code}, Error Message: {err.Message}"));
        }
    }
}