
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A suite run (test invocation): the grouping object over every<br/>
    /// test run dispatched by one Run All, batch, or resubmit call.<br/>
    /// `status` and the count fields are derived from the child runs.<br/>
    /// `status` is `running` while any child run is still queued or<br/>
    /// running, then `passed` (all passed), `failed` (at least one<br/>
    /// failed), or `error` (at least one errored, none failed).
    /// </summary>
    public sealed partial class AgentTestSuiteRun
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
        /// Lifecycle of a test run: `queued` - `running` - terminal.<br/>
        /// Terminal states:<br/>
        /// - `passed` - the agent behaviour met the success criteria.<br/>
        /// - `failed` - the agent behaviour did not meet the success criteria.<br/>
        /// - `error` - the runner itself could not complete (LLM outage, network error, etc.),<br/>
        ///   distinct from `failed` which means the agent behaviour was judged and found lacking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TestRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TestRunStatus Status { get; set; }

        /// <summary>
        /// Number of child runs in the suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PassedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErroredCount { get; set; }

        /// <summary>
        /// Child runs still queued or running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingCount { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSuiteRun" /> class.
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
        /// Lifecycle of a test run: `queued` - `running` - terminal.<br/>
        /// Terminal states:<br/>
        /// - `passed` - the agent behaviour met the success criteria.<br/>
        /// - `failed` - the agent behaviour did not meet the success criteria.<br/>
        /// - `error` - the runner itself could not complete (LLM outage, network error, etc.),<br/>
        ///   distinct from `failed` which means the agent behaviour was judged and found lacking.
        /// </param>
        /// <param name="totalRuns">
        /// Number of child runs in the suite.
        /// </param>
        /// <param name="passedCount"></param>
        /// <param name="failedCount"></param>
        /// <param name="erroredCount"></param>
        /// <param name="pendingCount">
        /// Child runs still queued or running.
        /// </param>
        /// <param name="createdAt"></param>
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
        public AgentTestSuiteRun(
            string id,
            global::Speechify.SuiteRunTrigger trigger,
            global::Speechify.TestRunStatus status,
            int totalRuns,
            int passedCount,
            int failedCount,
            int erroredCount,
            int pendingCount,
            global::System.DateTime createdAt,
            string? agentId,
            string? agentName,
            string? parentSuiteRunId,
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
            this.TotalRuns = totalRuns;
            this.PassedCount = passedCount;
            this.FailedCount = failedCount;
            this.ErroredCount = erroredCount;
            this.PendingCount = pendingCount;
            this.CreatedAt = createdAt;
            this.EndedAt = endedAt;
            this.ConfigOverride = configOverride;
            this.FlowVersionId = flowVersionId;
            this.FlowVersionNumber = flowVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestSuiteRun" /> class.
        /// </summary>
        public AgentTestSuiteRun()
        {
        }

    }
}