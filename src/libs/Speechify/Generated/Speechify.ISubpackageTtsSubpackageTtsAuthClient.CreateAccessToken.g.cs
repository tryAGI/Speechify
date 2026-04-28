#nullable enable

namespace Speechify
{
    public partial interface ISubpackageTtsSubpackageTtsAuthClient
    {
        /// <summary>
        /// Create Access Token<br/>
        /// WARNING: This endpoint is deprecated. Create a new API token for the logged in user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAccessToken> CreateAccessTokenAsync(

            global::Speechify.TtsCreateAccessTokenRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Access Token<br/>
        /// WARNING: This endpoint is deprecated. Create a new API token for the logged in user.
        /// </summary>
        /// <param name="grantType">
        /// in: body
        /// </param>
        /// <param name="scope">
        /// The scope, or a space-delimited list of scopes the token is requested for<br/>
        /// in: body
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TtsAccessToken> CreateAccessTokenAsync(
            global::Speechify.TtsCreateAccessTokenRequestGrantType grantType = default,
            global::Speechify.TtsCreateAccessTokenRequestScope? scope = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}