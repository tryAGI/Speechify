
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 409 body when a tool create is refused because the name is taken. The<br/>
    /// standard `Error` envelope (so clients read `error.code` and<br/>
    /// `request_id`); the resource holding the name rides the structured<br/>
    /// `error.details.held_by` extension, and `error.fields.name` carries the<br/>
    /// same refusal against the input that caused it.
    /// </summary>
    public sealed partial class ToolNameTakenError
    {
        /// <summary>
        /// The error block on a tool name-collision 409. The standard `ErrorDetail`<br/>
        /// whose `details.held_by` names what holds the name, present whenever the<br/>
        /// server could still resolve a holder (`code` = `tool_name_taken`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ToolNameTakenErrorDetail Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNameTakenError" /> class.
        /// </summary>
        /// <param name="error">
        /// The error block on a tool name-collision 409. The standard `ErrorDetail`<br/>
        /// whose `details.held_by` names what holds the name, present whenever the<br/>
        /// server could still resolve a holder (`code` = `tool_name_taken`).
        /// </param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolNameTakenError(
            global::Speechify.ToolNameTakenErrorDetail error,
            string? requestId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolNameTakenError" /> class.
        /// </summary>
        public ToolNameTakenError()
        {
        }

    }
}