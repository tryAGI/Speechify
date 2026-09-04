
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The run settled, and this event carries its answer. It is the last event<br/>
    /// on the stream - there is no `[DONE]` sentinel - and it is everything a<br/>
    /// client needs, so following a run to completion takes no follow-up<br/>
    /// request.
    /// </summary>
    public sealed partial class AgentRunStreamEventVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunStreamEventVariant3TypeJsonConverter))]
        public global::Speechify.AgentRunStreamEventVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunEndedEventStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentRunEndedEventStatus Status { get; set; }

        /// <summary>
        /// Why the run stopped short. Absent when it finished its work.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_reason")]
        public string? IncompleteReason { get; set; }

        /// <summary>
        /// The run's answer, as Get Agent Run returns it but without<br/>
        /// `transcript` - the stream has already delivered every step<br/>
        /// individually, so repeating them here would send the run twice.<br/>
        /// Absent on a run that produced no answer (failed, cancelled, or<br/>
        /// stopped short).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Speechify.AgentRunEndedEventOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStreamEventVariant3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="incompleteReason">
        /// Why the run stopped short. Absent when it finished its work.
        /// </param>
        /// <param name="output">
        /// The run's answer, as Get Agent Run returns it but without<br/>
        /// `transcript` - the stream has already delivered every step<br/>
        /// individually, so repeating them here would send the run twice.<br/>
        /// Absent on a run that produced no answer (failed, cancelled, or<br/>
        /// stopped short).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunStreamEventVariant3(
            global::Speechify.AgentRunEndedEventStatus status,
            global::Speechify.AgentRunStreamEventVariant3Type type,
            string? incompleteReason,
            global::Speechify.AgentRunEndedEventOutput? output)
        {
            this.Type = type;
            this.Status = status;
            this.IncompleteReason = incompleteReason;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStreamEventVariant3" /> class.
        /// </summary>
        public AgentRunStreamEventVariant3()
        {
        }

    }
}