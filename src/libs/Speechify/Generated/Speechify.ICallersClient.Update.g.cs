#nullable enable

namespace Speechify
{
    public partial interface ICallersClient
    {
        /// <summary>
        /// Update Caller<br/>
        /// Update the customer-editable fields on a caller. PATCH semantics:<br/>
        /// omitted fields are unchanged, present fields overwrite. To clear<br/>
        /// a nullable field (`display_name`, `external_ref`) pass an empty<br/>
        /// string. `metadata` REPLACES the existing JSONB blob when supplied.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Caller> UpdateAsync(
            string callerId,

            global::Speechify.UpdateCallerRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Caller<br/>
        /// Update the customer-editable fields on a caller. PATCH semantics:<br/>
        /// omitted fields are unchanged, present fields overwrite. To clear<br/>
        /// a nullable field (`display_name`, `external_ref`) pass an empty<br/>
        /// string. `metadata` REPLACES the existing JSONB blob when supplied.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.Caller>> UpdateAsResponseAsync(
            string callerId,

            global::Speechify.UpdateCallerRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Caller<br/>
        /// Update the customer-editable fields on a caller. PATCH semantics:<br/>
        /// omitted fields are unchanged, present fields overwrite. To clear<br/>
        /// a nullable field (`display_name`, `external_ref`) pass an empty<br/>
        /// string. `metadata` REPLACES the existing JSONB blob when supplied.
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="displayName">
        /// Operator-editable display name. Empty string clears the column.
        /// </param>
        /// <param name="externalRef">
        /// Optional handle into the customer's own CRM. Empty string clears the column.
        /// </param>
        /// <param name="metadata">
        /// Replacement metadata JSONB. Must not be `null`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.Caller> UpdateAsync(
            string callerId,
            string? speechifyVersion = default,
            string? displayName = default,
            string? externalRef = default,
            object? metadata = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}