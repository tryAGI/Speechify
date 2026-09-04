
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRunStreamEventVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        RunEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStreamEventVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStreamEventVariant3Type value)
        {
            return value switch
            {
                AgentRunStreamEventVariant3Type.RunEnded => "run.ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStreamEventVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "run.ended" => AgentRunStreamEventVariant3Type.RunEnded,
                _ => null,
            };
        }
    }
}