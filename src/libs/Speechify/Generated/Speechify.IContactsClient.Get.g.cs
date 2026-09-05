#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Get Contact<br/>
        /// Fetch one contact by id, scoped to the caller's workspace, with its<br/>
        /// live identifiers. Returns 404 for missing, merged-away, or<br/>
        /// foreign-workspace contacts - contact existence is never leaked across<br/>
        /// workspaces.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Contact> GetAsync(
            string contactId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Contact<br/>
        /// Fetch one contact by id, scoped to the caller's workspace, with its<br/>
        /// live identifiers. Returns 404 for missing, merged-away, or<br/>
        /// foreign-workspace contacts - contact existence is never leaked across<br/>
        /// workspaces.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Contact>> GetAsResponseAsync(
            string contactId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}