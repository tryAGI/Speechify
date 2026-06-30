
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1UsageRequestsAnalyticsGetParametersMethodSchemaItems
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
    public static class V1UsageRequestsAnalyticsGetParametersMethodSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1UsageRequestsAnalyticsGetParametersMethodSchemaItems value)
        {
            return value switch
            {
                V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Delete => "DELETE",
                V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Get => "GET",
                V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Head => "HEAD",
                V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Options => "OPTIONS",
                V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Patch => "PATCH",
                V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Post => "POST",
                V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1UsageRequestsAnalyticsGetParametersMethodSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Delete,
                "GET" => V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Get,
                "HEAD" => V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Head,
                "OPTIONS" => V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Options,
                "PATCH" => V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Patch,
                "POST" => V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Post,
                "PUT" => V1UsageRequestsAnalyticsGetParametersMethodSchemaItems.Put,
                _ => null,
            };
        }
    }
}