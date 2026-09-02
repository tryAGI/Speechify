
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The state the child settled in, present on the `observation` step that folded its result back. Absent on the `delegation` step, where the child has not settled yet.
    /// </summary>
    public enum RunStepDelegationChildStatus
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
    public static class RunStepDelegationChildStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDelegationChildStatus value)
        {
            return value switch
            {
                RunStepDelegationChildStatus.Canceled => "canceled",
                RunStepDelegationChildStatus.Canceling => "canceling",
                RunStepDelegationChildStatus.Expired => "expired",
                RunStepDelegationChildStatus.Failed => "failed",
                RunStepDelegationChildStatus.Queued => "queued",
                RunStepDelegationChildStatus.RequiresAction => "requires_action",
                RunStepDelegationChildStatus.Running => "running",
                RunStepDelegationChildStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDelegationChildStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => RunStepDelegationChildStatus.Canceled,
                "canceling" => RunStepDelegationChildStatus.Canceling,
                "expired" => RunStepDelegationChildStatus.Expired,
                "failed" => RunStepDelegationChildStatus.Failed,
                "queued" => RunStepDelegationChildStatus.Queued,
                "requires_action" => RunStepDelegationChildStatus.RequiresAction,
                "running" => RunStepDelegationChildStatus.Running,
                "succeeded" => RunStepDelegationChildStatus.Succeeded,
                _ => null,
            };
        }
    }
}