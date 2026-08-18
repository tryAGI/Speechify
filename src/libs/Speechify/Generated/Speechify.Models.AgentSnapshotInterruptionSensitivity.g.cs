
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Interruption-sensitivity level the call ran under; null = the platform default.
    /// </summary>
    public enum AgentSnapshotInterruptionSensitivity
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSnapshotInterruptionSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSnapshotInterruptionSensitivity value)
        {
            return value switch
            {
                AgentSnapshotInterruptionSensitivity.High => "high",
                AgentSnapshotInterruptionSensitivity.Low => "low",
                AgentSnapshotInterruptionSensitivity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSnapshotInterruptionSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentSnapshotInterruptionSensitivity.High,
                "low" => AgentSnapshotInterruptionSensitivity.Low,
                "medium" => AgentSnapshotInterruptionSensitivity.Medium,
                _ => null,
            };
        }
    }
}