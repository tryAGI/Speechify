#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// List Evaluation Cases<br/>
        /// List the labelled questions of a knowledge base, newest first.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page. Default<br/>
        /// page size is 50 and max is 200. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListKnowledgeBaseEvalCasesResponse> ListEvalCasesAsync(
            string kbId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Evaluation Cases<br/>
        /// List the labelled questions of a knowledge base, newest first.<br/>
        /// Cursor-paginated: omit `cursor` to fetch the first page. Default<br/>
        /// page size is 50 and max is 200. Walk pages while `has_more` is true.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListKnowledgeBaseEvalCasesResponse>> ListEvalCasesAsResponseAsync(
            string kbId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}