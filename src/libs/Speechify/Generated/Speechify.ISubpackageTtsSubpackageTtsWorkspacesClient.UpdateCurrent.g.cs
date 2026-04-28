#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Update Current<br/>
        /// Rename the current workspace. Owner or admin only.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsTenant> UpdateCurrentAsync(

            global::Speechify.TtsUpdateWorkspaceRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Current<br/>
        /// Rename the current workspace. Owner or admin only.
        /// </summary>
        /// <param name="name">
        /// New display name. Required; must be 120 characters or fewer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsTenant> UpdateCurrentAsync(
            string name,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}