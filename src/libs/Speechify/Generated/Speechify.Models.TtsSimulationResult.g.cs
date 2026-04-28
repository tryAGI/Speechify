
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Result details for a `simulation` test run.
    /// </summary>
    public sealed partial class TtsSimulationResult
    {
        /// <summary>
        /// Full synthetic conversation in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage> Transcript { get; set; }

        /// <summary>
        /// Every tool invocation across all turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsSimulationToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Number of agent turns that ran before the simulation ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnsUsed { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsSimulationResult" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Full synthetic conversation in order.
        /// </param>
        /// <param name="turnsUsed">
        /// Number of agent turns that ran before the simulation ended.
        /// </param>
        /// <param name="passed"></param>
        /// <param name="rationale">
        /// LLM judge's explanation of the verdict.
        /// </param>
        /// <param name="durationMs"></param>
        /// <param name="toolCalls">
        /// Every tool invocation across all turns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSimulationResult(
            global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage> transcript,
            int turnsUsed,
            bool passed,
            string rationale,
            long durationMs,
            global::System.Collections.Generic.IList<global::Speechify.TtsSimulationToolCall>? toolCalls)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.ToolCalls = toolCalls;
            this.TurnsUsed = turnsUsed;
            this.Passed = passed;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSimulationResult" /> class.
        /// </summary>
        public TtsSimulationResult()
        {
        }
    }
}