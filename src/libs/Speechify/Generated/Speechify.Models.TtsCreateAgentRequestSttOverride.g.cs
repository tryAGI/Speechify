
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional non-default streaming-STT stack for this agent.<br/>
    /// Omit to use the worker's default stack (today: whisper-v3).<br/>
    /// See the Agent schema for the full option semantics.
    /// </summary>
    public enum TtsCreateAgentRequestSttOverride
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
        /// whisper-v3).
        /// </summary>
        WhisperV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsCreateAgentRequestSttOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreateAgentRequestSttOverride value)
        {
            return value switch
            {
                TtsCreateAgentRequestSttOverride.Flux => "flux",
                TtsCreateAgentRequestSttOverride.GptRealtimeWhisper => "gpt-realtime-whisper",
                TtsCreateAgentRequestSttOverride.WhisperV3 => "whisper-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreateAgentRequestSttOverride? ToEnum(string value)
        {
            return value switch
            {
                "flux" => TtsCreateAgentRequestSttOverride.Flux,
                "gpt-realtime-whisper" => TtsCreateAgentRequestSttOverride.GptRealtimeWhisper,
                "whisper-v3" => TtsCreateAgentRequestSttOverride.WhisperV3,
                _ => null,
            };
        }
    }
}