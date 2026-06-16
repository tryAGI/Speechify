
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional pre-mixed ambient bed. Null disables background<br/>
    /// noise.
    /// </summary>
    public enum AgentBackgroundNoisePreset
    {
        /// <summary>
        /// 
        /// </summary>
        City,
        /// <summary>
        /// 
        /// </summary>
        CrowdedRoom,
        /// <summary>
        /// 
        /// </summary>
        Forest,
        /// <summary>
        /// 
        /// </summary>
        HoldMusic,
        /// <summary>
        /// 
        /// </summary>
        KeyboardTyping,
        /// <summary>
        /// 
        /// </summary>
        Office,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBackgroundNoisePreset value)
        {
            return value switch
            {
                AgentBackgroundNoisePreset.City => "city",
                AgentBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                AgentBackgroundNoisePreset.Forest => "forest",
                AgentBackgroundNoisePreset.HoldMusic => "hold_music",
                AgentBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                AgentBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => AgentBackgroundNoisePreset.City,
                "crowded_room" => AgentBackgroundNoisePreset.CrowdedRoom,
                "forest" => AgentBackgroundNoisePreset.Forest,
                "hold_music" => AgentBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => AgentBackgroundNoisePreset.KeyboardTyping,
                "office" => AgentBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}