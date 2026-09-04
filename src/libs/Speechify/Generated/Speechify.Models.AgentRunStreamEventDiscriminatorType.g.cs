
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRunStreamEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        RunEnded,
        /// <summary>
        ///
        /// </summary>
        RunStatusChanged,
        /// <summary>
        ///
        /// </summary>
        RunStepAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStreamEventDiscriminatorType value)
        {
            return value switch
            {
                AgentRunStreamEventDiscriminatorType.RunEnded => "run.ended",
                AgentRunStreamEventDiscriminatorType.RunStatusChanged => "run.status.changed",
                AgentRunStreamEventDiscriminatorType.RunStepAdded => "run.step.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "run.ended" => AgentRunStreamEventDiscriminatorType.RunEnded,
                "run.status.changed" => AgentRunStreamEventDiscriminatorType.RunStatusChanged,
                "run.step.added" => AgentRunStreamEventDiscriminatorType.RunStepAdded,
                _ => null,
            };
        }
    }
}