
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Why a non-failed run stopped short: `max_turns_exhausted`, `budget_exhausted`, or `output_schema_violation` (the agent never produced an object matching `input.output_schema`; `output.reply` keeps its prose and `output.data` is absent).
    /// </summary>
    public enum AgentRunIncompleteReason
    {
        /// <summary>
        /// `max_turns_exhausted`, `budget_exhausted`, or `output_schema_violation` (the agent never produced an object matching `input.output_schema`; `output.reply` keeps its prose and `output.data` is absent).
        /// </summary>
        BudgetExhausted,
        /// <summary>
        /// `max_turns_exhausted`, `budget_exhausted`, or `output_schema_violation` (the agent never produced an object matching `input.output_schema`; `output.reply` keeps its prose and `output.data` is absent).
        /// </summary>
        MaxTurnsExhausted,
        /// <summary>
        /// `max_turns_exhausted`, `budget_exhausted`, or `output_schema_violation` (the agent never produced an object matching `input.output_schema`; `output.reply` keeps its prose and `output.data` is absent).
        /// </summary>
        OutputSchemaViolation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunIncompleteReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunIncompleteReason value)
        {
            return value switch
            {
                AgentRunIncompleteReason.BudgetExhausted => "budget_exhausted",
                AgentRunIncompleteReason.MaxTurnsExhausted => "max_turns_exhausted",
                AgentRunIncompleteReason.OutputSchemaViolation => "output_schema_violation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunIncompleteReason? ToEnum(string value)
        {
            return value switch
            {
                "budget_exhausted" => AgentRunIncompleteReason.BudgetExhausted,
                "max_turns_exhausted" => AgentRunIncompleteReason.MaxTurnsExhausted,
                "output_schema_violation" => AgentRunIncompleteReason.OutputSchemaViolation,
                _ => null,
            };
        }
    }
}