
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchRecipientStatus
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
    public static class BatchRecipientStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchRecipientStatus value)
        {
            return value switch
            {
                BatchRecipientStatus.Completed => "completed",
                BatchRecipientStatus.Dialing => "dialing",
                BatchRecipientStatus.Failed => "failed",
                BatchRecipientStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchRecipientStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => BatchRecipientStatus.Completed,
                "dialing" => BatchRecipientStatus.Dialing,
                "failed" => BatchRecipientStatus.Failed,
                "pending" => BatchRecipientStatus.Pending,
                _ => null,
            };
        }
    }
}