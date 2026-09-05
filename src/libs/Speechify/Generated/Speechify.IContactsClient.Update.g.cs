#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Update Contact<br/>
        /// Rename a contact or replace its metadata. Omitted fields are<br/>
        /// unchanged; an empty `display_name` clears the column; `metadata`<br/>
        /// replaces the stored blob in full.<br/>
        /// Identifiers are NOT editable here - each one is an assertion of record<br/>
        /// with its own provenance, so they are attached and detached through<br/>
        /// their own sub-resource.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Contact> UpdateAsync(
            string contactId,

            global::Speechify.UpdateContactRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Contact<br/>
        /// Rename a contact or replace its metadata. Omitted fields are<br/>
        /// unchanged; an empty `display_name` clears the column; `metadata`<br/>
        /// replaces the stored blob in full.<br/>
        /// Identifiers are NOT editable here - each one is an assertion of record<br/>
        /// with its own provenance, so they are attached and detached through<br/>
        /// their own sub-resource.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Contact>> UpdateAsResponseAsync(
            string contactId,

            global::Speechify.UpdateContactRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Contact<br/>
        /// Rename a contact or replace its metadata. Omitted fields are<br/>
        /// unchanged; an empty `display_name` clears the column; `metadata`<br/>
        /// replaces the stored blob in full.<br/>
        /// Identifiers are NOT editable here - each one is an assertion of record<br/>
        /// with its own provenance, so they are attached and detached through<br/>
        /// their own sub-resource.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="displayName">
        /// Operator-editable display name. Empty string clears the column; an explicit `null` is rejected with a 400.
        /// </param>
        /// <param name="metadata">
        /// Replacement metadata JSONB. An explicit `null` is rejected with a 400.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Contact> UpdateAsync(
            string contactId,
            string? speechifyVersion = default,
            string? displayName = default,
            object? metadata = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}