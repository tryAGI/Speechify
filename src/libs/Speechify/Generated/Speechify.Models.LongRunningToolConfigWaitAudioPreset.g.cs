
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which bundled clip to loop. One roster and one mix level<br/>
    /// shared with the agent-level background noise, so a preset<br/>
    /// sounds the same whichever surface picks it.
    /// </summary>
    public enum LongRunningToolConfigWaitAudioPreset
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
    public static class LongRunningToolConfigWaitAudioPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LongRunningToolConfigWaitAudioPreset value)
        {
            return value switch
            {
                LongRunningToolConfigWaitAudioPreset.City => "city",
                LongRunningToolConfigWaitAudioPreset.CrowdedRoom => "crowded_room",
                LongRunningToolConfigWaitAudioPreset.Forest => "forest",
                LongRunningToolConfigWaitAudioPreset.HoldMusic => "hold_music",
                LongRunningToolConfigWaitAudioPreset.KeyboardTyping => "keyboard_typing",
                LongRunningToolConfigWaitAudioPreset.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LongRunningToolConfigWaitAudioPreset? ToEnum(string value)
        {
            return value switch
            {
                "city" => LongRunningToolConfigWaitAudioPreset.City,
                "crowded_room" => LongRunningToolConfigWaitAudioPreset.CrowdedRoom,
                "forest" => LongRunningToolConfigWaitAudioPreset.Forest,
                "hold_music" => LongRunningToolConfigWaitAudioPreset.HoldMusic,
                "keyboard_typing" => LongRunningToolConfigWaitAudioPreset.KeyboardTyping,
                "office" => LongRunningToolConfigWaitAudioPreset.Office,
                _ => null,
            };
        }
    }
}