
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsAmdConfigOnVoicemailAction
    {
        /// <summary>
        /// 
        /// </summary>
        Hangup,
        /// <summary>
        /// 
        /// </summary>
        LeaveMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsAmdConfigOnVoicemailActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsAmdConfigOnVoicemailAction value)
        {
            return value switch
            {
                TtsAmdConfigOnVoicemailAction.Hangup => "hangup",
                TtsAmdConfigOnVoicemailAction.LeaveMessage => "leave_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsAmdConfigOnVoicemailAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => TtsAmdConfigOnVoicemailAction.Hangup,
                "leave_message" => TtsAmdConfigOnVoicemailAction.LeaveMessage,
                _ => null,
            };
        }
    }
}