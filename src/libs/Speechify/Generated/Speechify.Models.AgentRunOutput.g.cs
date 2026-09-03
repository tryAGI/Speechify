
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The run's result, present only when `status` is `succeeded`.
    /// </summary>
    public sealed partial class AgentRunOutput
    {
        /// <summary>
        /// The agent's final answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply")]
        public string? Reply { get; set; }

        /// <summary>
        /// The structured output, present only when the run carried an<br/>
        /// `output_schema` and the agent produced an object satisfying it.<br/>
        /// Never present alongside `incomplete_reason: output_schema_violation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// The per-step conversation record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentRunOutputTranscriptItems>? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunOutput" /> class.
        /// </summary>
        /// <param name="reply">
        /// The agent's final answer.
        /// </param>
        /// <param name="data">
        /// The structured output, present only when the run carried an<br/>
        /// `output_schema` and the agent produced an object satisfying it.<br/>
        /// Never present alongside `incomplete_reason: output_schema_violation`.
        /// </param>
        /// <param name="transcript">
        /// The per-step conversation record.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunOutput(
            string? reply,
            object? data,
            global::System.Collections.Generic.IList<global::Speechify.AgentRunOutputTranscriptItems>? transcript)
        {
            this.Reply = reply;
            this.Data = data;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunOutput" /> class.
        /// </summary>
        public AgentRunOutput()
        {
        }

    }
}