
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsWidgetConfigTheme
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Dark,
        /// <summary>
        /// 
        /// </summary>
        Light,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsWidgetConfigThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsWidgetConfigTheme value)
        {
            return value switch
            {
                TtsWidgetConfigTheme.Auto => "auto",
                TtsWidgetConfigTheme.Dark => "dark",
                TtsWidgetConfigTheme.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsWidgetConfigTheme? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TtsWidgetConfigTheme.Auto,
                "dark" => TtsWidgetConfigTheme.Dark,
                "light" => TtsWidgetConfigTheme.Light,
                _ => null,
            };
        }
    }
}