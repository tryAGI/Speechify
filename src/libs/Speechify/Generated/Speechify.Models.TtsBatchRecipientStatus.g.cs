
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsBatchRecipientStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Dialing,
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
    public static class TtsBatchRecipientStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsBatchRecipientStatus value)
        {
            return value switch
            {
                TtsBatchRecipientStatus.Completed => "completed",
                TtsBatchRecipientStatus.Dialing => "dialing",
                TtsBatchRecipientStatus.Failed => "failed",
                TtsBatchRecipientStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsBatchRecipientStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TtsBatchRecipientStatus.Completed,
                "dialing" => TtsBatchRecipientStatus.Dialing,
                "failed" => TtsBatchRecipientStatus.Failed,
                "pending" => TtsBatchRecipientStatus.Pending,
                _ => null,
            };
        }
    }
}