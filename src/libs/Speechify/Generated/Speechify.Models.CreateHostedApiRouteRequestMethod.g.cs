
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateHostedApiRouteRequestMethod
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
    public static class CreateHostedApiRouteRequestMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateHostedApiRouteRequestMethod value)
        {
            return value switch
            {
                CreateHostedApiRouteRequestMethod.Get => "GET",
                CreateHostedApiRouteRequestMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateHostedApiRouteRequestMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => CreateHostedApiRouteRequestMethod.Get,
                "POST" => CreateHostedApiRouteRequestMethod.Post,
                _ => null,
            };
        }
    }
}