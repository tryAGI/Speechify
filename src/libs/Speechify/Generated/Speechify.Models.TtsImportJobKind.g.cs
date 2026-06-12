
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public enum TtsImportJobKind
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
    public static class TtsImportJobKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsImportJobKind value)
        {
            return value switch
            {
                TtsImportJobKind.Crawl => "crawl",
                TtsImportJobKind.Refresh => "refresh",
                TtsImportJobKind.Sitemap => "sitemap",
                TtsImportJobKind.Urls => "urls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsImportJobKind? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => TtsImportJobKind.Crawl,
                "refresh" => TtsImportJobKind.Refresh,
                "sitemap" => TtsImportJobKind.Sitemap,
                "urls" => TtsImportJobKind.Urls,
                _ => null,
            };
        }
    }
}