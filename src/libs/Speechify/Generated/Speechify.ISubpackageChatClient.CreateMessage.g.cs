#nullable enable

namespace Speechify
{
    public partial interface ISubpackageChatClient
    {
        /// <summary>
        /// Create Message<br/>
        /// Anthropic-compatible Messages endpoint. The gateway runs a mixture of<br/>
        /// frontier models and returns a single answer in Anthropic's Messages<br/>
        /// shape: point the Anthropic SDK (or Claude Code via `ANTHROPIC_BASE_URL`)<br/>
        /// at this base URL and set `model` to one of the `waymark-*` routes. Any<br/>
        /// standard Anthropic parameter (`system`, `temperature`, `top_p`,<br/>
        /// `stop_sequences`, `tools`, …) is forwarded.<br/>
        /// Set `stream: true` to receive the answer as a `text/event-stream` of<br/>
        /// Anthropic server-sent events. The response adds a `waymark` object<br/>
        /// reporting which upstream models ran and their per-model token counts, and<br/>
        /// the `Speechify-Route` response header names the route that served the<br/>
        /// request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AnthropicMessage> CreateMessageAsync(

            global::Speechify.AnthropicMessageRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Message<br/>
        /// Anthropic-compatible Messages endpoint. The gateway runs a mixture of<br/>
        /// frontier models and returns a single answer in Anthropic's Messages<br/>
        /// shape: point the Anthropic SDK (or Claude Code via `ANTHROPIC_BASE_URL`)<br/>
        /// at this base URL and set `model` to one of the `waymark-*` routes. Any<br/>
        /// standard Anthropic parameter (`system`, `temperature`, `top_p`,<br/>
        /// `stop_sequences`, `tools`, …) is forwarded.<br/>
        /// Set `stream: true` to receive the answer as a `text/event-stream` of<br/>
        /// Anthropic server-sent events. The response adds a `waymark` object<br/>
        /// reporting which upstream models ran and their per-model token counts, and<br/>
        /// the `Speechify-Route` response header names the route that served the<br/>
        /// request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AnthropicMessage>> CreateMessageAsResponseAsync(

            global::Speechify.AnthropicMessageRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Message<br/>
        /// Anthropic-compatible Messages endpoint. The gateway runs a mixture of<br/>
        /// frontier models and returns a single answer in Anthropic's Messages<br/>
        /// shape: point the Anthropic SDK (or Claude Code via `ANTHROPIC_BASE_URL`)<br/>
        /// at this base URL and set `model` to one of the `waymark-*` routes. Any<br/>
        /// standard Anthropic parameter (`system`, `temperature`, `top_p`,<br/>
        /// `stop_sequences`, `tools`, …) is forwarded.<br/>
        /// Set `stream: true` to receive the answer as a `text/event-stream` of<br/>
        /// Anthropic server-sent events. The response adds a `waymark` object<br/>
        /// reporting which upstream models ran and their per-model token counts, and<br/>
        /// the `Speechify-Route` response header names the route that served the<br/>
        /// request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AnthropicMessage> CreateMessageAsync(
            global::Speechify.AnthropicMessageRequestModel model,
            long maxTokens,
            global::System.Collections.Generic.IList<global::Speechify.AnthropicMessageRequestMessagesItems> messages,
            string? speechifyVersion = default,
            global::Speechify.AnthropicMessageRequestSystem? system = default,
            bool? stream = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}