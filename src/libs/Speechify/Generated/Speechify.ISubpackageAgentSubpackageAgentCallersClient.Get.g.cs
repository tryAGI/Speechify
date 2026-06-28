#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentCallersClient
    {
        /// <summary>
        /// Get Caller<br/>
        /// Fetch a single caller by id. Returns 404 for soft-deleted or<br/>
        /// foreign-tenant rows — GDPR-purged callers appear as "not found"<br/>
        /// to the API.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Caller> GetAsync(
            string callerId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Caller<br/>
        /// Fetch a single caller by id. Returns 404 for soft-deleted or<br/>
        /// foreign-tenant rows — GDPR-purged callers appear as "not found"<br/>
        /// to the API.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Caller>> GetAsResponseAsync(
            string callerId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}