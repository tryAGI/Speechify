
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsCreatedVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Personal,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsCreatedVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreatedVoiceType value)
        {
            return value switch
            {
                TtsCreatedVoiceType.Personal => "personal",
                TtsCreatedVoiceType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreatedVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "personal" => TtsCreatedVoiceType.Personal,
                "shared" => TtsCreatedVoiceType.Shared,
                _ => null,
            };
        }
    }
}