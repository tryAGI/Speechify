
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsQueryResultBucket
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsQueryResultBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsQueryResultBucket value)
        {
            return value switch
            {
                AnalyticsQueryResultBucket.Day => "day",
                AnalyticsQueryResultBucket.Month => "month",
                AnalyticsQueryResultBucket.None => "none",
                AnalyticsQueryResultBucket.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsQueryResultBucket? ToEnum(string value)
        {
            return value switch
            {
                "day" => AnalyticsQueryResultBucket.Day,
                "month" => AnalyticsQueryResultBucket.Month,
                "none" => AnalyticsQueryResultBucket.None,
                "week" => AnalyticsQueryResultBucket.Week,
                _ => null,
            };
        }
    }
}