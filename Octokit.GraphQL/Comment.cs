namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a comment.
    /// </summary>
    public interface IComment : IQueryEntity
    {
        /// <summary>
        /// The actor who authored the comment.
        /// </summary>
        IActor Author { get; }

        /// <summary>
        /// The comment body as Markdown.
        /// </summary>
        string Body { get; }

        /// <summary>
        /// The comment body rendered to HTML.
        /// </summary>
        string BodyHTML { get; }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        string CreatedAt { get; }

        /// <summary>
        /// Check if this comment was created via an email reply.
        /// </summary>
        bool CreatedViaEmail { get; }

        /// <summary>
        /// The actor who edited the comment.
        /// </summary>
        IActor Editor { get; }

        string Id { get; }

        /// <summary>
        /// The moment the editor made the last edit
        /// </summary>
        string LastEditedAt { get; }

        /// <summary>
        /// Identifies when the comment was published at.
        /// </summary>
        string PublishedAt { get; }

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        string UpdatedAt { get; }

        /// <summary>
        /// Did the viewer author this comment.
        /// </summary>
        bool ViewerDidAuthor { get; }
    }
}

namespace Octokit.GraphQL.Internal
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    internal class StubIComment : QueryEntity, IComment
    {
        public StubIComment(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        public IActor Author => this.CreateProperty(x => x.Author, Octokit.GraphQL.Internal.StubIActor.Create);

        public string Body { get; }

        public string BodyHTML { get; }

        public string CreatedAt { get; }

        public bool CreatedViaEmail { get; }

        public IActor Editor => this.CreateProperty(x => x.Editor, Octokit.GraphQL.Internal.StubIActor.Create);

        public string Id { get; }

        public string LastEditedAt { get; }

        public string PublishedAt { get; }

        public string UpdatedAt { get; }

        public bool ViewerDidAuthor { get; }

        internal static StubIComment Create(IQueryProvider provider, Expression expression)
        {
            return new StubIComment(provider, expression);
        }
    }
}