#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAgentsClient
    {
        /// <summary>
        /// Move Test<br/>
        /// Move a test into a folder. Pass `folder_id: null` for root.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task MoveTestAsync(
            string id,

            global::Speechify.TtsMoveAgentTestRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Test<br/>
        /// Move a test into a folder. Pass `folder_id: null` for root.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="folderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task MoveTestAsync(
            string id,
            string? folderId = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}