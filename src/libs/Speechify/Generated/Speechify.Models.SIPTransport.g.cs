
#nullable enable

namespace Speechify
{
    /// <summary>
    /// SIP transport protocol. `auto` lets LiveKit negotiate. Use `tls`<br/>
    /// for production where available - note that TLS is incompatible<br/>
    /// with SIP REFER (cold transfer). Trunks that need `transfer_to_number`<br/>
    /// should use `udp` or `tcp`.
    /// </summary>
    public enum SIPTransport
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
    public static class SIPTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPTransport value)
        {
            return value switch
            {
                SIPTransport.Auto => "auto",
                SIPTransport.Tcp => "tcp",
                SIPTransport.Tls => "tls",
                SIPTransport.Udp => "udp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPTransport? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SIPTransport.Auto,
                "tcp" => SIPTransport.Tcp,
                "tls" => SIPTransport.Tls,
                "udp" => SIPTransport.Udp,
                _ => null,
            };
        }
    }
}