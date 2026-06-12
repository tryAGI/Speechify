
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Where the trunk came from. Informs the provisioning path and<br/>
    /// portability story.<br/>
    /// - `livekit` - Provisioned by LiveKit's native phone-number API.<br/>
    /// - `twilio` - Backed by a Twilio Elastic SIP Trunk on the customer's account.<br/>
    /// - `byoc` - Any SIP provider with a customer-managed trunk.
    /// </summary>
    public enum TtsSIPTrunkKind
    {
        /// <summary>
        /// 
        /// </summary>
        Byoc,
        /// <summary>
        /// 
        /// </summary>
        Livekit,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsSIPTrunkKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSIPTrunkKind value)
        {
            return value switch
            {
                TtsSIPTrunkKind.Byoc => "byoc",
                TtsSIPTrunkKind.Livekit => "livekit",
                TtsSIPTrunkKind.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSIPTrunkKind? ToEnum(string value)
        {
            return value switch
            {
                "byoc" => TtsSIPTrunkKind.Byoc,
                "livekit" => TtsSIPTrunkKind.Livekit,
                "twilio" => TtsSIPTrunkKind.Twilio,
                _ => null,
            };
        }
    }
}