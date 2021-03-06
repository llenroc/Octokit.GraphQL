namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// A subset of repository info shared with potential collaborators.
    /// </summary>
    public class RepositoryInvitationRepository : QueryEntity
    {
        public RepositoryInvitationRepository(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        /// <summary>
        /// The description of the repository.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The description of the repository rendered to HTML.
        /// </summary>
        public string DescriptionHTML { get; }

        /// <summary>
        /// Indicates if the repository has issues feature enabled.
        /// </summary>
        public bool HasIssuesEnabled { get; }

        /// <summary>
        /// Indicates if the repository has wiki feature enabled.
        /// </summary>
        public bool HasWikiEnabled { get; }

        /// <summary>
        /// The repository's URL.
        /// </summary>
        public string HomepageUrl { get; }

        /// <summary>
        /// Identifies if the repository is a fork.
        /// </summary>
        public bool IsFork { get; }

        /// <summary>
        /// Indicates if the repository has been locked or not.
        /// </summary>
        public bool IsLocked { get; }

        /// <summary>
        /// Identifies if the repository is a mirror.
        /// </summary>
        public bool IsMirror { get; }

        /// <summary>
        /// Identifies if the repository is private.
        /// </summary>
        public bool IsPrivate { get; }

        /// <summary>
        /// The license associated with the repository
        /// </summary>
        public string License { get; }

        /// <summary>
        /// The reason the repository has been locked.
        /// </summary>
        public RepositoryLockReason? LockReason { get; }

        /// <summary>
        /// The repository's original mirror URL.
        /// </summary>
        public string MirrorUrl { get; }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The repository's name with owner.
        /// </summary>
        public string NameWithOwner { get; }

        /// <summary>
        /// The User owner of the repository.
        /// </summary>
        public IRepositoryOwner Owner => this.CreateProperty(x => x.Owner, Octokit.GraphQL.Internal.StubIRepositoryOwner.Create);

        /// <summary>
        /// The HTTP path for this repository
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// Identifies when the repository was last pushed to.
        /// </summary>
        public string PushedAt { get; }

        /// <summary>
        /// The HTTP path for this repository
        /// </summary>
        public string ResourcePath { get; }

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        public string UpdatedAt { get; }

        /// <summary>
        /// The HTTP url for this repository
        /// </summary>
        public string Url { get; }

        internal static RepositoryInvitationRepository Create(IQueryProvider provider, Expression expression)
        {
            return new RepositoryInvitationRepository(provider, expression);
        }
    }
}