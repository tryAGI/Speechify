
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminator value: bearer
    /// </summary>
    public enum TtsMCPAuthVariant2Type
    {
        /// <summary>
        /// bearer
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsMCPAuthVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMCPAuthVariant2Type value)
        {
            return value switch
            {
                TtsMCPAuthVariant2Type.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMCPAuthVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => TtsMCPAuthVariant2Type.Bearer,
                _ => null,
            };
        }
    }
}