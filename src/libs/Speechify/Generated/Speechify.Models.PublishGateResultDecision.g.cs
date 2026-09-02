
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The recorded gate decision on a successful publish. A refused<br/>
    /// publish is a 422 (`agent_publish_gate_failed`), so `blocked` /<br/>
    /// `errored` never appear here.
    /// </summary>
    public enum PublishGateResultDecision
    {
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
    public static class PublishGateResultDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishGateResultDecision value)
        {
            return value switch
            {
                PublishGateResultDecision.Overridden => "overridden",
                PublishGateResultDecision.Passed => "passed",
                PublishGateResultDecision.SkippedNoSuite => "skipped_no_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishGateResultDecision? ToEnum(string value)
        {
            return value switch
            {
                "overridden" => PublishGateResultDecision.Overridden,
                "passed" => PublishGateResultDecision.Passed,
                "skipped_no_suite" => PublishGateResultDecision.SkippedNoSuite,
                _ => null,
            };
        }
    }
}