#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentCallersClient
    {
        /// <summary>
        /// Delete Caller (GDPR purge)<br/>
        /// Soft-delete the caller AND cascade soft-delete every memory row<br/>
        /// pointing at it. Conversations survive (forensic / billing records)<br/>
        /// but their caller pointer surfaces as "deleted" through the API.<br/>
        /// Idempotent — re-deleting an already-purged caller returns<br/>
        /// `{caller_purged: 0, memories_purged: 0}`. Audit row counts<br/>
        /// accompany every response so a privacy operator has direct<br/>
        /// evidence of the purge without re-querying.<br/>
        /// Returns `200` with the row-count body rather than a bodiless<br/>
        /// `204`: the counts are GDPR-purge audit evidence. This is a<br/>
        /// deliberate exception to the delete-returns-204 convention,<br/>
        /// shared with the bulk memory purge<br/>
        /// (`DELETE /v1/agents/{agent_id}/memories`).
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.DeleteCallerResponse> DeleteAsync(
            string callerId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Caller (GDPR purge)<br/>
        /// Soft-delete the caller AND cascade soft-delete every memory row<br/>
        /// pointing at it. Conversations survive (forensic / billing records)<br/>
        /// but their caller pointer surfaces as "deleted" through the API.<br/>
        /// Idempotent — re-deleting an already-purged caller returns<br/>
        /// `{caller_purged: 0, memories_purged: 0}`. Audit row counts<br/>
        /// accompany every response so a privacy operator has direct<br/>
        /// evidence of the purge without re-querying.<br/>
        /// Returns `200` with the row-count body rather than a bodiless<br/>
        /// `204`: the counts are GDPR-purge audit evidence. This is a<br/>
        /// deliberate exception to the delete-returns-204 convention,<br/>
        /// shared with the bulk memory purge<br/>
        /// (`DELETE /v1/agents/{agent_id}/memories`).
        /// </summary>
        /// <param name="callerId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.DeleteCallerResponse>> DeleteAsResponseAsync(
            string callerId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}