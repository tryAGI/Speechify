
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How long to keep it. `ephemeral` (the default) is working material<br/>
    /// for a run and is deleted after 14 days. `kept` survives until you<br/>
    /// delete it - use it for anything an agent produced that you intend to<br/>
    /// keep or serve.
    /// </summary>
    public enum V1FilesPostRequestBodyContentMultipartFormDataSchemaKind
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
    public static class V1FilesPostRequestBodyContentMultipartFormDataSchemaKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1FilesPostRequestBodyContentMultipartFormDataSchemaKind value)
        {
            return value switch
            {
                V1FilesPostRequestBodyContentMultipartFormDataSchemaKind.Ephemeral => "ephemeral",
                V1FilesPostRequestBodyContentMultipartFormDataSchemaKind.Kept => "kept",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1FilesPostRequestBodyContentMultipartFormDataSchemaKind? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => V1FilesPostRequestBodyContentMultipartFormDataSchemaKind.Ephemeral,
                "kept" => V1FilesPostRequestBodyContentMultipartFormDataSchemaKind.Kept,
                _ => null,
            };
        }
    }
}