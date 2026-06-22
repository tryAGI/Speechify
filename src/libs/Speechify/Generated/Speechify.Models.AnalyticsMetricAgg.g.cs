
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Aggregation. `count` ignores `field`; `avg`/`sum`/`min`/`max` reduce over a numeric `field`; `rate` is the share of rows matching `rate_predicate`.
    /// </summary>
    public enum AnalyticsMetricAgg
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Rate,
        /// <summary>
        /// 
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsMetricAggExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsMetricAgg value)
        {
            return value switch
            {
                AnalyticsMetricAgg.Avg => "avg",
                AnalyticsMetricAgg.Count => "count",
                AnalyticsMetricAgg.Max => "max",
                AnalyticsMetricAgg.Min => "min",
                AnalyticsMetricAgg.Rate => "rate",
                AnalyticsMetricAgg.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsMetricAgg? ToEnum(string value)
        {
            return value switch
            {
                "avg" => AnalyticsMetricAgg.Avg,
                "count" => AnalyticsMetricAgg.Count,
                "max" => AnalyticsMetricAgg.Max,
                "min" => AnalyticsMetricAgg.Min,
                "rate" => AnalyticsMetricAgg.Rate,
                "sum" => AnalyticsMetricAgg.Sum,
                _ => null,
            };
        }
    }
}