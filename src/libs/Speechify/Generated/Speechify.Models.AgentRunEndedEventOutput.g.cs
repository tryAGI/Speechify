
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The run's answer, as Get Agent Run returns it but without<br/>
    /// `transcript` - the stream has already delivered every step<br/>
    /// individually, so repeating them here would send the run twice.<br/>
    /// Absent on a run that produced no answer (failed, cancelled, or<br/>
    /// stopped short).
    /// </summary>
    public sealed partial class AgentRunEndedEventOutput
    {
        /// <summary>
        /// The agent's final answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply")]
        public string? Reply { get; set; }

        /// <summary>
        /// The structured output, present only when the run carried an<br/>
        /// `output_schema` and the agent produced an object satisfying it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunEndedEventOutput" /> class.
        /// </summary>
        /// <param name="reply">
        /// The agent's final answer.
        /// </param>
        /// <param name="data">
        /// The structured output, present only when the run carried an<br/>
        /// `output_schema` and the agent produced an object satisfying it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunEndedEventOutput(
            string? reply,
            object? data)
        {
            this.Reply = reply;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunEndedEventOutput" /> class.
        /// </summary>
        public AgentRunEndedEventOutput()
        {
        }

    }
}