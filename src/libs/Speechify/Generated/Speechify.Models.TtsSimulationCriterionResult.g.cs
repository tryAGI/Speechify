
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One scored entry of an agent's configured evaluation criterion<br/>
    /// against a simulation transcript. Mirrors the per-criterion row<br/>
    /// the post-call evaluator persists, so test runs and live<br/>
    /// conversations carry identical per-criterion shapes.
    /// </summary>
    public sealed partial class TtsSimulationCriterionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriterionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Three-state outcome. `unknown` means the criterion did not<br/>
        /// apply on this run (the topic never came up); `failure`<br/>
        /// means it did apply and the agent did not satisfy it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsSimulationCriterionResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsSimulationCriterionResultStatus Status { get; set; }

        /// <summary>
        /// 0.0..1.0 continuous estimate of how well the criterion was met.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSimulationCriterionResult" /> class.
        /// </summary>
        /// <param name="criterionId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Three-state outcome. `unknown` means the criterion did not<br/>
        /// apply on this run (the topic never came up); `failure`<br/>
        /// means it did apply and the agent did not satisfy it.
        /// </param>
        /// <param name="rationale"></param>
        /// <param name="score">
        /// 0.0..1.0 continuous estimate of how well the criterion was met.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSimulationCriterionResult(
            string criterionId,
            string name,
            global::Speechify.TtsSimulationCriterionResultStatus status,
            string rationale,
            double? score)
        {
            this.CriterionId = criterionId ?? throw new global::System.ArgumentNullException(nameof(criterionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Score = score;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSimulationCriterionResult" /> class.
        /// </summary>
        public TtsSimulationCriterionResult()
        {
        }

    }
}