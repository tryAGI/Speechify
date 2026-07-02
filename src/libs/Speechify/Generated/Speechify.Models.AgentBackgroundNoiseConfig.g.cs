
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional ambient background-noise bed mixed into the call.
    /// </summary>
    public sealed partial class AgentBackgroundNoiseConfig
    {
        /// <summary>
        /// Pre-mixed ambient bed. Null disables background noise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetJsonConverter))]
        public global::Speechify.AgentBackgroundNoiseConfigPreset? Preset { get; set; }

        /// <summary>
        /// Volume of the background-noise bed (0.0-1.0). Null disables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public string? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBackgroundNoiseConfig" /> class.
        /// </summary>
        /// <param name="preset">
        /// Pre-mixed ambient bed. Null disables background noise.
        /// </param>
        /// <param name="volume">
        /// Volume of the background-noise bed (0.0-1.0). Null disables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBackgroundNoiseConfig(
            global::Speechify.AgentBackgroundNoiseConfigPreset? preset,
            string? volume)
        {
            this.Preset = preset;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBackgroundNoiseConfig" /> class.
        /// </summary>
        public AgentBackgroundNoiseConfig()
        {
        }

    }
}