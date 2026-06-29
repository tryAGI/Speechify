
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicMessageRequestMessagesItems
    {
        /// <summary>
        /// The role of the message author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnthropicMessageRequestMessagesItemsRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnthropicMessageRequestMessagesItemsRole Role { get; set; }

        /// <summary>
        /// The message content: a plain string for simple turns, or an<br/>
        /// array of Anthropic content blocks for multimodal / tool input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnthropicMessageRequestMessagesItemsContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnthropicMessageRequestMessagesItemsContent Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageRequestMessagesItems" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message author.
        /// </param>
        /// <param name="content">
        /// The message content: a plain string for simple turns, or an<br/>
        /// array of Anthropic content blocks for multimodal / tool input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessageRequestMessagesItems(
            global::Speechify.AnthropicMessageRequestMessagesItemsRole role,
            global::Speechify.AnthropicMessageRequestMessagesItemsContent content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageRequestMessagesItems" /> class.
        /// </summary>
        public AnthropicMessageRequestMessagesItems()
        {
        }

    }
}