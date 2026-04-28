
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListKnowledgeBasesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_bases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBase> KnowledgeBases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBasesResponse" /> class.
        /// </summary>
        /// <param name="knowledgeBases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListKnowledgeBasesResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBase> knowledgeBases)
        {
            this.KnowledgeBases = knowledgeBases ?? throw new global::System.ArgumentNullException(nameof(knowledgeBases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBasesResponse" /> class.
        /// </summary>
        public TtsListKnowledgeBasesResponse()
        {
        }
    }
}