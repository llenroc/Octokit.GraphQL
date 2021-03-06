namespace Octokit.GraphQL
{
    using System.Linq;

    /// <summary>
    /// Autogenerated input type of DeclineTopicSuggestion
    /// </summary>
    public class DeclineTopicSuggestionInput
    {
        public string ClientMutationId { get; set; }

        public string RepositoryId { get; set; }

        public string Name { get; set; }

        public TopicSuggestionDeclineReason Reason { get; set; }
    }
}