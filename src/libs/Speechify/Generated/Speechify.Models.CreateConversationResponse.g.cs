
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Returned when a conversation is created. The `token` + `url`<br/>
    /// let the caller connect its browser/SDK directly to the<br/>
    /// realtime voice session — the agent that answers is dispatched<br/>
    /// server-side.
    /// </summary>
    public sealed partial class CreateConversationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.Conversation Conversation { get; set; }

        /// <summary>
        /// Short-lived realtime session access token (JWT).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Realtime session wss:// URL to connect to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationResponse" /> class.
        /// </summary>
        /// <param name="conversation"></param>
        /// <param name="token">
        /// Short-lived realtime session access token (JWT).
        /// </param>
        /// <param name="url">
        /// Realtime session wss:// URL to connect to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationResponse(
            global::Speechify.Conversation conversation,
            string token,
            string url)
        {
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationResponse" /> class.
        /// </summary>
        public CreateConversationResponse()
        {
        }

    }
}