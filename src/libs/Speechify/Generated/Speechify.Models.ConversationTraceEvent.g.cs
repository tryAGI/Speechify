
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A discrete action that fired during a turn - a tool call or a DTMF<br/>
    /// keypress. Carries timing and kind only, no free-text arguments.
    /// </summary>
    public sealed partial class ConversationTraceEvent
    {
        /// <summary>
        /// The kind of action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ConversationTraceEventKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ConversationTraceEventKind Kind { get; set; }

        /// <summary>
        /// The tool name (agent configuration, not caller data). Empty for DTMF.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Milliseconds from the start of the call to when the action fired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long OffsetMs { get; set; }

        /// <summary>
        /// How long the action took, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public double? DurationMs { get; set; }

        /// <summary>
        /// True when the tool call failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTraceEvent" /> class.
        /// </summary>
        /// <param name="kind">
        /// The kind of action.
        /// </param>
        /// <param name="offsetMs">
        /// Milliseconds from the start of the call to when the action fired.
        /// </param>
        /// <param name="name">
        /// The tool name (agent configuration, not caller data). Empty for DTMF.
        /// </param>
        /// <param name="durationMs">
        /// How long the action took, in milliseconds.
        /// </param>
        /// <param name="isError">
        /// True when the tool call failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTraceEvent(
            global::Speechify.ConversationTraceEventKind kind,
            long offsetMs,
            string? name,
            double? durationMs,
            bool? isError)
        {
            this.Kind = kind;
            this.Name = name;
            this.OffsetMs = offsetMs;
            this.DurationMs = durationMs;
            this.IsError = isError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTraceEvent" /> class.
        /// </summary>
        public ConversationTraceEvent()
        {
        }

    }
}