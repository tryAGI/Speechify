
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Which runtime carried the conversation. `web` is the browser /<br/>
    /// SDK realtime path; the `sip_*` and `phone` variants come<br/>
    /// from the telephony stack; `text` is the turn-based, roomless<br/>
    /// runtime (no call duration) that the message API and every<br/>
    /// messaging channel share.<br/>
    /// A conversation reports the transport it actually ran on:<br/>
    /// `web`, `sip_inbound`, `sip_outbound` or `text`. `phone` is<br/>
    /// selectable when filtering a list and matches calls in either<br/>
    /// direction; `whatsapp` is reserved and matches nothing today.<br/>
    /// To tell two conversations on the same transport apart, filter<br/>
    /// or read `channel` instead.
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
        Text,
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
                ConversationTransport.Text => "text",
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
                "text" => ConversationTransport.Text,
                "web" => ConversationTransport.Web,
                "whatsapp" => ConversationTransport.Whatsapp,
                _ => null,
            };
        }
    }
}