
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsListKnowledgeBaseDocumentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseDocument> Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBaseDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsListKnowledgeBaseDocumentsResponse(
            global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseDocument> documents)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsListKnowledgeBaseDocumentsResponse" /> class.
        /// </summary>
        public TtsListKnowledgeBaseDocumentsResponse()
        {
        }
    }
}