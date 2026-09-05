#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Attach Contact Identifier<br/>
        /// Assert that a typed identifier denotes this person - the mechanism by<br/>
        /// which a phone number becomes linked to the application user it belongs<br/>
        /// to, so a call from that number resolves to everything the agent<br/>
        /// already knows.<br/>
        /// The server stamps `asserted_by: api` and `verified_at` because the<br/>
        /// request authenticated: your backend identified the end user before<br/>
        /// telling us. Neither can be supplied by the client.<br/>
        /// Attaching an identifier another contact already holds is refused with<br/>
        /// `409 contact_identifier_conflict` naming the holder - never a silent<br/>
        /// re-point, because that would be a merge nobody asked for, and a wrong<br/>
        /// merge discloses one person's facts to another. Re-attaching an<br/>
        /// identifier this same contact already holds succeeds unchanged.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ContactIdentifier> AttachIdentifierAsync(
            string contactId,

            global::Speechify.AttachContactIdentifierRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Contact Identifier<br/>
        /// Assert that a typed identifier denotes this person - the mechanism by<br/>
        /// which a phone number becomes linked to the application user it belongs<br/>
        /// to, so a call from that number resolves to everything the agent<br/>
        /// already knows.<br/>
        /// The server stamps `asserted_by: api` and `verified_at` because the<br/>
        /// request authenticated: your backend identified the end user before<br/>
        /// telling us. Neither can be supplied by the client.<br/>
        /// Attaching an identifier another contact already holds is refused with<br/>
        /// `409 contact_identifier_conflict` naming the holder - never a silent<br/>
        /// re-point, because that would be a merge nobody asked for, and a wrong<br/>
        /// merge discloses one person's facts to another. Re-attaching an<br/>
        /// identifier this same contact already holds succeeds unchanged.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ContactIdentifier>> AttachIdentifierAsResponseAsync(
            string contactId,

            global::Speechify.AttachContactIdentifierRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach Contact Identifier<br/>
        /// Assert that a typed identifier denotes this person - the mechanism by<br/>
        /// which a phone number becomes linked to the application user it belongs<br/>
        /// to, so a call from that number resolves to everything the agent<br/>
        /// already knows.<br/>
        /// The server stamps `asserted_by: api` and `verified_at` because the<br/>
        /// request authenticated: your backend identified the end user before<br/>
        /// telling us. Neither can be supplied by the client.<br/>
        /// Attaching an identifier another contact already holds is refused with<br/>
        /// `409 contact_identifier_conflict` naming the holder - never a silent<br/>
        /// re-point, because that would be a merge nobody asked for, and a wrong<br/>
        /// merge discloses one person's facts to another. Re-attaching an<br/>
        /// identifier this same contact already holds succeeds unchanged.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="kind">
        /// The namespace this value lives in.
        /// </param>
        /// <param name="value">
        /// The handle - an application user id, an E.164 number, an email address.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ContactIdentifier> AttachIdentifierAsync(
            string contactId,
            global::Speechify.AttachContactIdentifierRequestKind kind,
            string value,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}