#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsKnowledgeBasesClient
    {
        /// <summary>
        /// Search<br/>
        /// Semantic search across a caller-owned list of knowledge bases.<br/>
        /// Returns ranked chunks with source filename and a cosine-similarity<br/>
        /// score. Limited to 50 results per request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsSearchKnowledgeBasesResponse> SearchAsync(

            global::Speechify.TtsSearchKnowledgeBasesRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search<br/>
        /// Semantic search across a caller-owned list of knowledge bases.<br/>
        /// Returns ranked chunks with source filename and a cosine-similarity<br/>
        /// score. Limited to 50 results per request.
        /// </summary>
        /// <param name="query">
        /// Natural-language search query.
        /// </param>
        /// <param name="kbIds">
        /// Knowledge bases to search across. Results scoped to caller-owned entries; unknown IDs are silently ignored.
        /// </param>
        /// <param name="topK">
        /// Max hits to return (default 5, capped at 50).<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsSearchKnowledgeBasesResponse> SearchAsync(
            string query,
            global::System.Collections.Generic.IList<string> kbIds,
            int? topK = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}