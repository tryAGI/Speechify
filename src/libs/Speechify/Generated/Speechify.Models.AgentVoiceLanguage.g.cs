
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentVoiceLanguage
    {
        /// <summary>
        /// BCP-47-ish locale tag (e.g. `en-US`, `de-DE`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// URL to a short audio preview for this locale, or null if<br/>
        /// no preview is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_audio")]
        public string? PreviewAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceLanguage" /> class.
        /// </summary>
        /// <param name="locale">
        /// BCP-47-ish locale tag (e.g. `en-US`, `de-DE`).
        /// </param>
        /// <param name="previewAudio">
        /// URL to a short audio preview for this locale, or null if<br/>
        /// no preview is available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVoiceLanguage(
            string locale,
            string? previewAudio)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.PreviewAudio = previewAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVoiceLanguage" /> class.
        /// </summary>
        public AgentVoiceLanguage()
        {
        }

    }
}