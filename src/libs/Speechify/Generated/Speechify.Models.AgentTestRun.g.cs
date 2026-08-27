
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One execution of a test. The lifecycle `status` is the unified<br/>
    /// async-job vocabulary; the pass/fail judgment lives in the separate<br/>
    /// `verdict` field. `result` is populated when the run reached a<br/>
    /// verdict (`status` is `completed`); see `TestRunResult` for the<br/>
    /// shape. A run that could not execute is `status` `failed` with no<br/>
    /// `verdict`, and `error` carries the reason.
    /// </summary>
    public sealed partial class AgentTestRun
    {
        /// <summary>
        /// Prefixed wire identifier (`run_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent this run executed against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

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
        /// The pass/fail judgment, present only once the run reached a<br/>
        /// verdict (`status` is `completed`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestVerdict?, object>))]
        public global::Speechify.OneOf<global::Speechify.TestVerdict?, object>? Verdict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Populated once the run reached a verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>))]
        public global::Speechify.OneOf<global::Speechify.TestRunResult, object>? Result { get; set; }

        /// <summary>
        /// Human-readable error message when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`run_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="testId">
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent test.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent this run executed against.
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
        /// <param name="createdAt"></param>
        /// <param name="verdict">
        /// The pass/fail judgment, present only once the run reached a<br/>
        /// verdict (`status` is `completed`).
        /// </param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="result">
        /// Populated once the run reached a verdict.
        /// </param>
        /// <param name="error">
        /// Human-readable error message when `status` is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTestRun(
            string id,
            string testId,
            string agentId,
            global::Speechify.JobStatus status,
            global::System.DateTime createdAt,
            global::Speechify.OneOf<global::Speechify.TestVerdict?, object>? verdict,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            global::Speechify.OneOf<global::Speechify.TestRunResult, object>? result,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.Verdict = verdict;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Result = result;
            this.Error = error;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTestRun" /> class.
        /// </summary>
        public AgentTestRun()
        {
        }

    }
}