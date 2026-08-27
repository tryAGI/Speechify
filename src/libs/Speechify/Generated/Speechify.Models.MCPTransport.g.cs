
#nullable enable

namespace Speechify
{
    /// <summary>
    /// MCP transport. `http_streamable` is the default; `sse` is the<br/>
    /// legacy fallback for servers that haven't migrated yet.
    /// </summary>
    public enum MCPTransport
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
    public static class MCPTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPTransport value)
        {
            return value switch
            {
                MCPTransport.HttpStreamable => "http_streamable",
                MCPTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPTransport? ToEnum(string value)
        {
            return value switch
            {
                "http_streamable" => MCPTransport.HttpStreamable,
                "sse" => MCPTransport.Sse,
                _ => null,
            };
        }
    }
}