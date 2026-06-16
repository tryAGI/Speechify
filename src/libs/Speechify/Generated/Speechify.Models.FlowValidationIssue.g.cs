
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One flow-graph validation problem, located by node/edge/field path.
    /// </summary>
    public sealed partial class FlowValidationIssue
    {
        /// <summary>
        /// Node / edge / field path the issue applies to; drives editor highlighting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Stable per-issue code, e.g. `tool_call.tool_id.invalid`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowValidationIssue" /> class.
        /// </summary>
        /// <param name="path">
        /// Node / edge / field path the issue applies to; drives editor highlighting.
        /// </param>
        /// <param name="code">
        /// Stable per-issue code, e.g. `tool_call.tool_id.invalid`.
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlowValidationIssue(
            string path,
            string code,
            string message)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowValidationIssue" /> class.
        /// </summary>
        public FlowValidationIssue()
        {
        }

    }
}