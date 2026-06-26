#nullable enable

namespace Speechify
{
    public partial interface ISubpackageCredentialsClient
    {
        /// <summary>
        /// List Credentials<br/>
        /// List every active credential in the caller's workspace, newest<br/>
        /// first. The vault is write-only: each `config` is the masked<br/>
        /// `CredentialConfigView` (non-secret fields plus `*_set` markers) —<br/>
        /// secret values are never returned. Soft-deleted credentials are<br/>
        /// omitted.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListCredentialsResponse> ListAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Credentials<br/>
        /// List every active credential in the caller's workspace, newest<br/>
        /// first. The vault is write-only: each `config` is the masked<br/>
        /// `CredentialConfigView` (non-secret fields plus `*_set` markers) —<br/>
        /// secret values are never returned. Soft-deleted credentials are<br/>
        /// omitted.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListCredentialsResponse>> ListAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}