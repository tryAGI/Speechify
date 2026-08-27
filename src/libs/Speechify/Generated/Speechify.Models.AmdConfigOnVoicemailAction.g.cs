
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum AmdConfigOnVoicemailAction
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
    public static class AmdConfigOnVoicemailActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AmdConfigOnVoicemailAction value)
        {
            return value switch
            {
                AmdConfigOnVoicemailAction.Hangup => "hangup",
                AmdConfigOnVoicemailAction.LeaveMessage => "leave_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AmdConfigOnVoicemailAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => AmdConfigOnVoicemailAction.Hangup,
                "leave_message" => AmdConfigOnVoicemailAction.LeaveMessage,
                _ => null,
            };
        }
    }
}