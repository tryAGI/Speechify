
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The format for the output audio. Note, that the current default is "wav", but there's no guarantee it will not change in the future. We recommend always passing the specific param you expect.<br/>
    /// Default Value: wav
    /// </summary>
    public enum TtsGetSpeechRequestAudioFormat
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
    public static class TtsGetSpeechRequestAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsGetSpeechRequestAudioFormat value)
        {
            return value switch
            {
                TtsGetSpeechRequestAudioFormat.Aac => "aac",
                TtsGetSpeechRequestAudioFormat.Mp3 => "mp3",
                TtsGetSpeechRequestAudioFormat.Ogg => "ogg",
                TtsGetSpeechRequestAudioFormat.Pcm => "pcm",
                TtsGetSpeechRequestAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsGetSpeechRequestAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac" => TtsGetSpeechRequestAudioFormat.Aac,
                "mp3" => TtsGetSpeechRequestAudioFormat.Mp3,
                "ogg" => TtsGetSpeechRequestAudioFormat.Ogg,
                "pcm" => TtsGetSpeechRequestAudioFormat.Pcm,
                "wav" => TtsGetSpeechRequestAudioFormat.Wav,
                _ => null,
            };
        }
    }
}