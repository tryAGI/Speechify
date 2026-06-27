
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The domain pass/fail judgment of an agent-test run or suite run,<br/>
    /// separate from the lifecycle `status`. Present only once the run<br/>
    /// reached a verdict (`status` is `completed`); absent for a run that<br/>
    /// could not execute (`status` `failed`), was `cancelled`, or is still<br/>
    /// in flight.
    /// </summary>
    public enum TestVerdict
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Passed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestVerdict value)
        {
            return value switch
            {
                TestVerdict.Failed => "failed",
                TestVerdict.Passed => "passed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestVerdict? ToEnum(string value)
        {
            return value switch
            {
                "failed" => TestVerdict.Failed,
                "passed" => TestVerdict.Passed,
                _ => null,
            };
        }
    }
}