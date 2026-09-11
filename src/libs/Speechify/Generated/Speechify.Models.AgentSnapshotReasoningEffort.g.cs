
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The reasoning setting configured at conversation start; `none`<br/>
    /// when off. Records what was configured, not what dispatch served:<br/>
    /// a spoken turn runs without reasoning regardless.
    /// </summary>
    public enum AgentSnapshotReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSnapshotReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSnapshotReasoningEffort value)
        {
            return value switch
            {
                AgentSnapshotReasoningEffort.High => "high",
                AgentSnapshotReasoningEffort.Low => "low",
                AgentSnapshotReasoningEffort.Medium => "medium",
                AgentSnapshotReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSnapshotReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentSnapshotReasoningEffort.High,
                "low" => AgentSnapshotReasoningEffort.Low,
                "medium" => AgentSnapshotReasoningEffort.Medium,
                "none" => AgentSnapshotReasoningEffort.None,
                _ => null,
            };
        }
    }
}