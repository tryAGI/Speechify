
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which entry point created a suite run.<br/>
    /// - `run_all`  - POST /v1/agents/{id}/tests/runs.<br/>
    /// - `batch`    - POST /v1/agents/tests/runs/batch.<br/>
    /// - `resubmit` - POST /v1/agents/tests/suite-runs/{id}/resubmit.
    /// </summary>
    public enum TtsSuiteRunTrigger
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
    public static class TtsSuiteRunTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSuiteRunTrigger value)
        {
            return value switch
            {
                TtsSuiteRunTrigger.Batch => "batch",
                TtsSuiteRunTrigger.Resubmit => "resubmit",
                TtsSuiteRunTrigger.RunAll => "run_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSuiteRunTrigger? ToEnum(string value)
        {
            return value switch
            {
                "batch" => TtsSuiteRunTrigger.Batch,
                "resubmit" => TtsSuiteRunTrigger.Resubmit,
                "run_all" => TtsSuiteRunTrigger.RunAll,
                _ => null,
            };
        }
    }
}