
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The format of the audio data
    /// </summary>
    public enum TtsGetSpeechResponseAudioFormat
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
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsGetSpeechResponseAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsGetSpeechResponseAudioFormat value)
        {
            return value switch
            {
                TtsGetSpeechResponseAudioFormat.Aac => "aac",
                TtsGetSpeechResponseAudioFormat.Mp3 => "mp3",
                TtsGetSpeechResponseAudioFormat.Ogg => "ogg",
                TtsGetSpeechResponseAudioFormat.Pcm => "pcm",
                TtsGetSpeechResponseAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsGetSpeechResponseAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac" => TtsGetSpeechResponseAudioFormat.Aac,
                "mp3" => TtsGetSpeechResponseAudioFormat.Mp3,
                "ogg" => TtsGetSpeechResponseAudioFormat.Ogg,
                "pcm" => TtsGetSpeechResponseAudioFormat.Pcm,
                "wav" => TtsGetSpeechResponseAudioFormat.Wav,
                _ => null,
            };
        }
    }
}