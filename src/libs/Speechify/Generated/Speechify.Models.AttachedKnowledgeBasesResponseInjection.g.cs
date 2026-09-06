
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the agent's attached knowledge reaches the model, on the<br/>
    /// first page only. `whole` means the entire attached corpus rides<br/>
    /// in the prompt and the agent never searches (`corpus_tokens` is<br/>
    /// its size); otherwise retrieval is on and `pinned_documents`<br/>
    /// counts the documents pinned into every prompt beside it.<br/>
    /// `auto_tokens` is the automatic tier's budget, 0 when off.
    /// </summary>
    public sealed partial class AttachedKnowledgeBasesResponseInjection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whole")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Whole { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_tokens")]
        public int? CorpusTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AutoTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned_documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PinnedDocuments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedKnowledgeBasesResponseInjection" /> class.
        /// </summary>
        /// <param name="whole"></param>
        /// <param name="autoTokens"></param>
        /// <param name="pinnedDocuments"></param>
        /// <param name="corpusTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachedKnowledgeBasesResponseInjection(
            bool whole,
            int autoTokens,
            int pinnedDocuments,
            int? corpusTokens)
        {
            this.Whole = whole;
            this.CorpusTokens = corpusTokens;
            this.AutoTokens = autoTokens;
            this.PinnedDocuments = pinnedDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachedKnowledgeBasesResponseInjection" /> class.
        /// </summary>
        public AttachedKnowledgeBasesResponseInjection()
        {
        }

    }
}