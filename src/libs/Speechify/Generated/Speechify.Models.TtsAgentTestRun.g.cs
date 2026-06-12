
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One execution of a test. `result` is populated when `status`<br/>
    /// reaches a terminal state (`passed`, `failed`, or `error`).<br/>
    /// See `TestRunResult` for the shape.
    /// </summary>
    public sealed partial class TtsAgentTestRun
    {
        /// <summary>
        /// Prefixed wire identifier (`run_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 3 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent test. ADR 0015 FK consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent this run executed against. ADR 0015 FK<br/>
        /// consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Lifecycle of a test run: `queued` - `running` - terminal.<br/>
        /// Terminal states:<br/>
        /// - `passed` - the agent behaviour met the success criteria.<br/>
        /// - `failed` - the agent behaviour did not meet the success criteria.<br/>
        /// - `error` - the runner itself could not complete (LLM outage, network error, etc.),<br/>
        ///   distinct from `failed` which means the agent behaviour was judged and found lacking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsTestRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsTestRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Populated on terminal status only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsTestRunResult, object>))]
        public global::Speechify.OneOf<global::Speechify.TtsTestRunResult, object>? Result { get; set; }

        /// <summary>
        /// Human-readable error message when status is `error`.
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
        /// Initializes a new instance of the <see cref="TtsAgentTestRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`run_&lt;26 char Crockford base32&gt;`).<br/>
        /// ADR 0015 Cluster 3 hard-break: URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404 as of Cluster 3.
        /// </param>
        /// <param name="testId">
        /// Prefixed wire identifier (`test_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent test. ADR 0015 FK consistency.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent this run executed against. ADR 0015 FK<br/>
        /// consistency.
        /// </param>
        /// <param name="status">
        /// Lifecycle of a test run: `queued` - `running` - terminal.<br/>
        /// Terminal states:<br/>
        /// - `passed` - the agent behaviour met the success criteria.<br/>
        /// - `failed` - the agent behaviour did not meet the success criteria.<br/>
        /// - `error` - the runner itself could not complete (LLM outage, network error, etc.),<br/>
        ///   distinct from `failed` which means the agent behaviour was judged and found lacking.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="result">
        /// Populated on terminal status only.
        /// </param>
        /// <param name="error">
        /// Human-readable error message when status is `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAgentTestRun(
            string id,
            string testId,
            string agentId,
            global::Speechify.TtsTestRunStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            global::Speechify.OneOf<global::Speechify.TtsTestRunResult, object>? result,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Result = result;
            this.Error = error;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAgentTestRun" /> class.
        /// </summary>
        public TtsAgentTestRun()
        {
        }

    }
}