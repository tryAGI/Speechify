
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
    public enum ParameterCheckMode
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
    public static class ParameterCheckModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParameterCheckMode value)
        {
            return value switch
            {
                ParameterCheckMode.Exact => "exact",
                ParameterCheckMode.Llm => "llm",
                ParameterCheckMode.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParameterCheckMode? ToEnum(string value)
        {
            return value switch
            {
                "exact" => ParameterCheckMode.Exact,
                "llm" => ParameterCheckMode.Llm,
                "regex" => ParameterCheckMode.Regex,
                _ => null,
            };
        }
    }
}