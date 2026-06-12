
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsBatchCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsBatchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsBatchCallStatus value)
        {
            return value switch
            {
                TtsBatchCallStatus.Cancelled => "cancelled",
                TtsBatchCallStatus.Completed => "completed",
                TtsBatchCallStatus.Failed => "failed",
                TtsBatchCallStatus.Pending => "pending",
                TtsBatchCallStatus.Running => "running",
                TtsBatchCallStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsBatchCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => TtsBatchCallStatus.Cancelled,
                "completed" => TtsBatchCallStatus.Completed,
                "failed" => TtsBatchCallStatus.Failed,
                "pending" => TtsBatchCallStatus.Pending,
                "running" => TtsBatchCallStatus.Running,
                "scheduled" => TtsBatchCallStatus.Scheduled,
                _ => null,
            };
        }
    }
}