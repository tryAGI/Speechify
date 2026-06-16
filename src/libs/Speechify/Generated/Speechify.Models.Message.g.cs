
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Message
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.MessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.MessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_args")]
        public object? ToolArgs { get; set; }

        /// <summary>
        /// Arbitrary JSON value returned by the tool (object, array, string, or primitive).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_result")]
        public object? ToolResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="conversationId">
        /// Prefixed wire identifier (`conv_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the parent conversation.
        /// </param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="startedAt"></param>
        /// <param name="toolName"></param>
        /// <param name="toolArgs"></param>
        /// <param name="toolResult">
        /// Arbitrary JSON value returned by the tool (object, array, string, or primitive).
        /// </param>
        /// <param name="endedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Message(
            string id,
            string conversationId,
            global::Speechify.MessageRole role,
            string content,
            global::System.DateTime startedAt,
            string? toolName,
            object? toolArgs,
            object? toolResult,
            global::System.DateTime? endedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolName = toolName;
            this.ToolArgs = toolArgs;
            this.ToolResult = toolResult;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        public Message()
        {
        }

    }
}