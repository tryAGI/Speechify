
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What happens when the rail trips, in enforce mode. `observe`<br/>
    /// records only. `block` withholds the text (a blocked reply<br/>
    /// speaks the fallback line; a blocked tool call is refused and<br/>
    /// the model is told). `mask` substitutes the matched spans.<br/>
    /// Bounded by the policy `mode`: observe mode never blocks or<br/>
    /// masks.
    /// </summary>
    public enum AgentGuardrailRailAction
    {
        /// <summary>
        /// observe mode never blocks or
        /// </summary>
        Block,
        /// <summary>
        ///
        /// </summary>
        Mask,
        /// <summary>
        /// observe mode never blocks or
        /// </summary>
        Observe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGuardrailRailActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGuardrailRailAction value)
        {
            return value switch
            {
                AgentGuardrailRailAction.Block => "block",
                AgentGuardrailRailAction.Mask => "mask",
                AgentGuardrailRailAction.Observe => "observe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGuardrailRailAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => AgentGuardrailRailAction.Block,
                "mask" => AgentGuardrailRailAction.Mask,
                "observe" => AgentGuardrailRailAction.Observe,
                _ => null,
            };
        }
    }
}