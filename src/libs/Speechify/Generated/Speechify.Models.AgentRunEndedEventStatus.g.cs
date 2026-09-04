
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRunEndedEventStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunEndedEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunEndedEventStatus value)
        {
            return value switch
            {
                AgentRunEndedEventStatus.Canceled => "canceled",
                AgentRunEndedEventStatus.Expired => "expired",
                AgentRunEndedEventStatus.Failed => "failed",
                AgentRunEndedEventStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunEndedEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AgentRunEndedEventStatus.Canceled,
                "expired" => AgentRunEndedEventStatus.Expired,
                "failed" => AgentRunEndedEventStatus.Failed,
                "succeeded" => AgentRunEndedEventStatus.Succeeded,
                _ => null,
            };
        }
    }
}