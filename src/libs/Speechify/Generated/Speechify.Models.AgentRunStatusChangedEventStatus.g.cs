
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentRunStatusChangedEventStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Canceling,
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
        Queued,
        /// <summary>
        ///
        /// </summary>
        RequiresAction,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStatusChangedEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStatusChangedEventStatus value)
        {
            return value switch
            {
                AgentRunStatusChangedEventStatus.Canceled => "canceled",
                AgentRunStatusChangedEventStatus.Canceling => "canceling",
                AgentRunStatusChangedEventStatus.Expired => "expired",
                AgentRunStatusChangedEventStatus.Failed => "failed",
                AgentRunStatusChangedEventStatus.Queued => "queued",
                AgentRunStatusChangedEventStatus.RequiresAction => "requires_action",
                AgentRunStatusChangedEventStatus.Running => "running",
                AgentRunStatusChangedEventStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStatusChangedEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AgentRunStatusChangedEventStatus.Canceled,
                "canceling" => AgentRunStatusChangedEventStatus.Canceling,
                "expired" => AgentRunStatusChangedEventStatus.Expired,
                "failed" => AgentRunStatusChangedEventStatus.Failed,
                "queued" => AgentRunStatusChangedEventStatus.Queued,
                "requires_action" => AgentRunStatusChangedEventStatus.RequiresAction,
                "running" => AgentRunStatusChangedEventStatus.Running,
                "succeeded" => AgentRunStatusChangedEventStatus.Succeeded,
                _ => null,
            };
        }
    }
}