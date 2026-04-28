#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsMemoriesClient
    {
        /// <summary>
        /// Delete<br/>
        /// Soft-delete one memory row.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string memoryId,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}