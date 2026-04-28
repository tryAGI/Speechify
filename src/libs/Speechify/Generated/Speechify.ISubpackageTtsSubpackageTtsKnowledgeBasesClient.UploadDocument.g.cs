#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsKnowledgeBasesClient
    {
        /// <summary>
        /// Upload Document<br/>
        /// Upload a document (PDF, plain text, markdown, or HTML) to a<br/>
        /// knowledge base. The document is extracted, chunked, embedded, and<br/>
        /// indexed synchronously; expect a few seconds per MB of input.<br/>
        /// Maximum 10 MB per upload.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsKnowledgeBaseDocument> UploadDocumentAsync(
            string id,

            global::Speechify.UploadDocumentRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Document<br/>
        /// Upload a document (PDF, plain text, markdown, or HTML) to a<br/>
        /// knowledge base. The document is extracted, chunked, embedded, and<br/>
        /// indexed synchronously; expect a few seconds per MB of input.<br/>
        /// Maximum 10 MB per upload.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsKnowledgeBaseDocument> UploadDocumentAsync(
            string id,
            byte[] file,
            string filename,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}