
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Anthropic token-usage totals for the request.
    /// </summary>
    public sealed partial class AnthropicMessageUsage
    {
        /// <summary>
        /// The number of input tokens consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public long? InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public long? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens consumed.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens produced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessageUsage(
            long? inputTokens,
            long? outputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageUsage" /> class.
        /// </summary>
        public AnthropicMessageUsage()
        {
        }

    }
}