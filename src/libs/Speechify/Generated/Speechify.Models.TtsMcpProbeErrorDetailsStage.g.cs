
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsMcpProbeErrorDetailsStage
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
    public static class TtsMcpProbeErrorDetailsStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMcpProbeErrorDetailsStage value)
        {
            return value switch
            {
                TtsMcpProbeErrorDetailsStage.McpConnect => "mcp_connect",
                TtsMcpProbeErrorDetailsStage.McpInitialize => "mcp_initialize",
                TtsMcpProbeErrorDetailsStage.McpListTools => "mcp_list_tools",
                TtsMcpProbeErrorDetailsStage.McpNotify => "mcp_notify",
                TtsMcpProbeErrorDetailsStage.Oauth2Token => "oauth2_token",
                TtsMcpProbeErrorDetailsStage.Validation => "validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMcpProbeErrorDetailsStage? ToEnum(string value)
        {
            return value switch
            {
                "mcp_connect" => TtsMcpProbeErrorDetailsStage.McpConnect,
                "mcp_initialize" => TtsMcpProbeErrorDetailsStage.McpInitialize,
                "mcp_list_tools" => TtsMcpProbeErrorDetailsStage.McpListTools,
                "mcp_notify" => TtsMcpProbeErrorDetailsStage.McpNotify,
                "oauth2_token" => TtsMcpProbeErrorDetailsStage.Oauth2Token,
                "validation" => TtsMcpProbeErrorDetailsStage.Validation,
                _ => null,
            };
        }
    }
}