
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsEvaluationKind
    {
        /// <summary>
        /// 
        /// </summary>
        Criterion,
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
        Summary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsEvaluationKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsEvaluationKind value)
        {
            return value switch
            {
                TtsEvaluationKind.Criterion => "criterion",
                TtsEvaluationKind.Data => "data",
                TtsEvaluationKind.Summary => "summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsEvaluationKind? ToEnum(string value)
        {
            return value switch
            {
                "criterion" => TtsEvaluationKind.Criterion,
                "data" => TtsEvaluationKind.Data,
                "summary" => TtsEvaluationKind.Summary,
                _ => null,
            };
        }
    }
}