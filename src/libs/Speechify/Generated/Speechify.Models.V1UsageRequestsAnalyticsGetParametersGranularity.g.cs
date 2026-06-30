
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Default Value: 1h
    /// </summary>
    public enum V1UsageRequestsAnalyticsGetParametersGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        x12h,
        /// <summary>
        /// 
        /// </summary>
        x15m,
        /// <summary>
        /// 
        /// </summary>
        x1d,
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x1m,
        /// <summary>
        /// 
        /// </summary>
        x30m,
        /// <summary>
        /// 
        /// </summary>
        x5m,
        /// <summary>
        /// 
        /// </summary>
        x6h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1UsageRequestsAnalyticsGetParametersGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1UsageRequestsAnalyticsGetParametersGranularity value)
        {
            return value switch
            {
                V1UsageRequestsAnalyticsGetParametersGranularity.x12h => "12h",
                V1UsageRequestsAnalyticsGetParametersGranularity.x15m => "15m",
                V1UsageRequestsAnalyticsGetParametersGranularity.x1d => "1d",
                V1UsageRequestsAnalyticsGetParametersGranularity.x1h => "1h",
                V1UsageRequestsAnalyticsGetParametersGranularity.x1m => "1m",
                V1UsageRequestsAnalyticsGetParametersGranularity.x30m => "30m",
                V1UsageRequestsAnalyticsGetParametersGranularity.x5m => "5m",
                V1UsageRequestsAnalyticsGetParametersGranularity.x6h => "6h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1UsageRequestsAnalyticsGetParametersGranularity? ToEnum(string value)
        {
            return value switch
            {
                "12h" => V1UsageRequestsAnalyticsGetParametersGranularity.x12h,
                "15m" => V1UsageRequestsAnalyticsGetParametersGranularity.x15m,
                "1d" => V1UsageRequestsAnalyticsGetParametersGranularity.x1d,
                "1h" => V1UsageRequestsAnalyticsGetParametersGranularity.x1h,
                "1m" => V1UsageRequestsAnalyticsGetParametersGranularity.x1m,
                "30m" => V1UsageRequestsAnalyticsGetParametersGranularity.x30m,
                "5m" => V1UsageRequestsAnalyticsGetParametersGranularity.x5m,
                "6h" => V1UsageRequestsAnalyticsGetParametersGranularity.x6h,
                _ => null,
            };
        }
    }
}