
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedApiResolverType
    {
        /// <summary>
        ///
        /// </summary>
        Run,
        /// <summary>
        ///
        /// </summary>
        RunLatest,
        /// <summary>
        ///
        /// </summary>
        StoreDocument,
        /// <summary>
        ///
        /// </summary>
        StoreQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedApiResolverTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedApiResolverType value)
        {
            return value switch
            {
                HostedApiResolverType.Run => "run",
                HostedApiResolverType.RunLatest => "run_latest",
                HostedApiResolverType.StoreDocument => "store_document",
                HostedApiResolverType.StoreQuery => "store_query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedApiResolverType? ToEnum(string value)
        {
            return value switch
            {
                "run" => HostedApiResolverType.Run,
                "run_latest" => HostedApiResolverType.RunLatest,
                "store_document" => HostedApiResolverType.StoreDocument,
                "store_query" => HostedApiResolverType.StoreQuery,
                _ => null,
            };
        }
    }
}