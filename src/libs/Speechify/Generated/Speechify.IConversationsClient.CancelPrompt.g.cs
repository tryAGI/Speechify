#nullable enable

namespace Speechify
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Cancel Conversation Prompt<br/>
        /// Cancel an agent-initiated turn the worker has not started. Idempotent:<br/>
        /// a `pending` prompt moves to `cancelled` and nothing is posted; a<br/>
        /// prompt already `running` or terminal is returned unchanged - a<br/>
        /// running turn is seconds from posting and its reply is already the<br/>
        /// agent's own words, so there is nothing to recall.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="promptId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ConversationPrompt> CancelPromptAsync(
            string conversationId,
            string promptId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Conversation Prompt<br/>
        /// Cancel an agent-initiated turn the worker has not started. Idempotent:<br/>
        /// a `pending` prompt moves to `cancelled` and nothing is posted; a<br/>
        /// prompt already `running` or terminal is returned unchanged - a<br/>
        /// running turn is seconds from posting and its reply is already the<br/>
        /// agent's own words, so there is nothing to recall.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="promptId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ConversationPrompt>> CancelPromptAsResponseAsync(
            string conversationId,
            string promptId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}