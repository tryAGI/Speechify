
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminator value: none
    /// </summary>
    public enum MCPAuthVariant1Type
    {
        /// <summary>
        /// none
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPAuthVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPAuthVariant1Type value)
        {
            return value switch
            {
                MCPAuthVariant1Type.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPAuthVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "none" => MCPAuthVariant1Type.None,
                _ => null,
            };
        }
    }
}