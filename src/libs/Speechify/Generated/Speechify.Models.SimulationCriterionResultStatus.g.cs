
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Three-state outcome. `unknown` means the criterion did not<br/>
    /// apply on this run (the topic never came up); `failure`<br/>
    /// means it did apply and the agent did not satisfy it.
    /// </summary>
    public enum SimulationCriterionResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
        /// <summary>
        ///
        /// </summary>
        Success,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationCriterionResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationCriterionResultStatus value)
        {
            return value switch
            {
                SimulationCriterionResultStatus.Failure => "failure",
                SimulationCriterionResultStatus.Success => "success",
                SimulationCriterionResultStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationCriterionResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => SimulationCriterionResultStatus.Failure,
                "success" => SimulationCriterionResultStatus.Success,
                "unknown" => SimulationCriterionResultStatus.Unknown,
                _ => null,
            };
        }
    }
}