
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum EvaluationKind
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
    public static class EvaluationKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationKind value)
        {
            return value switch
            {
                EvaluationKind.Criterion => "criterion",
                EvaluationKind.Data => "data",
                EvaluationKind.Summary => "summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationKind? ToEnum(string value)
        {
            return value switch
            {
                "criterion" => EvaluationKind.Criterion,
                "data" => EvaluationKind.Data,
                "summary" => EvaluationKind.Summary,
                _ => null,
            };
        }
    }
}