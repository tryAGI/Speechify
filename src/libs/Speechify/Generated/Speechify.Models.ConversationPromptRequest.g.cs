
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/conversations/{conversation_id}/prompts`.
    /// </summary>
    public sealed partial class ConversationPromptRequest
    {
        /// <summary>
        /// What the agent is asked to do in the conversation. It is the turn's input, run with the agent's normal tools on the thread's own context; what the agent writes in reply is what the thread sees.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPromptRequest" /> class.
        /// </summary>
        /// <param name="instruction">
        /// What the agent is asked to do in the conversation. It is the turn's input, run with the agent's normal tools on the thread's own context; what the agent writes in reply is what the thread sees.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationPromptRequest(
            string instruction)
        {
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationPromptRequest" /> class.
        /// </summary>
        public ConversationPromptRequest()
        {
        }

    }
}