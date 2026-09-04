
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRunStreamEventVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        RunStepAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStreamEventVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStreamEventVariant1Type value)
        {
            return value switch
            {
                AgentRunStreamEventVariant1Type.RunStepAdded => "run.step.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStreamEventVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "run.step.added" => AgentRunStreamEventVariant1Type.RunStepAdded,
                _ => null,
            };
        }
    }
}