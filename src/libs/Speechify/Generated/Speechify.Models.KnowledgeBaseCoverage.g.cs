
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What one knowledge base was asked over a trailing window, what it<br/>
    /// could not answer, and what in it never gets used. Built from the<br/>
    /// searches agents ran against it.
    /// </summary>
    public sealed partial class KnowledgeBaseCoverage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KbId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowDays { get; set; }

        /// <summary>
        /// Start of the window; searches at or after this instant count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Since { get; set; }

        /// <summary>
        /// The strip above the report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.KnowledgeBaseCoverageHealth Health { get; set; }

        /// <summary>
        /// The partial and insufficient searches, clustered by the content<br/>
        /// words they share, most frequent first. At most 50 clusters, built<br/>
        /// from the newest 2,000 such searches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gaps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseCoverageGap> Gaps { get; set; }

        /// <summary>
        /// Ready documents no search in the window retrieved a passage<br/>
        /// from, oldest first. The oldest 100; `unused_document_count` is<br/>
        /// the exact total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unused_documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseCoverageDocument> UnusedDocuments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unused_document_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnusedDocumentCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverage" /> class.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="windowDays"></param>
        /// <param name="since">
        /// Start of the window; searches at or after this instant count.
        /// </param>
        /// <param name="health">
        /// The strip above the report.
        /// </param>
        /// <param name="gaps">
        /// The partial and insufficient searches, clustered by the content<br/>
        /// words they share, most frequent first. At most 50 clusters, built<br/>
        /// from the newest 2,000 such searches.
        /// </param>
        /// <param name="unusedDocuments">
        /// Ready documents no search in the window retrieved a passage<br/>
        /// from, oldest first. The oldest 100; `unused_document_count` is<br/>
        /// the exact total.
        /// </param>
        /// <param name="unusedDocumentCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseCoverage(
            string kbId,
            int windowDays,
            global::System.DateTime since,
            global::Speechify.KnowledgeBaseCoverageHealth health,
            global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseCoverageGap> gaps,
            global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseCoverageDocument> unusedDocuments,
            int unusedDocumentCount)
        {
            this.KbId = kbId ?? throw new global::System.ArgumentNullException(nameof(kbId));
            this.WindowDays = windowDays;
            this.Since = since;
            this.Health = health ?? throw new global::System.ArgumentNullException(nameof(health));
            this.Gaps = gaps ?? throw new global::System.ArgumentNullException(nameof(gaps));
            this.UnusedDocuments = unusedDocuments ?? throw new global::System.ArgumentNullException(nameof(unusedDocuments));
            this.UnusedDocumentCount = unusedDocumentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverage" /> class.
        /// </summary>
        public KnowledgeBaseCoverage()
        {
        }

    }
}