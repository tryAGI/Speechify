
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Overall sentiment classification.
    /// </summary>
    public enum SimulationResultSentiment
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
    public static class SimulationResultSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationResultSentiment value)
        {
            return value switch
            {
                SimulationResultSentiment.Negative => "negative",
                SimulationResultSentiment.Neutral => "neutral",
                SimulationResultSentiment.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationResultSentiment? ToEnum(string value)
        {
            return value switch
            {
                "negative" => SimulationResultSentiment.Negative,
                "neutral" => SimulationResultSentiment.Neutral,
                "positive" => SimulationResultSentiment.Positive,
                _ => null,
            };
        }
    }
}