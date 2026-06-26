#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentConversationsClient
    {
        /// <summary>
        /// Get Conversation Traces<br/>
        /// Retrieve the per-call trace timeline for a conversation: the worker<br/>
        /// pipeline spans (STT, end-of-turn, LLM, TTS, tool calls, DTMF) in call<br/>
        /// order, each with its start offset from the beginning of the call and<br/>
        /// its duration, for rendering a latency waterfall. Returns an empty<br/>
        /// timeline for a call that never connected.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ConversationTrace> GetTracesAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Conversation Traces<br/>
        /// Retrieve the per-call trace timeline for a conversation: the worker<br/>
        /// pipeline spans (STT, end-of-turn, LLM, TTS, tool calls, DTMF) in call<br/>
        /// order, each with its start offset from the beginning of the call and<br/>
        /// its duration, for rendering a latency waterfall. Returns an empty<br/>
        /// timeline for a call that never connected.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ConversationTrace>> GetTracesAsResponseAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}