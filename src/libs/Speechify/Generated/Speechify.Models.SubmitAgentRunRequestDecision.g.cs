
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The approval disposition. `approve` resumes the run to execute the pending action; `deny` resumes it down its could-not-complete path.
    /// </summary>
    public enum SubmitAgentRunRequestDecision
    {
        /// <summary>
        ///
        /// </summary>
        Approve,
        /// <summary>
        ///
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitAgentRunRequestDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitAgentRunRequestDecision value)
        {
            return value switch
            {
                SubmitAgentRunRequestDecision.Approve => "approve",
                SubmitAgentRunRequestDecision.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitAgentRunRequestDecision? ToEnum(string value)
        {
            return value switch
            {
                "approve" => SubmitAgentRunRequestDecision.Approve,
                "deny" => SubmitAgentRunRequestDecision.Deny,
                _ => null,
            };
        }
    }
}