
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Result details for a `simulation` test run. AIS-3446 unifies<br/>
    /// scoring with the post-call evaluator: the synthetic transcript<br/>
    /// is scored against the agent's configured evaluation criteria<br/>
    /// and data-collection fields, then per-test `data_assertions`<br/>
    /// check the extracted values. The top-level `passed` is derived<br/>
    /// — every criterion must resolve to `success` or `unknown` and<br/>
    /// every assertion must pass.
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
        /// Top-level verdict explanation (run summary on pass; first failing criterion or assertion on fail).
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
        /// One-sentence narrative summary of what happened in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Overall sentiment classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsSimulationResultSentimentJsonConverter))]
        public global::Speechify.TtsSimulationResultSentiment? Sentiment { get; set; }

        /// <summary>
        /// One result row per configured EvaluationCriterion on the<br/>
        /// agent. Same shape as the per-criterion rows persisted on<br/>
        /// the post-call evaluations table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsSimulationCriterionResult>? Criteria { get; set; }

        /// <summary>
        /// LLM-extracted values for the agent's configured<br/>
        /// data-collection fields. Keys mirror the agent's<br/>
        /// data_collection field keys; values are typed per the<br/>
        /// declared field type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// One result row per `data_assertions` entry on the simulation config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_assertions")]
        public global::System.Collections.Generic.IList<global::Speechify.TtsDataAssertionResult>? DataAssertions { get; set; }

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
        /// Top-level verdict explanation (run summary on pass; first failing criterion or assertion on fail).
        /// </param>
        /// <param name="durationMs"></param>
        /// <param name="toolCalls">
        /// Every tool invocation across all turns.
        /// </param>
        /// <param name="summary">
        /// One-sentence narrative summary of what happened in the conversation.
        /// </param>
        /// <param name="sentiment">
        /// Overall sentiment classification.
        /// </param>
        /// <param name="criteria">
        /// One result row per configured EvaluationCriterion on the<br/>
        /// agent. Same shape as the per-criterion rows persisted on<br/>
        /// the post-call evaluations table.
        /// </param>
        /// <param name="data">
        /// LLM-extracted values for the agent's configured<br/>
        /// data-collection fields. Keys mirror the agent's<br/>
        /// data_collection field keys; values are typed per the<br/>
        /// declared field type.
        /// </param>
        /// <param name="dataAssertions">
        /// One result row per `data_assertions` entry on the simulation config.
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
            global::System.Collections.Generic.IList<global::Speechify.TtsSimulationToolCall>? toolCalls,
            string? summary,
            global::Speechify.TtsSimulationResultSentiment? sentiment,
            global::System.Collections.Generic.IList<global::Speechify.TtsSimulationCriterionResult>? criteria,
            object? data,
            global::System.Collections.Generic.IList<global::Speechify.TtsDataAssertionResult>? dataAssertions)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.ToolCalls = toolCalls;
            this.TurnsUsed = turnsUsed;
            this.Passed = passed;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.DurationMs = durationMs;
            this.Summary = summary;
            this.Sentiment = sentiment;
            this.Criteria = criteria;
            this.Data = data;
            this.DataAssertions = dataAssertions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSimulationResult" /> class.
        /// </summary>
        public TtsSimulationResult()
        {
        }

    }
}