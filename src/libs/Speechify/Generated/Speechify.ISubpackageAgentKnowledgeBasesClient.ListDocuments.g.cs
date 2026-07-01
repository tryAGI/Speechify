#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// List Knowledge Base Documents<br/>
        /// List documents ingested into a knowledge base. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. Default page size is 50<br/>
        /// and max is 200. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="folderId"></param>
        /// <param name="q"></param>
        /// <param name="sourceKind"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListKnowledgeBaseDocumentsResponse> ListDocumentsAsync(
            string kbId,
            string? folderId = default,
            string? q = default,
            string? sourceKind = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Knowledge Base Documents<br/>
        /// List documents ingested into a knowledge base. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. Default page size is 50<br/>
        /// and max is 200. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="folderId"></param>
        /// <param name="q"></param>
        /// <param name="sourceKind"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListKnowledgeBaseDocumentsResponse>> ListDocumentsAsResponseAsync(
            string kbId,
            string? folderId = default,
            string? q = default,
            string? sourceKind = default,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}