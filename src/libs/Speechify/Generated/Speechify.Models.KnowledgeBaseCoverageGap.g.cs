
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One cluster of questions the knowledge base did not cover.
    /// </summary>
    public sealed partial class KnowledgeBaseCoverageGap
    {
        /// <summary>
        /// The phrasing callers used most often.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Other phrasings in the cluster, newest first (at most 5).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Variants { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Searches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Partial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insufficient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Insufficient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastSeenAt { get; set; }

        /// <summary>
        /// The most recent conversations that hit the gap (at most 5).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ConversationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverageGap" /> class.
        /// </summary>
        /// <param name="query">
        /// The phrasing callers used most often.
        /// </param>
        /// <param name="variants">
        /// Other phrasings in the cluster, newest first (at most 5).
        /// </param>
        /// <param name="searches"></param>
        /// <param name="partial"></param>
        /// <param name="insufficient"></param>
        /// <param name="lastSeenAt"></param>
        /// <param name="conversationIds">
        /// The most recent conversations that hit the gap (at most 5).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseCoverageGap(
            string query,
            global::System.Collections.Generic.IList<string> variants,
            int searches,
            int partial,
            int insufficient,
            global::System.DateTime lastSeenAt,
            global::System.Collections.Generic.IList<string> conversationIds)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Variants = variants ?? throw new global::System.ArgumentNullException(nameof(variants));
            this.Searches = searches;
            this.Partial = partial;
            this.Insufficient = insufficient;
            this.LastSeenAt = lastSeenAt;
            this.ConversationIds = conversationIds ?? throw new global::System.ArgumentNullException(nameof(conversationIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseCoverageGap" /> class.
        /// </summary>
        public KnowledgeBaseCoverageGap()
        {
        }

    }
}