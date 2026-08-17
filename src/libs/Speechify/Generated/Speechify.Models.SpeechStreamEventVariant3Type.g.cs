
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechStreamEventVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechStreamEventVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStreamEventVariant3Type value)
        {
            return value switch
            {
                SpeechStreamEventVariant3Type.SpeechError => "speech.error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStreamEventVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "speech.error" => SpeechStreamEventVariant3Type.SpeechError,
                _ => null,
            };
        }
    }
}