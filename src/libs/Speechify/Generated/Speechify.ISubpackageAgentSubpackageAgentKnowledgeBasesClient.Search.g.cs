#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Search Knowledge Bases<br/>
        /// Semantic search across a caller-owned list of knowledge bases.<br/>
        /// Returns ranked chunks with source filename and a cosine-similarity<br/>
        /// score. Limited to 50 results per request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.SearchKnowledgeBasesResponse> SearchAsync(

            global::Speechify.SearchKnowledgeBasesRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Knowledge Bases<br/>
        /// Semantic search across a caller-owned list of knowledge bases.<br/>
        /// Returns ranked chunks with source filename and a cosine-similarity<br/>
        /// score. Limited to 50 results per request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.SearchKnowledgeBasesResponse>> SearchAsResponseAsync(

            global::Speechify.SearchKnowledgeBasesRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Knowledge Bases<br/>
        /// Semantic search across a caller-owned list of knowledge bases.<br/>
        /// Returns ranked chunks with source filename and a cosine-similarity<br/>
        /// score. Limited to 50 results per request.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="query">
        /// Natural-language search query.
        /// </param>
        /// <param name="kbIds">
        /// Knowledge bases to search across. Results scoped to caller-owned entries; unknown IDs are silently ignored.
        /// </param>
        /// <param name="limit">
        /// Max hits to return (default 5, capped at 50).<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.SearchKnowledgeBasesResponse> SearchAsync(
            string query,
            global::System.Collections.Generic.IList<string> kbIds,
            string? speechifyVersion = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}