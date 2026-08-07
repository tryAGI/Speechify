#nullable enable

namespace Speechify
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// List Agent Voices<br/>
        /// List the voice catalogue available for voice agents: the curated<br/>
        /// shared catalogue plus your workspace's own cloned voices, each<br/>
        /// marked by `type` (`shared` or `personal`). The same slug set is<br/>
        /// accepted by POST/PATCH /v1/agents, so any voice listed here can be<br/>
        /// assigned to an agent. Cloned voices are workspace-owned only - a<br/>
        /// personal voice scoped to an individual is not selectable on an<br/>
        /// agent, which is a workspace-shared resource. The JSON layout<br/>
        /// intentionally mirrors the TTS `/v1/voices` shape so a single voice<br/>
        /// picker can consume both endpoints.<br/>
        /// Cursor-paginated: pass `cursor` + `limit` and walk pages while<br/>
        /// `has_more` is true. From API version `2026-08-07` an omitted `limit`<br/>
        /// returns the first page (default 50, max 200); a caller pinned before<br/>
        /// that date keeps the historical whole-catalogue response until it opts<br/>
        /// in. The shared catalogue is served first, then your cloned voices.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.ListAgentVoicesResponse> ListAgentVoicesAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Voices<br/>
        /// List the voice catalogue available for voice agents: the curated<br/>
        /// shared catalogue plus your workspace's own cloned voices, each<br/>
        /// marked by `type` (`shared` or `personal`). The same slug set is<br/>
        /// accepted by POST/PATCH /v1/agents, so any voice listed here can be<br/>
        /// assigned to an agent. Cloned voices are workspace-owned only - a<br/>
        /// personal voice scoped to an individual is not selectable on an<br/>
        /// agent, which is a workspace-shared resource. The JSON layout<br/>
        /// intentionally mirrors the TTS `/v1/voices` shape so a single voice<br/>
        /// picker can consume both endpoints.<br/>
        /// Cursor-paginated: pass `cursor` + `limit` and walk pages while<br/>
        /// `has_more` is true. From API version `2026-08-07` an omitted `limit`<br/>
        /// returns the first page (default 50, max 200); a caller pinned before<br/>
        /// that date keeps the historical whole-catalogue response until it opts<br/>
        /// in. The shared catalogue is served first, then your cloned voices.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.ListAgentVoicesResponse>> ListAgentVoicesAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}