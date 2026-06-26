#nullable enable

namespace Speechify
{
    public partial interface ISubpackageCredentialsClient
    {
        /// <summary>
        /// Get Credential<br/>
        /// Fetch one credential by id, scoped to the caller's workspace.<br/>
        /// `config` is the masked `CredentialConfigView` — secret values are<br/>
        /// never returned. Returns 404 for missing, soft-deleted, or<br/>
        /// foreign-workspace credentials — credential existence is never<br/>
        /// leaked across workspaces.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Credential> GetAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Credential<br/>
        /// Fetch one credential by id, scoped to the caller's workspace.<br/>
        /// `config` is the masked `CredentialConfigView` — secret values are<br/>
        /// never returned. Returns 404 for missing, soft-deleted, or<br/>
        /// foreign-workspace credentials — credential existence is never<br/>
        /// leaked across workspaces.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Credential>> GetAsResponseAsync(
            string id,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}