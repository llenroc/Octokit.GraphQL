using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Octokit.GraphQL
{
    /// <summary>
    /// The possible PubSub channels for an issue.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IssuePubSubTopic
    {
        /// <summary>
        /// The channel ID for observing issue updates.
        /// </summary>
        [EnumMember(Value = "UPDATED")]
        Updated,

        /// <summary>
        /// The channel ID for marking an issue as read.
        /// </summary>
        [EnumMember(Value = "MARKASREAD")]
        Markasread,
    }
}