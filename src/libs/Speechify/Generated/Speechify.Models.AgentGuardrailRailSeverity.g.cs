
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The severity stamped on the decision when the rail trips. Defaults to medium.
    /// </summary>
    public enum AgentGuardrailRailSeverity
    {
        /// <summary>
        ///
        /// </summary>
        Critical,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGuardrailRailSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGuardrailRailSeverity value)
        {
            return value switch
            {
                AgentGuardrailRailSeverity.Critical => "critical",
                AgentGuardrailRailSeverity.High => "high",
                AgentGuardrailRailSeverity.Low => "low",
                AgentGuardrailRailSeverity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGuardrailRailSeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => AgentGuardrailRailSeverity.Critical,
                "high" => AgentGuardrailRailSeverity.High,
                "low" => AgentGuardrailRailSeverity.Low,
                "medium" => AgentGuardrailRailSeverity.Medium,
                _ => null,
            };
        }
    }
}