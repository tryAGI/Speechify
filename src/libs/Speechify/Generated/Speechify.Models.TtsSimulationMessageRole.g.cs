
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsSimulationMessageRole
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
    public static class TtsSimulationMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSimulationMessageRole value)
        {
            return value switch
            {
                TtsSimulationMessageRole.Assistant => "assistant",
                TtsSimulationMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSimulationMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => TtsSimulationMessageRole.Assistant,
                "user" => TtsSimulationMessageRole.User,
                _ => null,
            };
        }
    }
}