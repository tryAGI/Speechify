
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional non-default streaming-STT stack for this agent.<br/>
    /// Omit to use the worker's default stack (today: whisper-v3).<br/>
    /// See the Agent schema for the full option semantics.
    /// </summary>
    public enum CreateAgentRequestSttOverride
    {
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
    public static class CreateAgentRequestSttOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRequestSttOverride value)
        {
            return value switch
            {
                CreateAgentRequestSttOverride.GptRealtimeWhisper => "gpt-realtime-whisper",
                CreateAgentRequestSttOverride.WhisperV3 => "whisper-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRequestSttOverride? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime-whisper" => CreateAgentRequestSttOverride.GptRealtimeWhisper,
                "whisper-v3" => CreateAgentRequestSttOverride.WhisperV3,
                _ => null,
            };
        }
    }
}