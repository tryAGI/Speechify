
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsDataAssertionResultMode
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
    public static class TtsDataAssertionResultModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsDataAssertionResultMode value)
        {
            return value switch
            {
                TtsDataAssertionResultMode.Exact => "exact",
                TtsDataAssertionResultMode.Llm => "llm",
                TtsDataAssertionResultMode.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsDataAssertionResultMode? ToEnum(string value)
        {
            return value switch
            {
                "exact" => TtsDataAssertionResultMode.Exact,
                "llm" => TtsDataAssertionResultMode.Llm,
                "regex" => TtsDataAssertionResultMode.Regex,
                _ => null,
            };
        }
    }
}