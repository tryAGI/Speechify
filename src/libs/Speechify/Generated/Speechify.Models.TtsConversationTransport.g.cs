
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the caller reached the agent. `web` is the browser /<br/>
    /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
    /// from the telephony stack.
    /// </summary>
    public enum TtsConversationTransport
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
    public static class TtsConversationTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsConversationTransport value)
        {
            return value switch
            {
                TtsConversationTransport.Phone => "phone",
                TtsConversationTransport.SipInbound => "sip_inbound",
                TtsConversationTransport.SipOutbound => "sip_outbound",
                TtsConversationTransport.Web => "web",
                TtsConversationTransport.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsConversationTransport? ToEnum(string value)
        {
            return value switch
            {
                "phone" => TtsConversationTransport.Phone,
                "sip_inbound" => TtsConversationTransport.SipInbound,
                "sip_outbound" => TtsConversationTransport.SipOutbound,
                "web" => TtsConversationTransport.Web,
                "whatsapp" => TtsConversationTransport.Whatsapp,
                _ => null,
            };
        }
    }
}