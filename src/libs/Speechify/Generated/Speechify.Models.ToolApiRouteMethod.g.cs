
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolApiRouteMethod
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
    public static class ToolApiRouteMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolApiRouteMethod value)
        {
            return value switch
            {
                ToolApiRouteMethod.Get => "GET",
                ToolApiRouteMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolApiRouteMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => ToolApiRouteMethod.Get,
                "POST" => ToolApiRouteMethod.Post,
                _ => null,
            };
        }
    }
}