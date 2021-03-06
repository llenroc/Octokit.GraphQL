namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a Git blob.
    /// </summary>
    public class Blob : QueryEntity
    {
        public Blob(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// An abbreviated version of the Git object ID
        /// </summary>
        public string AbbreviatedOid { get; }

        /// <summary>
        /// Byte size of Blob object
        /// </summary>
        public int ByteSize { get; }

        /// <summary>
        /// The HTTP path for this Git object
        /// </summary>
        public string CommitPath { get; }

        /// <summary>
        /// The HTTP path for this Git object
        /// </summary>
        public string CommitResourcePath { get; }

        /// <summary>
        /// The HTTP url for this Git object
        /// </summary>
        public string CommitUrl { get; }

        public string Id { get; }

        /// <summary>
        /// Indicates whether the Blob is binary or text
        /// </summary>
        public bool IsBinary { get; }

        /// <summary>
        /// Indicates whether the contents is truncated
        /// </summary>
        public bool IsTruncated { get; }

        /// <summary>
        /// The Git object ID
        /// </summary>
        public string Oid { get; }

        /// <summary>
        /// The Repository the Git object belongs to
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.GraphQL.Repository.Create);

        /// <summary>
        /// UTF8 text data or null if the Blob is binary
        /// </summary>
        public string Text { get; }

        internal static Blob Create(IQueryProvider provider, Expression expression)
        {
            return new Blob(provider, expression);
        }
    }
}