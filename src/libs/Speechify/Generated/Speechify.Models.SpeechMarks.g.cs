
#nullable enable

namespace Speechify
{
    /// <summary>
    /// It is used to annotate the audio data with metadata about the synthesis process, like word timing or phoneme details.
    /// </summary>
    public sealed partial class SpeechMarks
    {
        /// <summary>
        /// Array of NestedChunk, each providing detailed segment information within the synthesized speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.NestedChunk> Chunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechMarks" /> class.
        /// </summary>
        /// <param name="chunks">
        /// Array of NestedChunk, each providing detailed segment information within the synthesized speech.
        /// </param>
        /// <param name="end"></param>
        /// <param name="endTime"></param>
        /// <param name="start"></param>
        /// <param name="startTime"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechMarks(
            global::System.Collections.Generic.IList<global::Speechify.NestedChunk> chunks,
            long end,
            double endTime,
            long start,
            double startTime,
            string type,
            string? value)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.End = end;
            this.EndTime = endTime;
            this.Start = start;
            this.StartTime = startTime;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechMarks" /> class.
        /// </summary>
        public SpeechMarks()
        {
        }

    }
}