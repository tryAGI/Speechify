#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Upload Knowledge Base Document<br/>
        /// Upload a document (PDF, plain text, markdown, or HTML) to a<br/>
        /// knowledge base. The document is extracted, chunked, embedded, and<br/>
        /// indexed synchronously; expect a few seconds per MB of input.<br/>
        /// Maximum 10 MB per upload.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocument> UploadDocumentAsync(
            string kbId,

            global::Speechify.UploadDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Knowledge Base Document<br/>
        /// Upload a document (PDF, plain text, markdown, or HTML) to a<br/>
        /// knowledge base. The document is extracted, chunked, embedded, and<br/>
        /// indexed synchronously; expect a few seconds per MB of input.<br/>
        /// Maximum 10 MB per upload.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseDocument>> UploadDocumentAsResponseAsync(
            string kbId,

            global::Speechify.UploadDocumentRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Knowledge Base Document<br/>
        /// Upload a document (PDF, plain text, markdown, or HTML) to a<br/>
        /// knowledge base. The document is extracted, chunked, embedded, and<br/>
        /// indexed synchronously; expect a few seconds per MB of input.<br/>
        /// Maximum 10 MB per upload.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocument> UploadDocumentAsync(
            string kbId,
            byte[] file,
            string filename,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Knowledge Base Document<br/>
        /// Upload a document (PDF, plain text, markdown, or HTML) to a<br/>
        /// knowledge base. The document is extracted, chunked, embedded, and<br/>
        /// indexed synchronously; expect a few seconds per MB of input.<br/>
        /// Maximum 10 MB per upload.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.KnowledgeBaseDocument> UploadDocumentAsync(
            string kbId,
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Knowledge Base Document<br/>
        /// Upload a document (PDF, plain text, markdown, or HTML) to a<br/>
        /// knowledge base. The document is extracted, chunked, embedded, and<br/>
        /// indexed synchronously; expect a few seconds per MB of input.<br/>
        /// Maximum 10 MB per upload.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.KnowledgeBaseDocument>> UploadDocumentAsResponseAsync(
            string kbId,
            global::System.IO.Stream file,
            string filename,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}