
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One `search_knowledge` invocation recorded against a<br/>
    /// conversation. Powers the Retrieval panel on the conversation<br/>
    /// detail view.
    /// </summary>
    public sealed partial class RetrievalLogEntry
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the conversation.
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
        public required global::System.Collections.Generic.IList<global::Speechify.RetrievalLogResult> Results { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HitCount { get; set; }

        /// <summary>
        /// Key of the flow node that was active when the agent ran this<br/>
        /// search. Empty when the call ran without a flow, or for rows<br/>
        /// recorded before phase attribution existed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeKey { get; set; }

        /// <summary>
        /// The retrieval contract that produced this row, so results can be<br/>
        /// compared like with like across a rollout. Rows recorded before<br/>
        /// versioning carry `v1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetrievalVersion { get; set; }

        /// <summary>
        /// The verdict the agent was given for this search. Absent on rows<br/>
        /// recorded before coverage existed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.RetrievalCoverageJsonConverter))]
        public global::Speechify.RetrievalCoverage? Coverage { get; set; }

        /// <summary>
        /// How long the search took, in milliseconds. Absent on rows<br/>
        /// recorded before it was measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_ms")]
        public int? LatencyMs { get; set; }

        /// <summary>
        /// The knowledge bases this search actually ran against. Equal<br/>
        /// to the agent's full attached set unless the active subagent<br/>
        /// node carried a `knowledge_base_filter`, in which case it is<br/>
        /// the narrowed subset — so the log shows which sources each<br/>
        /// phase of the call was allowed to consult, not just which<br/>
        /// ones returned a hit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searched_knowledge_base_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SearchedKnowledgeBaseIds { get; set; }

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
        /// Initializes a new instance of the <see cref="RetrievalLogEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conversationId">
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the conversation.
        /// </param>
        /// <param name="query"></param>
        /// <param name="results"></param>
        /// <param name="limit"></param>
        /// <param name="hitCount"></param>
        /// <param name="nodeKey">
        /// Key of the flow node that was active when the agent ran this<br/>
        /// search. Empty when the call ran without a flow, or for rows<br/>
        /// recorded before phase attribution existed.
        /// </param>
        /// <param name="retrievalVersion">
        /// The retrieval contract that produced this row, so results can be<br/>
        /// compared like with like across a rollout. Rows recorded before<br/>
        /// versioning carry `v1`.
        /// </param>
        /// <param name="searchedKnowledgeBaseIds">
        /// The knowledge bases this search actually ran against. Equal<br/>
        /// to the agent's full attached set unless the active subagent<br/>
        /// node carried a `knowledge_base_filter`, in which case it is<br/>
        /// the narrowed subset — so the log shows which sources each<br/>
        /// phase of the call was allowed to consult, not just which<br/>
        /// ones returned a hit.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="coverage">
        /// The verdict the agent was given for this search. Absent on rows<br/>
        /// recorded before coverage existed.
        /// </param>
        /// <param name="latencyMs">
        /// How long the search took, in milliseconds. Absent on rows<br/>
        /// recorded before it was measured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalLogEntry(
            string id,
            string conversationId,
            string query,
            global::System.Collections.Generic.IList<global::Speechify.RetrievalLogResult> results,
            int limit,
            int hitCount,
            string nodeKey,
            string retrievalVersion,
            global::System.Collections.Generic.IList<string> searchedKnowledgeBaseIds,
            global::System.DateTime createdAt,
            global::Speechify.RetrievalCoverage? coverage,
            int? latencyMs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Limit = limit;
            this.HitCount = hitCount;
            this.NodeKey = nodeKey ?? throw new global::System.ArgumentNullException(nameof(nodeKey));
            this.RetrievalVersion = retrievalVersion ?? throw new global::System.ArgumentNullException(nameof(retrievalVersion));
            this.Coverage = coverage;
            this.LatencyMs = latencyMs;
            this.SearchedKnowledgeBaseIds = searchedKnowledgeBaseIds ?? throw new global::System.ArgumentNullException(nameof(searchedKnowledgeBaseIds));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalLogEntry" /> class.
        /// </summary>
        public RetrievalLogEntry()
        {
        }

    }
}