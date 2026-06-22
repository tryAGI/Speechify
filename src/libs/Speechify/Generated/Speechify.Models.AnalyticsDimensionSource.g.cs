
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Where the dimension comes from, used to group the picker.
    /// </summary>
    public enum AnalyticsDimensionSource
    {
        /// <summary>
        /// 
        /// </summary>
        Conversation,
        /// <summary>
        /// 
        /// </summary>
        DataField,
        /// <summary>
        /// 
        /// </summary>
        Evaluation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsDimensionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsDimensionSource value)
        {
            return value switch
            {
                AnalyticsDimensionSource.Conversation => "conversation",
                AnalyticsDimensionSource.DataField => "data_field",
                AnalyticsDimensionSource.Evaluation => "evaluation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsDimensionSource? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => AnalyticsDimensionSource.Conversation,
                "data_field" => AnalyticsDimensionSource.DataField,
                "evaluation" => AnalyticsDimensionSource.Evaluation,
                _ => null,
            };
        }
    }
}