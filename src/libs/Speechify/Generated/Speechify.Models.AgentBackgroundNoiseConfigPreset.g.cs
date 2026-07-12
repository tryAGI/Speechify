
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Pre-mixed ambient bed. Null disables background noise.
    /// </summary>
    public enum AgentBackgroundNoiseConfigPreset
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
    public static class AgentBackgroundNoiseConfigPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBackgroundNoiseConfigPreset value)
        {
            return value switch
            {
                AgentBackgroundNoiseConfigPreset.City => "city",
                AgentBackgroundNoiseConfigPreset.CrowdedRoom => "crowded_room",
                AgentBackgroundNoiseConfigPreset.Forest => "forest",
                AgentBackgroundNoiseConfigPreset.HoldMusic => "hold_music",
                AgentBackgroundNoiseConfigPreset.KeyboardTyping => "keyboard_typing",
                AgentBackgroundNoiseConfigPreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBackgroundNoiseConfigPreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => AgentBackgroundNoiseConfigPreset.City,
                "crowded_room" => AgentBackgroundNoiseConfigPreset.CrowdedRoom,
                "forest" => AgentBackgroundNoiseConfigPreset.Forest,
                "hold_music" => AgentBackgroundNoiseConfigPreset.HoldMusic,
                "keyboard_typing" => AgentBackgroundNoiseConfigPreset.KeyboardTyping,
                "office" => AgentBackgroundNoiseConfigPreset.Office,
                _ => null,
            };
        }
    }
}