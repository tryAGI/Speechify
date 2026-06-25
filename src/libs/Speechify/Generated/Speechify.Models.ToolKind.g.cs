
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What kind of tool this is, and where it executes.<br/>
    /// - `builtin`: a worker-resident platform capability (e.g. end_call, play_audio), configured per-agent<br/>
    /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
    /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
    /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
    /// </summary>
    public enum ToolKind
    {
        /// <summary>
        /// a worker-resident platform capability (e.g. end_call, play_audio), configured per-agent
        /// </summary>
        Builtin,
        /// <summary>
        /// worker dispatches to the caller's browser/SDK via data channel
        /// </summary>
        Client,
        /// <summary>
        /// worker connects to a customer-hosted MCP server and proxies tool calls
        /// </summary>
        Mcp,
        /// <summary>
        /// worker signs a payload and POSTs it to your URL
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolKind value)
        {
            return value switch
            {
                ToolKind.Builtin => "builtin",
                ToolKind.Client => "client",
                ToolKind.Mcp => "mcp",
                ToolKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolKind? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ToolKind.Builtin,
                "client" => ToolKind.Client,
                "mcp" => ToolKind.Mcp,
                "webhook" => ToolKind.Webhook,
                _ => null,
            };
        }
    }
}