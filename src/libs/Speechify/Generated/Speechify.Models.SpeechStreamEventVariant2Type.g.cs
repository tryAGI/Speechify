
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechStreamEventVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechStreamEventVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStreamEventVariant2Type value)
        {
            return value switch
            {
                SpeechStreamEventVariant2Type.SpeechDone => "speech.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStreamEventVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "speech.done" => SpeechStreamEventVariant2Type.SpeechDone,
                _ => null,
            };
        }
    }
}