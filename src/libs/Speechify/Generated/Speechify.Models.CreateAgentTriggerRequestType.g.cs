
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentTriggerRequestType
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
    public static class CreateAgentTriggerRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentTriggerRequestType value)
        {
            return value switch
            {
                CreateAgentTriggerRequestType.Schedule => "schedule",
                CreateAgentTriggerRequestType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentTriggerRequestType? ToEnum(string value)
        {
            return value switch
            {
                "schedule" => CreateAgentTriggerRequestType.Schedule,
                "webhook" => CreateAgentTriggerRequestType.Webhook,
                _ => null,
            };
        }
    }
}