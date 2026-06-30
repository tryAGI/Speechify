
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1UsageRequestsGetParametersMethodSchemaItems
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
        Options,
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
    public static class V1UsageRequestsGetParametersMethodSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1UsageRequestsGetParametersMethodSchemaItems value)
        {
            return value switch
            {
                V1UsageRequestsGetParametersMethodSchemaItems.Delete => "DELETE",
                V1UsageRequestsGetParametersMethodSchemaItems.Get => "GET",
                V1UsageRequestsGetParametersMethodSchemaItems.Head => "HEAD",
                V1UsageRequestsGetParametersMethodSchemaItems.Options => "OPTIONS",
                V1UsageRequestsGetParametersMethodSchemaItems.Patch => "PATCH",
                V1UsageRequestsGetParametersMethodSchemaItems.Post => "POST",
                V1UsageRequestsGetParametersMethodSchemaItems.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1UsageRequestsGetParametersMethodSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => V1UsageRequestsGetParametersMethodSchemaItems.Delete,
                "GET" => V1UsageRequestsGetParametersMethodSchemaItems.Get,
                "HEAD" => V1UsageRequestsGetParametersMethodSchemaItems.Head,
                "OPTIONS" => V1UsageRequestsGetParametersMethodSchemaItems.Options,
                "PATCH" => V1UsageRequestsGetParametersMethodSchemaItems.Patch,
                "POST" => V1UsageRequestsGetParametersMethodSchemaItems.Post,
                "PUT" => V1UsageRequestsGetParametersMethodSchemaItems.Put,
                _ => null,
            };
        }
    }
}