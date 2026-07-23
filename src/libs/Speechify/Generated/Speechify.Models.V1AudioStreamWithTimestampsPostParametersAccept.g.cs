
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1AudioStreamWithTimestampsPostParametersAccept
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
    public static class V1AudioStreamWithTimestampsPostParametersAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1AudioStreamWithTimestampsPostParametersAccept value)
        {
            return value switch
            {
                V1AudioStreamWithTimestampsPostParametersAccept.AudioAac => "audio/aac",
                V1AudioStreamWithTimestampsPostParametersAccept.AudioMpeg => "audio/mpeg",
                V1AudioStreamWithTimestampsPostParametersAccept.AudioOgg => "audio/ogg",
                V1AudioStreamWithTimestampsPostParametersAccept.AudioPcm => "audio/pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1AudioStreamWithTimestampsPostParametersAccept? ToEnum(string value)
        {
            return value switch
            {
                "audio/aac" => V1AudioStreamWithTimestampsPostParametersAccept.AudioAac,
                "audio/mpeg" => V1AudioStreamWithTimestampsPostParametersAccept.AudioMpeg,
                "audio/ogg" => V1AudioStreamWithTimestampsPostParametersAccept.AudioOgg,
                "audio/pcm" => V1AudioStreamWithTimestampsPostParametersAccept.AudioPcm,
                _ => null,
            };
        }
    }
}