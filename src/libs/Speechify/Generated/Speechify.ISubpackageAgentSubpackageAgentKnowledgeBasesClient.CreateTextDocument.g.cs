#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Create Text Document<br/>
        /// Create a document from inline pasted text. Content is chunked,<br/>
        /// embedded, and indexed synchronously.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocument> CreateTextDocumentAsync(
            string kbId,

            global::Speechify.CreateTextDocumentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Text Document<br/>
        /// Create a document from inline pasted text. Content is chunked,<br/>
        /// embedded, and indexed synchronously.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseDocument>> CreateTextDocumentAsResponseAsync(
            string kbId,

            global::Speechify.CreateTextDocumentRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Text Document<br/>
        /// Create a document from inline pasted text. Content is chunked,<br/>
        /// embedded, and indexed synchronously.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="folderId">
        /// Folder to drop the document into. Prefixed wire identifier<br/>
        /// (`kfolder_&lt;26 char Crockford base32&gt;`); null/omitted = root.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocument> CreateTextDocumentAsync(
            string kbId,
            string name,
            string content,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}