
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the assertion validates the extracted value.
    /// </summary>
    public enum TtsDataAssertionMode
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
    public static class TtsDataAssertionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsDataAssertionMode value)
        {
            return value switch
            {
                TtsDataAssertionMode.Exact => "exact",
                TtsDataAssertionMode.Llm => "llm",
                TtsDataAssertionMode.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsDataAssertionMode? ToEnum(string value)
        {
            return value switch
            {
                "exact" => TtsDataAssertionMode.Exact,
                "llm" => TtsDataAssertionMode.Llm,
                "regex" => TtsDataAssertionMode.Regex,
                _ => null,
            };
        }
    }
}