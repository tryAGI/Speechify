
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenApiBodyContentType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenApiBodyContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenApiBodyContentType value)
        {
            return value switch
            {
                OpenApiBodyContentType.ApplicationJson => "application/json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenApiBodyContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => OpenApiBodyContentType.ApplicationJson,
                _ => null,
            };
        }
    }
}