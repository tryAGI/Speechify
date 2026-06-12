
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsSearchKnowledgeBasesRequest
    {
        /// <summary>
        /// Natural-language search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Knowledge bases to search across. Results scoped to caller-owned entries; unknown IDs are silently ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kb_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KbIds { get; set; }

        /// <summary>
        /// Max hits to return (default 5, capped at 50).<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSearchKnowledgeBasesRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural-language search query.
        /// </param>
        /// <param name="kbIds">
        /// Knowledge bases to search across. Results scoped to caller-owned entries; unknown IDs are silently ignored.
        /// </param>
        /// <param name="topK">
        /// Max hits to return (default 5, capped at 50).<br/>
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSearchKnowledgeBasesRequest(
            string query,
            global::System.Collections.Generic.IList<string> kbIds,
            int? topK)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.KbIds = kbIds ?? throw new global::System.ArgumentNullException(nameof(kbIds));
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSearchKnowledgeBasesRequest" /> class.
        /// </summary>
        public TtsSearchKnowledgeBasesRequest()
        {
        }

    }
}