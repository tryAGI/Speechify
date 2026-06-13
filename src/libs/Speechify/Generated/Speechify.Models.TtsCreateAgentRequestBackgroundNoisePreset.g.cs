
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
    /// disable the bed, which also clears `background_noise_volume`.
    /// </summary>
    public enum TtsCreateAgentRequestBackgroundNoisePreset
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
    public static class TtsCreateAgentRequestBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsCreateAgentRequestBackgroundNoisePreset value)
        {
            return value switch
            {
                TtsCreateAgentRequestBackgroundNoisePreset.City => "city",
                TtsCreateAgentRequestBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                TtsCreateAgentRequestBackgroundNoisePreset.Forest => "forest",
                TtsCreateAgentRequestBackgroundNoisePreset.HoldMusic => "hold_music",
                TtsCreateAgentRequestBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                TtsCreateAgentRequestBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsCreateAgentRequestBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => TtsCreateAgentRequestBackgroundNoisePreset.City,
                "crowded_room" => TtsCreateAgentRequestBackgroundNoisePreset.CrowdedRoom,
                "forest" => TtsCreateAgentRequestBackgroundNoisePreset.Forest,
                "hold_music" => TtsCreateAgentRequestBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => TtsCreateAgentRequestBackgroundNoisePreset.KeyboardTyping,
                "office" => TtsCreateAgentRequestBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}