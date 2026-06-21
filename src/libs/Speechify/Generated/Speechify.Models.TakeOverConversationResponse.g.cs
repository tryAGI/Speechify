
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Connection details for an authorized operator (workspace owner or<br/>
    /// admin) taking over an active conversation. A real-time client<br/>
    /// consumes `livekit_url` + `token` to join the live call publishing<br/>
    /// the operator's microphone; the AI agent stands down for the<br/>
    /// duration and resumes when the operator leaves.
    /// </summary>
    public sealed partial class TakeOverConversationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("room_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoomName { get; set; }

        /// <summary>
        /// Signaling URL the real-time client connects to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LivekitUrl { get; set; }

        /// <summary>
        /// Short-lived access token authorizing the operator to publish<br/>
        /// audio to and subscribe to the live call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Opaque participant identity for the operator's session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identity { get; set; }

        /// <summary>
        /// When the token stops being accepted. The client should re-mint past this point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TakeOverConversationResponse" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="roomName"></param>
        /// <param name="livekitUrl">
        /// Signaling URL the real-time client connects to.
        /// </param>
        /// <param name="token">
        /// Short-lived access token authorizing the operator to publish<br/>
        /// audio to and subscribe to the live call.
        /// </param>
        /// <param name="identity">
        /// Opaque participant identity for the operator's session.
        /// </param>
        /// <param name="expiresAt">
        /// When the token stops being accepted. The client should re-mint past this point.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TakeOverConversationResponse(
            string conversationId,
            string roomName,
            string livekitUrl,
            string token,
            string identity,
            global::System.DateTime expiresAt)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.RoomName = roomName ?? throw new global::System.ArgumentNullException(nameof(roomName));
            this.LivekitUrl = livekitUrl ?? throw new global::System.ArgumentNullException(nameof(livekitUrl));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Identity = identity ?? throw new global::System.ArgumentNullException(nameof(identity));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TakeOverConversationResponse" /> class.
        /// </summary>
        public TakeOverConversationResponse()
        {
        }

    }
}