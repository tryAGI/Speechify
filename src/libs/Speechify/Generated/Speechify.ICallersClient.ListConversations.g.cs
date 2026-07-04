#nullable enable

namespace Speechify
{
    public partial interface ICallersClient
    {
        /// <summary>
        /// List Conversations For Caller<br/>
        /// List one page of conversations belonging to the caller, newest<br/>
        /// started first. Same wire envelope as the workspace-wide<br/>
        /// `GET /v1/agents/conversations`, narrowed to one caller.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListCallerConversationsResponse> ListConversationsAsync(
            string callerId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Conversations For Caller<br/>
        /// List one page of conversations belonging to the caller, newest<br/>
        /// started first. Same wire envelope as the workspace-wide<br/>
        /// `GET /v1/agents/conversations`, narrowed to one caller.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListCallerConversationsResponse>> ListConversationsAsResponseAsync(
            string callerId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}