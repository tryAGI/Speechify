
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Terminal event: the synthesis completed and no further events follow.<br/>
    /// There is no `[DONE]` sentinel.
    /// </summary>
    public sealed partial class SpeechStreamEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.SpeechStreamEventVariant2TypeJsonConverter))]
        public global::Speechify.SpeechStreamEventVariant2Type Type { get; set; }

        /// <summary>
        /// Number of billable characters processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_characters_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BillableCharactersCount { get; set; }

        /// <summary>
        /// Duration of the synthesized audio in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventVariant2" /> class.
        /// </summary>
        /// <param name="billableCharactersCount">
        /// Number of billable characters processed.
        /// </param>
        /// <param name="audioDurationMs">
        /// Duration of the synthesized audio in milliseconds.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechStreamEventVariant2(
            int billableCharactersCount,
            int audioDurationMs,
            global::Speechify.SpeechStreamEventVariant2Type type)
        {
            this.Type = type;
            this.BillableCharactersCount = billableCharactersCount;
            this.AudioDurationMs = audioDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamEventVariant2" /> class.
        /// </summary>
        public SpeechStreamEventVariant2()
        {
        }

    }
}