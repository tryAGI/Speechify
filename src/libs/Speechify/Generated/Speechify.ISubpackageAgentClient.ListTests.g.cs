#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// List Agent Tests<br/>
        /// List all tests configured for the agent. Each entry includes the<br/>
        /// most recent run so a client can render pass/fail badges without<br/>
        /// an extra round-trip. Cursor-paginated: omit `cursor` for the first<br/>
        /// page; walk pages while `has_more` is true (default page size 50,<br/>
        /// max 200).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListTestsResponse> ListTestsAsync(
            string agentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Tests<br/>
        /// List all tests configured for the agent. Each entry includes the<br/>
        /// most recent run so a client can render pass/fail badges without<br/>
        /// an extra round-trip. Cursor-paginated: omit `cursor` for the first<br/>
        /// page; walk pages while `has_more` is true (default page size 50,<br/>
        /// max 200).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListTestsResponse>> ListTestsAsResponseAsync(
            string agentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}