
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One case's outcome with a uniform per-criterion breakdown.
    /// </summary>
    public sealed partial class EvaluationCaseVerdict
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CaseId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// `errored` = the run could not complete, so the behaviour was not judged (distinct from `failed`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.EvaluationCaseVerdictOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.EvaluationCaseVerdictOutcome Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        ///
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterionVerdict> Criteria { get; set; }

        /// <summary>
        /// Full per-type run detail (transcript, tool calls, per-type<br/>
        /// result), for a consumer that needs the synthetic conversation.<br/>
        /// Present when the case ran; absent on an errored case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCaseVerdict" /> class.
        /// </summary>
        /// <param name="caseId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="outcome">
        /// `errored` = the run could not complete, so the behaviour was not judged (distinct from `failed`).
        /// </param>
        /// <param name="passed"></param>
        /// <param name="rationale"></param>
        /// <param name="durationMs"></param>
        /// <param name="criteria"></param>
        /// <param name="result">
        /// Full per-type run detail (transcript, tool calls, per-type<br/>
        /// result), for a consumer that needs the synthetic conversation.<br/>
        /// Present when the case ran; absent on an errored case.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCaseVerdict(
            string caseId,
            string name,
            string type,
            global::Speechify.EvaluationCaseVerdictOutcome outcome,
            bool passed,
            string rationale,
            long durationMs,
            global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterionVerdict> criteria,
            object? result)
        {
            this.CaseId = caseId ?? throw new global::System.ArgumentNullException(nameof(caseId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Outcome = outcome;
            this.Passed = passed;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.DurationMs = durationMs;
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCaseVerdict" /> class.
        /// </summary>
        public EvaluationCaseVerdict()
        {
        }

    }
}