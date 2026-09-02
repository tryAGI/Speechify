
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the gate decided. `overridden` means the checks did NOT pass and a<br/>
    /// human published anyway with a recorded justification - it is not a pass.<br/>
    /// `skipped_no_suite` means nothing was checked.
    /// </summary>
    public enum PublishGateRunDecision
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Errored,
        /// <summary>
        ///
        /// </summary>
        Overridden,
        /// <summary>
        ///
        /// </summary>
        Passed,
        /// <summary>
        ///
        /// </summary>
        SkippedNoSuite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishGateRunDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishGateRunDecision value)
        {
            return value switch
            {
                PublishGateRunDecision.Blocked => "blocked",
                PublishGateRunDecision.Errored => "errored",
                PublishGateRunDecision.Overridden => "overridden",
                PublishGateRunDecision.Passed => "passed",
                PublishGateRunDecision.SkippedNoSuite => "skipped_no_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishGateRunDecision? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => PublishGateRunDecision.Blocked,
                "errored" => PublishGateRunDecision.Errored,
                "overridden" => PublishGateRunDecision.Overridden,
                "passed" => PublishGateRunDecision.Passed,
                "skipped_no_suite" => PublishGateRunDecision.SkippedNoSuite,
                _ => null,
            };
        }
    }
}