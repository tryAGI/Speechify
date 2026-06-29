
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Token usage for a single upstream model in the fan-out.
    /// </summary>
    public sealed partial class WaymarkModelUsage
    {
        /// <summary>
        /// The upstream model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Prompt (input) tokens this model consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long InputTokens { get; set; }

        /// <summary>
        /// Completion (output) tokens this model produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long OutputTokens { get; set; }

        /// <summary>
        /// Input tokens served from provider cache reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CachedInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WaymarkModelUsage" /> class.
        /// </summary>
        /// <param name="model">
        /// The upstream model identifier.
        /// </param>
        /// <param name="inputTokens">
        /// Prompt (input) tokens this model consumed.
        /// </param>
        /// <param name="outputTokens">
        /// Completion (output) tokens this model produced.
        /// </param>
        /// <param name="cachedInputTokens">
        /// Input tokens served from provider cache reads.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WaymarkModelUsage(
            string model,
            long inputTokens,
            long outputTokens,
            long cachedInputTokens)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CachedInputTokens = cachedInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaymarkModelUsage" /> class.
        /// </summary>
        public WaymarkModelUsage()
        {
        }

    }
}