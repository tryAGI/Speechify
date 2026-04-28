
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsSearchKnowledgeBasesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseSearchHit> Hits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSearchKnowledgeBasesResponse" /> class.
        /// </summary>
        /// <param name="hits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsSearchKnowledgeBasesResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseSearchHit> hits)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsSearchKnowledgeBasesResponse" /> class.
        /// </summary>
        public TtsSearchKnowledgeBasesResponse()
        {
        }
    }
}