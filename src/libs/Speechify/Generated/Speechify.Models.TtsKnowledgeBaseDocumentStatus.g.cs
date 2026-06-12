
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Document lifecycle. `fetching` is the pre-scrape state used<br/>
    /// only by url-sourced rows; file and text docs skip straight<br/>
    /// to `embedding` because their content is available<br/>
    /// synchronously. Terminal states are `ready` and `failed`.
    /// </summary>
    public enum TtsKnowledgeBaseDocumentStatus
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
    public static class TtsKnowledgeBaseDocumentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsKnowledgeBaseDocumentStatus value)
        {
            return value switch
            {
                TtsKnowledgeBaseDocumentStatus.Embedding => "embedding",
                TtsKnowledgeBaseDocumentStatus.Failed => "failed",
                TtsKnowledgeBaseDocumentStatus.Fetching => "fetching",
                TtsKnowledgeBaseDocumentStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsKnowledgeBaseDocumentStatus? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => TtsKnowledgeBaseDocumentStatus.Embedding,
                "failed" => TtsKnowledgeBaseDocumentStatus.Failed,
                "fetching" => TtsKnowledgeBaseDocumentStatus.Fetching,
                "ready" => TtsKnowledgeBaseDocumentStatus.Ready,
                _ => null,
            };
        }
    }
}