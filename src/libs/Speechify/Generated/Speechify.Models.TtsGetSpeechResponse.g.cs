
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsGetSpeechResponse
    {
        /// <summary>
        /// Synthesized speech audio, Base64-encoded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AudioData { get; set; }

        /// <summary>
        /// The format of the audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TtsGetSpeechResponseAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsGetSpeechResponseAudioFormat AudioFormat { get; set; }

        /// <summary>
        /// The number of billable characters processed in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_characters_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BillableCharactersCount { get; set; }

        /// <summary>
        /// It is used to annotate the audio data with metadata about the synthesis process, like word timing or phoneme details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_marks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.TtsSpeechMarks SpeechMarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetSpeechResponse" /> class.
        /// </summary>
        /// <param name="audioData">
        /// Synthesized speech audio, Base64-encoded
        /// </param>
        /// <param name="audioFormat">
        /// The format of the audio data
        /// </param>
        /// <param name="billableCharactersCount">
        /// The number of billable characters processed in the request.
        /// </param>
        /// <param name="speechMarks">
        /// It is used to annotate the audio data with metadata about the synthesis process, like word timing or phoneme details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsGetSpeechResponse(
            byte[] audioData,
            global::Speechify.TtsGetSpeechResponseAudioFormat audioFormat,
            long billableCharactersCount,
            global::Speechify.TtsSpeechMarks speechMarks)
        {
            this.AudioData = audioData ?? throw new global::System.ArgumentNullException(nameof(audioData));
            this.AudioFormat = audioFormat;
            this.BillableCharactersCount = billableCharactersCount;
            this.SpeechMarks = speechMarks ?? throw new global::System.ArgumentNullException(nameof(speechMarks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsGetSpeechResponse" /> class.
        /// </summary>
        public TtsGetSpeechResponse()
        {
        }

    }
}