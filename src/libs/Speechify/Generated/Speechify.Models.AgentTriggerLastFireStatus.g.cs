
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The outcome of the most recent fire: `dispatched` with a run,<br/>
    /// `failed` with the reason in `last_fire_error`, or `pending` while a<br/>
    /// transient failure waits for its retry. Absent until the trigger has<br/>
    /// fired once. A `failed` trigger stays `failed` until a later fire<br/>
    /// succeeds; `trigger.fire_failed` is delivered each time.
    /// </summary>
    public enum AgentTriggerLastFireStatus
    {
        /// <summary>
        /// `dispatched` with a run,
        /// </summary>
        Dispatched,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTriggerLastFireStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTriggerLastFireStatus value)
        {
            return value switch
            {
                AgentTriggerLastFireStatus.Dispatched => "dispatched",
                AgentTriggerLastFireStatus.Failed => "failed",
                AgentTriggerLastFireStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTriggerLastFireStatus? ToEnum(string value)
        {
            return value switch
            {
                "dispatched" => AgentTriggerLastFireStatus.Dispatched,
                "failed" => AgentTriggerLastFireStatus.Failed,
                "pending" => AgentTriggerLastFireStatus.Pending,
                _ => null,
            };
        }
    }
}