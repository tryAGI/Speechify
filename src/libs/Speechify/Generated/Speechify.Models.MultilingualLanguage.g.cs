
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One language available to multilingual agents. Which backend<br/>
    /// serves a language is an internal routing decision and is not<br/>
    /// exposed; what callers need is whether it survives on the realtime<br/>
    /// pipeline and which voice speaks it by default.
    /// </summary>
    public sealed partial class MultilingualLanguage
    {
        /// <summary>
        /// BCP-47 tag to declare, at the granularity that changes what a<br/>
        /// caller hears: a locale where the accent is a real choice<br/>
        /// (`es-MX`, `pt-BR`), a plain subtag where it is not (`pl`). The<br/>
        /// tag reaches the speech model as-is. Only one entry per language<br/>
        /// may be declared on an agent, so `es-MX` and `es-ES` are<br/>
        /// alternatives rather than a pair.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// False for languages the audio-native realtime model cannot<br/>
        /// serve. Declaring one on a realtime agent is rejected at write<br/>
        /// time, so pickers should disable it rather than let the save<br/>
        /// fail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realtime_supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RealtimeSupported { get; set; }

        /// <summary>
        /// Voice used when the language carries no per-language<br/>
        /// `voice_id`. Omitted when the agent's own voice speaks the<br/>
        /// language, which is what preserves voice identity across a<br/>
        /// switch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_voice_id")]
        public string? DefaultVoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualLanguage" /> class.
        /// </summary>
        /// <param name="language">
        /// BCP-47 tag to declare, at the granularity that changes what a<br/>
        /// caller hears: a locale where the accent is a real choice<br/>
        /// (`es-MX`, `pt-BR`), a plain subtag where it is not (`pl`). The<br/>
        /// tag reaches the speech model as-is. Only one entry per language<br/>
        /// may be declared on an agent, so `es-MX` and `es-ES` are<br/>
        /// alternatives rather than a pair.
        /// </param>
        /// <param name="realtimeSupported">
        /// False for languages the audio-native realtime model cannot<br/>
        /// serve. Declaring one on a realtime agent is rejected at write<br/>
        /// time, so pickers should disable it rather than let the save<br/>
        /// fail.
        /// </param>
        /// <param name="defaultVoiceId">
        /// Voice used when the language carries no per-language<br/>
        /// `voice_id`. Omitted when the agent's own voice speaks the<br/>
        /// language, which is what preserves voice identity across a<br/>
        /// switch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultilingualLanguage(
            string language,
            bool realtimeSupported,
            string? defaultVoiceId)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.RealtimeSupported = realtimeSupported;
            this.DefaultVoiceId = defaultVoiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualLanguage" /> class.
        /// </summary>
        public MultilingualLanguage()
        {
        }

    }
}