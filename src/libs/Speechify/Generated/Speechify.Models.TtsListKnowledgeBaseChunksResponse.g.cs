
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListKnowledgeBaseChunksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseChunk> Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBaseChunksResponse" /> class.
        /// </summary>
        /// <param name="chunks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListKnowledgeBaseChunksResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseChunk> chunks)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBaseChunksResponse" /> class.
        /// </summary>
        public TtsListKnowledgeBaseChunksResponse()
        {
        }
    }
}