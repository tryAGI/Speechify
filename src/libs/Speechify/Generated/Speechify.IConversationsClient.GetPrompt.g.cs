#nullable enable

namespace Speechify
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Get Conversation Prompt<br/>
        /// Poll an agent-initiated turn. `pending` is queued, `running` is on the<br/>
        /// worker, `completed` means the reply reached the thread (or the agent<br/>
        /// chose to say nothing), `failed` carries `error` saying why it never<br/>
        /// posted, and `cancelled` means a cancel got there before the worker.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="promptId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ConversationPrompt> GetPromptAsync(
            string conversationId,
            string promptId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Conversation Prompt<br/>
        /// Poll an agent-initiated turn. `pending` is queued, `running` is on the<br/>
        /// worker, `completed` means the reply reached the thread (or the agent<br/>
        /// chose to say nothing), `failed` carries `error` saying why it never<br/>
        /// posted, and `cancelled` means a cancel got there before the worker.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="promptId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ConversationPrompt>> GetPromptAsResponseAsync(
            string conversationId,
            string promptId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}