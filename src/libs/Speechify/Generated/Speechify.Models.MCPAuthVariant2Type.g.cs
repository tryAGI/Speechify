
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminator value: bearer
    /// </summary>
    public enum MCPAuthVariant2Type
    {
        /// <summary>
        /// bearer
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPAuthVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPAuthVariant2Type value)
        {
            return value switch
            {
                MCPAuthVariant2Type.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPAuthVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => MCPAuthVariant2Type.Bearer,
                _ => null,
            };
        }
    }
}