#nullable enable

namespace Speechify
{
    public partial interface IPublishGateClient
    {
        /// <summary>
        /// Get Latest Publish Gate Run<br/>
        /// Return the agent's most recent publish-gate decision, or `null` when it has<br/>
        /// never been gated. This is the durable answer to "are this agent's checks<br/>
        /// passing, and when were they last run", without republishing it.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.LatestPublishGateRunResponse> LatestAsync(
            string agentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Latest Publish Gate Run<br/>
        /// Return the agent's most recent publish-gate decision, or `null` when it has<br/>
        /// never been gated. This is the durable answer to "are this agent's checks<br/>
        /// passing, and when were they last run", without republishing it.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.LatestPublishGateRunResponse>> LatestAsResponseAsync(
            string agentId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}