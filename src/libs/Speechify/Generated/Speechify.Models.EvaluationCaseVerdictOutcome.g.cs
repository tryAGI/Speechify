
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `errored` = the run could not complete, so the behaviour was not judged (distinct from `failed`).
    /// </summary>
    public enum EvaluationCaseVerdictOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Errored,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Passed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationCaseVerdictOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationCaseVerdictOutcome value)
        {
            return value switch
            {
                EvaluationCaseVerdictOutcome.Errored => "errored",
                EvaluationCaseVerdictOutcome.Failed => "failed",
                EvaluationCaseVerdictOutcome.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationCaseVerdictOutcome? ToEnum(string value)
        {
            return value switch
            {
                "errored" => EvaluationCaseVerdictOutcome.Errored,
                "failed" => EvaluationCaseVerdictOutcome.Failed,
                "passed" => EvaluationCaseVerdictOutcome.Passed,
                _ => null,
            };
        }
    }
}