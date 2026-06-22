#nullable enable

namespace Speechify
{
    public partial interface ISubpackageAgentSubpackageAgentAnalyticsClient
    {
        /// <summary>
        /// Run an analytics query<br/>
        /// Run one tenant-scoped aggregation over the workspace's conversations<br/>
        /// and post-call evaluations — the query that powers a single dashboard<br/>
        /// widget. Every chart type is a different shape of this request: a<br/>
        /// number card omits `group_by` and `time.bucket`; a line chart sets a<br/>
        /// `time.bucket`; bar / column / donut set `group_by`; a table sets<br/>
        /// several `group_by` dimensions.<br/>
        /// `metric` is the value each group/bucket reduces to (`count`, or an<br/>
        /// `avg` / `sum` / `min` / `max` over a numeric field, or a `rate` whose<br/>
        /// numerator is `rate_predicate`). `group_by` and `filters` reference<br/>
        /// dimension keys from `GET /v1/agents/analytics/dimensions`; an unknown<br/>
        /// dimension, metric, or operator is rejected. `compare_to_previous`<br/>
        /// returns the same query for the immediately preceding period. The<br/>
        /// number of breakdown groups is capped by `breakdown_limit`; `meta.truncated`<br/>
        /// reports when groups were dropped.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AnalyticsQueryResult> QueryAsync(

            global::Speechify.AnalyticsQueryRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run an analytics query<br/>
        /// Run one tenant-scoped aggregation over the workspace's conversations<br/>
        /// and post-call evaluations — the query that powers a single dashboard<br/>
        /// widget. Every chart type is a different shape of this request: a<br/>
        /// number card omits `group_by` and `time.bucket`; a line chart sets a<br/>
        /// `time.bucket`; bar / column / donut set `group_by`; a table sets<br/>
        /// several `group_by` dimensions.<br/>
        /// `metric` is the value each group/bucket reduces to (`count`, or an<br/>
        /// `avg` / `sum` / `min` / `max` over a numeric field, or a `rate` whose<br/>
        /// numerator is `rate_predicate`). `group_by` and `filters` reference<br/>
        /// dimension keys from `GET /v1/agents/analytics/dimensions`; an unknown<br/>
        /// dimension, metric, or operator is rejected. `compare_to_previous`<br/>
        /// returns the same query for the immediately preceding period. The<br/>
        /// number of breakdown groups is capped by `breakdown_limit`; `meta.truncated`<br/>
        /// reports when groups were dropped.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.AnalyticsQueryResult>> QueryAsResponseAsync(

            global::Speechify.AnalyticsQueryRequest request,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run an analytics query<br/>
        /// Run one tenant-scoped aggregation over the workspace's conversations<br/>
        /// and post-call evaluations — the query that powers a single dashboard<br/>
        /// widget. Every chart type is a different shape of this request: a<br/>
        /// number card omits `group_by` and `time.bucket`; a line chart sets a<br/>
        /// `time.bucket`; bar / column / donut set `group_by`; a table sets<br/>
        /// several `group_by` dimensions.<br/>
        /// `metric` is the value each group/bucket reduces to (`count`, or an<br/>
        /// `avg` / `sum` / `min` / `max` over a numeric field, or a `rate` whose<br/>
        /// numerator is `rate_predicate`). `group_by` and `filters` reference<br/>
        /// dimension keys from `GET /v1/agents/analytics/dimensions`; an unknown<br/>
        /// dimension, metric, or operator is rejected. `compare_to_previous`<br/>
        /// returns the same query for the immediately preceding period. The<br/>
        /// number of breakdown groups is capped by `breakdown_limit`; `meta.truncated`<br/>
        /// reports when groups were dropped.
        /// </summary>
        /// <param name="metric">
        /// The value each group / bucket reduces to.
        /// </param>
        /// <param name="groupBy">
        /// Up to 5 groupable dimension keys. Empty for a single-value (number) result.
        /// </param>
        /// <param name="filters"></param>
        /// <param name="time">
        /// Time scope + bucketing. Defaults to the last 30 days, the `started_at` field, no bucketing, and UTC.
        /// </param>
        /// <param name="compareToPrevious">
        /// When true, also return the same query for the immediately preceding period of equal length.
        /// </param>
        /// <param name="breakdownLimit">
        /// Max number of breakdown groups (default 50, capped at 50). Excess groups are dropped and `meta.truncated` is set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AnalyticsQueryResult> QueryAsync(
            global::Speechify.AnalyticsMetric metric,
            global::System.Collections.Generic.IList<string>? groupBy = default,
            global::System.Collections.Generic.IList<global::Speechify.AnalyticsFilter>? filters = default,
            global::Speechify.AnalyticsTime? time = default,
            bool? compareToPrevious = default,
            int? breakdownLimit = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}