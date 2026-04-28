
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Three flavours coexist, discriminated by `kind`:<br/>
    /// - `criterion` rows carry `status` + `passed` + `score` + `rationale` for one criterion<br/>
    /// - `summary` row carries overall sentiment + rationale in `rationale`<br/>
    /// - `data` row carries the structured data-collection payload in `data`<br/>
    /// `status` is the canonical three-state result. `passed` is a<br/>
    /// derived boolean kept for backwards compatibility with earlier<br/>
    /// webhook consumers: success→true, failure→false, unknown→null.
    /// </summary>
    public sealed partial class TtsEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsEvaluationKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsEvaluationKind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criterion_id")]
        public string? CriterionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Three-state criterion result. `unknown` means the criterion did not apply to this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsEvaluationStatus?, object>))]
        public global::Speechify.OneOf<global::Speechify.TtsEvaluationStatus?, object>? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        public bool? Passed { get; set; }

        /// <summary>
        /// 
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
        /// Structured data-collection payload (present only on `kind=data` rows).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsEvaluation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conversationId"></param>
        /// <param name="kind"></param>
        /// <param name="name"></param>
        /// <param name="rationale"></param>
        /// <param name="createdAt"></param>
        /// <param name="criterionId"></param>
        /// <param name="status">
        /// Three-state criterion result. `unknown` means the criterion did not apply to this call.
        /// </param>
        /// <param name="passed"></param>
        /// <param name="score"></param>
        /// <param name="data">
        /// Structured data-collection payload (present only on `kind=data` rows).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsEvaluation(
            string id,
            string conversationId,
            global::Speechify.TtsEvaluationKind kind,
            string name,
            string rationale,
            global::System.DateTime createdAt,
            string? criterionId,
            global::Speechify.OneOf<global::Speechify.TtsEvaluationStatus?, object>? status,
            bool? passed,
            double? score,
            object? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Kind = kind;
            this.CriterionId = criterionId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Passed = passed;
            this.Score = score;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.Data = data;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEvaluation" /> class.
        /// </summary>
        public TtsEvaluation()
        {
        }
    }
}