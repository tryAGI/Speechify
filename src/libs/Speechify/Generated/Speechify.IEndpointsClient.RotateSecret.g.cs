#nullable enable

namespace Speechify
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// Rotate webhook endpoint secret<br/>
        /// Mint a new HMAC signing secret for the endpoint and return it in the<br/>
        /// response `secret` field (shown exactly once). The previous secret stops<br/>
        /// signing immediately, so accept both during your cutover window.
        /// </summary>
        /// <param name="webhookEndpointId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WebhookEndpoint> RotateSecretAsync(
            string webhookEndpointId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate webhook endpoint secret<br/>
        /// Mint a new HMAC signing secret for the endpoint and return it in the<br/>
        /// response `secret` field (shown exactly once). The previous secret stops<br/>
        /// signing immediately, so accept both during your cutover window.
        /// </summary>
        /// <param name="webhookEndpointId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WebhookEndpoint>> RotateSecretAsResponseAsync(
            string webhookEndpointId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}