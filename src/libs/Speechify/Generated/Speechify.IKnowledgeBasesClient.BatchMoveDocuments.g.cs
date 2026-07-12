#nullable enable

namespace Speechify
{
    public partial interface IKnowledgeBasesClient
    {
        /// <summary>
        /// Batch Move Documents<br/>
        /// Move multiple documents into a folder in a single transaction.<br/>
        /// Pass `folder_id: null` to move every doc to root. Capped at<br/>
        /// 200 ids per call. Returns the moved documents.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.BatchMoveDocumentsResponse> BatchMoveDocumentsAsync(
            string kbId,

            global::Speechify.BatchMoveDocumentsRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Move Documents<br/>
        /// Move multiple documents into a folder in a single transaction.<br/>
        /// Pass `folder_id: null` to move every doc to root. Capped at<br/>
        /// 200 ids per call. Returns the moved documents.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.BatchMoveDocumentsResponse>> BatchMoveDocumentsAsResponseAsync(
            string kbId,

            global::Speechify.BatchMoveDocumentsRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Move Documents<br/>
        /// Move multiple documents into a folder in a single transaction.<br/>
        /// Pass `folder_id: null` to move every doc to root. Capped at<br/>
        /// 200 ids per call. Returns the moved documents.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="ids"></param>
        /// <param name="folderId">
        /// Destination folder. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null moves every<br/>
        /// document to the knowledge base root.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.BatchMoveDocumentsResponse> BatchMoveDocumentsAsync(
            string kbId,
            global::System.Collections.Generic.IList<string> ids,
            string? speechifyVersion = default,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}