
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Ambient-bed preset at call time; null = no background noise.
    /// </summary>
    public enum AgentSnapshotBackgroundNoisePreset
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
    public static class AgentSnapshotBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSnapshotBackgroundNoisePreset value)
        {
            return value switch
            {
                AgentSnapshotBackgroundNoisePreset.City => "city",
                AgentSnapshotBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                AgentSnapshotBackgroundNoisePreset.Forest => "forest",
                AgentSnapshotBackgroundNoisePreset.HoldMusic => "hold_music",
                AgentSnapshotBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                AgentSnapshotBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSnapshotBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => AgentSnapshotBackgroundNoisePreset.City,
                "crowded_room" => AgentSnapshotBackgroundNoisePreset.CrowdedRoom,
                "forest" => AgentSnapshotBackgroundNoisePreset.Forest,
                "hold_music" => AgentSnapshotBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => AgentSnapshotBackgroundNoisePreset.KeyboardTyping,
                "office" => AgentSnapshotBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}