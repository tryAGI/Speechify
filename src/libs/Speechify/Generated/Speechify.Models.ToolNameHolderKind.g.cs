
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What the holder is.
    /// </summary>
    public enum ToolNameHolderKind
    {
        /// <summary>
        ///
        /// </summary>
        Builtin,
        /// <summary>
        ///
        /// </summary>
        Client,
        /// <summary>
        ///
        /// </summary>
        Mcp,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolNameHolderKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolNameHolderKind value)
        {
            return value switch
            {
                ToolNameHolderKind.Builtin => "builtin",
                ToolNameHolderKind.Client => "client",
                ToolNameHolderKind.Mcp => "mcp",
                ToolNameHolderKind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolNameHolderKind? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ToolNameHolderKind.Builtin,
                "client" => ToolNameHolderKind.Client,
                "mcp" => ToolNameHolderKind.Mcp,
                "webhook" => ToolNameHolderKind.Webhook,
                _ => null,
            };
        }
    }
}