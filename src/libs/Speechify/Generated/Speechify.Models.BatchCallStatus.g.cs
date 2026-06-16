
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchCallStatus
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
    public static class BatchCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchCallStatus value)
        {
            return value switch
            {
                BatchCallStatus.Cancelled => "cancelled",
                BatchCallStatus.Completed => "completed",
                BatchCallStatus.Failed => "failed",
                BatchCallStatus.Pending => "pending",
                BatchCallStatus.Running => "running",
                BatchCallStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BatchCallStatus.Cancelled,
                "completed" => BatchCallStatus.Completed,
                "failed" => BatchCallStatus.Failed,
                "pending" => BatchCallStatus.Pending,
                "running" => BatchCallStatus.Running,
                "scheduled" => BatchCallStatus.Scheduled,
                _ => null,
            };
        }
    }
}