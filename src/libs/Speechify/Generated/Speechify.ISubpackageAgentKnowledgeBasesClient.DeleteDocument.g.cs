#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Delete Knowledge Base Document<br/>
        /// Delete a document and all its chunks.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteDocumentAsync(
            string kbId,
            string documentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Knowledge Base Document<br/>
        /// Delete a document and all its chunks.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="documentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteDocumentAsResponseAsync(
            string kbId,
            string documentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}