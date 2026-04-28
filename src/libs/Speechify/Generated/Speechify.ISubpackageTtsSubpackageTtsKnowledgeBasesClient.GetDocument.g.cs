#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsKnowledgeBasesClient
    {
        /// <summary>
        /// Get Document<br/>
        /// Retrieve a document by ID.
        /// </summary>
        /// <param name="docId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsKnowledgeBaseDocument> GetDocumentAsync(
            string docId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}