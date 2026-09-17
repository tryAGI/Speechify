
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Selects the default check set when `check` is absent.
    /// </summary>
    public enum AgentGuardrailRailClass
    {
        /// <summary>
        ///
        /// </summary>
        Input,
        /// <summary>
        ///
        /// </summary>
        Output,
        /// <summary>
        ///
        /// </summary>
        Provenance,
        /// <summary>
        ///
        /// </summary>
        ToolCall,
        /// <summary>
        ///
        /// </summary>
        Topical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGuardrailRailClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGuardrailRailClass value)
        {
            return value switch
            {
                AgentGuardrailRailClass.Input => "input",
                AgentGuardrailRailClass.Output => "output",
                AgentGuardrailRailClass.Provenance => "provenance",
                AgentGuardrailRailClass.ToolCall => "tool_call",
                AgentGuardrailRailClass.Topical => "topical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGuardrailRailClass? ToEnum(string value)
        {
            return value switch
            {
                "input" => AgentGuardrailRailClass.Input,
                "output" => AgentGuardrailRailClass.Output,
                "provenance" => AgentGuardrailRailClass.Provenance,
                "tool_call" => AgentGuardrailRailClass.ToolCall,
                "topical" => AgentGuardrailRailClass.Topical,
                _ => null,
            };
        }
    }
}