
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Whether the trunk handles inbound calls, outbound calls, or both.<br/>
    /// A `both` trunk has distinct LiveKit inbound and outbound trunk IDs.
    /// </summary>
    public enum TtsSIPTrunkDirection
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
    public static class TtsSIPTrunkDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSIPTrunkDirection value)
        {
            return value switch
            {
                TtsSIPTrunkDirection.Both => "both",
                TtsSIPTrunkDirection.Inbound => "inbound",
                TtsSIPTrunkDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSIPTrunkDirection? ToEnum(string value)
        {
            return value switch
            {
                "both" => TtsSIPTrunkDirection.Both,
                "inbound" => TtsSIPTrunkDirection.Inbound,
                "outbound" => TtsSIPTrunkDirection.Outbound,
                _ => null,
            };
        }
    }
}