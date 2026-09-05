
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One run of every case against the live retrieval pipeline. Poll it<br/>
    /// while `status` is `pending` or `running`; `metrics` fills in when it<br/>
    /// completes.
    /// </summary>
    public sealed partial class KnowledgeBaseEvaluation
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
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KbId { get; set; }

        /// <summary>
        /// The one lifecycle vocabulary shared by every async job (batch<br/>
        /// calls, knowledge-base imports, agent-test runs, suite runs):<br/>
        /// `pending` → `running` → a terminal state.<br/>
        /// - `pending` - accepted but not yet executing (queued for a worker,<br/>
        ///   or deferred to a future scheduled time).<br/>
        /// - `running` - actively executing.<br/>
        /// - `completed` - ran to conclusion. The single terminal-success<br/>
        ///   verb. For a job that produces a pass/fail judgment (an agent-test<br/>
        ///   run), this means it produced a verdict - read the separate<br/>
        ///   `verdict` field for the judgment, not this status.<br/>
        /// - `failed` - could not complete (an infrastructure or input<br/>
        ///   failure), distinct from a `completed` job whose `verdict` is<br/>
        ///   `failed`.<br/>
        /// - `cancelled` - cancelled before reaching a natural terminal state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.JobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.JobStatus Status { get; set; }

        /// <summary>
        /// The retrieval pipeline the run was started under, so two runs can be compared like with like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetrievalVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopK { get; set; }

        /// <summary>
        /// Cases to evaluate (the progress denominator).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Cases evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// Cases whose search failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// The verdict breakdown over the cases evaluated so far, apart from the processing counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.KnowledgeBaseEvaluationResults Results { get; set; }

        /// <summary>
        /// The summary, null until the evaluation completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::Speechify.KnowledgeBaseEvaluationMetrics? Metrics { get; set; }

        /// <summary>
        ///
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kbId"></param>
        /// <param name="status">
        /// The one lifecycle vocabulary shared by every async job (batch<br/>
        /// calls, knowledge-base imports, agent-test runs, suite runs):<br/>
        /// `pending` → `running` → a terminal state.<br/>
        /// - `pending` - accepted but not yet executing (queued for a worker,<br/>
        ///   or deferred to a future scheduled time).<br/>
        /// - `running` - actively executing.<br/>
        /// - `completed` - ran to conclusion. The single terminal-success<br/>
        ///   verb. For a job that produces a pass/fail judgment (an agent-test<br/>
        ///   run), this means it produced a verdict - read the separate<br/>
        ///   `verdict` field for the judgment, not this status.<br/>
        /// - `failed` - could not complete (an infrastructure or input<br/>
        ///   failure), distinct from a `completed` job whose `verdict` is<br/>
        ///   `failed`.<br/>
        /// - `cancelled` - cancelled before reaching a natural terminal state.
        /// </param>
        /// <param name="retrievalVersion">
        /// The retrieval pipeline the run was started under, so two runs can be compared like with like.
        /// </param>
        /// <param name="topK"></param>
        /// <param name="total">
        /// Cases to evaluate (the progress denominator).
        /// </param>
        /// <param name="completed">
        /// Cases evaluated.
        /// </param>
        /// <param name="failed">
        /// Cases whose search failed.
        /// </param>
        /// <param name="results">
        /// The verdict breakdown over the cases evaluated so far, apart from the processing counts.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="metrics">
        /// The summary, null until the evaluation completes.
        /// </param>
        /// <param name="error"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseEvaluation(
            string id,
            string kbId,
            global::Speechify.JobStatus status,
            string retrievalVersion,
            int topK,
            int total,
            int completed,
            int failed,
            global::Speechify.KnowledgeBaseEvaluationResults results,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Speechify.KnowledgeBaseEvaluationMetrics? metrics,
            string? error,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.Status = status;
            this.RetrievalVersion = retrievalVersion ?? throw new global::System.ArgumentNullException(nameof(retrievalVersion));
            this.TopK = topK;
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Metrics = metrics;
            this.Error = error;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseEvaluation" /> class.
        /// </summary>
        public KnowledgeBaseEvaluation()
        {
        }

    }
}