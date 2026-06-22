
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for POST /v1/agents/analytics/query.
    /// </summary>
    public sealed partial class AnalyticsQueryResult
    {
        /// <summary>
        /// The value each group / bucket reduces to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsMetric Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnalyticsQueryResultBucketJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsQueryResultBucket Bucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.AnalyticsSeries> Series { get; set; }

        /// <summary>
        /// The same query over the immediately preceding period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public global::Speechify.AnalyticsPreviousResult? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsQueryMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryResult" /> class.
        /// </summary>
        /// <param name="metric">
        /// The value each group / bucket reduces to.
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="bucket"></param>
        /// <param name="series"></param>
        /// <param name="meta"></param>
        /// <param name="previous">
        /// The same query over the immediately preceding period.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryResult(
            global::Speechify.AnalyticsMetric metric,
            global::System.Collections.Generic.IList<string> groupBy,
            global::Speechify.AnalyticsQueryResultBucket bucket,
            global::System.Collections.Generic.IList<global::Speechify.AnalyticsSeries> series,
            global::Speechify.AnalyticsQueryMeta meta,
            global::Speechify.AnalyticsPreviousResult? previous)
        {
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.Bucket = bucket;
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Previous = previous;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryResult" /> class.
        /// </summary>
        public AnalyticsQueryResult()
        {
        }

    }
}