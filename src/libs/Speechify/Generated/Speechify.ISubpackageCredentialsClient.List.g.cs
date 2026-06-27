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
        /// omitted. Cursor-paginated: omit `cursor` for the first page; walk<br/>
        /// pages while `has_more` is true (default page size 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListCredentialsResponse> ListAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Credentials<br/>
        /// List every active credential in the caller's workspace, newest<br/>
        /// first. The vault is write-only: each `config` is the masked<br/>
        /// `CredentialConfigView` (non-secret fields plus `*_set` markers) —<br/>
        /// secret values are never returned. Soft-deleted credentials are<br/>
        /// omitted. Cursor-paginated: omit `cursor` for the first page; walk<br/>
        /// pages while `has_more` is true (default page size 50, max 200).
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListCredentialsResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}