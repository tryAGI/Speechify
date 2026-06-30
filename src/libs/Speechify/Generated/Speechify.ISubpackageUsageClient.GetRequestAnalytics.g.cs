#nullable enable

namespace Speechify
{
    public partial interface ISubpackageUsageClient
    {
        /// <summary>
        /// Get API Request Analytics<br/>
        /// API-Request analytics for the workspace: request volume split by<br/>
        /// response code over time, success rate, average and p50/p95/p99<br/>
        /// latency per time bucket, and the most-called routes. Tenant-scoped<br/>
        /// server-side and gated on the `usage.view` permission. Same optional<br/>
        /// filters as the Request Log; `granularity` controls the time-bucket<br/>
        /// size. Default range is the last 7 days, capped at 30 days.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="granularity">
        /// Default Value: 1h
        /// </param>
        /// <param name="method"></param>
        /// <param name="status"></param>
        /// <param name="path"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="principalType"></param>
        /// <param name="minLatencyMs"></param>
        /// <param name="maxLatencyMs"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.RequestAnalyticsResponse> GetRequestAnalyticsAsync(
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Speechify.V1UsageRequestsAnalyticsGetParametersGranularity? granularity = default,
            global::System.Collections.Generic.IList<global::Speechify.V1UsageRequestsAnalyticsGetParametersMethodSchemaItems>? method = default,
            global::System.Collections.Generic.IList<int>? status = default,
            string? path = default,
            string? userId = default,
            string? apiKeyId = default,
            global::Speechify.V1UsageRequestsAnalyticsGetParametersPrincipalType? principalType = default,
            int? minLatencyMs = default,
            int? maxLatencyMs = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get API Request Analytics<br/>
        /// API-Request analytics for the workspace: request volume split by<br/>
        /// response code over time, success rate, average and p50/p95/p99<br/>
        /// latency per time bucket, and the most-called routes. Tenant-scoped<br/>
        /// server-side and gated on the `usage.view` permission. Same optional<br/>
        /// filters as the Request Log; `granularity` controls the time-bucket<br/>
        /// size. Default range is the last 7 days, capped at 30 days.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="granularity">
        /// Default Value: 1h
        /// </param>
        /// <param name="method"></param>
        /// <param name="status"></param>
        /// <param name="path"></param>
        /// <param name="userId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="principalType"></param>
        /// <param name="minLatencyMs"></param>
        /// <param name="maxLatencyMs"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.RequestAnalyticsResponse>> GetRequestAnalyticsAsResponseAsync(
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::Speechify.V1UsageRequestsAnalyticsGetParametersGranularity? granularity = default,
            global::System.Collections.Generic.IList<global::Speechify.V1UsageRequestsAnalyticsGetParametersMethodSchemaItems>? method = default,
            global::System.Collections.Generic.IList<int>? status = default,
            string? path = default,
            string? userId = default,
            string? apiKeyId = default,
            global::Speechify.V1UsageRequestsAnalyticsGetParametersPrincipalType? principalType = default,
            int? minLatencyMs = default,
            int? maxLatencyMs = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}