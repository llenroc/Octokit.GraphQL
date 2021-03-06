namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// A repository contains the content for a project.
    /// </summary>
    public class Repository : QueryEntity
    {
        public Repository(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Returns the code of conduct for this repository
        /// </summary>
        public CodeOfConduct CodeOfConduct => this.CreateProperty(x => x.CodeOfConduct, Octokit.GraphQL.CodeOfConduct.Create);

        /// <summary>
        /// A list of commit comments associated with the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public CommitCommentConnection CommitComments(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.CommitComments(first, after, last, before), Octokit.GraphQL.CommitCommentConnection.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public string CreatedAt { get; }

        /// <summary>
        /// Identifies the primary key from the database.
        /// </summary>
        public int? DatabaseId { get; }

        /// <summary>
        /// The Ref associated with the repository's default branch.
        /// </summary>
        public Ref DefaultBranchRef => this.CreateProperty(x => x.DefaultBranchRef, Octokit.GraphQL.Ref.Create);

        /// <summary>
        /// The description of the repository.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The description of the repository rendered to HTML.
        /// </summary>
        public string DescriptionHTML { get; }

        /// <summary>
        /// The number of kilobytes this repository occupies on disk.
        /// </summary>
        public int? DiskUsage { get; }

        /// <summary>
        /// A list of forked repositories.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="privacy">If non-null, filters repositories according to privacy</param>
        /// <param name="orderBy">Ordering options for repositories returned from the connection</param>
        /// <param name="affiliations">Affiliation options for repositories returned from the connection</param>
        /// <param name="isLocked">If non-null, filters repositories according to whether they have been locked</param>
        public RepositoryConnection Forks(int? first = null, string after = null, int? last = null, string before = null, RepositoryPrivacy? privacy = null, RepositoryOrder orderBy = null, IQueryable<RepositoryAffiliation?> affiliations = null, bool? isLocked = null) => this.CreateMethodCall(x => x.Forks(first, after, last, before, privacy, orderBy, affiliations, isLocked), Octokit.GraphQL.RepositoryConnection.Create);

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

        public string Id { get; }

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
        /// Returns a single issue from the current repository by number.
        /// </summary>
        /// <param name="number">The number for the issue to be returned.</param>
        public Issue Issue(int number) => this.CreateMethodCall(x => x.Issue(number), Octokit.GraphQL.Issue.Create);

        /// <summary>
        /// Returns a single issue-like object from the current repository by number.
        /// </summary>
        /// <param name="number">The number for the issue to be returned.</param>
        public IssueOrPullRequest IssueOrPullRequest(int number) => this.CreateMethodCall(x => x.IssueOrPullRequest(number), Octokit.GraphQL.IssueOrPullRequest.Create);

        /// <summary>
        /// A list of issues that have been opened in the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="states">A list of states to filter the issues by.</param>
        /// <param name="labels">A list of label names to filter the issues by.</param>
        public IssueConnection Issues(int? first = null, string after = null, int? last = null, string before = null, IQueryable<IssueState?> states = null, IQueryable<string> labels = null) => this.CreateMethodCall(x => x.Issues(first, after, last, before, states, labels), Octokit.GraphQL.IssueConnection.Create);

        /// <summary>
        /// Returns a single label by name
        /// </summary>
        /// <param name="name">Label name</param>
        public Label Label(string name) => this.CreateMethodCall(x => x.Label(name), Octokit.GraphQL.Label.Create);

        /// <summary>
        /// A list of labels associated with the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public LabelConnection Labels(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Labels(first, after, last, before), Octokit.GraphQL.LabelConnection.Create);

        /// <summary>
        /// A list containing a breakdown of the language composition of the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="orderBy">Order for connection</param>
        public LanguageConnection Languages(int? first = null, string after = null, int? last = null, string before = null, LanguageOrder orderBy = null) => this.CreateMethodCall(x => x.Languages(first, after, last, before, orderBy), Octokit.GraphQL.LanguageConnection.Create);

        /// <summary>
        /// The license associated with the repository
        /// </summary>
        public string License { get; }

        /// <summary>
        /// The reason the repository has been locked.
        /// </summary>
        public RepositoryLockReason? LockReason { get; }

        /// <summary>
        /// A list of Users that can be mentioned in the context of the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public UserConnection MentionableUsers(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.MentionableUsers(first, after, last, before), Octokit.GraphQL.UserConnection.Create);

        /// <summary>
        /// Returns a single milestone from the current repository by number.
        /// </summary>
        /// <param name="number">The number for the milestone to be returned.</param>
        public Milestone Milestone(int number) => this.CreateMethodCall(x => x.Milestone(number), Octokit.GraphQL.Milestone.Create);

        /// <summary>
        /// A list of milestones associated with the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public MilestoneConnection Milestones(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Milestones(first, after, last, before), Octokit.GraphQL.MilestoneConnection.Create);

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
        /// A Git object in the repository
        /// </summary>
        /// <param name="oid">The Git object ID</param>
        /// <param name="expression">A Git revision expression suitable for rev-parse</param>
        public IGitObject Object(string oid = null, string expression = null) => this.CreateMethodCall(x => x.Object(oid, expression), Octokit.GraphQL.Internal.StubIGitObject.Create);

        /// <summary>
        /// The User owner of the repository.
        /// </summary>
        public IRepositoryOwner Owner => this.CreateProperty(x => x.Owner, Octokit.GraphQL.Internal.StubIRepositoryOwner.Create);

        /// <summary>
        /// The repository parent, if this is a fork.
        /// </summary>
        public Repository Parent => this.CreateProperty(x => x.Parent, Octokit.GraphQL.Repository.Create);

        /// <summary>
        /// The HTTP path for this repository
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The primary language of the repository's code.
        /// </summary>
        public Language PrimaryLanguage => this.CreateProperty(x => x.PrimaryLanguage, Octokit.GraphQL.Language.Create);

        /// <summary>
        /// Find project by number.
        /// </summary>
        /// <param name="number">The project number to find.</param>
        public Project Project(int number) => this.CreateMethodCall(x => x.Project(number), Octokit.GraphQL.Project.Create);

        /// <summary>
        /// A list of projects under the owner.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="orderBy">Ordering options for projects returned from the connection</param>
        /// <param name="search">Query to search projects by, currently only searching by name.</param>
        /// <param name="states">A list of states to filter the projects by.</param>
        public ProjectConnection Projects(int? first = null, string after = null, int? last = null, string before = null, ProjectOrder orderBy = null, string search = null, IQueryable<ProjectState> states = null) => this.CreateMethodCall(x => x.Projects(first, after, last, before, orderBy, search, states), Octokit.GraphQL.ProjectConnection.Create);

        /// <summary>
        /// The HTTP path listing repository's projects
        /// </summary>
        public string ProjectsPath { get; }

        /// <summary>
        /// The HTTP path listing repository's projects
        /// </summary>
        public string ProjectsResourcePath { get; }

        /// <summary>
        /// The HTTP url listing repository's projects
        /// </summary>
        public string ProjectsUrl { get; }

        /// <summary>
        /// A list of protected branches that are on this repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public ProtectedBranchConnection ProtectedBranches(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.ProtectedBranches(first, after, last, before), Octokit.GraphQL.ProtectedBranchConnection.Create);

        /// <summary>
        /// Returns a single pull request from the current repository by number.
        /// </summary>
        /// <param name="number">The number for the pull request to be returned.</param>
        public PullRequest PullRequest(int number) => this.CreateMethodCall(x => x.PullRequest(number), Octokit.GraphQL.PullRequest.Create);

        /// <summary>
        /// A list of pull requests that have been opened in the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="states">A list of states to filter the pull requests by.</param>
        /// <param name="labels">A list of label names to filter the pull requests by.</param>
        /// <param name="headRefName">The head ref name to filter the pull requests by.</param>
        /// <param name="baseRefName">The base ref name to filter the pull requests by.</param>
        public PullRequestConnection PullRequests(int? first = null, string after = null, int? last = null, string before = null, IQueryable<PullRequestState> states = null, IQueryable<string> labels = null, string headRefName = null, string baseRefName = null) => this.CreateMethodCall(x => x.PullRequests(first, after, last, before, states, labels, headRefName, baseRefName), Octokit.GraphQL.PullRequestConnection.Create);

        /// <summary>
        /// Identifies when the repository was last pushed to.
        /// </summary>
        public string PushedAt { get; }

        /// <summary>
        /// Fetch a given ref from the repository
        /// </summary>
        /// <param name="qualifiedName">The ref to retrieve.Fully qualified matches are checked in order (`refs/heads/master`) before falling back onto checks for short name matches (`master`).</param>
        public Ref Ref(string qualifiedName) => this.CreateMethodCall(x => x.Ref(qualifiedName), Octokit.GraphQL.Ref.Create);

        /// <summary>
        /// Fetch a list of refs from the repository
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="refPrefix">A ref name prefix like `refs/heads/`, `refs/tags/`, etc.</param>
        /// <param name="direction">The ordering direction.</param>
        public RefConnection Refs(string refPrefix, int? first = null, string after = null, int? last = null, string before = null, OrderDirection? direction = null) => this.CreateMethodCall(x => x.Refs(refPrefix, first, after, last, before, direction), Octokit.GraphQL.RefConnection.Create);

        /// <summary>
        /// List of releases which are dependent on this repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public ReleaseConnection Releases(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Releases(first, after, last, before), Octokit.GraphQL.ReleaseConnection.Create);

        /// <summary>
        /// A list of applied repository-topic associations for this repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public RepositoryTopicConnection RepositoryTopics(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.RepositoryTopics(first, after, last, before), Octokit.GraphQL.RepositoryTopicConnection.Create);

        /// <summary>
        /// The HTTP path for this repository
        /// </summary>
        public string ResourcePath { get; }

        /// <summary>
        /// A list of users who have starred this repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        /// <param name="orderBy">Order for connection</param>
        public StargazerConnection Stargazers(int? first = null, string after = null, int? last = null, string before = null, StarOrder orderBy = null) => this.CreateMethodCall(x => x.Stargazers(first, after, last, before, orderBy), Octokit.GraphQL.StargazerConnection.Create);

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        public string UpdatedAt { get; }

        /// <summary>
        /// The HTTP url for this repository
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Indicates whether the viewer has admin permissions on this repository.
        /// </summary>
        public bool ViewerCanAdminister { get; }

        /// <summary>
        /// Can the current viewer create new projects on this owner.
        /// </summary>
        public bool ViewerCanCreateProjects { get; }

        /// <summary>
        /// Check if the viewer is able to change their subscription status for the repository.
        /// </summary>
        public bool ViewerCanSubscribe { get; }

        /// <summary>
        /// Indicates whether the viewer can update the topics of this repository.
        /// </summary>
        public bool ViewerCanUpdateTopics { get; }

        /// <summary>
        /// Returns a boolean indicating whether the viewing user has starred this repository.
        /// </summary>
        public bool ViewerHasStarred { get; }

        /// <summary>
        /// Identifies if the viewer is watching, not watching, or ignoring the repository.
        /// </summary>
        public SubscriptionState ViewerSubscription { get; }

        /// <summary>
        /// A list of users watching the repository.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public UserConnection Watchers(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Watchers(first, after, last, before), Octokit.GraphQL.UserConnection.Create);

        internal static Repository Create(IQueryProvider provider, Expression expression)
        {
            return new Repository(provider, expression);
        }
    }
}