
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Where the run stands. On `run.ended` it is one of `succeeded`, `failed`, `canceled` or `expired`; on `run.updated` it never is.
    /// </summary>
    public enum AgentRunLifecycleStatus
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
    public static class AgentRunLifecycleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunLifecycleStatus value)
        {
            return value switch
            {
                AgentRunLifecycleStatus.Canceled => "canceled",
                AgentRunLifecycleStatus.Canceling => "canceling",
                AgentRunLifecycleStatus.Expired => "expired",
                AgentRunLifecycleStatus.Failed => "failed",
                AgentRunLifecycleStatus.Queued => "queued",
                AgentRunLifecycleStatus.RequiresAction => "requires_action",
                AgentRunLifecycleStatus.Running => "running",
                AgentRunLifecycleStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunLifecycleStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AgentRunLifecycleStatus.Canceled,
                "canceling" => AgentRunLifecycleStatus.Canceling,
                "expired" => AgentRunLifecycleStatus.Expired,
                "failed" => AgentRunLifecycleStatus.Failed,
                "queued" => AgentRunLifecycleStatus.Queued,
                "requires_action" => AgentRunLifecycleStatus.RequiresAction,
                "running" => AgentRunLifecycleStatus.Running,
                "succeeded" => AgentRunLifecycleStatus.Succeeded,
                _ => null,
            };
        }
    }
}