
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Lifecycle of a test run: `queued` - `running` - terminal.<br/>
    /// Terminal states:<br/>
    /// - `passed` - the agent behaviour met the success criteria.<br/>
    /// - `failed` - the agent behaviour did not meet the success criteria.<br/>
    /// - `error` - the runner itself could not complete (LLM outage, network error, etc.),<br/>
    ///   distinct from `failed` which means the agent behaviour was judged and found lacking.
    /// </summary>
    public enum TestRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Passed,
        /// <summary>
        /// `queued` - `running` - terminal.
        /// </summary>
        Queued,
        /// <summary>
        /// `queued` - `running` - terminal.
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestRunStatus value)
        {
            return value switch
            {
                TestRunStatus.Error => "error",
                TestRunStatus.Failed => "failed",
                TestRunStatus.Passed => "passed",
                TestRunStatus.Queued => "queued",
                TestRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => TestRunStatus.Error,
                "failed" => TestRunStatus.Failed,
                "passed" => TestRunStatus.Passed,
                "queued" => TestRunStatus.Queued,
                "running" => TestRunStatus.Running,
                _ => null,
            };
        }
    }
}