
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Async URL import job (sitemap, crawl, plus<br/>
    /// the auto-refresh path). Poll<br/>
    /// `GET /v1/agents/knowledge-bases/{kb_id}/imports` while the job is<br/>
    /// non-terminal.
    /// </summary>
    public sealed partial class ImportJob
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ImportJobKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ImportJobKind Kind { get; set; }

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
        /// Total URLs to process (the progress denominator).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// URLs imported successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// URLs that failed to import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// JSON blob whose shape depends on `kind` — typically `url`,<br/>
        /// `max_pages`, `max_depth`. Read it for display<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Params { get; set; }

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
        /// Initializes a new instance of the <see cref="ImportJob" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kbId"></param>
        /// <param name="kind"></param>
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
        /// <param name="total">
        /// Total URLs to process (the progress denominator).
        /// </param>
        /// <param name="completed">
        /// URLs imported successfully.
        /// </param>
        /// <param name="failed">
        /// URLs that failed to import.
        /// </param>
        /// <param name="params">
        /// JSON blob whose shape depends on `kind` — typically `url`,<br/>
        /// `max_pages`, `max_depth`. Read it for display<br/>
        /// only.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="error"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportJob(
            string id,
            string kbId,
            global::Speechify.ImportJobKind kind,
            global::Speechify.JobStatus status,
            int total,
            int completed,
            int failed,
            object @params,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? error,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.Kind = kind;
            this.Status = status;
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.Error = error;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJob" /> class.
        /// </summary>
        public ImportJob()
        {
        }

    }
}