#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Get Contact Resolver<br/>
        /// Read the workspace's contact-resolver configuration - the endpoint<br/>
        /// Speechify asks "who is on this call" at session start.<br/>
        /// The signing secret is never returned here. It is revealed once, by the<br/>
        /// call that mints it, and again by a rotation.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ContactResolver> GetResolverAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Contact Resolver<br/>
        /// Read the workspace's contact-resolver configuration - the endpoint<br/>
        /// Speechify asks "who is on this call" at session start.<br/>
        /// The signing secret is never returned here. It is revealed once, by the<br/>
        /// call that mints it, and again by a rotation.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ContactResolver>> GetResolverAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}