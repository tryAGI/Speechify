
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Streaming-STT stack override. Send an empty string ("") to<br/>
    /// clear the override and fall back to the worker default<br/>
    /// (today: whisper-v3). Any non-empty value must be a known<br/>
    /// stack name.
    /// </summary>
    public enum UpdateAgentRequestSttOverride
    {
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
    public static class UpdateAgentRequestSttOverrideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentRequestSttOverride value)
        {
            return value switch
            {
                UpdateAgentRequestSttOverride.GptRealtimeWhisper => "gpt-realtime-whisper",
                UpdateAgentRequestSttOverride.WhisperV3 => "whisper-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentRequestSttOverride? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime-whisper" => UpdateAgentRequestSttOverride.GptRealtimeWhisper,
                "whisper-v3" => UpdateAgentRequestSttOverride.WhisperV3,
                _ => null,
            };
        }
    }
}