
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCreateVoiceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_audio")]
        public string? PreviewAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateVoiceLanguage" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="previewAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCreateVoiceLanguage(
            string? locale,
            string? previewAudio)
        {
            this.Locale = locale;
            this.PreviewAudio = previewAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCreateVoiceLanguage" /> class.
        /// </summary>
        public TtsCreateVoiceLanguage()
        {
        }

    }
}