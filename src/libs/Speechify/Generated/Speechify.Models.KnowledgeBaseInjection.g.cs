
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The prompt budget in force for this knowledge base, present on the<br/>
    /// by-id read. `auto_tokens` is the automatic tier's budget (0 when the<br/>
    /// tier is off): a knowledge base whose documents count at most that<br/>
    /// many tokens is placed in the prompt whole. `pin_budget_tokens`<br/>
    /// bounds the documents pinned with `injection_mode: always`, and<br/>
    /// `pinned_tokens` is what they count today.
    /// </summary>
    public sealed partial class KnowledgeBaseInjection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AutoTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pin_budget_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PinBudgetTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PinnedTokens { get; set; }

        /// <summary>
        /// This knowledge base on its own counts at most `auto_tokens`<br/>
        /// tokens, so an agent whose attached knowledge stays under the<br/>
        /// budget carries it in the prompt whole and logs no searches<br/>
        /// for it. Always false while the automatic tier is off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fits_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FitsPrompt { get; set; }

        /// <summary>
        /// The exact token count when `fits_prompt` is true; absent otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_tokens")]
        public int? CorpusTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseInjection" /> class.
        /// </summary>
        /// <param name="autoTokens"></param>
        /// <param name="pinBudgetTokens"></param>
        /// <param name="pinnedTokens"></param>
        /// <param name="fitsPrompt">
        /// This knowledge base on its own counts at most `auto_tokens`<br/>
        /// tokens, so an agent whose attached knowledge stays under the<br/>
        /// budget carries it in the prompt whole and logs no searches<br/>
        /// for it. Always false while the automatic tier is off.
        /// </param>
        /// <param name="corpusTokens">
        /// The exact token count when `fits_prompt` is true; absent otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseInjection(
            int autoTokens,
            int pinBudgetTokens,
            int pinnedTokens,
            bool fitsPrompt,
            int? corpusTokens)
        {
            this.AutoTokens = autoTokens;
            this.PinBudgetTokens = pinBudgetTokens;
            this.PinnedTokens = pinnedTokens;
            this.FitsPrompt = fitsPrompt;
            this.CorpusTokens = corpusTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseInjection" /> class.
        /// </summary>
        public KnowledgeBaseInjection()
        {
        }

    }
}