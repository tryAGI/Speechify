
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional override for the streaming-STT stack this agent<br/>
    /// dispatches with. Null means use the worker's default<br/>
    /// stack (today: whisper-v3, Baseten Whisper Large V3). Pick<br/>
    /// `whisper-v3` to pin Whisper Large V3 explicitly, `flux` to<br/>
    /// opt into Deepgram Flux's semantic end-of-turn detection, or<br/>
    /// `gpt-realtime-whisper` for OpenAI's streaming Whisper-class<br/>
    /// STT.
    /// </summary>
    public enum TtsAgentSttOverride
    {
        /// <summary>
        /// 
        /// </summary>
        Flux,
        /// <summary>
        /// 
        /// </summary>
        GptRealtimeWhisper,
        /// <summary>
        /// whisper-v3, Baseten Whisper Large V3). Pick
        /// </summary>
        WhisperV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsAgentSttOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAgentSttOverride value)
        {
            return value switch
            {
                TtsAgentSttOverride.Flux => "flux",
                TtsAgentSttOverride.GptRealtimeWhisper => "gpt-realtime-whisper",
                TtsAgentSttOverride.WhisperV3 => "whisper-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAgentSttOverride? ToEnum(string value)
        {
            return value switch
            {
                "flux" => TtsAgentSttOverride.Flux,
                "gpt-realtime-whisper" => TtsAgentSttOverride.GptRealtimeWhisper,
                "whisper-v3" => TtsAgentSttOverride.WhisperV3,
                _ => null,
            };
        }
    }
}