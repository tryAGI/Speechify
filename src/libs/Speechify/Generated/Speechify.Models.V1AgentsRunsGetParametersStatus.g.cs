
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum V1AgentsRunsGetParametersStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
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
    public static class V1AgentsRunsGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AgentsRunsGetParametersStatus value)
        {
            return value switch
            {
                V1AgentsRunsGetParametersStatus.Canceled => "canceled",
                V1AgentsRunsGetParametersStatus.Failed => "failed",
                V1AgentsRunsGetParametersStatus.Queued => "queued",
                V1AgentsRunsGetParametersStatus.RequiresAction => "requires_action",
                V1AgentsRunsGetParametersStatus.Running => "running",
                V1AgentsRunsGetParametersStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AgentsRunsGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => V1AgentsRunsGetParametersStatus.Canceled,
                "failed" => V1AgentsRunsGetParametersStatus.Failed,
                "queued" => V1AgentsRunsGetParametersStatus.Queued,
                "requires_action" => V1AgentsRunsGetParametersStatus.RequiresAction,
                "running" => V1AgentsRunsGetParametersStatus.Running,
                "succeeded" => V1AgentsRunsGetParametersStatus.Succeeded,
                _ => null,
            };
        }
    }
}