#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Detach Contact Identifier<br/>
        /// Reverse a link. A wrong link is a disclosure, so undoing one is a<br/>
        /// first-class operation rather than a support ticket: the identifier<br/>
        /// stops resolving to this contact immediately, and a future session on<br/>
        /// that channel mints a fresh contact instead.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="identifierId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DetachIdentifierAsync(
            string contactId,
            string identifierId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detach Contact Identifier<br/>
        /// Reverse a link. A wrong link is a disclosure, so undoing one is a<br/>
        /// first-class operation rather than a support ticket: the identifier<br/>
        /// stops resolving to this contact immediately, and a future session on<br/>
        /// that channel mints a fresh contact instead.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="identifierId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<string>> DetachIdentifierAsResponseAsync(
            string contactId,
            string identifierId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}