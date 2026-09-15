
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A run as the project run stream reports it: which run, whose, where it<br/>
    /// stands and what it is waiting on. Each field means what it means on the<br/>
    /// run object, except `user_identity`, which the run object carries under<br/>
    /// `input`. What the run was asked and what it answered are never here.
    /// </summary>
    public sealed partial class AgentRunLifecycle
    {
        /// <summary>
        /// Run id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The agent running it. On a delegated child this is the member agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The project the run belongs to; null in the Default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Where the run stands. On `run.ended` it is one of `succeeded`, `failed`, `canceled` or `expired`; on `run.updated` it never is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunLifecycleStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentRunLifecycleStatus Status { get; set; }

        /// <summary>
        /// The person the run acts for. Absent when it acts for nobody in particular.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

        /// <summary>
        /// A human approval a run is durably parked on (present on `AgentRun` only while `status` is `requires_action`). Rendered VERBATIM for the approver - never a summary the agent wrote - so an injected agent cannot misrepresent what it is about to do. Resolve it with `submitRun`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_action")]
        public global::Speechify.PendingAction? PendingAction { get; set; }

        /// <summary>
        /// Why a settled run stopped short, as on the run object: `max_turns_exhausted`, `budget_exhausted` or `output_schema_violation`, or a sentence on an `expired` run. Absent when it finished its work.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_reason")]
        public string? IncompleteReason { get; set; }

        /// <summary>
        /// How the run failed. Present only on a `failed` run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Speechify.AgentRunLifecycleError? Error { get; set; }

        /// <summary>
        /// The run's metadata. `trigger` says how the run started: `api`, `manual`, `schedule`, `webhook`, `team` or `delegation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The run that delegated this one a sub-goal. Absent on a root run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        public string? ParentRunId { get; set; }

        /// <summary>
        /// When the run was accepted and queued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When a worker picked the run up. Absent while `queued`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the run settled. Present only on `run.ended`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunLifecycle" /> class.
        /// </summary>
        /// <param name="id">
        /// Run id.
        /// </param>
        /// <param name="agentId">
        /// The agent running it. On a delegated child this is the member agent.
        /// </param>
        /// <param name="status">
        /// Where the run stands. On `run.ended` it is one of `succeeded`, `failed`, `canceled` or `expired`; on `run.updated` it never is.
        /// </param>
        /// <param name="createdAt">
        /// When the run was accepted and queued.
        /// </param>
        /// <param name="projectId">
        /// The project the run belongs to; null in the Default project.
        /// </param>
        /// <param name="userIdentity">
        /// The person the run acts for. Absent when it acts for nobody in particular.
        /// </param>
        /// <param name="pendingAction">
        /// A human approval a run is durably parked on (present on `AgentRun` only while `status` is `requires_action`). Rendered VERBATIM for the approver - never a summary the agent wrote - so an injected agent cannot misrepresent what it is about to do. Resolve it with `submitRun`.
        /// </param>
        /// <param name="incompleteReason">
        /// Why a settled run stopped short, as on the run object: `max_turns_exhausted`, `budget_exhausted` or `output_schema_violation`, or a sentence on an `expired` run. Absent when it finished its work.
        /// </param>
        /// <param name="error">
        /// How the run failed. Present only on a `failed` run.
        /// </param>
        /// <param name="metadata">
        /// The run's metadata. `trigger` says how the run started: `api`, `manual`, `schedule`, `webhook`, `team` or `delegation`.
        /// </param>
        /// <param name="parentRunId">
        /// The run that delegated this one a sub-goal. Absent on a root run.
        /// </param>
        /// <param name="startedAt">
        /// When a worker picked the run up. Absent while `queued`.
        /// </param>
        /// <param name="endedAt">
        /// When the run settled. Present only on `run.ended`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunLifecycle(
            string id,
            string agentId,
            global::Speechify.AgentRunLifecycleStatus status,
            global::System.DateTime createdAt,
            string? projectId,
            string? userIdentity,
            global::Speechify.PendingAction? pendingAction,
            string? incompleteReason,
            global::Speechify.AgentRunLifecycleError? error,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? parentRunId,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ProjectId = projectId;
            this.Status = status;
            this.UserIdentity = userIdentity;
            this.PendingAction = pendingAction;
            this.IncompleteReason = incompleteReason;
            this.Error = error;
            this.Metadata = metadata;
            this.ParentRunId = parentRunId;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunLifecycle" /> class.
        /// </summary>
        public AgentRunLifecycle()
        {
        }

    }
}