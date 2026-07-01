#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentTestsClient
    {
        /// <summary>
        /// List Tests<br/>
        /// Workspace-wide list of tests across every agent the caller owns.<br/>
        /// Supports filters (agent, type, last-run status, folder), full-text<br/>
        /// search on name/description, and cursor pagination. Each row carries<br/>
        /// its newest run and attached agent IDs so the list renders without<br/>
        /// N+1 round-trips. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="verdict"></param>
        /// <param name="folderId"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="q"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListTestsResponse> ListAllTestsAsync(
            string? agentId = default,
            string? type = default,
            string? status = default,
            string? verdict = default,
            string? folderId = default,
            string? updatedAfter = default,
            string? q = default,
            int? limit = default,
            string? cursor = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tests<br/>
        /// Workspace-wide list of tests across every agent the caller owns.<br/>
        /// Supports filters (agent, type, last-run status, folder), full-text<br/>
        /// search on name/description, and cursor pagination. Each row carries<br/>
        /// its newest run and attached agent IDs so the list renders without<br/>
        /// N+1 round-trips. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="verdict"></param>
        /// <param name="folderId"></param>
        /// <param name="updatedAfter"></param>
        /// <param name="q"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListTestsResponse>> ListAllTestsAsResponseAsync(
            string? agentId = default,
            string? type = default,
            string? status = default,
            string? verdict = default,
            string? folderId = default,
            string? updatedAfter = default,
            string? q = default,
            int? limit = default,
            string? cursor = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}