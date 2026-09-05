
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateHostedApiRouteRequestMethod
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
    public static class UpdateHostedApiRouteRequestMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateHostedApiRouteRequestMethod value)
        {
            return value switch
            {
                UpdateHostedApiRouteRequestMethod.Get => "GET",
                UpdateHostedApiRouteRequestMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateHostedApiRouteRequestMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => UpdateHostedApiRouteRequestMethod.Get,
                "POST" => UpdateHostedApiRouteRequestMethod.Post,
                _ => null,
            };
        }
    }
}