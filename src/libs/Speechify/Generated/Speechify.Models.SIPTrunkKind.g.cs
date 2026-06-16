
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
    public enum SIPTrunkKind
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
    public static class SIPTrunkKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTrunkKind value)
        {
            return value switch
            {
                SIPTrunkKind.Byoc => "byoc",
                SIPTrunkKind.Livekit => "livekit",
                SIPTrunkKind.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTrunkKind? ToEnum(string value)
        {
            return value switch
            {
                "byoc" => SIPTrunkKind.Byoc,
                "livekit" => SIPTrunkKind.Livekit,
                "twilio" => SIPTrunkKind.Twilio,
                _ => null,
            };
        }
    }
}