
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum WidgetConfigTheme
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
    public static class WidgetConfigThemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetConfigTheme value)
        {
            return value switch
            {
                WidgetConfigTheme.Auto => "auto",
                WidgetConfigTheme.Dark => "dark",
                WidgetConfigTheme.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetConfigTheme? ToEnum(string value)
        {
            return value switch
            {
                "auto" => WidgetConfigTheme.Auto,
                "dark" => WidgetConfigTheme.Dark,
                "light" => WidgetConfigTheme.Light,
                _ => null,
            };
        }
    }
}