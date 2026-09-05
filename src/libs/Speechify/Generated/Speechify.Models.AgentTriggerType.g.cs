
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTriggerType
    {
        /// <summary>
        ///
        /// </summary>
        Schedule,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTriggerType value)
        {
            return value switch
            {
                AgentTriggerType.Schedule => "schedule",
                AgentTriggerType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => AgentTriggerType.Schedule,
                "webhook" => AgentTriggerType.Webhook,
                _ => null,
            };
        }
    }
}