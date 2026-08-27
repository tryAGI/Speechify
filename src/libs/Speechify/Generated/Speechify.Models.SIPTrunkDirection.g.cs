
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Whether the trunk handles inbound calls, outbound calls, or both.<br/>
    /// A `both` trunk has distinct provider inbound and outbound trunk IDs.
    /// </summary>
    public enum SIPTrunkDirection
    {
        /// <summary>
        ///
        /// </summary>
        Both,
        /// <summary>
        ///
        /// </summary>
        Inbound,
        /// <summary>
        ///
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPTrunkDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTrunkDirection value)
        {
            return value switch
            {
                SIPTrunkDirection.Both => "both",
                SIPTrunkDirection.Inbound => "inbound",
                SIPTrunkDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTrunkDirection? ToEnum(string value)
        {
            return value switch
            {
                "both" => SIPTrunkDirection.Both,
                "inbound" => SIPTrunkDirection.Inbound,
                "outbound" => SIPTrunkDirection.Outbound,
                _ => null,
            };
        }
    }
}