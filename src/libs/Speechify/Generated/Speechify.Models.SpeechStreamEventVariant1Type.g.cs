
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechStreamEventVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        SpeechChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechStreamEventVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStreamEventVariant1Type value)
        {
            return value switch
            {
                SpeechStreamEventVariant1Type.SpeechChunk => "speech.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStreamEventVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "speech.chunk" => SpeechStreamEventVariant1Type.SpeechChunk,
                _ => null,
            };
        }
    }
}