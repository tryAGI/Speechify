
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Voice provenance. Always `shared` on this endpoint — personal<br/>
    /// / cloned voices are not exposed here; they stay on<br/>
    /// `GET /v1/voices`.
    /// </summary>
    public enum TtsAgentVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsAgentVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAgentVoiceType value)
        {
            return value switch
            {
                TtsAgentVoiceType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAgentVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "shared" => TtsAgentVoiceType.Shared,
                _ => null,
            };
        }
    }
}