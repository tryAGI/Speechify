
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The nature of the traffic.
    /// </summary>
    public enum IntendedUseMarketingOrInformational
    {
        /// <summary>
        ///
        /// </summary>
        Informational,
        /// <summary>
        ///
        /// </summary>
        Marketing,
        /// <summary>
        ///
        /// </summary>
        Mixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntendedUseMarketingOrInformationalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntendedUseMarketingOrInformational value)
        {
            return value switch
            {
                IntendedUseMarketingOrInformational.Informational => "informational",
                IntendedUseMarketingOrInformational.Marketing => "marketing",
                IntendedUseMarketingOrInformational.Mixed => "mixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntendedUseMarketingOrInformational? ToEnum(string value)
        {
            return value switch
            {
                "informational" => IntendedUseMarketingOrInformational.Informational,
                "marketing" => IntendedUseMarketingOrInformational.Marketing,
                "mixed" => IntendedUseMarketingOrInformational.Mixed,
                _ => null,
            };
        }
    }
}