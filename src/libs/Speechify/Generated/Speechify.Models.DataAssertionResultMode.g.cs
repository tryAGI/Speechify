
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataAssertionResultMode
    {
        /// <summary>
        /// 
        /// </summary>
        Exact,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataAssertionResultModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataAssertionResultMode value)
        {
            return value switch
            {
                DataAssertionResultMode.Exact => "exact",
                DataAssertionResultMode.Llm => "llm",
                DataAssertionResultMode.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataAssertionResultMode? ToEnum(string value)
        {
            return value switch
            {
                "exact" => DataAssertionResultMode.Exact,
                "llm" => DataAssertionResultMode.Llm,
                "regex" => DataAssertionResultMode.Regex,
                _ => null,
            };
        }
    }
}