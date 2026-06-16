
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetConfigStyle
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
    public static class WidgetConfigStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigStyle value)
        {
            return value switch
            {
                WidgetConfigStyle.Fab => "fab",
                WidgetConfigStyle.Pill => "pill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigStyle? ToEnum(string value)
        {
            return value switch
            {
                "fab" => WidgetConfigStyle.Fab,
                "pill" => WidgetConfigStyle.Pill,
                _ => null,
            };
        }
    }
}