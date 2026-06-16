
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the caller reached the agent. `web` is the browser /<br/>
    /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
    /// from the telephony stack.
    /// </summary>
    public enum ConversationTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Phone,
        /// <summary>
        /// 
        /// </summary>
        SipInbound,
        /// <summary>
        /// 
        /// </summary>
        SipOutbound,
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        Whatsapp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationTransport value)
        {
            return value switch
            {
                ConversationTransport.Phone => "phone",
                ConversationTransport.SipInbound => "sip_inbound",
                ConversationTransport.SipOutbound => "sip_outbound",
                ConversationTransport.Web => "web",
                ConversationTransport.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationTransport? ToEnum(string value)
        {
            return value switch
            {
                "phone" => ConversationTransport.Phone,
                "sip_inbound" => ConversationTransport.SipInbound,
                "sip_outbound" => ConversationTransport.SipOutbound,
                "web" => ConversationTransport.Web,
                "whatsapp" => ConversationTransport.Whatsapp,
                _ => null,
            };
        }
    }
}