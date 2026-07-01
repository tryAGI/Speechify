#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Batch Delete Documents<br/>
        /// Delete multiple documents in a single transaction. All ids<br/>
        /// must belong to the supplied knowledge base; mismatches fail<br/>
        /// the request with 400 before any rows are touched. Capped at<br/>
        /// 200 ids per call.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BatchDeleteDocumentsAsync(
            string kbId,

            global::Speechify.BatchDeleteDocumentsRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Delete Documents<br/>
        /// Delete multiple documents in a single transaction. All ids<br/>
        /// must belong to the supplied knowledge base; mismatches fail<br/>
        /// the request with 400 before any rows are touched. Capped at<br/>
        /// 200 ids per call.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> BatchDeleteDocumentsAsResponseAsync(
            string kbId,

            global::Speechify.BatchDeleteDocumentsRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Delete Documents<br/>
        /// Delete multiple documents in a single transaction. All ids<br/>
        /// must belong to the supplied knowledge base; mismatches fail<br/>
        /// the request with 400 before any rows are touched. Capped at<br/>
        /// 200 ids per call.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> BatchDeleteDocumentsAsync(
            string kbId,
            global::System.Collections.Generic.IList<string> ids,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}