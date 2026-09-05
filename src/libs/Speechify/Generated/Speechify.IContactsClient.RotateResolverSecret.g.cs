#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Rotate Contact Resolver Secret<br/>
        /// Mint a new signing secret for the workspace's resolver and return it<br/>
        /// once. The previous secret stops signing immediately, so deploy the new<br/>
        /// one to your verifier before rotating - a request your endpoint cannot<br/>
        /// verify should be rejected, and a rejected resolver call degrades to a<br/>
        /// call with no contact.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ContactResolver> RotateResolverSecretAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate Contact Resolver Secret<br/>
        /// Mint a new signing secret for the workspace's resolver and return it<br/>
        /// once. The previous secret stops signing immediately, so deploy the new<br/>
        /// one to your verifier before rotating - a request your endpoint cannot<br/>
        /// verify should be rejected, and a rejected resolver call degrades to a<br/>
        /// call with no contact.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ContactResolver>> RotateResolverSecretAsResponseAsync(
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}