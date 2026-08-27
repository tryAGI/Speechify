
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public enum ImportJobKind
    {
        /// <summary>
        ///
        /// </summary>
        Crawl,
        /// <summary>
        ///
        /// </summary>
        Refresh,
        /// <summary>
        ///
        /// </summary>
        Sitemap,
        /// <summary>
        ///
        /// </summary>
        Urls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportJobKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportJobKind value)
        {
            return value switch
            {
                ImportJobKind.Crawl => "crawl",
                ImportJobKind.Refresh => "refresh",
                ImportJobKind.Sitemap => "sitemap",
                ImportJobKind.Urls => "urls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportJobKind? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ImportJobKind.Crawl,
                "refresh" => ImportJobKind.Refresh,
                "sitemap" => ImportJobKind.Sitemap,
                "urls" => ImportJobKind.Urls,
                _ => null,
            };
        }
    }
}