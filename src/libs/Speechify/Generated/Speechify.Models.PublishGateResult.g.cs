
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The behavioral-eval gate outcome recorded for a publish. Present only<br/>
    /// when the workspace is opted into the publish gate.
    /// </summary>
    public sealed partial class PublishGateResult
    {
        /// <summary>
        /// The recorded gate decision on a successful publish. A refused<br/>
        /// publish is a 422 (`agent_publish_gate_failed`), so `blocked` /<br/>
        /// `errored` never appear here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.PublishGateResultDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.PublishGateResultDecision Decision { get; set; }

        /// <summary>
        /// Human-readable summary of the gate outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The gate-branchable result: an overall pass/fail plus a per-case<br/>
        /// breakdown. `passed` is true only when every case passed — a failed<br/>
        /// or errored case fails the verdict, so a gate fails safe when a case<br/>
        /// could not be judged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        public global::Speechify.EvaluationVerdict? Verdict { get; set; }

        /// <summary>
        /// How many behavioral cases were scored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suite_size")]
        public int? SuiteSize { get; set; }

        /// <summary>
        /// Wall-clock time the gate evaluation took.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public long? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishGateResult" /> class.
        /// </summary>
        /// <param name="decision">
        /// The recorded gate decision on a successful publish. A refused<br/>
        /// publish is a 422 (`agent_publish_gate_failed`), so `blocked` /<br/>
        /// `errored` never appear here.
        /// </param>
        /// <param name="message">
        /// Human-readable summary of the gate outcome.
        /// </param>
        /// <param name="verdict">
        /// The gate-branchable result: an overall pass/fail plus a per-case<br/>
        /// breakdown. `passed` is true only when every case passed — a failed<br/>
        /// or errored case fails the verdict, so a gate fails safe when a case<br/>
        /// could not be judged.
        /// </param>
        /// <param name="suiteSize">
        /// How many behavioral cases were scored.
        /// </param>
        /// <param name="durationMs">
        /// Wall-clock time the gate evaluation took.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishGateResult(
            global::Speechify.PublishGateResultDecision decision,
            string? message,
            global::Speechify.EvaluationVerdict? verdict,
            int? suiteSize,
            long? durationMs)
        {
            this.Decision = decision;
            this.Message = message;
            this.Verdict = verdict;
            this.SuiteSize = suiteSize;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishGateResult" /> class.
        /// </summary>
        public PublishGateResult()
        {
        }

    }
}