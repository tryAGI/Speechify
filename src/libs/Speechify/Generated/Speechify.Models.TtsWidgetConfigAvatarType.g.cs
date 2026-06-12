
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsWidgetConfigAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Orb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsWidgetConfigAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsWidgetConfigAvatarType value)
        {
            return value switch
            {
                TtsWidgetConfigAvatarType.Image => "image",
                TtsWidgetConfigAvatarType.Orb => "orb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsWidgetConfigAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "image" => TtsWidgetConfigAvatarType.Image,
                "orb" => TtsWidgetConfigAvatarType.Orb,
                _ => null,
            };
        }
    }
}