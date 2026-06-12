
#nullable enable

namespace Speechify
{
    /// <summary>
    /// SIP transport protocol. `auto` lets LiveKit negotiate. Use `tls`<br/>
    /// for production where available - note that TLS is incompatible<br/>
    /// with SIP REFER (cold transfer). Trunks that need `transfer_to_number`<br/>
    /// should use `udp` or `tcp`.
    /// </summary>
    public enum TtsSIPTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Tcp,
        /// <summary>
        /// 
        /// </summary>
        Tls,
        /// <summary>
        /// 
        /// </summary>
        Udp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsSIPTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsSIPTransport value)
        {
            return value switch
            {
                TtsSIPTransport.Auto => "auto",
                TtsSIPTransport.Tcp => "tcp",
                TtsSIPTransport.Tls => "tls",
                TtsSIPTransport.Udp => "udp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsSIPTransport? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TtsSIPTransport.Auto,
                "tcp" => TtsSIPTransport.Tcp,
                "tls" => TtsSIPTransport.Tls,
                "udp" => TtsSIPTransport.Udp,
                _ => null,
            };
        }
    }
}