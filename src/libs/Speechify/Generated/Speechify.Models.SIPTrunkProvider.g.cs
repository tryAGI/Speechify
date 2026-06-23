
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which provider backs the trunk. Informs the provisioning path and<br/>
    /// portability story.<br/>
    /// - `livekit` - Provisioned by LiveKit's native phone-number API.<br/>
    /// - `twilio` - Backed by a Twilio Elastic SIP Trunk on the customer's account.<br/>
    /// - `byoc` - Any SIP provider with a customer-managed trunk.
    /// </summary>
    public enum SIPTrunkProvider
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
    public static class SIPTrunkProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTrunkProvider value)
        {
            return value switch
            {
                SIPTrunkProvider.Byoc => "byoc",
                SIPTrunkProvider.Livekit => "livekit",
                SIPTrunkProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTrunkProvider? ToEnum(string value)
        {
            return value switch
            {
                "byoc" => SIPTrunkProvider.Byoc,
                "livekit" => SIPTrunkProvider.Livekit,
                "twilio" => SIPTrunkProvider.Twilio,
                _ => null,
            };
        }
    }
}