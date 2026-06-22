
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyticsTimeBucket
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
    public static class AnalyticsTimeBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsTimeBucket value)
        {
            return value switch
            {
                AnalyticsTimeBucket.Day => "day",
                AnalyticsTimeBucket.Month => "month",
                AnalyticsTimeBucket.None => "none",
                AnalyticsTimeBucket.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsTimeBucket? ToEnum(string value)
        {
            return value switch
            {
                "day" => AnalyticsTimeBucket.Day,
                "month" => AnalyticsTimeBucket.Month,
                "none" => AnalyticsTimeBucket.None,
                "week" => AnalyticsTimeBucket.Week,
                _ => null,
            };
        }
    }
}