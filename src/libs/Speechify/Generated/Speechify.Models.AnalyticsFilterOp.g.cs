
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsFilterOp
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsFilterOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsFilterOp value)
        {
            return value switch
            {
                AnalyticsFilterOp.Eq => "eq",
                AnalyticsFilterOp.Gt => "gt",
                AnalyticsFilterOp.Gte => "gte",
                AnalyticsFilterOp.In => "in",
                AnalyticsFilterOp.Lt => "lt",
                AnalyticsFilterOp.Lte => "lte",
                AnalyticsFilterOp.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsFilterOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AnalyticsFilterOp.Eq,
                "gt" => AnalyticsFilterOp.Gt,
                "gte" => AnalyticsFilterOp.Gte,
                "in" => AnalyticsFilterOp.In,
                "lt" => AnalyticsFilterOp.Lt,
                "lte" => AnalyticsFilterOp.Lte,
                "neq" => AnalyticsFilterOp.Neq,
                _ => null,
            };
        }
    }
}