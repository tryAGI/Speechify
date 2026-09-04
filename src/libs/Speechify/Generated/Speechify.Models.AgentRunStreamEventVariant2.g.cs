
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The run moved to a new status. Not terminal: a run reporting<br/>
    /// `requires_action` is waiting on a human and the stream keeps tailing,<br/>
    /// which is precisely when a client most needs to be told.
    /// </summary>
    public sealed partial class AgentRunStreamEventVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunStreamEventVariant2TypeJsonConverter))]
        public global::Speechify.AgentRunStreamEventVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentRunStatusChangedEventStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentRunStatusChangedEventStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStreamEventVariant2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunStreamEventVariant2(
            global::Speechify.AgentRunStatusChangedEventStatus status,
            global::Speechify.AgentRunStreamEventVariant2Type type)
        {
            this.Type = type;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunStreamEventVariant2" /> class.
        /// </summary>
        public AgentRunStreamEventVariant2()
        {
        }

    }
}