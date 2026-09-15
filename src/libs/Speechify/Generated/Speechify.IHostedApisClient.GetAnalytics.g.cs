#nullable enable

namespace Speechify
{
    public partial interface IHostedApisClient
    {
        /// <summary>
        /// Get Hosted API Analytics<br/>
        /// Requests the API served over time: volume split by status, success<br/>
        /// rate, and p50/p95/p99 latency per time bucket, plus one `top_paths`<br/>
        /// row per route, busiest first, naming the route by `route_id`. Every<br/>
        /// request its host answered counts, including refusals such as a<br/>
        /// missing key (401) or an exhausted rate limit (429); `top_paths` counts<br/>
        /// only the requests that matched a route, including a route an MCP<br/>
        /// client called by tool name.<br/>
        /// The window defaults to the last 7 days and is capped at 30.<br/>
        /// History starts at `history_starts_at`, the first request in the last<br/>
        /// 30 days attributed to this API: requests before it cannot be<br/>
        /// attributed, so a bucket before it is missing data, not a quiet period.<br/>
        /// When `history_starts_at` is absent, no request to this API has been<br/>
        /// attributed in the last 30 days, and no bucket is known to be complete.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="granularity">
        /// Default Value: 1h
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RequestAnalyticsResponse> GetAnalyticsAsync(
            string apiId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Speechify.V1ApisApiIdAnalyticsGetParametersGranularity? granularity = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Hosted API Analytics<br/>
        /// Requests the API served over time: volume split by status, success<br/>
        /// rate, and p50/p95/p99 latency per time bucket, plus one `top_paths`<br/>
        /// row per route, busiest first, naming the route by `route_id`. Every<br/>
        /// request its host answered counts, including refusals such as a<br/>
        /// missing key (401) or an exhausted rate limit (429); `top_paths` counts<br/>
        /// only the requests that matched a route, including a route an MCP<br/>
        /// client called by tool name.<br/>
        /// The window defaults to the last 7 days and is capped at 30.<br/>
        /// History starts at `history_starts_at`, the first request in the last<br/>
        /// 30 days attributed to this API: requests before it cannot be<br/>
        /// attributed, so a bucket before it is missing data, not a quiet period.<br/>
        /// When `history_starts_at` is absent, no request to this API has been<br/>
        /// attributed in the last 30 days, and no bucket is known to be complete.<br/>
        /// Dark launch: requires the `hosted_apis_access` entitlement (402 `hosted_apis_not_in_plan` otherwise).
        /// </summary>
        /// <param name="apiId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="granularity">
        /// Default Value: 1h
        /// </param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RequestAnalyticsResponse>> GetAnalyticsAsResponseAsync(
            string apiId,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Speechify.V1ApisApiIdAnalyticsGetParametersGranularity? granularity = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}