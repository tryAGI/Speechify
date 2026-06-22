
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which timestamp to scope + bucket on. `started_at` excludes never-connected calls; `created_at` counts all attempts.
    /// </summary>
    public enum AnalyticsTimeField
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        StartedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsTimeFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsTimeField value)
        {
            return value switch
            {
                AnalyticsTimeField.CreatedAt => "created_at",
                AnalyticsTimeField.StartedAt => "started_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsTimeField? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AnalyticsTimeField.CreatedAt,
                "started_at" => AnalyticsTimeField.StartedAt,
                _ => null,
            };
        }
    }
}