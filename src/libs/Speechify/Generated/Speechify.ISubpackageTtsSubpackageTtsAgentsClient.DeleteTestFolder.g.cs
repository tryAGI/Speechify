#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Delete Test Folder<br/>
        /// Soft-delete a folder. Child tests drop back to root.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTestFolderAsync(
            string id,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}