
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A workspace project: resource grouping that a member grant or a<br/>
    /// credential pin can also scope. Resources<br/>
    /// (agents, knowledge bases, phone numbers, tools, audio) reference a<br/>
    /// project by id; a resource with no `project_id` lives in the<br/>
    /// implicit Default project. A project can carry member grants, which<br/>
    /// scope a granted member to the projects they hold, and the invoice<br/>
    /// stays workspace-level with no billing split. A project may<br/>
    /// carry a monthly spend LIMIT, which bounds work without splitting<br/>
    /// the bill, capacity CEILINGS (`max_concurrent_calls`,<br/>
    /// `max_requests_per_minute`) that sit below the workspace's own<br/>
    /// plan limits so one project cannot consume the whole allowance,<br/>
    /// and it may be ARCHIVED, which suspends all work and spend inside<br/>
    /// it while everything stays readable.
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// When the project was archived; `null` while it is live. While<br/>
        /// set, nothing new starts or bills inside the project and every<br/>
        /// such attempt answers `409 project_archived`.<br/>
        /// Absent rather than null while a console runs ahead of an API<br/>
        /// that predates archiving, which is why it is not required:<br/>
        /// read absent and null alike.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// When this project was purged, present only on the rows returned<br/>
        /// by `include_purged=true`. A purged project is kept for 30 days<br/>
        /// from this stamp and permanently deleted after that, so the<br/>
        /// restore deadline is this value plus the window; it is absent on<br/>
        /// every project that still exists. Restore it with<br/>
        /// `POST /v1/projects/{project_id}/restore`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purged_at")]
        public global::System.DateTime? PurgedAt { get; set; }

        /// <summary>
        /// The most voice-agent calls this project may have active at<br/>
        /// once, present only when set. Checked after the workspace's own<br/>
        /// active-call cap on every call start (web session, outbound<br/>
        /// call, batch dial, inbound SIP), keyed on the project the<br/>
        /// call's agent lives in: a call over the ceiling is refused with<br/>
        /// the same `429 concurrency_limit_reached` the workspace cap<br/>
        /// answers (an inbound caller hears the busy message), while<br/>
        /// sibling projects keep their headroom. Never higher than the<br/>
        /// workspace's cap: a project can narrow the workspace's<br/>
        /// capacity, not raise it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_calls")]
        public int? MaxConcurrentCalls { get; set; }

        /// <summary>
        /// The most API requests per minute credentials pinned to this<br/>
        /// project may make across every surface, present only when set.<br/>
        /// Checked after the workspace's own request-rate limit, in one<br/>
        /// bucket per project: a request over the ceiling is refused with<br/>
        /// the same `429 rate_limited` the workspace limit answers, while<br/>
        /// other projects and unpinned credentials are untouched. Never<br/>
        /// higher than the workspace's widest per-surface rate over a<br/>
        /// minute: a project can narrow the workspace's capacity, not<br/>
        /// raise it. Console sessions and unpinned keys carry no project<br/>
        /// and are never subject to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_minute")]
        public int? MaxRequestsPerMinute { get; set; }

        /// <summary>
        /// The project's monthly spend limit in US dollars, present only<br/>
        /// when one is set. New billable work attributed to this project is<br/>
        /// refused with the coded `402 project_spend_limit_exceeded` once<br/>
        /// `monthly_spend` reaches it; the limit resets at the calendar-month<br/>
        /// boundary (UTC).<br/>
        /// Spend is attributed the same way it is billed: work from a<br/>
        /// project-pinned API key counts against that key's project, and a<br/>
        /// voice-agent conversation counts against its agent's project. The<br/>
        /// implicit Default project cannot carry a limit — it has no project<br/>
        /// record — so spend there is bounded by the workspace's<br/>
        /// `monthly_budget` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget")]
        public double? MonthlyBudget { get; set; }

        /// <summary>
        /// The project's billed month-to-date spend in US dollars, present<br/>
        /// whenever the billing plane answered - regardless of whether a<br/>
        /// spend limit is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_spend")]
        public double? MonthlySpend { get; set; }

        /// <summary>
        /// Workspace-scoped project identifier (prefixed external id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable label, unique per workspace (case-insensitive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">
        /// Workspace-scoped project identifier (prefixed external id).
        /// </param>
        /// <param name="name">
        /// Human-readable label, unique per workspace (case-insensitive).
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="archivedAt">
        /// When the project was archived; `null` while it is live. While<br/>
        /// set, nothing new starts or bills inside the project and every<br/>
        /// such attempt answers `409 project_archived`.<br/>
        /// Absent rather than null while a console runs ahead of an API<br/>
        /// that predates archiving, which is why it is not required:<br/>
        /// read absent and null alike.
        /// </param>
        /// <param name="purgedAt">
        /// When this project was purged, present only on the rows returned<br/>
        /// by `include_purged=true`. A purged project is kept for 30 days<br/>
        /// from this stamp and permanently deleted after that, so the<br/>
        /// restore deadline is this value plus the window; it is absent on<br/>
        /// every project that still exists. Restore it with<br/>
        /// `POST /v1/projects/{project_id}/restore`.
        /// </param>
        /// <param name="maxConcurrentCalls">
        /// The most voice-agent calls this project may have active at<br/>
        /// once, present only when set. Checked after the workspace's own<br/>
        /// active-call cap on every call start (web session, outbound<br/>
        /// call, batch dial, inbound SIP), keyed on the project the<br/>
        /// call's agent lives in: a call over the ceiling is refused with<br/>
        /// the same `429 concurrency_limit_reached` the workspace cap<br/>
        /// answers (an inbound caller hears the busy message), while<br/>
        /// sibling projects keep their headroom. Never higher than the<br/>
        /// workspace's cap: a project can narrow the workspace's<br/>
        /// capacity, not raise it.
        /// </param>
        /// <param name="maxRequestsPerMinute">
        /// The most API requests per minute credentials pinned to this<br/>
        /// project may make across every surface, present only when set.<br/>
        /// Checked after the workspace's own request-rate limit, in one<br/>
        /// bucket per project: a request over the ceiling is refused with<br/>
        /// the same `429 rate_limited` the workspace limit answers, while<br/>
        /// other projects and unpinned credentials are untouched. Never<br/>
        /// higher than the workspace's widest per-surface rate over a<br/>
        /// minute: a project can narrow the workspace's capacity, not<br/>
        /// raise it. Console sessions and unpinned keys carry no project<br/>
        /// and are never subject to it.
        /// </param>
        /// <param name="monthlyBudget">
        /// The project's monthly spend limit in US dollars, present only<br/>
        /// when one is set. New billable work attributed to this project is<br/>
        /// refused with the coded `402 project_spend_limit_exceeded` once<br/>
        /// `monthly_spend` reaches it; the limit resets at the calendar-month<br/>
        /// boundary (UTC).<br/>
        /// Spend is attributed the same way it is billed: work from a<br/>
        /// project-pinned API key counts against that key's project, and a<br/>
        /// voice-agent conversation counts against its agent's project. The<br/>
        /// implicit Default project cannot carry a limit — it has no project<br/>
        /// record — so spend there is bounded by the workspace's<br/>
        /// `monthly_budget` instead.
        /// </param>
        /// <param name="monthlySpend">
        /// The project's billed month-to-date spend in US dollars, present<br/>
        /// whenever the billing plane answered - regardless of whether a<br/>
        /// spend limit is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Project(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? archivedAt,
            global::System.DateTime? purgedAt,
            int? maxConcurrentCalls,
            int? maxRequestsPerMinute,
            double? monthlyBudget,
            double? monthlySpend)
        {
            this.ArchivedAt = archivedAt;
            this.PurgedAt = purgedAt;
            this.MaxConcurrentCalls = maxConcurrentCalls;
            this.MaxRequestsPerMinute = maxRequestsPerMinute;
            this.MonthlyBudget = monthlyBudget;
            this.MonthlySpend = monthlySpend;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }

    }
}