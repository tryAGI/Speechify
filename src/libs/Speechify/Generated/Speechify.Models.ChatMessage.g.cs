
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A single message in an OpenAI-format conversation.
    /// </summary>
    public sealed partial class ChatMessage
    {
        /// <summary>
        /// The role of the message author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ChatMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ChatMessageRole Role { get; set; }

        /// <summary>
        /// The message content. A plain string for most messages; OpenAI-style<br/>
        /// content-part arrays are also accepted for multimodal input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ChatMessageContentJsonConverter))]
        public global::Speechify.ChatMessageContent? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message author.
        /// </param>
        /// <param name="content">
        /// The message content. A plain string for most messages; OpenAI-style<br/>
        /// content-part arrays are also accepted for multimodal input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessage(
            global::Speechify.ChatMessageRole role,
            global::Speechify.ChatMessageContent? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        public ChatMessage()
        {
        }

    }
}