
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Voice provenance. `shared` is the curated catalogue every workspace<br/>
    /// sees; `personal` is a voice this workspace cloned itself (workspace-<br/>
    /// owned clones only). Both can be assigned to an agent. Treat this as an<br/>
    /// open set - new values may be added, so branch on the ones you know and<br/>
    /// fall through for the rest.
    /// </summary>
    public enum AgentVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Personal,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentVoiceType value)
        {
            return value switch
            {
                AgentVoiceType.Personal => "personal",
                AgentVoiceType.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "personal" => AgentVoiceType.Personal,
                "shared" => AgentVoiceType.Shared,
                _ => null,
            };
        }
    }
}