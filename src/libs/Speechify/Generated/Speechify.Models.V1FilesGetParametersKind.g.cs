
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum V1FilesGetParametersKind
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
        /// <summary>
        ///
        /// </summary>
        Kept,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1FilesGetParametersKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1FilesGetParametersKind value)
        {
            return value switch
            {
                V1FilesGetParametersKind.Ephemeral => "ephemeral",
                V1FilesGetParametersKind.Kept => "kept",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1FilesGetParametersKind? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => V1FilesGetParametersKind.Ephemeral,
                "kept" => V1FilesGetParametersKind.Kept,
                _ => null,
            };
        }
    }
}