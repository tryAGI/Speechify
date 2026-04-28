#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Create Test Folder<br/>
        /// Create a test folder. Max depth is 3.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTestFolder> CreateTestFolderAsync(

            global::Speechify.TtsCreateAgentTestFolderRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Test Folder<br/>
        /// Create a test folder. Max depth is 3.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parentFolderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAgentTestFolder> CreateTestFolderAsync(
            string name,
            string? parentFolderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}