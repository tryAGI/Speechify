
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Returned synchronously when LiveKit accepts the SIP INVITE. Poll<br/>
    /// `GET /v1/agents/conversations/{conversation_id}` for status transitions:<br/>
    /// `pending` (ringing) → `active` (answered) → `completed`.
    /// </summary>
    public sealed partial class CreateOutboundCallResponse
    {
        /// <summary>
        /// ID of the conversation created for this call. Use to poll status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundCallResponse" /> class.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation created for this call. Use to poll status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOutboundCallResponse(
            string conversationId)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOutboundCallResponse" /> class.
        /// </summary>
        public CreateOutboundCallResponse()
        {
        }

    }
}