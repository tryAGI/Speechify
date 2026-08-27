
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which entry point created a suite run.<br/>
    /// - `run_all`  - POST /v1/agents/{agent_id}/tests/runs.<br/>
    /// - `batch`    - POST /v1/agents/tests/runs/batch.<br/>
    /// - `resubmit` - POST /v1/agents/tests/suite-runs/{suite_run_id}/resubmit.
    /// </summary>
    public enum SuiteRunTrigger
    {
        /// <summary>
        ///
        /// </summary>
        Batch,
        /// <summary>
        ///
        /// </summary>
        Resubmit,
        /// <summary>
        ///
        /// </summary>
        RunAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SuiteRunTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SuiteRunTrigger value)
        {
            return value switch
            {
                SuiteRunTrigger.Batch => "batch",
                SuiteRunTrigger.Resubmit => "resubmit",
                SuiteRunTrigger.RunAll => "run_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SuiteRunTrigger? ToEnum(string value)
        {
            return value switch
            {
                "batch" => SuiteRunTrigger.Batch,
                "resubmit" => SuiteRunTrigger.Resubmit,
                "run_all" => SuiteRunTrigger.RunAll,
                _ => null,
            };
        }
    }
}