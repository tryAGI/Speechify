#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentFlowClient
    {
        /// <summary>
        /// Get Agent Flow Version<br/>
        /// Return the full flow graph for a specific published version.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="versionId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.GetFlowVersionResponse> GetVersionAsync(
            string agentId,
            string versionId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Flow Version<br/>
        /// Return the full flow graph for a specific published version.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="versionId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.GetFlowVersionResponse>> GetVersionAsResponseAsync(
            string agentId,
            string versionId,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}