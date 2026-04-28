
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A canned response returned when the agent calls `tool_name`. If<br/>
    /// `args_match` is set the mock only triggers when its value appears<br/>
    /// as a substring of the JSON-serialised call arguments (a deliberately<br/>
    /// simple v1 matcher — full expression support is planned). A mock<br/>
    /// without `args_match` always matches for its tool.
    /// </summary>
    public sealed partial class TtsToolMock
    {
        /// <summary>
        /// Name of the tool to intercept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Optional substring of the JSON-serialised call arguments. When<br/>
        /// absent the mock matches unconditionally for this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args_match")]
        public string? ArgsMatch { get; set; }

        /// <summary>
        /// JSON value returned to the agent as the tool result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsToolMock" /> class.
        /// </summary>
        /// <param name="toolName">
        /// Name of the tool to intercept.
        /// </param>
        /// <param name="response">
        /// JSON value returned to the agent as the tool result.
        /// </param>
        /// <param name="argsMatch">
        /// Optional substring of the JSON-serialised call arguments. When<br/>
        /// absent the mock matches unconditionally for this tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsToolMock(
            string toolName,
            object response,
            string? argsMatch)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ArgsMatch = argsMatch;
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsToolMock" /> class.
        /// </summary>
        public TtsToolMock()
        {
        }
    }
}