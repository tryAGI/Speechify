
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Async URL import job (sitemap, crawl, plus<br/>
    /// the auto-refresh path). The console polls<br/>
    /// `GET /v1/agents/knowledge-bases/{id}/imports` while the job is<br/>
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
        /// `pending` is the brief window between insert and the worker<br/>
        /// picking up; `running` is the bulk of the job's life;<br/>
        /// `completed` / `failed` / `cancelled` are terminal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ImportJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ImportJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedCount { get; set; }

        /// <summary>
        /// JSON blob whose shape depends on `kind` — typically `url`,<br/>
        /// `max_pages`, `max_depth`. The console reads it for display<br/>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_job_id")]
        public string? UpstreamJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedByUid { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

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
        /// `pending` is the brief window between insert and the worker<br/>
        /// picking up; `running` is the bulk of the job's life;<br/>
        /// `completed` / `failed` / `cancelled` are terminal.
        /// </param>
        /// <param name="requestedCount"></param>
        /// <param name="completedCount"></param>
        /// <param name="failedCount"></param>
        /// <param name="params">
        /// JSON blob whose shape depends on `kind` — typically `url`,<br/>
        /// `max_pages`, `max_depth`. The console reads it for display<br/>
        /// only.
        /// </param>
        /// <param name="createdByUid"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="error"></param>
        /// <param name="upstreamJobId"></param>
        /// <param name="startedAt"></param>
        /// <param name="finishedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportJob(
            string id,
            string kbId,
            global::Speechify.ImportJobKind kind,
            global::Speechify.ImportJobStatus status,
            int requestedCount,
            int completedCount,
            int failedCount,
            object @params,
            string createdByUid,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? error,
            string? upstreamJobId,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.Kind = kind;
            this.Status = status;
            this.RequestedCount = requestedCount;
            this.CompletedCount = completedCount;
            this.FailedCount = failedCount;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.Error = error;
            this.UpstreamJobId = upstreamJobId;
            this.CreatedByUid = createdByUid ?? throw new global::System.ArgumentNullException(nameof(createdByUid));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportJob" /> class.
        /// </summary>
        public ImportJob()
        {
        }

    }
}