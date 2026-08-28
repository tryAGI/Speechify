
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A sound looped under the wait, instead of - or beneath - the<br/>
    /// spoken phrase, for the caller who expects hold music rather<br/>
    /// than an agent repeating itself. It starts on the same dwell as<br/>
    /// `filler_message` (`filler_delay_ms` with nobody speaking) and<br/>
    /// stops the moment the tool settles, so the real answer never<br/>
    /// queues behind it. Omit to leave the wait silent; the phrase and<br/>
    /// the sound are independent, so set either, both, or neither.
    /// </summary>
    public sealed partial class LongRunningToolConfigWaitAudio
    {
        /// <summary>
        /// Which bundled clip to loop. One roster and one mix level<br/>
        /// shared with the agent-level background noise, so a preset<br/>
        /// sounds the same whichever surface picks it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.LongRunningToolConfigWaitAudioPresetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.LongRunningToolConfigWaitAudioPreset Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LongRunningToolConfigWaitAudio" /> class.
        /// </summary>
        /// <param name="preset">
        /// Which bundled clip to loop. One roster and one mix level<br/>
        /// shared with the agent-level background noise, so a preset<br/>
        /// sounds the same whichever surface picks it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LongRunningToolConfigWaitAudio(
            global::Speechify.LongRunningToolConfigWaitAudioPreset preset)
        {
            this.Preset = preset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LongRunningToolConfigWaitAudio" /> class.
        /// </summary>
        public LongRunningToolConfigWaitAudio()
        {
        }

    }
}