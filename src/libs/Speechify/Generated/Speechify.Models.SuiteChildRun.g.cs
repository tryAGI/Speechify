
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One child run inside a suite run, carrying the parent test's<br/>
    /// name and the target agent's name so the grouped result view can<br/>
    /// label each row. The agent name disambiguates results when the<br/>
    /// suite spans multiple agents.
    /// </summary>
    public sealed partial class SuiteChildRun
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
        /// Populated on terminal status only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>))]
        public global::Speechify.OneOf<global::Speechify.TestRunResult, object>? Result { get; set; }

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
        /// Name of the test this run executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestName { get; set; }

        /// <summary>
        /// Display name of the agent this run executed against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuiteChildRun" /> class.
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
        /// Lifecycle of a test run: `queued` - `running` - terminal.<br/>
        /// Terminal states:<br/>
        /// - `passed` - the agent behaviour met the success criteria.<br/>
        /// - `failed` - the agent behaviour did not meet the success criteria.<br/>
        /// - `error` - the runner itself could not complete (LLM outage, network error, etc.),<br/>
        ///   distinct from `failed` which means the agent behaviour was judged and found lacking.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="testName">
        /// Name of the test this run executed.
        /// </param>
        /// <param name="agentName">
        /// Display name of the agent this run executed against.
        /// </param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="result">
        /// Populated on terminal status only.
        /// </param>
        /// <param name="error">
        /// Human-readable error message when status is `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuiteChildRun(
            string id,
            string testId,
            string agentId,
            global::Speechify.TestRunStatus status,
            global::System.DateTime createdAt,
            string testName,
            string agentName,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            global::Speechify.OneOf<global::Speechify.TestRunResult, object>? result,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Status = status;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Result = result;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.TestName = testName ?? throw new global::System.ArgumentNullException(nameof(testName));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuiteChildRun" /> class.
        /// </summary>
        public SuiteChildRun()
        {
        }

    }
}