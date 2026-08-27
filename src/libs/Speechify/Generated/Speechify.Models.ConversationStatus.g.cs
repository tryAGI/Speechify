
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ConversationStatus
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
    public static class ConversationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationStatus value)
        {
            return value switch
            {
                ConversationStatus.Active => "active",
                ConversationStatus.Completed => "completed",
                ConversationStatus.Failed => "failed",
                ConversationStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ConversationStatus.Active,
                "completed" => ConversationStatus.Completed,
                "failed" => ConversationStatus.Failed,
                "pending" => ConversationStatus.Pending,
                _ => null,
            };
        }
    }
}