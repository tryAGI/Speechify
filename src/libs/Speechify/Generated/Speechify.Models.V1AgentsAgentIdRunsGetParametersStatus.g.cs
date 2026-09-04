
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum V1AgentsAgentIdRunsGetParametersStatus
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
    public static class V1AgentsAgentIdRunsGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AgentsAgentIdRunsGetParametersStatus value)
        {
            return value switch
            {
                V1AgentsAgentIdRunsGetParametersStatus.Canceled => "canceled",
                V1AgentsAgentIdRunsGetParametersStatus.Failed => "failed",
                V1AgentsAgentIdRunsGetParametersStatus.Queued => "queued",
                V1AgentsAgentIdRunsGetParametersStatus.RequiresAction => "requires_action",
                V1AgentsAgentIdRunsGetParametersStatus.Running => "running",
                V1AgentsAgentIdRunsGetParametersStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AgentsAgentIdRunsGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => V1AgentsAgentIdRunsGetParametersStatus.Canceled,
                "failed" => V1AgentsAgentIdRunsGetParametersStatus.Failed,
                "queued" => V1AgentsAgentIdRunsGetParametersStatus.Queued,
                "requires_action" => V1AgentsAgentIdRunsGetParametersStatus.RequiresAction,
                "running" => V1AgentsAgentIdRunsGetParametersStatus.Running,
                "succeeded" => V1AgentsAgentIdRunsGetParametersStatus.Succeeded,
                _ => null,
            };
        }
    }
}