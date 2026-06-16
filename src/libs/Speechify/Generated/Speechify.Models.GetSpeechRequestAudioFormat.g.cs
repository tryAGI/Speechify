
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The format for the output audio. Note, that the current default is "wav", but there's no guarantee it will not change in the future. We recommend always passing the specific param you expect.<br/>
    /// Default Value: wav
    /// </summary>
    public enum GetSpeechRequestAudioFormat
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
    public static class GetSpeechRequestAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechRequestAudioFormat value)
        {
            return value switch
            {
                GetSpeechRequestAudioFormat.Aac => "aac",
                GetSpeechRequestAudioFormat.Mp3 => "mp3",
                GetSpeechRequestAudioFormat.Ogg => "ogg",
                GetSpeechRequestAudioFormat.Pcm => "pcm",
                GetSpeechRequestAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechRequestAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac" => GetSpeechRequestAudioFormat.Aac,
                "mp3" => GetSpeechRequestAudioFormat.Mp3,
                "ogg" => GetSpeechRequestAudioFormat.Ogg,
                "pcm" => GetSpeechRequestAudioFormat.Pcm,
                "wav" => GetSpeechRequestAudioFormat.Wav,
                _ => null,
            };
        }
    }
}