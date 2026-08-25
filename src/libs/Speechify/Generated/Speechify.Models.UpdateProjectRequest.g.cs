
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Edits a project's display name, its monthly spend limit, and/or its<br/>
    /// capacity ceilings; at least one field must be present. The project<br/>
    /// id is immutable, so a rename never re-points the resources grouped<br/>
    /// under it. The limit fields are merge-patched: omit one to leave it<br/>
    /// unchanged; the capacity ceilings clear on an explicit `null`, the<br/>
    /// spend limit on `0`.
    /// </summary>
    public sealed partial class UpdateProjectRequest
    {
        /// <summary>
        /// Sets the project's active-call ceiling; `null` removes it.<br/>
        /// Must be a positive integer at or below the workspace's own<br/>
        /// active-call cap, otherwise the request is refused with<br/>
        /// `400 validation_failed` naming the field and the ceiling: a<br/>
        /// project can only narrow the workspace's capacity, never raise<br/>
        /// it. Requires the `billing.manage` permission, like the spend<br/>
        /// limit beside it. Takes effect on the next call start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_calls")]
        public int? MaxConcurrentCalls { get; set; }

        /// <summary>
        /// Sets the project's request-rate ceiling in requests per<br/>
        /// minute; `null` removes it. Must be a positive integer at or<br/>
        /// below the workspace's widest per-surface request rate over a<br/>
        /// minute, otherwise the request is refused with<br/>
        /// `400 validation_failed` naming the field and the ceiling.<br/>
        /// Requires the `billing.manage` permission. Takes effect on the<br/>
        /// next request from a credential pinned to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_requests_per_minute")]
        public int? MaxRequestsPerMinute { get; set; }

        /// <summary>
        /// New project name; unique per workspace (case-insensitive),<br/>
        /// surrounding whitespace is trimmed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Edits the project's MONTHLY spend limit in US dollars: omit to<br/>
        /// leave it unchanged, send a positive value to set or change it, or<br/>
        /// an explicit `0` to remove it. Amounts are whole cents written as a<br/>
        /// plain decimal; a finer value, or exponent notation, is refused<br/>
        /// rather than rounded. Requires the<br/>
        /// `billing.manage`<br/>
        /// permission (owners/admins), like the workspace budget — a<br/>
        /// spend ceiling is a billing control, not a grouping edit. Once the<br/>
        /// project's billed spend within the current calendar month (UTC)<br/>
        /// reaches the limit, new billable work attributed to that project is<br/>
        /// refused with the coded `402 project_spend_limit_exceeded` until<br/>
        /// the month resets or the limit is raised.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget")]
        public double? MonthlyBudget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="maxConcurrentCalls">
        /// Sets the project's active-call ceiling; `null` removes it.<br/>
        /// Must be a positive integer at or below the workspace's own<br/>
        /// active-call cap, otherwise the request is refused with<br/>
        /// `400 validation_failed` naming the field and the ceiling: a<br/>
        /// project can only narrow the workspace's capacity, never raise<br/>
        /// it. Requires the `billing.manage` permission, like the spend<br/>
        /// limit beside it. Takes effect on the next call start.
        /// </param>
        /// <param name="maxRequestsPerMinute">
        /// Sets the project's request-rate ceiling in requests per<br/>
        /// minute; `null` removes it. Must be a positive integer at or<br/>
        /// below the workspace's widest per-surface request rate over a<br/>
        /// minute, otherwise the request is refused with<br/>
        /// `400 validation_failed` naming the field and the ceiling.<br/>
        /// Requires the `billing.manage` permission. Takes effect on the<br/>
        /// next request from a credential pinned to the project.
        /// </param>
        /// <param name="name">
        /// New project name; unique per workspace (case-insensitive),<br/>
        /// surrounding whitespace is trimmed.
        /// </param>
        /// <param name="monthlyBudget">
        /// Edits the project's MONTHLY spend limit in US dollars: omit to<br/>
        /// leave it unchanged, send a positive value to set or change it, or<br/>
        /// an explicit `0` to remove it. Amounts are whole cents written as a<br/>
        /// plain decimal; a finer value, or exponent notation, is refused<br/>
        /// rather than rounded. Requires the<br/>
        /// `billing.manage`<br/>
        /// permission (owners/admins), like the workspace budget — a<br/>
        /// spend ceiling is a billing control, not a grouping edit. Once the<br/>
        /// project's billed spend within the current calendar month (UTC)<br/>
        /// reaches the limit, new billable work attributed to that project is<br/>
        /// refused with the coded `402 project_spend_limit_exceeded` until<br/>
        /// the month resets or the limit is raised.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequest(
            int? maxConcurrentCalls,
            int? maxRequestsPerMinute,
            string? name,
            double? monthlyBudget)
        {
            this.MaxConcurrentCalls = maxConcurrentCalls;
            this.MaxRequestsPerMinute = maxRequestsPerMinute;
            this.Name = name;
            this.MonthlyBudget = monthlyBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        public UpdateProjectRequest()
        {
        }

    }
}