namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// The results of a search.
    /// </summary>
    public class SearchResultItem : QueryEntity, IUnion
    {
        public SearchResultItem(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// An Issue is a place to discuss ideas, enhancements, tasks, and bugs for a project.
        /// </summary>
        public Issue Issue => this.CreateProperty(x => x.Issue, Octokit.GraphQL.Issue.Create);

        /// <summary>
        /// A repository pull request.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.GraphQL.PullRequest.Create);

        /// <summary>
        /// A repository contains the content for a project.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.GraphQL.Repository.Create);

        /// <summary>
        /// A user is an individual's account on GitHub that owns repositories and can make new content.
        /// </summary>
        public User User => this.CreateProperty(x => x.User, Octokit.GraphQL.User.Create);

        /// <summary>
        /// An account on GitHub, with one or more owners, that has repositories, members and teams.
        /// </summary>
        public Organization Organization => this.CreateProperty(x => x.Organization, Octokit.GraphQL.Organization.Create);

        internal static SearchResultItem Create(IQueryProvider provider, Expression expression)
        {
            return new SearchResultItem(provider, expression);
        }
    }
}