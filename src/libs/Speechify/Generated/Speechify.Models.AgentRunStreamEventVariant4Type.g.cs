
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRunStreamEventVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        RunEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStreamEventVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStreamEventVariant4Type value)
        {
            return value switch
            {
                AgentRunStreamEventVariant4Type.RunEnded => "run.ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStreamEventVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "run.ended" => AgentRunStreamEventVariant4Type.RunEnded,
                _ => null,
            };
        }
    }
}