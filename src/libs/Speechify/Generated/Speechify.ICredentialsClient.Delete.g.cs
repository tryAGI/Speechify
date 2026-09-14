#nullable enable

namespace Speechify
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Delete Credential<br/>
        /// Soft-delete a credential. Refused with `409 credential_in_use` while<br/>
        /// any tool, agent or channel still references it; the response `used_by`<br/>
        /// lists exactly what to detach first. Once unreferenced, the row is<br/>
        /// soft-deleted (a future GC job hard-deletes orphaned rows).
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string credentialId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Credential<br/>
        /// Soft-delete a credential. Refused with `409 credential_in_use` while<br/>
        /// any tool, agent or channel still references it; the response `used_by`<br/>
        /// lists exactly what to detach first. Once unreferenced, the row is<br/>
        /// soft-deleted (a future GC job hard-deletes orphaned rows).
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DeleteAsResponseAsync(
            string credentialId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}