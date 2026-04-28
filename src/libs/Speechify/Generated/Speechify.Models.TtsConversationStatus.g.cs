
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsConversationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsConversationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsConversationStatus value)
        {
            return value switch
            {
                TtsConversationStatus.Active => "active",
                TtsConversationStatus.Completed => "completed",
                TtsConversationStatus.Failed => "failed",
                TtsConversationStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsConversationStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => TtsConversationStatus.Active,
                "completed" => TtsConversationStatus.Completed,
                "failed" => TtsConversationStatus.Failed,
                "pending" => TtsConversationStatus.Pending,
                _ => null,
            };
        }
    }
}