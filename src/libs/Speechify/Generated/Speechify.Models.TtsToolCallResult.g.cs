
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Result details for a `tool` test run.
    /// </summary>
    public sealed partial class TtsToolCallResult
    {
        /// <summary>
        /// Name of the tool the agent actually called (may differ from `expected_tool`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_called")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCalled { get; set; }

        /// <summary>
        /// Arguments the agent passed to the tool, as a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_args")]
        public object? ToolArgs { get; set; }

        /// <summary>
        /// Name of the tool the test expected the agent to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpectedTool { get; set; }

        /// <summary>
        /// True when `tool_called` equals `expected_tool`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_matched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ToolMatched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheckResult> ParameterResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Explanation of the overall verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="TtsToolCallResult" /> class.
        /// </summary>
        /// <param name="toolCalled">
        /// Name of the tool the agent actually called (may differ from `expected_tool`).
        /// </param>
        /// <param name="expectedTool">
        /// Name of the tool the test expected the agent to call.
        /// </param>
        /// <param name="toolMatched">
        /// True when `tool_called` equals `expected_tool`.
        /// </param>
        /// <param name="parameterResults"></param>
        /// <param name="passed"></param>
        /// <param name="rationale">
        /// Explanation of the overall verdict.
        /// </param>
        /// <param name="durationMs"></param>
        /// <param name="toolArgs">
        /// Arguments the agent passed to the tool, as a JSON object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsToolCallResult(
            string toolCalled,
            string expectedTool,
            bool toolMatched,
            global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheckResult> parameterResults,
            bool passed,
            string rationale,
            long durationMs,
            object? toolArgs)
        {
            this.ToolCalled = toolCalled ?? throw new global::System.ArgumentNullException(nameof(toolCalled));
            this.ToolArgs = toolArgs;
            this.ExpectedTool = expectedTool ?? throw new global::System.ArgumentNullException(nameof(expectedTool));
            this.ToolMatched = toolMatched;
            this.ParameterResults = parameterResults ?? throw new global::System.ArgumentNullException(nameof(parameterResults));
            this.Passed = passed;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsToolCallResult" /> class.
        /// </summary>
        public TtsToolCallResult()
        {
        }

    }
}