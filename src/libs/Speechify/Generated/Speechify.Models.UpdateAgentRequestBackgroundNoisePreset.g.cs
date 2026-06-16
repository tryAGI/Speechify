
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
    /// disable the bed, which also clears `background_noise_volume`.
    /// </summary>
    public enum UpdateAgentRequestBackgroundNoisePreset
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
    public static class UpdateAgentRequestBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentRequestBackgroundNoisePreset value)
        {
            return value switch
            {
                UpdateAgentRequestBackgroundNoisePreset.City => "city",
                UpdateAgentRequestBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                UpdateAgentRequestBackgroundNoisePreset.Forest => "forest",
                UpdateAgentRequestBackgroundNoisePreset.HoldMusic => "hold_music",
                UpdateAgentRequestBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                UpdateAgentRequestBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentRequestBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => UpdateAgentRequestBackgroundNoisePreset.City,
                "crowded_room" => UpdateAgentRequestBackgroundNoisePreset.CrowdedRoom,
                "forest" => UpdateAgentRequestBackgroundNoisePreset.Forest,
                "hold_music" => UpdateAgentRequestBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => UpdateAgentRequestBackgroundNoisePreset.KeyboardTyping,
                "office" => UpdateAgentRequestBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}