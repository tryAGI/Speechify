
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A suite run plus every child run, for the grouped detail view.
    /// </summary>
    public sealed partial class AgentTestSuiteRunWithRuns
    {
        /// <summary>
        /// Prefixed wire identifier (`srun_&lt;26 char Crockford base32&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed `agent_&lt;crockford&gt;` id of the agent whose suite<br/>
        /// was run. Set for the `run_all` trigger; null for `batch`,<br/>
        /// which can span many agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Display name of `agent_id`'s agent, resolved at read time.<br/>
        /// Null whenever `agent_id` is null, and on the suite run<br/>
        /// embedded in run/resubmit creation responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Which entry point created a suite run.<br/>
        /// - `run_all`  - POST /v1/agents/{agent_id}/tests/runs.<br/>
        /// - `batch`    - POST /v1/agents/tests/runs/batch.<br/>
        /// - `resubmit` - POST /v1/agents/tests/suite-runs/{suite_run_id}/resubmit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SuiteRunTriggerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SuiteRunTrigger Trigger { get; set; }

        /// <summary>
        /// Set on a `resubmit`: the prefixed `srun_&lt;crockford&gt;` id of<br/>
        /// the suite run whose failed/errored tests this one re-ran.<br/>
        /// Null for `run_all` and `batch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_suite_run_id")]
        public string? ParentSuiteRunId { get; set; }

        /// <summary>
        /// The one lifecycle vocabulary shared by every async job (batch<br/>
        /// calls, knowledge-base imports, agent-test runs, suite runs):<br/>
        /// `pending` → `running` → a terminal state.<br/>
        /// - `pending` - accepted but not yet executing (queued for a worker,<br/>
        ///   or deferred to a future scheduled time).<br/>
        /// - `running` - actively executing.<br/>
        /// - `completed` - ran to conclusion. The single terminal-success<br/>
        ///   verb. For a job that produces a pass/fail judgment (an agent-test<br/>
        ///   run), this means it produced a verdict - read the separate<br/>
        ///   `verdict` field for the judgment, not this status.<br/>
        /// - `failed` - could not complete (an infrastructure or input<br/>
        ///   failure), distinct from a `completed` job whose `verdict` is<br/>
        ///   `failed`.<br/>
        /// - `cancelled` - cancelled before reaching a natural terminal state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.JobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.JobStatus Status { get; set; }

        /// <summary>
        /// The suite's pass/fail judgment, present only when `status` is<br/>
        /// `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestVerdict?, object>))]
        public global::Speechify.OneOf<global::Speechify.TestVerdict?, object>? Verdict { get; set; }

        /// <summary>
        /// Number of child runs in the suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Child runs that produced a verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// Child runs that could not execute (an infrastructure failure).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Child runs actively executing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Running { get; set; }

        /// <summary>
        /// Child runs queued, not yet executing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pending { get; set; }

        /// <summary>
        /// Child runs cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cancelled { get; set; }

        /// <summary>
        /// Per-verdict breakdown among the `completed` child runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentTestSuiteRunWithRunsResults Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Newest child-run completion; null until every child run is terminal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// The run-level config override this suite was run<br/>
        /// with, or null for an ordinary Run All / batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_override")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunConfigOverride, object>))]
        public global::Speechify.OneOf<global::Speechify.TestRunConfigOverride, object>? ConfigOverride { get; set; }

        /// <summary>
        /// The flow version (`agent_versions` row) this suite targeted,<br/>
        /// or null for the agent's active / synthesized flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flow_version_id")]
        public string? FlowVersionId { get; set; }

        /// <summary>
        /// Human-facing version number of `flow_version_id`; null when no version was targeted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flow_version_number")]
        public int? FlowVersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.SuiteChildRun> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSuiteRunWithRuns" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`srun_&lt;26 char Crockford base32&gt;`).
        /// </param>
        /// <param name="trigger">
        /// Which entry point created a suite run.<br/>
        /// - `run_all`  - POST /v1/agents/{agent_id}/tests/runs.<br/>
        /// - `batch`    - POST /v1/agents/tests/runs/batch.<br/>
        /// - `resubmit` - POST /v1/agents/tests/suite-runs/{suite_run_id}/resubmit.
        /// </param>
        /// <param name="status">
        /// The one lifecycle vocabulary shared by every async job (batch<br/>
        /// calls, knowledge-base imports, agent-test runs, suite runs):<br/>
        /// `pending` → `running` → a terminal state.<br/>
        /// - `pending` - accepted but not yet executing (queued for a worker,<br/>
        ///   or deferred to a future scheduled time).<br/>
        /// - `running` - actively executing.<br/>
        /// - `completed` - ran to conclusion. The single terminal-success<br/>
        ///   verb. For a job that produces a pass/fail judgment (an agent-test<br/>
        ///   run), this means it produced a verdict - read the separate<br/>
        ///   `verdict` field for the judgment, not this status.<br/>
        /// - `failed` - could not complete (an infrastructure or input<br/>
        ///   failure), distinct from a `completed` job whose `verdict` is<br/>
        ///   `failed`.<br/>
        /// - `cancelled` - cancelled before reaching a natural terminal state.
        /// </param>
        /// <param name="total">
        /// Number of child runs in the suite.
        /// </param>
        /// <param name="completed">
        /// Child runs that produced a verdict.
        /// </param>
        /// <param name="failed">
        /// Child runs that could not execute (an infrastructure failure).
        /// </param>
        /// <param name="running">
        /// Child runs actively executing.
        /// </param>
        /// <param name="pending">
        /// Child runs queued, not yet executing.
        /// </param>
        /// <param name="cancelled">
        /// Child runs cancelled.
        /// </param>
        /// <param name="results">
        /// Per-verdict breakdown among the `completed` child runs.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="runs"></param>
        /// <param name="agentId">
        /// Prefixed `agent_&lt;crockford&gt;` id of the agent whose suite<br/>
        /// was run. Set for the `run_all` trigger; null for `batch`,<br/>
        /// which can span many agents.
        /// </param>
        /// <param name="agentName">
        /// Display name of `agent_id`'s agent, resolved at read time.<br/>
        /// Null whenever `agent_id` is null, and on the suite run<br/>
        /// embedded in run/resubmit creation responses.
        /// </param>
        /// <param name="parentSuiteRunId">
        /// Set on a `resubmit`: the prefixed `srun_&lt;crockford&gt;` id of<br/>
        /// the suite run whose failed/errored tests this one re-ran.<br/>
        /// Null for `run_all` and `batch`.
        /// </param>
        /// <param name="verdict">
        /// The suite's pass/fail judgment, present only when `status` is<br/>
        /// `completed`.
        /// </param>
        /// <param name="endedAt">
        /// Newest child-run completion; null until every child run is terminal.
        /// </param>
        /// <param name="configOverride">
        /// The run-level config override this suite was run<br/>
        /// with, or null for an ordinary Run All / batch.
        /// </param>
        /// <param name="flowVersionId">
        /// The flow version (`agent_versions` row) this suite targeted,<br/>
        /// or null for the agent's active / synthesized flow.
        /// </param>
        /// <param name="flowVersionNumber">
        /// Human-facing version number of `flow_version_id`; null when no version was targeted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestSuiteRunWithRuns(
            string id,
            global::Speechify.SuiteRunTrigger trigger,
            global::Speechify.JobStatus status,
            int total,
            int completed,
            int failed,
            int running,
            int pending,
            int cancelled,
            global::Speechify.AgentTestSuiteRunWithRunsResults results,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Speechify.SuiteChildRun> runs,
            string? agentId,
            string? agentName,
            string? parentSuiteRunId,
            global::Speechify.OneOf<global::Speechify.TestVerdict?, object>? verdict,
            global::System.DateTime? endedAt,
            global::Speechify.OneOf<global::Speechify.TestRunConfigOverride, object>? configOverride,
            string? flowVersionId,
            int? flowVersionNumber)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId;
            this.AgentName = agentName;
            this.Trigger = trigger;
            this.ParentSuiteRunId = parentSuiteRunId;
            this.Status = status;
            this.Verdict = verdict;
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
            this.Running = running;
            this.Pending = pending;
            this.Cancelled = cancelled;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.CreatedAt = createdAt;
            this.EndedAt = endedAt;
            this.ConfigOverride = configOverride;
            this.FlowVersionId = flowVersionId;
            this.FlowVersionNumber = flowVersionNumber;
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSuiteRunWithRuns" /> class.
        /// </summary>
        public AgentTestSuiteRunWithRuns()
        {
        }

    }
}