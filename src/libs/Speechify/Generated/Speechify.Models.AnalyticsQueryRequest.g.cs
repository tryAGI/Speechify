
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One tenant-scoped aggregation that powers a dashboard widget.
    /// </summary>
    public sealed partial class AnalyticsQueryRequest
    {
        /// <summary>
        /// The value each group / bucket reduces to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsMetric Metric { get; set; }

        /// <summary>
        /// Up to 5 groupable dimension keys. Empty for a single-value (number) result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<string>? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Speechify.AnalyticsFilter>? Filters { get; set; }

        /// <summary>
        /// Time scope + bucketing. Defaults to the last 30 days, the `started_at` field, no bucketing, and UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public global::Speechify.AnalyticsTime? Time { get; set; }

        /// <summary>
        /// When true, also return the same query for the immediately preceding period of equal length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_to_previous")]
        public bool? CompareToPrevious { get; set; }

        /// <summary>
        /// Max number of breakdown groups (default 50, capped at 50). Excess groups are dropped and `meta.truncated` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown_limit")]
        public int? BreakdownLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryRequest(
            global::Speechify.AnalyticsMetric metric,
            global::System.Collections.Generic.IList<string>? groupBy,
            global::System.Collections.Generic.IList<global::Speechify.AnalyticsFilter>? filters,
            global::Speechify.AnalyticsTime? time,
            bool? compareToPrevious,
            int? breakdownLimit)
        {
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.GroupBy = groupBy;
            this.Filters = filters;
            this.Time = time;
            this.CompareToPrevious = compareToPrevious;
            this.BreakdownLimit = breakdownLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryRequest" /> class.
        /// </summary>
        public AnalyticsQueryRequest()
        {
        }

    }
}