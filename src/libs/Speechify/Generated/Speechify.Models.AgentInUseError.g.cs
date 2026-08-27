
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 409 body when an agent delete is refused because a live phone number<br/>
    /// still routes to it. The standard `Error` envelope (so clients read<br/>
    /// `error.code` = `agent_in_use` and `request_id`); the numbers to<br/>
    /// unbind ride the structured `error.details.used_by` extension.
    /// </summary>
    public sealed partial class AgentInUseError
    {
        /// <summary>
        /// The error block on an agent-in-use 409: the standard `ErrorDetail`<br/>
        /// (`code` = `agent_in_use`) whose structured `details.used_by` names<br/>
        /// the numbers to unbind first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentInUseErrorDetail Error { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentInUseError" /> class.
        /// </summary>
        /// <param name="error">
        /// The error block on an agent-in-use 409: the standard `ErrorDetail`<br/>
        /// (`code` = `agent_in_use`) whose structured `details.used_by` names<br/>
        /// the numbers to unbind first.
        /// </param>
        /// <param name="requestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInUseError(
            global::Speechify.AgentInUseErrorDetail error,
            string? requestId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInUseError" /> class.
        /// </summary>
        public AgentInUseError()
        {
        }

    }
}