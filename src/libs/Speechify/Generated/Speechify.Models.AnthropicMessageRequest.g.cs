
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Anthropic-compatible Messages request. Only `model`, `max_tokens`, and<br/>
    /// `messages` are required; any other Anthropic parameter (`system`,<br/>
    /// `temperature`, `top_p`, `stop_sequences`, `tools`, …) is accepted and<br/>
    /// forwarded unchanged.
    /// </summary>
    public sealed partial class AnthropicMessageRequest
    {
        /// <summary>
        /// The route to run. `waymark-fast` favors latency, `waymark-moa`<br/>
        /// balances quality and cost, and `waymark-max` runs the widest panel<br/>
        /// for the highest quality. Access to the higher routes depends on your<br/>
        /// plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnthropicMessageRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnthropicMessageRequestModel Model { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate before stopping. Required<br/>
        /// by the Anthropic Messages API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MaxTokens { get; set; }

        /// <summary>
        /// The conversation so far, in Anthropic message format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AnthropicMessageRequestMessagesItems> Messages { get; set; }

        /// <summary>
        /// A system prompt giving the model context and instructions: a plain<br/>
        /// string, or an array of Anthropic text blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnthropicMessageRequestSystemJsonConverter))]
        public global::Speechify.AnthropicMessageRequestSystem? System { get; set; }

        /// <summary>
        /// When true, the answer is streamed back as a `text/event-stream` of<br/>
        /// Anthropic server-sent events instead of a single JSON response.<br/>
        /// Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Amount of randomness injected into the response (0 to 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Use nucleus sampling over the given cumulative probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Custom text sequences that will cause the model to stop generating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The route to run. `waymark-fast` favors latency, `waymark-moa`<br/>
        /// balances quality and cost, and `waymark-max` runs the widest panel<br/>
        /// for the highest quality. Access to the higher routes depends on your<br/>
        /// plan.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate before stopping. Required<br/>
        /// by the Anthropic Messages API.
        /// </param>
        /// <param name="messages">
        /// The conversation so far, in Anthropic message format.
        /// </param>
        /// <param name="system">
        /// A system prompt giving the model context and instructions: a plain<br/>
        /// string, or an array of Anthropic text blocks.
        /// </param>
        /// <param name="stream">
        /// When true, the answer is streamed back as a `text/event-stream` of<br/>
        /// Anthropic server-sent events instead of a single JSON response.<br/>
        /// Defaults to false.
        /// </param>
        /// <param name="temperature">
        /// Amount of randomness injected into the response (0 to 1).
        /// </param>
        /// <param name="topP">
        /// Use nucleus sampling over the given cumulative probability.
        /// </param>
        /// <param name="stopSequences">
        /// Custom text sequences that will cause the model to stop generating.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessageRequest(
            global::Speechify.AnthropicMessageRequestModel model,
            long maxTokens,
            global::System.Collections.Generic.IList<global::Speechify.AnthropicMessageRequestMessagesItems> messages,
            global::Speechify.AnthropicMessageRequestSystem? system,
            bool? stream,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<string>? stopSequences)
        {
            this.Model = model;
            this.MaxTokens = maxTokens;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.System = system;
            this.Stream = stream;
            this.Temperature = temperature;
            this.TopP = topP;
            this.StopSequences = stopSequences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageRequest" /> class.
        /// </summary>
        public AnthropicMessageRequest()
        {
        }

    }
}