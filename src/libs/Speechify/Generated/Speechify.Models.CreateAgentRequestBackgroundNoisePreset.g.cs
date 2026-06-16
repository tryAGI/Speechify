
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Pre-mixed ambient bed slug. Send empty string ("") to<br/>
    /// disable the bed, which also clears `background_noise_volume`.
    /// </summary>
    public enum CreateAgentRequestBackgroundNoisePreset
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
    public static class CreateAgentRequestBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRequestBackgroundNoisePreset value)
        {
            return value switch
            {
                CreateAgentRequestBackgroundNoisePreset.City => "city",
                CreateAgentRequestBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                CreateAgentRequestBackgroundNoisePreset.Forest => "forest",
                CreateAgentRequestBackgroundNoisePreset.HoldMusic => "hold_music",
                CreateAgentRequestBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                CreateAgentRequestBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRequestBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => CreateAgentRequestBackgroundNoisePreset.City,
                "crowded_room" => CreateAgentRequestBackgroundNoisePreset.CrowdedRoom,
                "forest" => CreateAgentRequestBackgroundNoisePreset.Forest,
                "hold_music" => CreateAgentRequestBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => CreateAgentRequestBackgroundNoisePreset.KeyboardTyping,
                "office" => CreateAgentRequestBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}