#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentAdminClient
    {
        /// <summary>
        /// Take over conversation<br/>
        /// Take over an active voice-agent call. Returns short-lived<br/>
        /// credentials a real-time client uses to connect an authorized<br/>
        /// operator into the live call. The operator speaks to the caller<br/>
        /// directly while the AI agent stands down and stays silent, then<br/>
        /// resumes once the operator hands the call back. The requester must<br/>
        /// be an `owner` or `admin` of the workspace the call belongs to.<br/>
        /// Only an active call can be taken over; a pending or completed call<br/>
        /// returns 409.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TakeOverConversationResponse> TakeOverAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Take over conversation<br/>
        /// Take over an active voice-agent call. Returns short-lived<br/>
        /// credentials a real-time client uses to connect an authorized<br/>
        /// operator into the live call. The operator speaks to the caller<br/>
        /// directly while the AI agent stands down and stays silent, then<br/>
        /// resumes once the operator hands the call back. The requester must<br/>
        /// be an `owner` or `admin` of the workspace the call belongs to.<br/>
        /// Only an active call can be taken over; a pending or completed call<br/>
        /// returns 409.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TakeOverConversationResponse>> TakeOverAsResponseAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}