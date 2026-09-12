
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The outcome of the most recent fire: `dispatched` with a run,<br/>
    /// `failed` with the reason in `last_fire_error`, or `pending` while a<br/>
    /// transient failure waits for its retry. Absent until the trigger has<br/>
    /// fired once. A `failed` trigger stays `failed` until a later fire<br/>
    /// succeeds; `trigger.fire_failed` is delivered each time.<br/>
    /// A standing watch (a trigger with `thread`) settles one step further<br/>
    /// once its run finishes: `posted` when the run reported and the<br/>
    /// report reached the thread, `silent` when it concluded there was<br/>
    /// nothing to report and posted nothing. A watch whose run failed, or<br/>
    /// whose thread is gone, reads `failed` with the reason.
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
        /// <summary>
        /// `posted` when the run reported and the
        /// </summary>
        Posted,
        /// <summary>
        ///
        /// </summary>
        Silent,
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
                AgentTriggerLastFireStatus.Posted => "posted",
                AgentTriggerLastFireStatus.Silent => "silent",
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
                "posted" => AgentTriggerLastFireStatus.Posted,
                "silent" => AgentTriggerLastFireStatus.Silent,
                _ => null,
            };
        }
    }
}