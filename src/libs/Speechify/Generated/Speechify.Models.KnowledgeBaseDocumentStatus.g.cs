
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Document lifecycle. `fetching` is the pre-scrape state used<br/>
    /// only by url-sourced rows; file and text docs skip straight<br/>
    /// to `embedding` because their content is available<br/>
    /// synchronously. Terminal states are `ready` and `failed`.
    /// </summary>
    public enum KnowledgeBaseDocumentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Fetching,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseDocumentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseDocumentStatus value)
        {
            return value switch
            {
                KnowledgeBaseDocumentStatus.Embedding => "embedding",
                KnowledgeBaseDocumentStatus.Failed => "failed",
                KnowledgeBaseDocumentStatus.Fetching => "fetching",
                KnowledgeBaseDocumentStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseDocumentStatus? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => KnowledgeBaseDocumentStatus.Embedding,
                "failed" => KnowledgeBaseDocumentStatus.Failed,
                "fetching" => KnowledgeBaseDocumentStatus.Fetching,
                "ready" => KnowledgeBaseDocumentStatus.Ready,
                _ => null,
            };
        }
    }
}