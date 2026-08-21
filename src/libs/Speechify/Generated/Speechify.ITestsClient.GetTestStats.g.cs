#nullable enable

namespace Speechify
{
    public partial interface ITestsClient
    {
        /// <summary>
        /// Get Test Stats<br/>
        /// Aggregate pass-rate metrics over the last N days. Returns dense<br/>
        /// daily buckets (one entry per day, zero-filled) plus totals and a<br/>
        /// per-type breakdown. Powers the header chart on the global tests<br/>
        /// page. Default window is 30 days, max 90.<br/>
        /// Scoped by the same `project_id` filter as the list endpoint, so the<br/>
        /// chart above a narrowed table always counts the same tests.
        /// </summary>
        /// <param name="windowDays"></param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.TestStats> GetTestStatsAsync(
            int? windowDays = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Test Stats<br/>
        /// Aggregate pass-rate metrics over the last N days. Returns dense<br/>
        /// daily buckets (one entry per day, zero-filled) plus totals and a<br/>
        /// per-type breakdown. Powers the header chart on the global tests<br/>
        /// page. Default window is 30 days, max 90.<br/>
        /// Scoped by the same `project_id` filter as the list endpoint, so the<br/>
        /// chart above a narrowed table always counts the same tests.
        /// </summary>
        /// <param name="windowDays"></param>
        /// <param name="projectId"></param>
        /// <param name="speechifyVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.TestStats>> GetTestStatsAsResponseAsync(
            int? windowDays = default,
            string? projectId = default,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}