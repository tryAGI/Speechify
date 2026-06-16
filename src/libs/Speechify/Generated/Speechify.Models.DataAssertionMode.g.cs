
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the assertion validates the extracted value.
    /// </summary>
    public enum DataAssertionMode
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
    public static class DataAssertionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataAssertionMode value)
        {
            return value switch
            {
                DataAssertionMode.Exact => "exact",
                DataAssertionMode.Llm => "llm",
                DataAssertionMode.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataAssertionMode? ToEnum(string value)
        {
            return value switch
            {
                "exact" => DataAssertionMode.Exact,
                "llm" => DataAssertionMode.Llm,
                "regex" => DataAssertionMode.Regex,
                _ => null,
            };
        }
    }
}