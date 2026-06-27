#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// List Refresh History<br/>
        /// List auto-refresh attempts for a document, newest first.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page. Default<br/>
        /// page size is 50 and max is 200. Walk pages while `has_more` is<br/>
        /// true.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListRefreshHistoryResponse> ListRefreshHistoryAsync(
            string kbId,
            string documentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Refresh History<br/>
        /// List auto-refresh attempts for a document, newest first.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page. Default<br/>
        /// page size is 50 and max is 200. Walk pages while `has_more` is<br/>
        /// true.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListRefreshHistoryResponse>> ListRefreshHistoryAsResponseAsync(
            string kbId,
            string documentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}