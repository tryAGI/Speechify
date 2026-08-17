
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechChunk,
        /// <summary>
        /// 
        /// </summary>
        SpeechDone,
        /// <summary>
        /// 
        /// </summary>
        SpeechError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStreamEventDiscriminatorType value)
        {
            return value switch
            {
                SpeechStreamEventDiscriminatorType.SpeechChunk => "speech.chunk",
                SpeechStreamEventDiscriminatorType.SpeechDone => "speech.done",
                SpeechStreamEventDiscriminatorType.SpeechError => "speech.error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "speech.chunk" => SpeechStreamEventDiscriminatorType.SpeechChunk,
                "speech.done" => SpeechStreamEventDiscriminatorType.SpeechDone,
                "speech.error" => SpeechStreamEventDiscriminatorType.SpeechError,
                _ => null,
            };
        }
    }
}