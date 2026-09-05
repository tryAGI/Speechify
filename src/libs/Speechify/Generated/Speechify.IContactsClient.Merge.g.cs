#nullable enable

namespace Speechify
{
    public partial interface IContactsClient
    {
        /// <summary>
        /// Merge Contacts<br/>
        /// Fold one contact into another: every identifier, caller projection,<br/>
        /// conversation and memory that pointed at `from_contact_id` is<br/>
        /// re-pointed at the contact in the URL, the survivor's first/last-seen<br/>
        /// window widens to span both, and the merged-away contact is<br/>
        /// tombstoned.<br/>
        /// This is the deliberate counterpart to the refusal on identifier<br/>
        /// attach. Merging is destructive and one-way, so it is never inferred -<br/>
        /// the customer is the only party who knows two records are one person.<br/>
        /// All-or-nothing, and safe to retry: a repeat call finds nothing left<br/>
        /// pointing at the merged-away contact and returns the same survivor with<br/>
        /// a zeroed tally. Send an `Idempotency-Key` header to have a retry<br/>
        /// replay the first response verbatim.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.MergeContactsResponse> MergeAsync(
            string contactId,

            global::Speechify.MergeContactsRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge Contacts<br/>
        /// Fold one contact into another: every identifier, caller projection,<br/>
        /// conversation and memory that pointed at `from_contact_id` is<br/>
        /// re-pointed at the contact in the URL, the survivor's first/last-seen<br/>
        /// window widens to span both, and the merged-away contact is<br/>
        /// tombstoned.<br/>
        /// This is the deliberate counterpart to the refusal on identifier<br/>
        /// attach. Merging is destructive and one-way, so it is never inferred -<br/>
        /// the customer is the only party who knows two records are one person.<br/>
        /// All-or-nothing, and safe to retry: a repeat call finds nothing left<br/>
        /// pointing at the merged-away contact and returns the same survivor with<br/>
        /// a zeroed tally. Send an `Idempotency-Key` header to have a retry<br/>
        /// replay the first response verbatim.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.MergeContactsResponse>> MergeAsResponseAsync(
            string contactId,

            global::Speechify.MergeContactsRequest request,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge Contacts<br/>
        /// Fold one contact into another: every identifier, caller projection,<br/>
        /// conversation and memory that pointed at `from_contact_id` is<br/>
        /// re-pointed at the contact in the URL, the survivor's first/last-seen<br/>
        /// window widens to span both, and the merged-away contact is<br/>
        /// tombstoned.<br/>
        /// This is the deliberate counterpart to the refusal on identifier<br/>
        /// attach. Merging is destructive and one-way, so it is never inferred -<br/>
        /// the customer is the only party who knows two records are one person.<br/>
        /// All-or-nothing, and safe to retry: a repeat call finds nothing left<br/>
        /// pointing at the merged-away contact and returns the same survivor with<br/>
        /// a zeroed tally. Send an `Idempotency-Key` header to have a retry<br/>
        /// replay the first response verbatim.
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="fromContactId">
        /// The contact to fold into the one in the URL. It is tombstoned, and<br/>
        /// everything pointing at it is re-pointed at the survivor. Must<br/>
        /// differ from the contact in the URL.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.MergeContactsResponse> MergeAsync(
            string contactId,
            string fromContactId,
            string? speechifyVersion = default,
            string? idempotencyKey = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}