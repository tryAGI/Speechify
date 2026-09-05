
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The fire's dispatch status.
    /// </summary>
    public enum AgentTriggerFireResponseStatus
    {
        /// <summary>
        ///
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
    public static class AgentTriggerFireResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTriggerFireResponseStatus value)
        {
            return value switch
            {
                AgentTriggerFireResponseStatus.Dispatched => "dispatched",
                AgentTriggerFireResponseStatus.Failed => "failed",
                AgentTriggerFireResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTriggerFireResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "dispatched" => AgentTriggerFireResponseStatus.Dispatched,
                "failed" => AgentTriggerFireResponseStatus.Failed,
                "pending" => AgentTriggerFireResponseStatus.Pending,
                _ => null,
            };
        }
    }
}