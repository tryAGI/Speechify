
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Aggregate request analytics over a window of the request log.
    /// </summary>
    public sealed partial class RequestAnalyticsResponse
    {
        /// <summary>
        /// The time-bucket size of the series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Granularity { get; set; }

        /// <summary>
        /// Inclusive start of the resolved window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// Exclusive end of the resolved window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// Window-wide rollups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.RequestAnalyticsTotals Totals { get; set; }

        /// <summary>
        /// Per-bucket time series, oldest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.RequestAnalyticsBucket> Series { get; set; }

        /// <summary>
        /// The most-called route patterns in the window, busiest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.RequestTopPath> TopPaths { get; set; }

        /// <summary>
        /// True when a `project_id` filter's pinned key set exceeded the cap this endpoint applies: the result reflects only the project's newest keys within the cap, not its full traffic. Omitted (false) when no project filter was requested or its key set fit under the cap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_filter_truncated")]
        public bool? ProjectFilterTruncated { get; set; }

        /// <summary>
        /// Hosted API analytics only: the first request in the last 30 days the request log attributes to this API. Requests before it cannot be attributed, so a bucket before it is missing data rather than zero traffic. Absent when no such request exists, in which case no bucket is known to be complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_starts_at")]
        public global::System.DateTime? HistoryStartsAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="granularity">
        /// The time-bucket size of the series.
        /// </param>
        /// <param name="start">
        /// Inclusive start of the resolved window.
        /// </param>
        /// <param name="end">
        /// Exclusive end of the resolved window.
        /// </param>
        /// <param name="totals">
        /// Window-wide rollups.
        /// </param>
        /// <param name="series">
        /// Per-bucket time series, oldest first.
        /// </param>
        /// <param name="topPaths">
        /// The most-called route patterns in the window, busiest first.
        /// </param>
        /// <param name="projectFilterTruncated">
        /// True when a `project_id` filter's pinned key set exceeded the cap this endpoint applies: the result reflects only the project's newest keys within the cap, not its full traffic. Omitted (false) when no project filter was requested or its key set fit under the cap.
        /// </param>
        /// <param name="historyStartsAt">
        /// Hosted API analytics only: the first request in the last 30 days the request log attributes to this API. Requests before it cannot be attributed, so a bucket before it is missing data rather than zero traffic. Absent when no such request exists, in which case no bucket is known to be complete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestAnalyticsResponse(
            string granularity,
            global::System.DateTime start,
            global::System.DateTime end,
            global::Speechify.RequestAnalyticsTotals totals,
            global::System.Collections.Generic.IList<global::Speechify.RequestAnalyticsBucket> series,
            global::System.Collections.Generic.IList<global::Speechify.RequestTopPath> topPaths,
            bool? projectFilterTruncated,
            global::System.DateTime? historyStartsAt)
        {
            this.Granularity = granularity ?? throw new global::System.ArgumentNullException(nameof(granularity));
            this.Start = start;
            this.End = end;
            this.Totals = totals ?? throw new global::System.ArgumentNullException(nameof(totals));
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.TopPaths = topPaths ?? throw new global::System.ArgumentNullException(nameof(topPaths));
            this.ProjectFilterTruncated = projectFilterTruncated;
            this.HistoryStartsAt = historyStartsAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAnalyticsResponse" /> class.
        /// </summary>
        public RequestAnalyticsResponse()
        {
        }

    }
}