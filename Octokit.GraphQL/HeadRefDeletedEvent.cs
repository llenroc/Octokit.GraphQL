namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a 'head_ref_deleted' event on a given pull request.
    /// </summary>
    public class HeadRefDeletedEvent : QueryEntity
    {
        public HeadRefDeletedEvent(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the actor who performed the 'head_ref_deleted' event.
        /// </summary>
        public IActor Actor => this.CreateProperty(x => x.Actor, Octokit.GraphQL.Internal.StubIActor.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        /// <summary>
        /// Identifies the Ref associated with the `head_ref_deleted` event.
        /// </summary>
        public Ref HeadRef => this.CreateProperty(x => x.HeadRef, Octokit.GraphQL.Ref.Create);

        /// <summary>
        /// Identifies the name of the Ref associated with the `head_ref_deleted` event.
        /// </summary>
        public string HeadRefName { get; }

        public string Id { get; }

        /// <summary>
        /// PullRequest referenced by event.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.GraphQL.PullRequest.Create);

        internal static HeadRefDeletedEvent Create(IQueryProvider provider, Expression expression)
        {
            return new HeadRefDeletedEvent(provider, expression);
        }
    }
}