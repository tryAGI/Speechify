
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1AudioStreamPostParametersAccept
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
    public static class V1AudioStreamPostParametersAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AudioStreamPostParametersAccept value)
        {
            return value switch
            {
                V1AudioStreamPostParametersAccept.AudioAac => "audio/aac",
                V1AudioStreamPostParametersAccept.AudioMpeg => "audio/mpeg",
                V1AudioStreamPostParametersAccept.AudioOgg => "audio/ogg",
                V1AudioStreamPostParametersAccept.AudioPcm => "audio/pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AudioStreamPostParametersAccept? ToEnum(string value)
        {
            return value switch
            {
                "audio/aac" => V1AudioStreamPostParametersAccept.AudioAac,
                "audio/mpeg" => V1AudioStreamPostParametersAccept.AudioMpeg,
                "audio/ogg" => V1AudioStreamPostParametersAccept.AudioOgg,
                "audio/pcm" => V1AudioStreamPostParametersAccept.AudioPcm,
                _ => null,
            };
        }
    }
}