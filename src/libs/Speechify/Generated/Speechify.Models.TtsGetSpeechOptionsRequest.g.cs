
#nullable enable

namespace Speechify
{
    /// <summary>
    /// GetSpeechOptionsRequest is the wrapper for request parameters to the client
    /// </summary>
    public sealed partial class TtsGetSpeechOptionsRequest
    {
        /// <summary>
        /// Determines whether to normalize the audio loudness to a standard level.<br/>
        /// When enabled, loudness normalization aligns the audio output to the following standards:<br/>
        /// Integrated loudness: -14 LUFS<br/>
        /// True peak: -2 dBTP<br/>
        /// Loudness range: 7 LU<br/>
        /// If disabled, the audio loudness will match the original loudness of the selected voice, which may vary significantly and be either too quiet or too loud.<br/>
        /// Enabling loudness normalization can increase latency due to additional processing required for audio level adjustments.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness_normalization")]
        public bool? LoudnessNormalization { get; set; }

        /// <summary>
        /// Determines whether to normalize the text. If enabled, it will transform numbers, dates, etc. into words. For example, "55" is normalized into "fifty five".<br/>
        /// This can increase latency due to additional processing required for text normalization.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_normalization")]
        public bool? TextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetSpeechOptionsRequest" /> class.
        /// </summary>
        /// <param name="loudnessNormalization">
        /// Determines whether to normalize the audio loudness to a standard level.<br/>
        /// When enabled, loudness normalization aligns the audio output to the following standards:<br/>
        /// Integrated loudness: -14 LUFS<br/>
        /// True peak: -2 dBTP<br/>
        /// Loudness range: 7 LU<br/>
        /// If disabled, the audio loudness will match the original loudness of the selected voice, which may vary significantly and be either too quiet or too loud.<br/>
        /// Enabling loudness normalization can increase latency due to additional processing required for audio level adjustments.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="textNormalization">
        /// Determines whether to normalize the text. If enabled, it will transform numbers, dates, etc. into words. For example, "55" is normalized into "fifty five".<br/>
        /// This can increase latency due to additional processing required for text normalization.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetSpeechOptionsRequest(
            bool? loudnessNormalization,
            bool? textNormalization)
        {
            this.LoudnessNormalization = loudnessNormalization;
            this.TextNormalization = textNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetSpeechOptionsRequest" /> class.
        /// </summary>
        public TtsGetSpeechOptionsRequest()
        {
        }

    }
}