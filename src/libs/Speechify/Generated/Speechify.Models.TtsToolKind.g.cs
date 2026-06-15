
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Where the tool executes.<br/>
    /// - `system`:  worker-resident built-in (e.g. end_call, play_audio)<br/>
    /// - `webhook`: worker signs a payload and POSTs it to your URL<br/>
    /// - `client`:  worker dispatches to the caller's browser/SDK via data channel<br/>
    /// - `mcp`:     worker connects to a customer-hosted MCP server and proxies tool calls
    /// </summary>
    public enum TtsToolKind
    {
        /// <summary>
        /// worker dispatches to the caller's browser/SDK via data channel
        /// </summary>
        Client,
        /// <summary>
        /// worker connects to a customer-hosted MCP server and proxies tool calls
        /// </summary>
        Mcp,
        /// <summary>
        /// worker-resident built-in (e.g. end_call, play_audio)
        /// </summary>
        System,
        /// <summary>
        /// worker signs a payload and POSTs it to your URL
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsToolKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsToolKind value)
        {
            return value switch
            {
                TtsToolKind.Client => "client",
                TtsToolKind.Mcp => "mcp",
                TtsToolKind.System => "system",
                TtsToolKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsToolKind? ToEnum(string value)
        {
            return value switch
            {
                "client" => TtsToolKind.Client,
                "mcp" => TtsToolKind.Mcp,
                "system" => TtsToolKind.System,
                "webhook" => TtsToolKind.Webhook,
                _ => null,
            };
        }
    }
}