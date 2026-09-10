
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum StoreAggregateMetricOp
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
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreAggregateMetricOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreAggregateMetricOp value)
        {
            return value switch
            {
                StoreAggregateMetricOp.Avg => "avg",
                StoreAggregateMetricOp.Count => "count",
                StoreAggregateMetricOp.Max => "max",
                StoreAggregateMetricOp.Min => "min",
                StoreAggregateMetricOp.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreAggregateMetricOp? ToEnum(string value)
        {
            return value switch
            {
                "avg" => StoreAggregateMetricOp.Avg,
                "count" => StoreAggregateMetricOp.Count,
                "max" => StoreAggregateMetricOp.Max,
                "min" => StoreAggregateMetricOp.Min,
                "sum" => StoreAggregateMetricOp.Sum,
                _ => null,
            };
        }
    }
}