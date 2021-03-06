namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a starred repository.
    /// </summary>
    public class StarredRepositoryEdge : QueryEntity
    {
        public StarredRepositoryEdge(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        public string Cursor { get; }

        public Repository Node => this.CreateProperty(x => x.Node, Octokit.GraphQL.Repository.Create);

        /// <summary>
        /// Identifies when the item was starred.
        /// </summary>
        public string StarredAt { get; }

        internal static StarredRepositoryEdge Create(IQueryProvider provider, Expression expression)
        {
            return new StarredRepositoryEdge(provider, expression);
        }
    }
}