#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsWorkspacesClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a new workspace with the authenticated user as owner.<br/>
        /// The caller must switch their active workspace client-side via<br/>
        /// the `X-Tenant-ID` header to act on the new tenant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsTenant> CreateAsync(

            global::Speechify.TtsCreateWorkspaceRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Create a new workspace with the authenticated user as owner.<br/>
        /// The caller must switch their active workspace client-side via<br/>
        /// the `X-Tenant-ID` header to act on the new tenant.
        /// </summary>
        /// <param name="name">
        /// Display name for the new workspace. Trimmed; must be 120 characters or fewer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsTenant> CreateAsync(
            string? name = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}