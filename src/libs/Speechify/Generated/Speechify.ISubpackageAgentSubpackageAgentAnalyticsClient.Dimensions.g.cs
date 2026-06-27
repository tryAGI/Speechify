#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentAnalyticsClient
    {
        /// <summary>
        /// List analytics dimensions<br/>
        /// The typed dimension catalog the analytics dashboards filter and<br/>
        /// break down by. Returns the always-available call-level dimensions;<br/>
        /// pass `agent_id` to additionally include that agent's evaluation<br/>
        /// criteria and typed data-collection fields. Each dimension declares<br/>
        /// its value `type` and whether it can be used to filter, to group by,<br/>
        /// or both. Free-text fields are never returned as dimensions. Returns<br/>
        /// the full set in a single response: bounded by the typed dimension<br/>
        /// catalogue plus (with agent_id) one agent's evaluation config, so<br/>
        /// this list is intentionally not paginated.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AnalyticsDimensionsResponse> DimensionsAsync(
            string? agentId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List analytics dimensions<br/>
        /// The typed dimension catalog the analytics dashboards filter and<br/>
        /// break down by. Returns the always-available call-level dimensions;<br/>
        /// pass `agent_id` to additionally include that agent's evaluation<br/>
        /// criteria and typed data-collection fields. Each dimension declares<br/>
        /// its value `type` and whether it can be used to filter, to group by,<br/>
        /// or both. Free-text fields are never returned as dimensions. Returns<br/>
        /// the full set in a single response: bounded by the typed dimension<br/>
        /// catalogue plus (with agent_id) one agent's evaluation config, so<br/>
        /// this list is intentionally not paginated.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AnalyticsDimensionsResponse>> DimensionsAsResponseAsync(
            string? agentId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}