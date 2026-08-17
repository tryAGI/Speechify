
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A run of synthesized audio, the speech marks that became final with it,<br/>
    /// or both - a chunk may carry only one of the two, and the last chunk of<br/>
    /// a stream is often marks-only. Mark times are absolute milliseconds from<br/>
    /// the start of the synthesis: concatenate the audio chunks into one<br/>
    /// stream and apply the marks against that single timeline. Which chunk a<br/>
    /// mark arrives on is a delivery detail and carries no meaning.
    /// </summary>
    public sealed partial class SpeechStreamEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SpeechStreamEventVariant1TypeJsonConverter))]
        public global::Speechify.SpeechStreamEventVariant1Type Type { get; set; }

        /// <summary>
        /// A run of the synthesized audio, Base64-encoded, in the format the<br/>
        /// request selected (echoed on the `Speechify-Audio-Content-Type`<br/>
        /// response header). Absent on a marks-only chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Word timings addressing the original input text, with absolute<br/>
        /// millisecond times from the start of the synthesis. Absent when the<br/>
        /// chunk carries only audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_marks")]
        public global::System.Collections.Generic.IList<global::Speechify.NestedChunk>? SpeechMarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="audio">
        /// A run of the synthesized audio, Base64-encoded, in the format the<br/>
        /// request selected (echoed on the `Speechify-Audio-Content-Type`<br/>
        /// response header). Absent on a marks-only chunk.
        /// </param>
        /// <param name="speechMarks">
        /// Word timings addressing the original input text, with absolute<br/>
        /// millisecond times from the start of the synthesis. Absent when the<br/>
        /// chunk carries only audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechStreamEventVariant1(
            global::Speechify.SpeechStreamEventVariant1Type type,
            string? audio,
            global::System.Collections.Generic.IList<global::Speechify.NestedChunk>? speechMarks)
        {
            this.Type = type;
            this.Audio = audio;
            this.SpeechMarks = speechMarks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventVariant1" /> class.
        /// </summary>
        public SpeechStreamEventVariant1()
        {
        }

    }
}