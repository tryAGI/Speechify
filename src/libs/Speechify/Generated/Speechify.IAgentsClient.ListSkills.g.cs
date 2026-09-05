#nullable enable

namespace Speechify
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agent Skills<br/>
        /// List the skills attached to this agent, oldest attachment first - the<br/>
        /// order dispatch renders them in. Each carries the version it is pinned to<br/>
        /// and the version the catalog currently holds; when the two differ an<br/>
        /// upgrade is available, and nothing upgrades on its own.<br/>
        /// Cursor-paginated; walk pages while `has_more` is true.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentSkillsResponse> ListSkillsAsync(
            string agentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Skills<br/>
        /// List the skills attached to this agent, oldest attachment first - the<br/>
        /// order dispatch renders them in. Each carries the version it is pinned to<br/>
        /// and the version the catalog currently holds; when the two differ an<br/>
        /// upgrade is available, and nothing upgrades on its own.<br/>
        /// Cursor-paginated; walk pages while `has_more` is true.<br/>
        /// Dark launch: requires the `skills_access` entitlement (402 `skills_not_in_plan` otherwise).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentSkillsResponse>> ListSkillsAsResponseAsync(
            string agentId,
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}