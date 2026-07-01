#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentToolDefinitionsClient
    {
        /// <summary>
        /// Rotate Tool Webhook Secret<br/>
        /// Rotate the HMAC signing secret on a webhook tool. The tool id<br/>
        /// is preserved so attached agents keep working; only the secret<br/>
        /// rolls. The new plaintext is returned on `webhook_secret`<br/>
        /// exactly once — store it immediately, subsequent reads always<br/>
        /// return the masked placeholder. The previous secret is<br/>
        /// invalidated immediately on success.
        /// </summary>
        /// <param name="toolDefinitionId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Tool> RotateSecretAsync(
            string toolDefinitionId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Tool Webhook Secret<br/>
        /// Rotate the HMAC signing secret on a webhook tool. The tool id<br/>
        /// is preserved so attached agents keep working; only the secret<br/>
        /// rolls. The new plaintext is returned on `webhook_secret`<br/>
        /// exactly once — store it immediately, subsequent reads always<br/>
        /// return the masked placeholder. The previous secret is<br/>
        /// invalidated immediately on success.
        /// </summary>
        /// <param name="toolDefinitionId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Tool>> RotateSecretAsResponseAsync(
            string toolDefinitionId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}