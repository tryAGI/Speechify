
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Three-state criterion result. `unknown` means the criterion did not apply to this call.
    /// </summary>
    public enum TtsEvaluationStatus
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
    public static class TtsEvaluationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsEvaluationStatus value)
        {
            return value switch
            {
                TtsEvaluationStatus.Failure => "failure",
                TtsEvaluationStatus.Success => "success",
                TtsEvaluationStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsEvaluationStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => TtsEvaluationStatus.Failure,
                "success" => TtsEvaluationStatus.Success,
                "unknown" => TtsEvaluationStatus.Unknown,
                _ => null,
            };
        }
    }
}