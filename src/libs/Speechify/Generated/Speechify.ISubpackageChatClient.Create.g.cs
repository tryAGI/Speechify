#nullable enable

namespace Speechify
{
    public partial interface ISubpackageChatClient
    {
        /// <summary>
        /// Create Chat Completion<br/>
        /// OpenAI-compatible chat completions. The gateway runs a mixture of<br/>
        /// frontier models and returns a single answer, so the request and<br/>
        /// response follow the OpenAI chat-completions shape: point the OpenAI SDK<br/>
        /// at this base URL and set `model` to one of the `waymark-*` routes. Any<br/>
        /// standard OpenAI parameter (`temperature`, `max_tokens`, `tools`, …) is<br/>
        /// forwarded.<br/>
        /// Set `stream: true` to receive the answer as a `text/event-stream` of<br/>
        /// server-sent events. The response adds a `waymark` object reporting which<br/>
        /// upstream models ran and their per-model token counts, and the<br/>
        /// `Speechify-Route` response header names the route that served the<br/>
        /// request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ChatCompletionResponse> CreateAsync(

            global::Speechify.ChatCompletionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion<br/>
        /// OpenAI-compatible chat completions. The gateway runs a mixture of<br/>
        /// frontier models and returns a single answer, so the request and<br/>
        /// response follow the OpenAI chat-completions shape: point the OpenAI SDK<br/>
        /// at this base URL and set `model` to one of the `waymark-*` routes. Any<br/>
        /// standard OpenAI parameter (`temperature`, `max_tokens`, `tools`, …) is<br/>
        /// forwarded.<br/>
        /// Set `stream: true` to receive the answer as a `text/event-stream` of<br/>
        /// server-sent events. The response adds a `waymark` object reporting which<br/>
        /// upstream models ran and their per-model token counts, and the<br/>
        /// `Speechify-Route` response header names the route that served the<br/>
        /// request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ChatCompletionResponse>> CreateAsResponseAsync(

            global::Speechify.ChatCompletionRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion<br/>
        /// OpenAI-compatible chat completions. The gateway runs a mixture of<br/>
        /// frontier models and returns a single answer, so the request and<br/>
        /// response follow the OpenAI chat-completions shape: point the OpenAI SDK<br/>
        /// at this base URL and set `model` to one of the `waymark-*` routes. Any<br/>
        /// standard OpenAI parameter (`temperature`, `max_tokens`, `tools`, …) is<br/>
        /// forwarded.<br/>
        /// Set `stream: true` to receive the answer as a `text/event-stream` of<br/>
        /// server-sent events. The response adds a `waymark` object reporting which<br/>
        /// upstream models ran and their per-model token counts, and the<br/>
        /// `Speechify-Route` response header names the route that served the<br/>
        /// request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ChatCompletionResponse> CreateAsync(
            global::Speechify.ChatCompletionRequestModel model,
            global::System.Collections.Generic.IList<global::Speechify.ChatMessage> messages,
            string? speechifyVersion = default,
            bool? stream = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}