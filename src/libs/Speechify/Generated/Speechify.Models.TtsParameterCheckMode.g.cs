
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How a `ParameterCheck` validates a tool argument.<br/>
    /// - `exact` - JSON equality.<br/>
    /// - `regex` - the argument stringified is matched against the pattern.<br/>
    /// - `llm` - an LLM judge decides whether the value semantically satisfies<br/>
    ///   the criteria (e.g. "is a plausible email address").
    /// </summary>
    public enum TtsParameterCheckMode
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
    public static class TtsParameterCheckModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsParameterCheckMode value)
        {
            return value switch
            {
                TtsParameterCheckMode.Exact => "exact",
                TtsParameterCheckMode.Llm => "llm",
                TtsParameterCheckMode.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsParameterCheckMode? ToEnum(string value)
        {
            return value switch
            {
                "exact" => TtsParameterCheckMode.Exact,
                "llm" => TtsParameterCheckMode.Llm,
                "regex" => TtsParameterCheckMode.Regex,
                _ => null,
            };
        }
    }
}