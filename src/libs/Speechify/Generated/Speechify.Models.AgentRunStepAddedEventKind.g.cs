
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The step type. `output` is reserved for a future step kind - a run's final answer lives on the run object today, not in the journal.
    /// </summary>
    public enum AgentRunStepAddedEventKind
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
    public static class AgentRunStepAddedEventKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStepAddedEventKind value)
        {
            return value switch
            {
                AgentRunStepAddedEventKind.Delegation => "delegation",
                AgentRunStepAddedEventKind.Observation => "observation",
                AgentRunStepAddedEventKind.Output => "output",
                AgentRunStepAddedEventKind.Plan => "plan",
                AgentRunStepAddedEventKind.ToolCall => "tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStepAddedEventKind? ToEnum(string value)
        {
            return value switch
            {
                "delegation" => AgentRunStepAddedEventKind.Delegation,
                "observation" => AgentRunStepAddedEventKind.Observation,
                "output" => AgentRunStepAddedEventKind.Output,
                "plan" => AgentRunStepAddedEventKind.Plan,
                "tool_call" => AgentRunStepAddedEventKind.ToolCall,
                _ => null,
            };
        }
    }
}