
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `pending` is the brief window between insert and the worker<br/>
    /// picking up; `running` is the bulk of the job's life;<br/>
    /// `completed` / `failed` / `cancelled` are terminal.
    /// </summary>
    public enum ImportJobStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportJobStatus value)
        {
            return value switch
            {
                ImportJobStatus.Cancelled => "cancelled",
                ImportJobStatus.Completed => "completed",
                ImportJobStatus.Failed => "failed",
                ImportJobStatus.Pending => "pending",
                ImportJobStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ImportJobStatus.Cancelled,
                "completed" => ImportJobStatus.Completed,
                "failed" => ImportJobStatus.Failed,
                "pending" => ImportJobStatus.Pending,
                "running" => ImportJobStatus.Running,
                _ => null,
            };
        }
    }
}