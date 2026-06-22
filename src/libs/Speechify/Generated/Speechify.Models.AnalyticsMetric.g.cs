
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The value each group / bucket reduces to.
    /// </summary>
    public sealed partial class AnalyticsMetric
    {
        /// <summary>
        /// Aggregation. `count` ignores `field`; `avg`/`sum`/`min`/`max` reduce over a numeric `field`; `rate` is the share of rows matching `rate_predicate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AnalyticsMetricAggJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AnalyticsMetricAgg Agg { get; set; }

        /// <summary>
        /// Numeric dimension key for avg / sum / min / max (e.g. `duration_ms`, `eval_pass_rate`, `data.&lt;key&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// One filter condition. `field` is a filterable dimension key; `op` is the comparison; `value` is a scalar (or array for `in`). Numeric comparison operators require a numeric field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_predicate")]
        public global::Speechify.AnalyticsFilter? RatePredicate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetric" /> class.
        /// </summary>
        /// <param name="agg">
        /// Aggregation. `count` ignores `field`; `avg`/`sum`/`min`/`max` reduce over a numeric `field`; `rate` is the share of rows matching `rate_predicate`.
        /// </param>
        /// <param name="field">
        /// Numeric dimension key for avg / sum / min / max (e.g. `duration_ms`, `eval_pass_rate`, `data.&lt;key&gt;`).
        /// </param>
        /// <param name="ratePredicate">
        /// One filter condition. `field` is a filterable dimension key; `op` is the comparison; `value` is a scalar (or array for `in`). Numeric comparison operators require a numeric field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsMetric(
            global::Speechify.AnalyticsMetricAgg agg,
            string? field,
            global::Speechify.AnalyticsFilter? ratePredicate)
        {
            this.Agg = agg;
            this.Field = field;
            this.RatePredicate = ratePredicate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetric" /> class.
        /// </summary>
        public AnalyticsMetric()
        {
        }

    }
}