
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Speech-to-text configuration.
    /// </summary>
    public sealed partial class AgentSTTConfig
    {
        /// <summary>
        /// Pins the streaming speech-to-text stack this agent<br/>
        /// dispatches with. Null uses the platform default (Whisper<br/>
        /// Large V3).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentSttConfigOverrideJsonConverter))]
        public global::Speechify.AgentSttConfigOverride? Override { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSTTConfig" /> class.
        /// </summary>
        /// <param name="override">
        /// Pins the streaming speech-to-text stack this agent<br/>
        /// dispatches with. Null uses the platform default (Whisper<br/>
        /// Large V3).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSTTConfig(
            global::Speechify.AgentSttConfigOverride? @override)
        {
            this.Override = @override;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSTTConfig" /> class.
        /// </summary>
        public AgentSTTConfig()
        {
        }

    }
}