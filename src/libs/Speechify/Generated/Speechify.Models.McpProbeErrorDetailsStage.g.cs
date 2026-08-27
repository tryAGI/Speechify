
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum McpProbeErrorDetailsStage
    {
        /// <summary>
        ///
        /// </summary>
        McpConnect,
        /// <summary>
        ///
        /// </summary>
        McpInitialize,
        /// <summary>
        ///
        /// </summary>
        McpListTools,
        /// <summary>
        ///
        /// </summary>
        McpNotify,
        /// <summary>
        ///
        /// </summary>
        Oauth2Token,
        /// <summary>
        ///
        /// </summary>
        Validation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpProbeErrorDetailsStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpProbeErrorDetailsStage value)
        {
            return value switch
            {
                McpProbeErrorDetailsStage.McpConnect => "mcp_connect",
                McpProbeErrorDetailsStage.McpInitialize => "mcp_initialize",
                McpProbeErrorDetailsStage.McpListTools => "mcp_list_tools",
                McpProbeErrorDetailsStage.McpNotify => "mcp_notify",
                McpProbeErrorDetailsStage.Oauth2Token => "oauth2_token",
                McpProbeErrorDetailsStage.Validation => "validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpProbeErrorDetailsStage? ToEnum(string value)
        {
            return value switch
            {
                "mcp_connect" => McpProbeErrorDetailsStage.McpConnect,
                "mcp_initialize" => McpProbeErrorDetailsStage.McpInitialize,
                "mcp_list_tools" => McpProbeErrorDetailsStage.McpListTools,
                "mcp_notify" => McpProbeErrorDetailsStage.McpNotify,
                "oauth2_token" => McpProbeErrorDetailsStage.Oauth2Token,
                "validation" => McpProbeErrorDetailsStage.Validation,
                _ => null,
            };
        }
    }
}