#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentSipTrunksClient
    {
        /// <summary>
        /// List SIP Trunks<br/>
        /// List all SIP trunks in the caller's workspace. Cursor-paginated<br/>
        /// for uniformity with the other list endpoints: omit `cursor` for<br/>
        /// the first page; walk pages while `has_more` is true (default page<br/>
        /// size 50, max 200). In practice the workspace is capped at 20<br/>
        /// trunks, so every response fits in a single page.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListSIPTrunksResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List SIP Trunks<br/>
        /// List all SIP trunks in the caller's workspace. Cursor-paginated<br/>
        /// for uniformity with the other list endpoints: omit `cursor` for<br/>
        /// the first page; walk pages while `has_more` is true (default page<br/>
        /// size 50, max 200). In practice the workspace is capped at 20<br/>
        /// trunks, so every response fits in a single page.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListSIPTrunksResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}