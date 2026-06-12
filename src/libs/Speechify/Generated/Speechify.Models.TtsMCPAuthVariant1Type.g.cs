
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminator value: none
    /// </summary>
    public enum TtsMCPAuthVariant1Type
    {
        /// <summary>
        /// none
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TtsMCPAuthVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsMCPAuthVariant1Type value)
        {
            return value switch
            {
                TtsMCPAuthVariant1Type.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsMCPAuthVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "none" => TtsMCPAuthVariant1Type.None,
                _ => null,
            };
        }
    }
}