
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsGetVoiceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsGetVoiceLanguage" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="previewAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetVoiceLanguage(
            string locale,
            string? previewAudio)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.PreviewAudio = previewAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetVoiceLanguage" /> class.
        /// </summary>
        public TtsGetVoiceLanguage()
        {
        }
    }
}