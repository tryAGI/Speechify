#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsIvrMemoryClient
    {
        /// <summary>
        /// Invalidate IVR Menu<br/>
        /// Soft-invalidate the named menu. Future lookups skip it; the<br/>
        /// next discovery for the same fingerprint replaces it (clearing<br/>
        /// the invalidation). Idempotent: re-invalidating<br/>
        /// an already-invalidated row returns 404.<br/>
        /// Reason is optional and is captured in structured logs for<br/>
        /// operator triage. A future audit table may persist it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InvalidateAsync(
            string id,

            global::Speechify.TtsInvalidateIVRMenuRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invalidate IVR Menu<br/>
        /// Soft-invalidate the named menu. Future lookups skip it; the<br/>
        /// next discovery for the same fingerprint replaces it (clearing<br/>
        /// the invalidation). Idempotent: re-invalidating<br/>
        /// an already-invalidated row returns 404.<br/>
        /// Reason is optional and is captured in structured logs for<br/>
        /// operator triage. A future audit table may persist it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> InvalidateAsResponseAsync(
            string id,

            global::Speechify.TtsInvalidateIVRMenuRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invalidate IVR Menu<br/>
        /// Soft-invalidate the named menu. Future lookups skip it; the<br/>
        /// next discovery for the same fingerprint replaces it (clearing<br/>
        /// the invalidation). Idempotent: re-invalidating<br/>
        /// an already-invalidated row returns 404.<br/>
        /// Reason is optional and is captured in structured logs for<br/>
        /// operator triage. A future audit table may persist it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reason">
        /// Operator-debug cause string. Bounded to 256 chars.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> InvalidateAsync(
            string id,
            string? reason = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}