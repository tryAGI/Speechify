
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSpeechResponse
    {
        /// <summary>
        /// Synthesized speech audio, Base64-encoded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AudioData { get; set; }

        /// <summary>
        /// The codec of the audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.GetSpeechResponseAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.GetSpeechResponseAudioFormat AudioFormat { get; set; }

        /// <summary>
        /// The number of billable characters processed in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_characters_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BillableCharactersCount { get; set; }

        /// <summary>
        /// The full `codec_sampleRate_bitrate` format the audio was encoded in, returned when the request set `output_format`. It is the requested value unless the request named a bitrate above the mp3 ceiling, in which case it reports the bitrate actually delivered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AudioOutputFormatJsonConverter))]
        public global::Speechify.AudioOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// It is used to annotate the audio data with metadata about the synthesis process, like word timing or phoneme details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_marks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.SpeechMarks SpeechMarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeechResponse" /> class.
        /// </summary>
        /// <param name="audioData">
        /// Synthesized speech audio, Base64-encoded
        /// </param>
        /// <param name="audioFormat">
        /// The codec of the audio data
        /// </param>
        /// <param name="billableCharactersCount">
        /// The number of billable characters processed in the request.
        /// </param>
        /// <param name="speechMarks">
        /// It is used to annotate the audio data with metadata about the synthesis process, like word timing or phoneme details.
        /// </param>
        /// <param name="outputFormat">
        /// The full `codec_sampleRate_bitrate` format the audio was encoded in, returned when the request set `output_format`. It is the requested value unless the request named a bitrate above the mp3 ceiling, in which case it reports the bitrate actually delivered.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpeechResponse(
            byte[] audioData,
            global::Speechify.GetSpeechResponseAudioFormat audioFormat,
            long billableCharactersCount,
            global::Speechify.SpeechMarks speechMarks,
            global::Speechify.AudioOutputFormat? outputFormat)
        {
            this.AudioData = audioData ?? throw new global::System.ArgumentNullException(nameof(audioData));
            this.AudioFormat = audioFormat;
            this.BillableCharactersCount = billableCharactersCount;
            this.OutputFormat = outputFormat;
            this.SpeechMarks = speechMarks ?? throw new global::System.ArgumentNullException(nameof(speechMarks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeechResponse" /> class.
        /// </summary>
        public GetSpeechResponse()
        {
        }

    }
}