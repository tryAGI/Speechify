
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A durable async agent run. Enqueue it, get this handle, follow it with the run event stream (or poll `status`) until terminal. Backed by a durable job, so it survives a deploy.
    /// </summary>
    public sealed partial class AgentRun
    {
        /// <summary>
        /// The project this run belongs to; null when it belongs to none.<br/>
        /// Captured when the run was created, so it does not move if the agent later does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Run id (prefixed external id, `arun_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The agent that ran. On a delegated child this is the member agent, not the manager.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Lifecycle: `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentRunStatus Status { get; set; }

        /// <summary>
        /// The frozen request the run was created with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentRunInput Input { get; set; }

        /// <summary>
        /// The run's result, present only when `status` is `succeeded`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Speechify.AgentRunOutput? Output { get; set; }

        /// <summary>
        /// Present only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Speechify.AgentRunError? Error { get; set; }

        /// <summary>
        /// Why a non-failed run stopped short: `max_turns_exhausted`, `budget_exhausted`, or `output_schema_violation` (the agent never produced an object matching `input.output_schema`; `output.reply` keeps its prose and `output.data` is absent).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunIncompleteReasonJsonConverter))]
        public global::Speechify.AgentRunIncompleteReason? IncompleteReason { get; set; }

        /// <summary>
        /// What the run cost, populated once it reaches a terminal state: its wall-clock time plus its token usage summed across every step.<br/>
        /// The counts are THIS run's own. A run that delegated sub-goals does not include its children's, so a team run's true cost is this plus the usage of each run from `listRunChildren`.<br/>
        /// Attribute and forecast spend against the token counts. The model is not reported; your plan, not a model name, is what prices a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Speechify.AgentRunUsage? Usage { get; set; }

        /// <summary>
        /// A human approval a run is durably parked on (present on `AgentRun` only while `status` is `requires_action`). Rendered VERBATIM for the approver - never a summary the agent wrote - so an injected agent cannot misrepresent what it is about to do. Resolve it with `submitRun`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_action")]
        public global::Speechify.PendingAction? PendingAction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The run that delegated this one a sub-goal, absent on a root run. It is the upward half of lineage - what makes a child run of a member agent attributable to the team run that caused it (`listRunChildren` is the downward half).
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
        /// When a worker picked the run up. Absent while `queued`; the gap between this and `created_at` is queue wait, not agent time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the run settled. Present for every terminal status - succeeded, failed, canceled and expired alike - and absent otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Run id (prefixed external id, `arun_...`).
        /// </param>
        /// <param name="agentId">
        /// The agent that ran. On a delegated child this is the member agent, not the manager.
        /// </param>
        /// <param name="status">
        /// Lifecycle: `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </param>
        /// <param name="input">
        /// The frozen request the run was created with.
        /// </param>
        /// <param name="createdAt">
        /// When the run was accepted and queued.
        /// </param>
        /// <param name="projectId">
        /// The project this run belongs to; null when it belongs to none.<br/>
        /// Captured when the run was created, so it does not move if the agent later does.
        /// </param>
        /// <param name="output">
        /// The run's result, present only when `status` is `succeeded`.
        /// </param>
        /// <param name="error">
        /// Present only when `status` is `failed`.
        /// </param>
        /// <param name="incompleteReason">
        /// Why a non-failed run stopped short: `max_turns_exhausted`, `budget_exhausted`, or `output_schema_violation` (the agent never produced an object matching `input.output_schema`; `output.reply` keeps its prose and `output.data` is absent).
        /// </param>
        /// <param name="usage">
        /// What the run cost, populated once it reaches a terminal state: its wall-clock time plus its token usage summed across every step.<br/>
        /// The counts are THIS run's own. A run that delegated sub-goals does not include its children's, so a team run's true cost is this plus the usage of each run from `listRunChildren`.<br/>
        /// Attribute and forecast spend against the token counts. The model is not reported; your plan, not a model name, is what prices a run.
        /// </param>
        /// <param name="pendingAction">
        /// A human approval a run is durably parked on (present on `AgentRun` only while `status` is `requires_action`). Rendered VERBATIM for the approver - never a summary the agent wrote - so an injected agent cannot misrepresent what it is about to do. Resolve it with `submitRun`.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="parentRunId">
        /// The run that delegated this one a sub-goal, absent on a root run. It is the upward half of lineage - what makes a child run of a member agent attributable to the team run that caused it (`listRunChildren` is the downward half).
        /// </param>
        /// <param name="startedAt">
        /// When a worker picked the run up. Absent while `queued`; the gap between this and `created_at` is queue wait, not agent time.
        /// </param>
        /// <param name="endedAt">
        /// When the run settled. Present for every terminal status - succeeded, failed, canceled and expired alike - and absent otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRun(
            string id,
            string agentId,
            global::Speechify.AgentRunStatus status,
            global::Speechify.AgentRunInput input,
            global::System.DateTime createdAt,
            string? projectId,
            global::Speechify.AgentRunOutput? output,
            global::Speechify.AgentRunError? error,
            global::Speechify.AgentRunIncompleteReason? incompleteReason,
            global::Speechify.AgentRunUsage? usage,
            global::Speechify.PendingAction? pendingAction,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? parentRunId,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt)
        {
            this.ProjectId = projectId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output;
            this.Error = error;
            this.IncompleteReason = incompleteReason;
            this.Usage = usage;
            this.PendingAction = pendingAction;
            this.Metadata = metadata;
            this.ParentRunId = parentRunId;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRun" /> class.
        /// </summary>
        public AgentRun()
        {
        }

    }
}