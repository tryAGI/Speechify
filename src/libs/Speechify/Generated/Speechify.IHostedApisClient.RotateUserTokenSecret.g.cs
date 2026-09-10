#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// Rotate End-User Token Secret<br/>
        /// Mint the signing secret end-user tokens are verified against, replacing<br/>
        /// any previous one at once: every token signed with the old secret stops<br/>
        /// verifying. The plaintext is in this response and nowhere else; later<br/>
        /// reads show `user_token_secret_hint`. Your backend signs a JWT with it<br/>
        /// (HS256) carrying `sub` (the user, at most 256 characters) and `exp`<br/>
        /// (within 24 hours), and the consumer presents it as<br/>
        /// `Authorization: Bearer &lt;token&gt;`. Register `user_token_jwks_url`<br/>
        /// instead to verify with your own keys.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.HostedAPIUserTokenSecret> RotateUserTokenSecretAsync(
            string apiId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate End-User Token Secret<br/>
        /// Mint the signing secret end-user tokens are verified against, replacing<br/>
        /// any previous one at once: every token signed with the old secret stops<br/>
        /// verifying. The plaintext is in this response and nowhere else; later<br/>
        /// reads show `user_token_secret_hint`. Your backend signs a JWT with it<br/>
        /// (HS256) carrying `sub` (the user, at most 256 characters) and `exp`<br/>
        /// (within 24 hours), and the consumer presents it as<br/>
        /// `Authorization: Bearer &lt;token&gt;`. Register `user_token_jwks_url`<br/>
        /// instead to verify with your own keys.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.HostedAPIUserTokenSecret>> RotateUserTokenSecretAsResponseAsync(
            string apiId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}