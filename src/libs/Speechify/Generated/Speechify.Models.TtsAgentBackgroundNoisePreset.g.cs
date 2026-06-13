
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional pre-mixed ambient bed. Null disables background<br/>
    /// noise.
    /// </summary>
    public enum TtsAgentBackgroundNoisePreset
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
    public static class TtsAgentBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAgentBackgroundNoisePreset value)
        {
            return value switch
            {
                TtsAgentBackgroundNoisePreset.City => "city",
                TtsAgentBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                TtsAgentBackgroundNoisePreset.Forest => "forest",
                TtsAgentBackgroundNoisePreset.HoldMusic => "hold_music",
                TtsAgentBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                TtsAgentBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAgentBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => TtsAgentBackgroundNoisePreset.City,
                "crowded_room" => TtsAgentBackgroundNoisePreset.CrowdedRoom,
                "forest" => TtsAgentBackgroundNoisePreset.Forest,
                "hold_music" => TtsAgentBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => TtsAgentBackgroundNoisePreset.KeyboardTyping,
                "office" => TtsAgentBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}