#nullable enable

namespace Speechify
{
    public partial interface ISubpackageCredentialsClient
    {
        /// <summary>
        /// List Credentials<br/>
        /// List every active credential in the caller's workspace, newest<br/>
        /// first. Each credential's `config` is returned decrypted — the<br/>
        /// config IS the user-supplied secret, and the console relies on<br/>
        /// reading it back to pre-fill the edit form. Soft-deleted<br/>
        /// credentials are omitted.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListCredentialsResponse> ListAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Credentials<br/>
        /// List every active credential in the caller's workspace, newest<br/>
        /// first. Each credential's `config` is returned decrypted — the<br/>
        /// config IS the user-supplied secret, and the console relies on<br/>
        /// reading it back to pre-fill the edit form. Soft-deleted<br/>
        /// credentials are omitted.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListCredentialsResponse>> ListAsResponseAsync(
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}