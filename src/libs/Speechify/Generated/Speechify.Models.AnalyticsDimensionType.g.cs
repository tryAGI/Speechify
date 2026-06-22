
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The dimension's value type.
    /// </summary>
    public enum AnalyticsDimensionType
    {
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        Enum,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsDimensionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsDimensionType value)
        {
            return value switch
            {
                AnalyticsDimensionType.Bool => "bool",
                AnalyticsDimensionType.Enum => "enum",
                AnalyticsDimensionType.Number => "number",
                AnalyticsDimensionType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsDimensionType? ToEnum(string value)
        {
            return value switch
            {
                "bool" => AnalyticsDimensionType.Bool,
                "enum" => AnalyticsDimensionType.Enum,
                "number" => AnalyticsDimensionType.Number,
                "string" => AnalyticsDimensionType.String,
                _ => null,
            };
        }
    }
}