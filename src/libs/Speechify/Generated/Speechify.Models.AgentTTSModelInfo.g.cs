
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// One Simba model selectable with `tts.model`, plus the facts that<br/>
    /// decide whether a given agent may select it.
    /// </summary>
    public sealed partial class AgentTTSModelInfo
    {
        /// <summary>
        /// The value to send as `tts.model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A training still under evaluation. Fully servable and supported;<br/>
        /// simply not one agents are steered onto by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Beta { get; set; }

        /// <summary>
        /// True for the model an agent lands on with no pin. The floor of<br/>
        /// the catalog, and the only entry selectable in every language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Default { get; set; }

        /// <summary>
        /// The model has no multilingual deployment. An agent that resolves<br/>
        /// through the multilingual serving cannot select it at all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("english_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnglishOnly { get; set; }

        /// <summary>
        /// Deprecated and always `false`. No model requires a voice to be<br/>
        /// registered for it: every training conditions on the voice's own<br/>
        /// prompt audio, so every model is selectable on every voice we speak<br/>
        /// ourselves. The field stays on the response for compatibility and<br/>
        /// can be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_voice_curation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresVoiceCuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSModelInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// The value to send as `tts.model`.
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="beta">
        /// A training still under evaluation. Fully servable and supported;<br/>
        /// simply not one agents are steered onto by default.
        /// </param>
        /// <param name="default">
        /// True for the model an agent lands on with no pin. The floor of<br/>
        /// the catalog, and the only entry selectable in every language.
        /// </param>
        /// <param name="englishOnly">
        /// The model has no multilingual deployment. An agent that resolves<br/>
        /// through the multilingual serving cannot select it at all.
        /// </param>
        /// <param name="requiresVoiceCuration">
        /// Deprecated and always `false`. No model requires a voice to be<br/>
        /// registered for it: every training conditions on the voice's own<br/>
        /// prompt audio, so every model is selectable on every voice we speak<br/>
        /// ourselves. The field stays on the response for compatibility and<br/>
        /// can be ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTTSModelInfo(
            string id,
            string displayName,
            string description,
            bool beta,
            bool @default,
            bool englishOnly,
            bool requiresVoiceCuration)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Beta = beta;
            this.Default = @default;
            this.EnglishOnly = englishOnly;
            this.RequiresVoiceCuration = requiresVoiceCuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTTSModelInfo" /> class.
        /// </summary>
        public AgentTTSModelInfo()
        {
        }

    }
}