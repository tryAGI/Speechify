
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One selectable LLM model in the agent model picker.
    /// </summary>
    public sealed partial class LLMModelInfo
    {
        /// <summary>
        /// LLM provider serving the model (e.g. "openai", "speechify").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Model identifier passed through to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Human-readable picker label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// One-line picker description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Access class controlling which plans may select the model:<br/>
        /// 0 = managed, 1 = standard, 2 = premium. Premium models are<br/>
        /// available only on higher plans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Class { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelInfo" /> class.
        /// </summary>
        /// <param name="provider">
        /// LLM provider serving the model (e.g. "openai", "speechify").
        /// </param>
        /// <param name="model">
        /// Model identifier passed through to the provider.
        /// </param>
        /// <param name="label">
        /// Human-readable picker label.
        /// </param>
        /// <param name="description">
        /// One-line picker description.
        /// </param>
        /// <param name="class">
        /// Access class controlling which plans may select the model:<br/>
        /// 0 = managed, 1 = standard, 2 = premium. Premium models are<br/>
        /// available only on higher plans.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMModelInfo(
            string provider,
            string model,
            string label,
            string description,
            int @class)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Class = @class;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMModelInfo" /> class.
        /// </summary>
        public LLMModelInfo()
        {
        }

    }
}