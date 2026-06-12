
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Overall sentiment classification.
    /// </summary>
    public enum TtsSimulationResultSentiment
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsSimulationResultSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSimulationResultSentiment value)
        {
            return value switch
            {
                TtsSimulationResultSentiment.Negative => "negative",
                TtsSimulationResultSentiment.Neutral => "neutral",
                TtsSimulationResultSentiment.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSimulationResultSentiment? ToEnum(string value)
        {
            return value switch
            {
                "negative" => TtsSimulationResultSentiment.Negative,
                "neutral" => TtsSimulationResultSentiment.Neutral,
                "positive" => TtsSimulationResultSentiment.Positive,
                _ => null,
            };
        }
    }
}