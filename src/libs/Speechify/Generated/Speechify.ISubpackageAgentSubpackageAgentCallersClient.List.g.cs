#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentCallersClient
    {
        /// <summary>
        /// List Callers<br/>
        /// List the workspace's callers, ordered by most-recently-seen first.<br/>
        /// A caller is the per-(tenant, agent, identity) entity that owns<br/>
        /// long-term memories and conversation history.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="q"></param>
        /// <param name="lastSeenAfter"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListCallersResponse> ListAsync(
            string? agentId = default,
            string? q = default,
            global::System.DateTime? lastSeenAfter = default,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Callers<br/>
        /// List the workspace's callers, ordered by most-recently-seen first.<br/>
        /// A caller is the per-(tenant, agent, identity) entity that owns<br/>
        /// long-term memories and conversation history.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="q"></param>
        /// <param name="lastSeenAfter"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListCallersResponse>> ListAsResponseAsync(
            string? agentId = default,
            string? q = default,
            global::System.DateTime? lastSeenAfter = default,
            string? cursor = default,
            int? limit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}