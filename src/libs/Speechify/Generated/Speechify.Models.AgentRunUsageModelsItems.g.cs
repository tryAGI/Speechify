
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
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_micro_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CostMicroUsd { get; set; }

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
        /// <param name="inputTokens"></param>
        /// <param name="cachedInputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="costMicroUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunUsageModelsItems(
            string model,
            int inputTokens,
            int cachedInputTokens,
            int outputTokens,
            int totalTokens,
            long costMicroUsd)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.InputTokens = inputTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.CostMicroUsd = costMicroUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunUsageModelsItems" /> class.
        /// </summary>
        public AgentRunUsageModelsItems()
        {
        }

    }
}