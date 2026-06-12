
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsWidgetConfigStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Fab,
        /// <summary>
        /// 
        /// </summary>
        Pill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsWidgetConfigStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsWidgetConfigStyle value)
        {
            return value switch
            {
                TtsWidgetConfigStyle.Fab => "fab",
                TtsWidgetConfigStyle.Pill => "pill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsWidgetConfigStyle? ToEnum(string value)
        {
            return value switch
            {
                "fab" => TtsWidgetConfigStyle.Fab,
                "pill" => TtsWidgetConfigStyle.Pill,
                _ => null,
            };
        }
    }
}