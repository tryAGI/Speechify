#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsKnowledgeBasesClient
    {
        /// <summary>
        /// Delete<br/>
        /// Soft-delete a knowledge base. Documents and chunks are cascaded.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}