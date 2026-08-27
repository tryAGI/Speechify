
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum SimulationMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationMessageRole value)
        {
            return value switch
            {
                SimulationMessageRole.Assistant => "assistant",
                SimulationMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => SimulationMessageRole.Assistant,
                "user" => SimulationMessageRole.User,
                _ => null,
            };
        }
    }
}