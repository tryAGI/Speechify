
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Ambient-bed preset at call time; null = no background noise.
    /// </summary>
    public enum TtsAgentSnapshotBackgroundNoisePreset
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
    public static class TtsAgentSnapshotBackgroundNoisePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAgentSnapshotBackgroundNoisePreset value)
        {
            return value switch
            {
                TtsAgentSnapshotBackgroundNoisePreset.City => "city",
                TtsAgentSnapshotBackgroundNoisePreset.CrowdedRoom => "crowded_room",
                TtsAgentSnapshotBackgroundNoisePreset.Forest => "forest",
                TtsAgentSnapshotBackgroundNoisePreset.HoldMusic => "hold_music",
                TtsAgentSnapshotBackgroundNoisePreset.KeyboardTyping => "keyboard_typing",
                TtsAgentSnapshotBackgroundNoisePreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAgentSnapshotBackgroundNoisePreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => TtsAgentSnapshotBackgroundNoisePreset.City,
                "crowded_room" => TtsAgentSnapshotBackgroundNoisePreset.CrowdedRoom,
                "forest" => TtsAgentSnapshotBackgroundNoisePreset.Forest,
                "hold_music" => TtsAgentSnapshotBackgroundNoisePreset.HoldMusic,
                "keyboard_typing" => TtsAgentSnapshotBackgroundNoisePreset.KeyboardTyping,
                "office" => TtsAgentSnapshotBackgroundNoisePreset.Office,
                _ => null,
            };
        }
    }
}