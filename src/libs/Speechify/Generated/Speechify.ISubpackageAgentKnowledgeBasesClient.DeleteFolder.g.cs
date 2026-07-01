#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentKnowledgeBasesClient
    {
        /// <summary>
        /// Delete Folder<br/>
        /// Delete a folder. By default a folder that still contains<br/>
        /// documents or sub-folders is refused with `409` - pass<br/>
        /// `?force=true` to delete it anyway, which recursively moves its<br/>
        /// documents to root and removes its sub-folders.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="folderId"></param>
        /// <param name="force"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteFolderAsync(
            string kbId,
            string folderId,
            bool? force = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Folder<br/>
        /// Delete a folder. By default a folder that still contains<br/>
        /// documents or sub-folders is refused with `409` - pass<br/>
        /// `?force=true` to delete it anyway, which recursively moves its<br/>
        /// documents to root and removes its sub-folders.
        /// </summary>
        /// <param name="kbId"></param>
        /// <param name="folderId"></param>
        /// <param name="force"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteFolderAsResponseAsync(
            string kbId,
            string folderId,
            bool? force = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}