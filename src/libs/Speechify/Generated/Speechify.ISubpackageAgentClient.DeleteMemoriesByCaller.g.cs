#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentClient
    {
        /// <summary>
        /// Delete Memories by Caller<br/>
        /// Delete every memory ever extracted for a specific caller on<br/>
        /// this agent, addressed by `caller_identity`. Privacy / GDPR<br/>
        /// surface. Rows become permanently unreachable immediately and are<br/>
        /// hard-deleted by the retention job after the tenant's configured<br/>
        /// retention window.<br/>
        /// Returns `200` with the soft-deleted row count rather than a<br/>
        /// bodiless `204`: the count is GDPR-purge audit evidence, so a<br/>
        /// privacy operator has direct proof of the purge without<br/>
        /// re-querying. This is a deliberate exception to the<br/>
        /// delete-returns-204 convention, shared with the caller-purge<br/>
        /// cascade (`DELETE /v1/agents/callers/{caller_id}`).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="callerIdentity"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.DeleteMemoriesByCallerResponse> DeleteMemoriesByCallerAsync(
            string agentId,
            string callerIdentity,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Memories by Caller<br/>
        /// Delete every memory ever extracted for a specific caller on<br/>
        /// this agent, addressed by `caller_identity`. Privacy / GDPR<br/>
        /// surface. Rows become permanently unreachable immediately and are<br/>
        /// hard-deleted by the retention job after the tenant's configured<br/>
        /// retention window.<br/>
        /// Returns `200` with the soft-deleted row count rather than a<br/>
        /// bodiless `204`: the count is GDPR-purge audit evidence, so a<br/>
        /// privacy operator has direct proof of the purge without<br/>
        /// re-querying. This is a deliberate exception to the<br/>
        /// delete-returns-204 convention, shared with the caller-purge<br/>
        /// cascade (`DELETE /v1/agents/callers/{caller_id}`).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="callerIdentity"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.DeleteMemoriesByCallerResponse>> DeleteMemoriesByCallerAsResponseAsync(
            string agentId,
            string callerIdentity,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}