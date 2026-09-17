
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the rails may do. `observe` (the default when absent):<br/>
    /// every rail records what it would have done and changes<br/>
    /// nothing, which is how a new rail is measured on real traffic<br/>
    /// before it acts. `enforce`: each rail's own `action` applies.<br/>
    /// `off`: none of the policy's own rails run; the platform's<br/>
    /// rails keep observing. Move an agent to `enforce` on its<br/>
    /// observed counts, never by default.
    /// </summary>
    public enum AgentGuardrailsConfigMode
    {
        /// <summary>
        /// each rail's own `action` applies.
        /// </summary>
        Enforce,
        /// <summary>
        ///
        /// </summary>
        Observe,
        /// <summary>
        /// none of the policy's own rails run; the platform's
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGuardrailsConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGuardrailsConfigMode value)
        {
            return value switch
            {
                AgentGuardrailsConfigMode.Enforce => "enforce",
                AgentGuardrailsConfigMode.Observe => "observe",
                AgentGuardrailsConfigMode.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGuardrailsConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "enforce" => AgentGuardrailsConfigMode.Enforce,
                "observe" => AgentGuardrailsConfigMode.Observe,
                "off" => AgentGuardrailsConfigMode.Off,
                _ => null,
            };
        }
    }
}