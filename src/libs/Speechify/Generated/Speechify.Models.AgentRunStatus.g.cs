
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Lifecycle: `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
    /// </summary>
    public enum AgentRunStatus
    {
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        Canceled,
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        Canceling,
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        Expired,
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        Failed,
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        Queued,
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        RequiresAction,
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        Running,
        /// <summary>
        /// `queued` -&gt; `running` -&gt; `succeeded` | `failed` | `canceled` | `expired`. `requires_action` (a pending human approval) and `canceling` are transient. Terminal set: succeeded, failed, canceled, expired.
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStatus value)
        {
            return value switch
            {
                AgentRunStatus.Canceled => "canceled",
                AgentRunStatus.Canceling => "canceling",
                AgentRunStatus.Expired => "expired",
                AgentRunStatus.Failed => "failed",
                AgentRunStatus.Queued => "queued",
                AgentRunStatus.RequiresAction => "requires_action",
                AgentRunStatus.Running => "running",
                AgentRunStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AgentRunStatus.Canceled,
                "canceling" => AgentRunStatus.Canceling,
                "expired" => AgentRunStatus.Expired,
                "failed" => AgentRunStatus.Failed,
                "queued" => AgentRunStatus.Queued,
                "requires_action" => AgentRunStatus.RequiresAction,
                "running" => AgentRunStatus.Running,
                "succeeded" => AgentRunStatus.Succeeded,
                _ => null,
            };
        }
    }
}