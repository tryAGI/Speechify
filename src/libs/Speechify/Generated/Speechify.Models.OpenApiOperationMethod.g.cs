
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenApiOperationMethod
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Get,
        /// <summary>
        ///
        /// </summary>
        Head,
        /// <summary>
        ///
        /// </summary>
        Patch,
        /// <summary>
        ///
        /// </summary>
        Post,
        /// <summary>
        ///
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenApiOperationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenApiOperationMethod value)
        {
            return value switch
            {
                OpenApiOperationMethod.Delete => "DELETE",
                OpenApiOperationMethod.Get => "GET",
                OpenApiOperationMethod.Head => "HEAD",
                OpenApiOperationMethod.Patch => "PATCH",
                OpenApiOperationMethod.Post => "POST",
                OpenApiOperationMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenApiOperationMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => OpenApiOperationMethod.Delete,
                "GET" => OpenApiOperationMethod.Get,
                "HEAD" => OpenApiOperationMethod.Head,
                "PATCH" => OpenApiOperationMethod.Patch,
                "POST" => OpenApiOperationMethod.Post,
                "PUT" => OpenApiOperationMethod.Put,
                _ => null,
            };
        }
    }
}