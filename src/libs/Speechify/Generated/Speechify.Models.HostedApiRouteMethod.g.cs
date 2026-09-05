
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedApiRouteMethod
    {
        /// <summary>
        ///
        /// </summary>
        Get,
        /// <summary>
        ///
        /// </summary>
        Post,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiRouteMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiRouteMethod value)
        {
            return value switch
            {
                HostedApiRouteMethod.Get => "GET",
                HostedApiRouteMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiRouteMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => HostedApiRouteMethod.Get,
                "POST" => HostedApiRouteMethod.Post,
                _ => null,
            };
        }
    }
}