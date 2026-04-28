
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMessageRole value)
        {
            return value switch
            {
                TtsMessageRole.Assistant => "assistant",
                TtsMessageRole.System => "system",
                TtsMessageRole.Tool => "tool",
                TtsMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => TtsMessageRole.Assistant,
                "system" => TtsMessageRole.System,
                "tool" => TtsMessageRole.Tool,
                "user" => TtsMessageRole.User,
                _ => null,
            };
        }
    }
}