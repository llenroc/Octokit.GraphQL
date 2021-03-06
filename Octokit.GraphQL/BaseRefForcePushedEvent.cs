namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a 'base_ref_force_pushed' event on a given pull request.
    /// </summary>
    public class BaseRefForcePushedEvent : QueryEntity
    {
        public BaseRefForcePushedEvent(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the actor who performed the 'base_ref_force_pushed' event.
        /// </summary>
        public IActor Actor => this.CreateProperty(x => x.Actor, Octokit.GraphQL.Internal.StubIActor.Create);

        /// <summary>
        /// Identifies the after commit SHA for the 'base_ref_force_pushed' event.
        /// </summary>
        public Commit AfterCommit => this.CreateProperty(x => x.AfterCommit, Octokit.GraphQL.Commit.Create);

        /// <summary>
        /// Identifies the before commit SHA for the 'base_ref_force_pushed' event.
        /// </summary>
        public Commit BeforeCommit => this.CreateProperty(x => x.BeforeCommit, Octokit.GraphQL.Commit.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        public string Id { get; }

        /// <summary>
        /// PullRequest referenced by event.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.GraphQL.PullRequest.Create);

        /// <summary>
        /// Identifies the fully qualified ref name for the 'base_ref_force_pushed' event.
        /// </summary>
        public Ref Ref => this.CreateProperty(x => x.Ref, Octokit.GraphQL.Ref.Create);

        internal static BaseRefForcePushedEvent Create(IQueryProvider provider, Expression expression)
        {
            return new BaseRefForcePushedEvent(provider, expression);
        }
    }
}