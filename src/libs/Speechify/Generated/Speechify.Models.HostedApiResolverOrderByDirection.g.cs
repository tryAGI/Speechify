
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedApiResolverOrderByDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiResolverOrderByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiResolverOrderByDirection value)
        {
            return value switch
            {
                HostedApiResolverOrderByDirection.Asc => "asc",
                HostedApiResolverOrderByDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiResolverOrderByDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => HostedApiResolverOrderByDirection.Asc,
                "desc" => HostedApiResolverOrderByDirection.Desc,
                _ => null,
            };
        }
    }
}