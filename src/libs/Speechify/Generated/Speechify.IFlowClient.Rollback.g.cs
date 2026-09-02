#nullable enable

namespace Speechify
{
    public partial interface IFlowClient
    {
        /// <summary>
        /// Roll Back Agent Flow<br/>
        /// Publish a prior flow version as the active graph.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.FlowVersion> RollbackAsync(
            string agentId,

            global::Speechify.RollbackFlowRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Roll Back Agent Flow<br/>
        /// Publish a prior flow version as the active graph.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.FlowVersion>> RollbackAsResponseAsync(
            string agentId,

            global::Speechify.RollbackFlowRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Roll Back Agent Flow<br/>
        /// Publish a prior flow version as the active graph.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="versionId">
        /// The flow version to roll back to (prefixed external id, `fver_...`).
        /// </param>
        /// <param name="gateOverrideReason">
        /// On a workspace with the behavioral-eval publish gate enabled, a<br/>
        /// non-empty justification re-activates a version past a failing<br/>
        /// behavioral suite. The suite still runs and its verdict is recorded<br/>
        /// with this reason - an override bypasses blocking, not measurement.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.FlowVersion> RollbackAsync(
            string agentId,
            string versionId,
            string? speechifyVersion = default,
            string? gateOverrideReason = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}