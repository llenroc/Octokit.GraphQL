namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// A Gist.
    /// </summary>
    public class Gist : QueryEntity
    {
        public Gist(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        /// <summary>
        /// The gist description.
        /// </summary>
        public string Description { get; }

        public string Id { get; }

        /// <summary>
        /// Whether the gist is public or not.
        /// </summary>
        public bool IsPublic { get; }

        /// <summary>
        /// The gist name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The gist owner.
        /// </summary>
        public IRepositoryOwner Owner => this.CreateProperty(x => x.Owner, Octokit.GraphQL.Internal.StubIRepositoryOwner.Create);

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        public string UpdatedAt { get; }

        internal static Gist Create(IQueryProvider provider, Expression expression)
        {
            return new Gist(provider, expression);
        }
    }
}