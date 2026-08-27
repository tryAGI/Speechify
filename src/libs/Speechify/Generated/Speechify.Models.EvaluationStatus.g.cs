
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Three-state criterion result. `unknown` means the criterion did not apply to this call.
    /// </summary>
    public enum EvaluationStatus
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
    public static class EvaluationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationStatus value)
        {
            return value switch
            {
                EvaluationStatus.Failure => "failure",
                EvaluationStatus.Success => "success",
                EvaluationStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => EvaluationStatus.Failure,
                "success" => EvaluationStatus.Success,
                "unknown" => EvaluationStatus.Unknown,
                _ => null,
            };
        }
    }
}