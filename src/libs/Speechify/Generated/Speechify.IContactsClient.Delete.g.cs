#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Delete Contact (GDPR purge)<br/>
        /// Erase a person: the contact, every identifier that resolves to them,<br/>
        /// every per-agent caller record of them, and every memory ever extracted<br/>
        /// about them - on every agent and every channel, in one call.<br/>
        /// This is the right-to-be-forgotten path. `DELETE<br/>
        /// /v1/agents/callers/{caller_id}` erases one agent's record of someone<br/>
        /// and has to be fired once per agent and once per channel; this reaches<br/>
        /// all of them, because "everything about this person" is a question the<br/>
        /// contact model can answer.<br/>
        /// Conversations survive - they are the billing and forensic record - but<br/>
        /// the facts extracted from them, and the copies of those facts frozen<br/>
        /// into past prompts, do not.<br/>
        /// The identifiers are tombstoned as part of the purge, which is what<br/>
        /// stops the person's phone number ever resolving again: a later merge<br/>
        /// naming the purged contact moves rows that are already dead rather than<br/>
        /// bringing a link back to life.<br/>
        /// Idempotent: re-deleting an already-purged contact returns all zeros<br/>
        /// rather than a 404, so a client that never saw the first response can<br/>
        /// safely repeat it.<br/>
        /// Returns `200` with the row counts rather than a bodiless `204`: the<br/>
        /// counts are the audit evidence a privacy operator needs, and re-reading<br/>
        /// a corpus you just asked us to erase is not a way to obtain them. Same<br/>
        /// deliberate exception `DELETE /v1/agents/callers/{caller_id}` takes.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.DeleteContactResponse> DeleteAsync(
            string contactId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Contact (GDPR purge)<br/>
        /// Erase a person: the contact, every identifier that resolves to them,<br/>
        /// every per-agent caller record of them, and every memory ever extracted<br/>
        /// about them - on every agent and every channel, in one call.<br/>
        /// This is the right-to-be-forgotten path. `DELETE<br/>
        /// /v1/agents/callers/{caller_id}` erases one agent's record of someone<br/>
        /// and has to be fired once per agent and once per channel; this reaches<br/>
        /// all of them, because "everything about this person" is a question the<br/>
        /// contact model can answer.<br/>
        /// Conversations survive - they are the billing and forensic record - but<br/>
        /// the facts extracted from them, and the copies of those facts frozen<br/>
        /// into past prompts, do not.<br/>
        /// The identifiers are tombstoned as part of the purge, which is what<br/>
        /// stops the person's phone number ever resolving again: a later merge<br/>
        /// naming the purged contact moves rows that are already dead rather than<br/>
        /// bringing a link back to life.<br/>
        /// Idempotent: re-deleting an already-purged contact returns all zeros<br/>
        /// rather than a 404, so a client that never saw the first response can<br/>
        /// safely repeat it.<br/>
        /// Returns `200` with the row counts rather than a bodiless `204`: the<br/>
        /// counts are the audit evidence a privacy operator needs, and re-reading<br/>
        /// a corpus you just asked us to erase is not a way to obtain them. Same<br/>
        /// deliberate exception `DELETE /v1/agents/callers/{caller_id}` takes.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.DeleteContactResponse>> DeleteAsResponseAsync(
            string contactId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}