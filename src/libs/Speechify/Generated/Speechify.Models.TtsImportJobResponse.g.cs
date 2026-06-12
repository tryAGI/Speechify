
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Wrapper returned by the async import endpoints (sitemap, crawl, multi-URL).
    /// </summary>
    public sealed partial class TtsImportJobResponse
    {
        /// <summary>
        /// Async URL import job (AIS-2655 sitemap, AIS-2657 crawl, plus<br/>
        /// the auto-refresh path). The console polls<br/>
        /// `GET /v1/agents/knowledge-bases/{id}/imports` while the job is<br/>
        /// non-terminal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsImportJob Job { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsImportJobResponse" /> class.
        /// </summary>
        /// <param name="job">
        /// Async URL import job (AIS-2655 sitemap, AIS-2657 crawl, plus<br/>
        /// the auto-refresh path). The console polls<br/>
        /// `GET /v1/agents/knowledge-bases/{id}/imports` while the job is<br/>
        /// non-terminal.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsImportJobResponse(
            global::Speechify.TtsImportJob job)
        {
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsImportJobResponse" /> class.
        /// </summary>
        public TtsImportJobResponse()
        {
        }

    }
}