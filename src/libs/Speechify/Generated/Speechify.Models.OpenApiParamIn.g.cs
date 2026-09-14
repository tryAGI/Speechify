
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Where the value rides. A `header` param may not be `Authorization`,<br/>
    /// `Host`, `Content-Type`, `Content-Length`, `Transfer-Encoding`,<br/>
    /// `Connection` or any `Speechify-` header.
    /// </summary>
    public enum OpenApiParamIn
    {
        /// <summary>
        ///
        /// </summary>
        Header,
        /// <summary>
        ///
        /// </summary>
        Path,
        /// <summary>
        ///
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenApiParamInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenApiParamIn value)
        {
            return value switch
            {
                OpenApiParamIn.Header => "header",
                OpenApiParamIn.Path => "path",
                OpenApiParamIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenApiParamIn? ToEnum(string value)
        {
            return value switch
            {
                "header" => OpenApiParamIn.Header,
                "path" => OpenApiParamIn.Path,
                "query" => OpenApiParamIn.Query,
                _ => null,
            };
        }
    }
}