
#nullable enable

namespace Speechify
{
    /// <summary>
    /// OpenAI-compatible chat-completion request. Only `model` and `messages`<br/>
    /// are required; any other OpenAI parameter (`temperature`, `max_tokens`,<br/>
    /// `tools`, `response_format`, …) is accepted and forwarded unchanged.
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// The route to run. `waymark-fast` favors latency, `waymark-moa`<br/>
        /// balances quality and cost, and `waymark-max` runs the widest panel<br/>
        /// for the highest quality. Access to the higher routes depends on your<br/>
        /// plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ChatCompletionRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ChatCompletionRequestModel Model { get; set; }

        /// <summary>
        /// The conversation so far, in OpenAI chat-message format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ChatMessage> Messages { get; set; }

        /// <summary>
        /// When true, the answer is streamed back as a `text/event-stream` of<br/>
        /// server-sent events instead of a single JSON response. Defaults to<br/>
        /// false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The route to run. `waymark-fast` favors latency, `waymark-moa`<br/>
        /// balances quality and cost, and `waymark-max` runs the widest panel<br/>
        /// for the highest quality. Access to the higher routes depends on your<br/>
        /// plan.
        /// </param>
        /// <param name="messages">
        /// The conversation so far, in OpenAI chat-message format.
        /// </param>
        /// <param name="stream">
        /// When true, the answer is streamed back as a `text/event-stream` of<br/>
        /// server-sent events instead of a single JSON response. Defaults to<br/>
        /// false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            global::Speechify.ChatCompletionRequestModel model,
            global::System.Collections.Generic.IList<global::Speechify.ChatMessage> messages,
            bool? stream)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }

    }
}