
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The decision applied automatically if nobody responds by `expires_at`.
    /// </summary>
    public enum PendingActionDefaultDecision
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
    public static class PendingActionDefaultDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PendingActionDefaultDecision value)
        {
            return value switch
            {
                PendingActionDefaultDecision.Approve => "approve",
                PendingActionDefaultDecision.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PendingActionDefaultDecision? ToEnum(string value)
        {
            return value switch
            {
                "approve" => PendingActionDefaultDecision.Approve,
                "deny" => PendingActionDefaultDecision.Deny,
                _ => null,
            };
        }
    }
}