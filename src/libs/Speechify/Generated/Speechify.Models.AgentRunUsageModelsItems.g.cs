
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentRunUsageModelsItems
    {
        /// <summary>
        /// The model that spent these tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsageModelsItems" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that spent these tokens.
        /// </param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunUsageModelsItems(
            string model,
            int promptTokens,
            int completionTokens,
            int totalTokens)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsageModelsItems" /> class.
        /// </summary>
        public AgentRunUsageModelsItems()
        {
        }

    }
}