
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Streaming-STT stack override. Send an empty string ("") to<br/>
    /// clear the override and fall back to the worker default<br/>
    /// (today: whisper-v3). Any non-empty value must be a known<br/>
    /// stack name.
    /// </summary>
    public enum TtsUpdateAgentRequestSttOverride
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
        /// whisper-v3). Any non-empty value must be a known
        /// </summary>
        WhisperV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsUpdateAgentRequestSttOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsUpdateAgentRequestSttOverride value)
        {
            return value switch
            {
                TtsUpdateAgentRequestSttOverride.Flux => "flux",
                TtsUpdateAgentRequestSttOverride.GptRealtimeWhisper => "gpt-realtime-whisper",
                TtsUpdateAgentRequestSttOverride.WhisperV3 => "whisper-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsUpdateAgentRequestSttOverride? ToEnum(string value)
        {
            return value switch
            {
                "flux" => TtsUpdateAgentRequestSttOverride.Flux,
                "gpt-realtime-whisper" => TtsUpdateAgentRequestSttOverride.GptRealtimeWhisper,
                "whisper-v3" => TtsUpdateAgentRequestSttOverride.WhisperV3,
                _ => null,
            };
        }
    }
}