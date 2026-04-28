
#nullable enable

namespace Speechify
{
    /// <summary>
    /// It details the type of segment, its start and end points in the text, and its start and end times in the synthesized speech audio.
    /// </summary>
    public sealed partial class TtsNestedChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public long? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public double? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public long? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="TtsNestedChunk" /> class.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="endTime"></param>
        /// <param name="start"></param>
        /// <param name="startTime"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsNestedChunk(
            long? end,
            double? endTime,
            long? start,
            double? startTime,
            string? type,
            string? value)
        {
            this.End = end;
            this.EndTime = endTime;
            this.Start = start;
            this.StartTime = startTime;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsNestedChunk" /> class.
        /// </summary>
        public TtsNestedChunk()
        {
        }
    }
}