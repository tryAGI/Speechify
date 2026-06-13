
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
    /// disable the bed, which also clears `background_noise_volume`.
    /// </summary>
    public enum TtsUpdateAgentRequestBackgroundNoisePreset
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
    public static class TtsUpdateAgentRequestBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsUpdateAgentRequestBackgroundNoisePreset value)
        {
            return value switch
            {
                TtsUpdateAgentRequestBackgroundNoisePreset.City => "city",
                TtsUpdateAgentRequestBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                TtsUpdateAgentRequestBackgroundNoisePreset.Forest => "forest",
                TtsUpdateAgentRequestBackgroundNoisePreset.HoldMusic => "hold_music",
                TtsUpdateAgentRequestBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                TtsUpdateAgentRequestBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsUpdateAgentRequestBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => TtsUpdateAgentRequestBackgroundNoisePreset.City,
                "crowded_room" => TtsUpdateAgentRequestBackgroundNoisePreset.CrowdedRoom,
                "forest" => TtsUpdateAgentRequestBackgroundNoisePreset.Forest,
                "hold_music" => TtsUpdateAgentRequestBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => TtsUpdateAgentRequestBackgroundNoisePreset.KeyboardTyping,
                "office" => TtsUpdateAgentRequestBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}