
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Connection details for an authorized observer (workspace owner or<br/>
    /// admin) joining an active conversation as a hidden, listen-only<br/>
    /// participant. The livekit-client SDK consumes `livekit_url` +<br/>
    /// `token` to attach to the live room and play the agent + caller<br/>
    /// audio tracks.
    /// </summary>
    public sealed partial class ShadowConversationResponse
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
        /// wss://… signaling URL for the LiveKit project hosting the room.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LivekitUrl { get; set; }

        /// <summary>
        /// Short-lived LiveKit access token. Grant has CanPublish=false,<br/>
        /// CanPublishData=false, CanSubscribe=true, Hidden=true so the<br/>
        /// observer can listen but cannot speak and is invisible to the<br/>
        /// caller and the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Opaque participant identity tag (e.g. shadow_&lt;hex&gt;). Visible only to admin tooling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identity { get; set; }

        /// <summary>
        /// When the token stops being accepted by LiveKit. The console should re-mint past this point.
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
        /// Initializes a new instance of the <see cref="ShadowConversationResponse" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="roomName"></param>
        /// <param name="livekitUrl">
        /// wss://… signaling URL for the LiveKit project hosting the room.
        /// </param>
        /// <param name="token">
        /// Short-lived LiveKit access token. Grant has CanPublish=false,<br/>
        /// CanPublishData=false, CanSubscribe=true, Hidden=true so the<br/>
        /// observer can listen but cannot speak and is invisible to the<br/>
        /// caller and the agent.
        /// </param>
        /// <param name="identity">
        /// Opaque participant identity tag (e.g. shadow_&lt;hex&gt;). Visible only to admin tooling.
        /// </param>
        /// <param name="expiresAt">
        /// When the token stops being accepted by LiveKit. The console should re-mint past this point.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShadowConversationResponse(
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
        /// Initializes a new instance of the <see cref="ShadowConversationResponse" /> class.
        /// </summary>
        public ShadowConversationResponse()
        {
        }

    }
}