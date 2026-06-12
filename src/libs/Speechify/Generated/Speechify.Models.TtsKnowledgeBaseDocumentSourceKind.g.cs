
#nullable enable

namespace Speechify
{
    /// <summary>
    /// How the document entered the KB. `file` is the upload path,<br/>
    /// `text` is inline pasted content, `url` is fetched via<br/>
    /// Firecrawl. Sitemap and crawl imports also produce `url` rows.
    /// </summary>
    public enum TtsKnowledgeBaseDocumentSourceKind
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
    public static class TtsKnowledgeBaseDocumentSourceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsKnowledgeBaseDocumentSourceKind value)
        {
            return value switch
            {
                TtsKnowledgeBaseDocumentSourceKind.File => "file",
                TtsKnowledgeBaseDocumentSourceKind.Text => "text",
                TtsKnowledgeBaseDocumentSourceKind.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsKnowledgeBaseDocumentSourceKind? ToEnum(string value)
        {
            return value switch
            {
                "file" => TtsKnowledgeBaseDocumentSourceKind.File,
                "text" => TtsKnowledgeBaseDocumentSourceKind.Text,
                "url" => TtsKnowledgeBaseDocumentSourceKind.Url,
                _ => null,
            };
        }
    }
}