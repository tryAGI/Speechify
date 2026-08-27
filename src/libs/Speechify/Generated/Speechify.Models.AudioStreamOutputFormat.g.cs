
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Audio output format for the streaming endpoint (`POST /v1/audio/stream`), as a `codec_sampleRate_bitrate` string. Same as `AudioOutputFormat` minus the `wav_*` formats: wav is only available on `POST /v1/audio/speech`. `pcm_*` and `ulaw_8000` are headerless raw audio; `pcm_16000` and `ulaw_8000` are the telephony formats Twilio/LiveKit SIP expect.<br/>
    /// 160 kbps is the highest bitrate an mp3 can carry at 22.05 and 24 kHz, so `mp3_22050_160` and `mp3_24000_160` are the maximum-fidelity mp3 formats; a request for `mp3_*_192` is encoded at 160 kbps. The two `mp3_*_160` formats are served by the Simba 3 models only.
    /// </summary>
    public enum AudioStreamOutputFormat
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
        Mp322050160,
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
        Mp324000160,
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
        /// wav is only available on `POST /v1/audio/speech`. `pcm_*` and `ulaw_8000` are headerless raw audio; `pcm_16000` and `ulaw_8000` are the telephony formats Twilio/LiveKit SIP expect.
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
        /// wav is only available on `POST /v1/audio/speech`. `pcm_*` and `ulaw_8000` are headerless raw audio; `pcm_16000` and `ulaw_8000` are the telephony formats Twilio/LiveKit SIP expect.
        /// </summary>
        Ulaw8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioStreamOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioStreamOutputFormat value)
        {
            return value switch
            {
                AudioStreamOutputFormat.Aac24000 => "aac_24000",
                AudioStreamOutputFormat.Mp322050128 => "mp3_22050_128",
                AudioStreamOutputFormat.Mp322050160 => "mp3_22050_160",
                AudioStreamOutputFormat.Mp322050192 => "mp3_22050_192",
                AudioStreamOutputFormat.Mp32205032 => "mp3_22050_32",
                AudioStreamOutputFormat.Mp32205064 => "mp3_22050_64",
                AudioStreamOutputFormat.Mp32205096 => "mp3_22050_96",
                AudioStreamOutputFormat.Mp324000128 => "mp3_24000_128",
                AudioStreamOutputFormat.Mp324000160 => "mp3_24000_160",
                AudioStreamOutputFormat.Mp324000192 => "mp3_24000_192",
                AudioStreamOutputFormat.Mp32400032 => "mp3_24000_32",
                AudioStreamOutputFormat.Mp32400064 => "mp3_24000_64",
                AudioStreamOutputFormat.Mp32400096 => "mp3_24000_96",
                AudioStreamOutputFormat.Ogg24000 => "ogg_24000",
                AudioStreamOutputFormat.Pcm16000 => "pcm_16000",
                AudioStreamOutputFormat.Pcm22050 => "pcm_22050",
                AudioStreamOutputFormat.Pcm24000 => "pcm_24000",
                AudioStreamOutputFormat.Pcm44100 => "pcm_44100",
                AudioStreamOutputFormat.Pcm48000 => "pcm_48000",
                AudioStreamOutputFormat.Pcm8000 => "pcm_8000",
                AudioStreamOutputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioStreamOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac_24000" => AudioStreamOutputFormat.Aac24000,
                "mp3_22050_128" => AudioStreamOutputFormat.Mp322050128,
                "mp3_22050_160" => AudioStreamOutputFormat.Mp322050160,
                "mp3_22050_192" => AudioStreamOutputFormat.Mp322050192,
                "mp3_22050_32" => AudioStreamOutputFormat.Mp32205032,
                "mp3_22050_64" => AudioStreamOutputFormat.Mp32205064,
                "mp3_22050_96" => AudioStreamOutputFormat.Mp32205096,
                "mp3_24000_128" => AudioStreamOutputFormat.Mp324000128,
                "mp3_24000_160" => AudioStreamOutputFormat.Mp324000160,
                "mp3_24000_192" => AudioStreamOutputFormat.Mp324000192,
                "mp3_24000_32" => AudioStreamOutputFormat.Mp32400032,
                "mp3_24000_64" => AudioStreamOutputFormat.Mp32400064,
                "mp3_24000_96" => AudioStreamOutputFormat.Mp32400096,
                "ogg_24000" => AudioStreamOutputFormat.Ogg24000,
                "pcm_16000" => AudioStreamOutputFormat.Pcm16000,
                "pcm_22050" => AudioStreamOutputFormat.Pcm22050,
                "pcm_24000" => AudioStreamOutputFormat.Pcm24000,
                "pcm_44100" => AudioStreamOutputFormat.Pcm44100,
                "pcm_48000" => AudioStreamOutputFormat.Pcm48000,
                "pcm_8000" => AudioStreamOutputFormat.Pcm8000,
                "ulaw_8000" => AudioStreamOutputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}