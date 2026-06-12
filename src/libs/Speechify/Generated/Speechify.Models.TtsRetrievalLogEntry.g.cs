
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One `search_knowledge` invocation recorded against a<br/>
    /// conversation. Powers the Retrieval panel on the conversation<br/>
    /// detail view.
    /// </summary>
    public sealed partial class TtsRetrievalLogEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the conversation. ADR 0015 FK consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsRetrievalLogResult> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HitCount { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsRetrievalLogEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conversationId">
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the conversation. ADR 0015 FK consistency.
        /// </param>
        /// <param name="query"></param>
        /// <param name="results"></param>
        /// <param name="topK"></param>
        /// <param name="hitCount"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsRetrievalLogEntry(
            string id,
            string conversationId,
            string query,
            global::System.Collections.Generic.IList<global::Speechify.TtsRetrievalLogResult> results,
            int topK,
            int hitCount,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TopK = topK;
            this.HitCount = hitCount;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsRetrievalLogEntry" /> class.
        /// </summary>
        public TtsRetrievalLogEntry()
        {
        }

    }
}