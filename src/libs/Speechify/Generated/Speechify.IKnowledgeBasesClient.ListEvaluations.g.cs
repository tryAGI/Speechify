#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// List Knowledge Base Evaluations<br/>
        /// List evaluations of a knowledge base, newest first. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. Default page size is 50 and<br/>
        /// max is 200. Walk pages while `has_more` is true.
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
        global::System.Threading.Tasks.Task<global::Speechify.ListKnowledgeBaseEvaluationsResponse> ListEvaluationsAsync(
            string kbId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Knowledge Base Evaluations<br/>
        /// List evaluations of a knowledge base, newest first. Cursor-paginated:<br/>
        /// omit `cursor` to fetch the first page. Default page size is 50 and<br/>
        /// max is 200. Walk pages while `has_more` is true.
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
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListKnowledgeBaseEvaluationsResponse>> ListEvaluationsAsResponseAsync(
            string kbId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}