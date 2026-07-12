#nullable enable

namespace Speechify
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Force-end conversation<br/>
        /// Force-terminate an ongoing conversation. Idempotent: a<br/>
        /// conversation that has already ended returns 204 the same as a<br/>
        /// successful first-time termination. Requires an `owner` or `admin`<br/>
        /// of the workspace — the same gate as take-over.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ForceEndAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Force-end conversation<br/>
        /// Force-terminate an ongoing conversation. Idempotent: a<br/>
        /// conversation that has already ended returns 204 the same as a<br/>
        /// successful first-time termination. Requires an `owner` or `admin`<br/>
        /// of the workspace — the same gate as take-over.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> ForceEndAsResponseAsync(
            string conversationId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}