
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsV1AudioStreamPostParametersAccept
    {
        /// <summary>
        /// 
        /// </summary>
        AudioAac,
        /// <summary>
        /// 
        /// </summary>
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        AudioOgg,
        /// <summary>
        /// 
        /// </summary>
        AudioPcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsV1AudioStreamPostParametersAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsV1AudioStreamPostParametersAccept value)
        {
            return value switch
            {
                TtsV1AudioStreamPostParametersAccept.AudioAac => "audio/aac",
                TtsV1AudioStreamPostParametersAccept.AudioMpeg => "audio/mpeg",
                TtsV1AudioStreamPostParametersAccept.AudioOgg => "audio/ogg",
                TtsV1AudioStreamPostParametersAccept.AudioPcm => "audio/pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsV1AudioStreamPostParametersAccept? ToEnum(string value)
        {
            return value switch
            {
                "audio/aac" => TtsV1AudioStreamPostParametersAccept.AudioAac,
                "audio/mpeg" => TtsV1AudioStreamPostParametersAccept.AudioMpeg,
                "audio/ogg" => TtsV1AudioStreamPostParametersAccept.AudioOgg,
                "audio/pcm" => TtsV1AudioStreamPostParametersAccept.AudioPcm,
                _ => null,
            };
        }
    }
}