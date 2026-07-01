#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentAdminClient
    {
        /// <summary>
        /// Mint shadow-call token<br/>
        /// Mint a listen-only realtime access token so an authorized observer<br/>
        /// can join an ongoing voice-agent conversation as a hidden<br/>
        /// participant. Any `member`, `admin`, or `owner` of the workspace<br/>
        /// the conversation belongs to may listen in — it is read-only<br/>
        /// observation. The token cannot publish audio or data; the observer<br/>
        /// is invisible to the caller and the agent. Speechify support<br/>
        /// engineers reach this endpoint the same way as any other observer<br/>
        /// — by being granted a role on the customer's workspace (typically<br/>
        /// under an NDA-backed support arrangement).
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ShadowConversationResponse> ShadowTokenAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mint shadow-call token<br/>
        /// Mint a listen-only realtime access token so an authorized observer<br/>
        /// can join an ongoing voice-agent conversation as a hidden<br/>
        /// participant. Any `member`, `admin`, or `owner` of the workspace<br/>
        /// the conversation belongs to may listen in — it is read-only<br/>
        /// observation. The token cannot publish audio or data; the observer<br/>
        /// is invisible to the caller and the agent. Speechify support<br/>
        /// engineers reach this endpoint the same way as any other observer<br/>
        /// — by being granted a role on the customer's workspace (typically<br/>
        /// under an NDA-backed support arrangement).
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ShadowConversationResponse>> ShadowTokenAsResponseAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}