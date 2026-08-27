
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the document entered the KB. `file` is the upload path,<br/>
    /// `text` is inline pasted content, `url` is fetched via<br/>
    /// Firecrawl. Sitemap and crawl imports also produce `url` rows.
    /// </summary>
    public enum KnowledgeBaseDocumentSourceKind
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseDocumentSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseDocumentSourceKind value)
        {
            return value switch
            {
                KnowledgeBaseDocumentSourceKind.File => "file",
                KnowledgeBaseDocumentSourceKind.Text => "text",
                KnowledgeBaseDocumentSourceKind.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseDocumentSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "file" => KnowledgeBaseDocumentSourceKind.File,
                "text" => KnowledgeBaseDocumentSourceKind.Text,
                "url" => KnowledgeBaseDocumentSourceKind.Url,
                _ => null,
            };
        }
    }
}