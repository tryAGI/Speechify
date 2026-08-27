
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The codec of the audio data
    /// </summary>
    public enum GetSpeechResponseAudioFormat
    {
        /// <summary>
        ///
        /// </summary>
        Aac,
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Ogg,
        /// <summary>
        ///
        /// </summary>
        Pcm,
        /// <summary>
        ///
        /// </summary>
        Ulaw,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpeechResponseAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechResponseAudioFormat value)
        {
            return value switch
            {
                GetSpeechResponseAudioFormat.Aac => "aac",
                GetSpeechResponseAudioFormat.Mp3 => "mp3",
                GetSpeechResponseAudioFormat.Ogg => "ogg",
                GetSpeechResponseAudioFormat.Pcm => "pcm",
                GetSpeechResponseAudioFormat.Ulaw => "ulaw",
                GetSpeechResponseAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechResponseAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac" => GetSpeechResponseAudioFormat.Aac,
                "mp3" => GetSpeechResponseAudioFormat.Mp3,
                "ogg" => GetSpeechResponseAudioFormat.Ogg,
                "pcm" => GetSpeechResponseAudioFormat.Pcm,
                "ulaw" => GetSpeechResponseAudioFormat.Ulaw,
                "wav" => GetSpeechResponseAudioFormat.Wav,
                _ => null,
            };
        }
    }
}