
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Audio output format as a `codec_sampleRate_bitrate` string, giving explicit control over sample rate and bitrate. `pcm_*` and `ulaw_8000` are headerless raw audio; `pcm_16000` and `ulaw_8000` are the telephony formats Twilio/LiveKit SIP expect.
    /// </summary>
    public enum AudioOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Aac24000,
        /// <summary>
        /// 
        /// </summary>
        Mp322050128,
        /// <summary>
        /// 
        /// </summary>
        Mp322050192,
        /// <summary>
        /// 
        /// </summary>
        Mp32205032,
        /// <summary>
        /// 
        /// </summary>
        Mp32205064,
        /// <summary>
        /// 
        /// </summary>
        Mp32205096,
        /// <summary>
        /// 
        /// </summary>
        Mp324000128,
        /// <summary>
        /// 
        /// </summary>
        Mp324000192,
        /// <summary>
        /// 
        /// </summary>
        Mp32400032,
        /// <summary>
        /// 
        /// </summary>
        Mp32400064,
        /// <summary>
        /// 
        /// </summary>
        Mp32400096,
        /// <summary>
        /// 
        /// </summary>
        Ogg24000,
        /// <summary>
        /// 
        /// </summary>
        Pcm16000,
        /// <summary>
        /// 
        /// </summary>
        Pcm22050,
        /// <summary>
        /// 
        /// </summary>
        Pcm24000,
        /// <summary>
        /// 
        /// </summary>
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        Pcm48000,
        /// <summary>
        /// 
        /// </summary>
        Pcm8000,
        /// <summary>
        /// 
        /// </summary>
        Ulaw8000,
        /// <summary>
        /// 
        /// </summary>
        Wav24000,
        /// <summary>
        /// 
        /// </summary>
        Wav48000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioOutputFormat value)
        {
            return value switch
            {
                AudioOutputFormat.Aac24000 => "aac_24000",
                AudioOutputFormat.Mp322050128 => "mp3_22050_128",
                AudioOutputFormat.Mp322050192 => "mp3_22050_192",
                AudioOutputFormat.Mp32205032 => "mp3_22050_32",
                AudioOutputFormat.Mp32205064 => "mp3_22050_64",
                AudioOutputFormat.Mp32205096 => "mp3_22050_96",
                AudioOutputFormat.Mp324000128 => "mp3_24000_128",
                AudioOutputFormat.Mp324000192 => "mp3_24000_192",
                AudioOutputFormat.Mp32400032 => "mp3_24000_32",
                AudioOutputFormat.Mp32400064 => "mp3_24000_64",
                AudioOutputFormat.Mp32400096 => "mp3_24000_96",
                AudioOutputFormat.Ogg24000 => "ogg_24000",
                AudioOutputFormat.Pcm16000 => "pcm_16000",
                AudioOutputFormat.Pcm22050 => "pcm_22050",
                AudioOutputFormat.Pcm24000 => "pcm_24000",
                AudioOutputFormat.Pcm44100 => "pcm_44100",
                AudioOutputFormat.Pcm48000 => "pcm_48000",
                AudioOutputFormat.Pcm8000 => "pcm_8000",
                AudioOutputFormat.Ulaw8000 => "ulaw_8000",
                AudioOutputFormat.Wav24000 => "wav_24000",
                AudioOutputFormat.Wav48000 => "wav_48000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac_24000" => AudioOutputFormat.Aac24000,
                "mp3_22050_128" => AudioOutputFormat.Mp322050128,
                "mp3_22050_192" => AudioOutputFormat.Mp322050192,
                "mp3_22050_32" => AudioOutputFormat.Mp32205032,
                "mp3_22050_64" => AudioOutputFormat.Mp32205064,
                "mp3_22050_96" => AudioOutputFormat.Mp32205096,
                "mp3_24000_128" => AudioOutputFormat.Mp324000128,
                "mp3_24000_192" => AudioOutputFormat.Mp324000192,
                "mp3_24000_32" => AudioOutputFormat.Mp32400032,
                "mp3_24000_64" => AudioOutputFormat.Mp32400064,
                "mp3_24000_96" => AudioOutputFormat.Mp32400096,
                "ogg_24000" => AudioOutputFormat.Ogg24000,
                "pcm_16000" => AudioOutputFormat.Pcm16000,
                "pcm_22050" => AudioOutputFormat.Pcm22050,
                "pcm_24000" => AudioOutputFormat.Pcm24000,
                "pcm_44100" => AudioOutputFormat.Pcm44100,
                "pcm_48000" => AudioOutputFormat.Pcm48000,
                "pcm_8000" => AudioOutputFormat.Pcm8000,
                "ulaw_8000" => AudioOutputFormat.Ulaw8000,
                "wav_24000" => AudioOutputFormat.Wav24000,
                "wav_48000" => AudioOutputFormat.Wav48000,
                _ => null,
            };
        }
    }
}