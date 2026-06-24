
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Pins the streaming speech-to-text stack this agent<br/>
    /// dispatches with. Null uses the platform default (Whisper<br/>
    /// Large V3).
    /// </summary>
    public enum AgentSttConfigOverride
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
    public static class AgentSttConfigOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSttConfigOverride value)
        {
            return value switch
            {
                AgentSttConfigOverride.GptRealtimeWhisper => "gpt-realtime-whisper",
                AgentSttConfigOverride.WhisperV3 => "whisper-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSttConfigOverride? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime-whisper" => AgentSttConfigOverride.GptRealtimeWhisper,
                "whisper-v3" => AgentSttConfigOverride.WhisperV3,
                _ => null,
            };
        }
    }
}