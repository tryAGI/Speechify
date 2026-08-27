
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Overall spam-risk classification. `unknown` means the number has<br/>
    /// been checked but the carrier networks have no score yet (a fresh<br/>
    /// number has no calling history); `low` / `medium` / `high` are the<br/>
    /// reported risk levels.
    /// </summary>
    public enum PhoneNumberReputationRisk
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberReputationRiskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberReputationRisk value)
        {
            return value switch
            {
                PhoneNumberReputationRisk.High => "high",
                PhoneNumberReputationRisk.Low => "low",
                PhoneNumberReputationRisk.Medium => "medium",
                PhoneNumberReputationRisk.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberReputationRisk? ToEnum(string value)
        {
            return value switch
            {
                "high" => PhoneNumberReputationRisk.High,
                "low" => PhoneNumberReputationRisk.Low,
                "medium" => PhoneNumberReputationRisk.Medium,
                "unknown" => PhoneNumberReputationRisk.Unknown,
                _ => null,
            };
        }
    }
}