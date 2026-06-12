
#nullable enable

namespace Speechify
{
    /// <summary>
    /// `pending` is the brief window between insert and the worker<br/>
    /// picking up; `running` is the bulk of the job's life;<br/>
    /// `completed` / `failed` / `cancelled` are terminal.
    /// </summary>
    public enum TtsImportJobStatus
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
    public static class TtsImportJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsImportJobStatus value)
        {
            return value switch
            {
                TtsImportJobStatus.Cancelled => "cancelled",
                TtsImportJobStatus.Completed => "completed",
                TtsImportJobStatus.Failed => "failed",
                TtsImportJobStatus.Pending => "pending",
                TtsImportJobStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsImportJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => TtsImportJobStatus.Cancelled,
                "completed" => TtsImportJobStatus.Completed,
                "failed" => TtsImportJobStatus.Failed,
                "pending" => TtsImportJobStatus.Pending,
                "running" => TtsImportJobStatus.Running,
                _ => null,
            };
        }
    }
}