
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Result details for a `reply` test run.
    /// </summary>
    public sealed partial class ReplyResult
    {
        /// <summary>
        /// The raw text response the agent produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// LLM judge's explanation of the verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        /// 0-1 judge confidence score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Score { get; set; }

        /// <summary>
        /// Wall-clock time for the run in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyResult" /> class.
        /// </summary>
        /// <param name="agentResponse">
        /// The raw text response the agent produced.
        /// </param>
        /// <param name="passed"></param>
        /// <param name="rationale">
        /// LLM judge's explanation of the verdict.
        /// </param>
        /// <param name="score">
        /// 0-1 judge confidence score.
        /// </param>
        /// <param name="durationMs">
        /// Wall-clock time for the run in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplyResult(
            string agentResponse,
            bool passed,
            string rationale,
            string score,
            long durationMs)
        {
            this.AgentResponse = agentResponse ?? throw new global::System.ArgumentNullException(nameof(agentResponse));
            this.Passed = passed;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.Score = score ?? throw new global::System.ArgumentNullException(nameof(score));
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyResult" /> class.
        /// </summary>
        public ReplyResult()
        {
        }

    }
}