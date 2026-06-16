
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One tool invocation that occurred during a simulation run.<br/>
    /// `mocked` is true when the call was intercepted by the run's<br/>
    /// mock config; false when the real tool was called or when the<br/>
    /// tool is a system tool.
    /// </summary>
    public sealed partial class SimulationToolCall
    {
        /// <summary>
        /// Zero-based index of the conversation turn in which this call occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Arguments passed to the tool, as a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Args { get; set; }

        /// <summary>
        /// Response returned to the agent (absent for system tools that end the call).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public object? Response { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Mocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationToolCall" /> class.
        /// </summary>
        /// <param name="turnIndex">
        /// Zero-based index of the conversation turn in which this call occurred.
        /// </param>
        /// <param name="toolName"></param>
        /// <param name="args">
        /// Arguments passed to the tool, as a JSON object.
        /// </param>
        /// <param name="mocked"></param>
        /// <param name="response">
        /// Response returned to the agent (absent for system tools that end the call).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationToolCall(
            int turnIndex,
            string toolName,
            object args,
            bool mocked,
            object? response)
        {
            this.TurnIndex = turnIndex;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Response = response;
            this.Mocked = mocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationToolCall" /> class.
        /// </summary>
        public SimulationToolCall()
        {
        }

    }
}