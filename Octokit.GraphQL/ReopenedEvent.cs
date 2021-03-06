namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a 'reopened' event on any `Closable`.
    /// </summary>
    public class ReopenedEvent : QueryEntity
    {
        public ReopenedEvent(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the actor who reopened the item.
        /// </summary>
        public IActor Actor => this.CreateProperty(x => x.Actor, Octokit.GraphQL.Internal.StubIActor.Create);

        /// <summary>
        /// Object that was reopened.
        /// </summary>
        public IClosable Closable => this.CreateProperty(x => x.Closable, Octokit.GraphQL.Internal.StubIClosable.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        public string Id { get; }

        internal static ReopenedEvent Create(IQueryProvider provider, Expression expression)
        {
            return new ReopenedEvent(provider, expression);
        }
    }
}