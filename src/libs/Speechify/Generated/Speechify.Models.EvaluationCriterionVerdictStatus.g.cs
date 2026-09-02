
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `unknown` = the condition did not apply to this run (distinct from `failure`).
    /// </summary>
    public enum EvaluationCriterionVerdictStatus
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
    public static class EvaluationCriterionVerdictStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationCriterionVerdictStatus value)
        {
            return value switch
            {
                EvaluationCriterionVerdictStatus.Failure => "failure",
                EvaluationCriterionVerdictStatus.Success => "success",
                EvaluationCriterionVerdictStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationCriterionVerdictStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => EvaluationCriterionVerdictStatus.Failure,
                "success" => EvaluationCriterionVerdictStatus.Success,
                "unknown" => EvaluationCriterionVerdictStatus.Unknown,
                _ => null,
            };
        }
    }
}