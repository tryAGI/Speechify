#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentAdminClient
    {
        /// <summary>
        /// Force-end conversation<br/>
        /// Force-terminate the LiveKit room for an ongoing conversation.<br/>
        /// Idempotent: rooms that LiveKit has already cleaned up return<br/>
        /// 204 the same as a successful first-time termination. Requires an<br/>
        /// `owner` or `admin` of the workspace — the same gate as take-over.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ForceEndAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Force-end conversation<br/>
        /// Force-terminate the LiveKit room for an ongoing conversation.<br/>
        /// Idempotent: rooms that LiveKit has already cleaned up return<br/>
        /// 204 the same as a successful first-time termination. Requires an<br/>
        /// `owner` or `admin` of the workspace — the same gate as take-over.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> ForceEndAsResponseAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}