
#nullable enable

namespace Speechify
{
    /// <summary>
    /// MCP transport. `http_streamable` is the default; `sse` is the<br/>
    /// legacy fallback for servers that haven't migrated yet.
    /// </summary>
    public enum TtsMCPTransport
    {
        /// <summary>
        /// 
        /// </summary>
        HttpStreamable,
        /// <summary>
        /// 
        /// </summary>
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsMCPTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMCPTransport value)
        {
            return value switch
            {
                TtsMCPTransport.HttpStreamable => "http_streamable",
                TtsMCPTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMCPTransport? ToEnum(string value)
        {
            return value switch
            {
                "http_streamable" => TtsMCPTransport.HttpStreamable,
                "sse" => TtsMCPTransport.Sse,
                _ => null,
            };
        }
    }
}