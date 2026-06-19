
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional override for the streaming-STT stack this agent<br/>
    /// dispatches with. Null means use the default (Whisper Large V3).<br/>
    /// Pick `whisper-v3` to pin Whisper Large V3 explicitly, or<br/>
    /// `gpt-realtime-whisper` for OpenAI's streaming Whisper-class STT.
    /// </summary>
    public enum AgentSttOverride
    {
        /// <summary>
        /// 
        /// </summary>
        GptRealtimeWhisper,
        /// <summary>
        /// 
        /// </summary>
        WhisperV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSttOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSttOverride value)
        {
            return value switch
            {
                AgentSttOverride.GptRealtimeWhisper => "gpt-realtime-whisper",
                AgentSttOverride.WhisperV3 => "whisper-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSttOverride? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime-whisper" => AgentSttOverride.GptRealtimeWhisper,
                "whisper-v3" => AgentSttOverride.WhisperV3,
                _ => null,
            };
        }
    }
}