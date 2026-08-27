
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The one lifecycle vocabulary shared by every async job (batch<br/>
    /// calls, knowledge-base imports, agent-test runs, suite runs):<br/>
    /// `pending` → `running` → a terminal state.<br/>
    /// - `pending` - accepted but not yet executing (queued for a worker,<br/>
    ///   or deferred to a future scheduled time).<br/>
    /// - `running` - actively executing.<br/>
    /// - `completed` - ran to conclusion. The single terminal-success<br/>
    ///   verb. For a job that produces a pass/fail judgment (an agent-test<br/>
    ///   run), this means it produced a verdict - read the separate<br/>
    ///   `verdict` field for the judgment, not this status.<br/>
    /// - `failed` - could not complete (an infrastructure or input<br/>
    ///   failure), distinct from a `completed` job whose `verdict` is<br/>
    ///   `failed`.<br/>
    /// - `cancelled` - cancelled before reaching a natural terminal state.
    /// </summary>
    public enum JobStatus
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
    public static class JobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatus value)
        {
            return value switch
            {
                JobStatus.Cancelled => "cancelled",
                JobStatus.Completed => "completed",
                JobStatus.Failed => "failed",
                JobStatus.Pending => "pending",
                JobStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => JobStatus.Cancelled,
                "completed" => JobStatus.Completed,
                "failed" => JobStatus.Failed,
                "pending" => JobStatus.Pending,
                "running" => JobStatus.Running,
                _ => null,
            };
        }
    }
}