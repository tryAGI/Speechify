
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Connection details for an authorized observer (workspace owner or<br/>
    /// admin) joining an active conversation as a hidden, listen-only<br/>
    /// participant. A realtime client consumes `signaling_url` + `token`<br/>
    /// to attach to the live room and play the agent + caller audio<br/>
    /// tracks.
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
        /// wss://… signaling URL the realtime client connects to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signaling_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignalingUrl { get; set; }

        /// <summary>
        /// Short-lived realtime access token. The grant is listen-only<br/>
        /// (cannot publish audio or data) and hidden, so the observer can<br/>
        /// hear the call but cannot speak and is invisible to the caller<br/>
        /// and the agent.
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
        /// When the token stops being accepted by the realtime provider. Re-mint past this point.
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
        /// <param name="signalingUrl">
        /// wss://… signaling URL the realtime client connects to.
        /// </param>
        /// <param name="token">
        /// Short-lived realtime access token. The grant is listen-only<br/>
        /// (cannot publish audio or data) and hidden, so the observer can<br/>
        /// hear the call but cannot speak and is invisible to the caller<br/>
        /// and the agent.
        /// </param>
        /// <param name="identity">
        /// Opaque participant identity tag (e.g. shadow_&lt;hex&gt;). Visible only to admin tooling.
        /// </param>
        /// <param name="expiresAt">
        /// When the token stops being accepted by the realtime provider. Re-mint past this point.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShadowConversationResponse(
            string conversationId,
            string signalingUrl,
            string token,
            string identity,
            global::System.DateTime expiresAt)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.SignalingUrl = signalingUrl ?? throw new global::System.ArgumentNullException(nameof(signalingUrl));
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