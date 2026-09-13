
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRunStreamEventVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        RunReplyDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStreamEventVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStreamEventVariant2Type value)
        {
            return value switch
            {
                AgentRunStreamEventVariant2Type.RunReplyDelta => "run.reply.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStreamEventVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "run.reply.delta" => AgentRunStreamEventVariant2Type.RunReplyDelta,
                _ => null,
            };
        }
    }
}