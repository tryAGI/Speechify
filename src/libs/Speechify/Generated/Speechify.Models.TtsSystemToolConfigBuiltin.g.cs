
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsSystemToolConfigBuiltin
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
        /// <summary>
        /// 
        /// </summary>
        PlayKeypadTouchTone,
        /// <summary>
        /// 
        /// </summary>
        SkipTurn,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgent,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsSystemToolConfigBuiltinExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSystemToolConfigBuiltin value)
        {
            return value switch
            {
                TtsSystemToolConfigBuiltin.EndCall => "end_call",
                TtsSystemToolConfigBuiltin.PlayKeypadTouchTone => "play_keypad_touch_tone",
                TtsSystemToolConfigBuiltin.SkipTurn => "skip_turn",
                TtsSystemToolConfigBuiltin.TransferToAgent => "transfer_to_agent",
                TtsSystemToolConfigBuiltin.TransferToNumber => "transfer_to_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSystemToolConfigBuiltin? ToEnum(string value)
        {
            return value switch
            {
                "end_call" => TtsSystemToolConfigBuiltin.EndCall,
                "play_keypad_touch_tone" => TtsSystemToolConfigBuiltin.PlayKeypadTouchTone,
                "skip_turn" => TtsSystemToolConfigBuiltin.SkipTurn,
                "transfer_to_agent" => TtsSystemToolConfigBuiltin.TransferToAgent,
                "transfer_to_number" => TtsSystemToolConfigBuiltin.TransferToNumber,
                _ => null,
            };
        }
    }
}