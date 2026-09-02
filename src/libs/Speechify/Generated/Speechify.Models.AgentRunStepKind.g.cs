
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The step type. `output` is reserved for a future step kind - a run's final answer lives on the run object today, not in the journal.
    /// </summary>
    public enum AgentRunStepKind
    {
        /// <summary>
        ///
        /// </summary>
        Delegation,
        /// <summary>
        ///
        /// </summary>
        Observation,
        /// <summary>
        ///
        /// </summary>
        Output,
        /// <summary>
        ///
        /// </summary>
        Plan,
        /// <summary>
        ///
        /// </summary>
        ToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStepKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStepKind value)
        {
            return value switch
            {
                AgentRunStepKind.Delegation => "delegation",
                AgentRunStepKind.Observation => "observation",
                AgentRunStepKind.Output => "output",
                AgentRunStepKind.Plan => "plan",
                AgentRunStepKind.ToolCall => "tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStepKind? ToEnum(string value)
        {
            return value switch
            {
                "delegation" => AgentRunStepKind.Delegation,
                "observation" => AgentRunStepKind.Observation,
                "output" => AgentRunStepKind.Output,
                "plan" => AgentRunStepKind.Plan,
                "tool_call" => AgentRunStepKind.ToolCall,
                _ => null,
            };
        }
    }
}