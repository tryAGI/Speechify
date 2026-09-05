
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Retrieval's verdict on whether the evidence it found answers the<br/>
    /// question. `sufficient`: answer from the hits. `partial`: something<br/>
    /// related was found; answer with care. `insufficient`: nothing found<br/>
    /// clears even the low bar, and the honest answer is that the knowledge<br/>
    /// base does not cover this; the agent's `search_knowledge` tool then<br/>
    /// reports no relevant context rather than the weak hits.
    /// </summary>
    public enum RetrievalCoverage
    {
        /// <summary>
        /// nothing found
        /// </summary>
        Insufficient,
        /// <summary>
        /// answer from the hits. `partial`: something
        /// </summary>
        Partial,
        /// <summary>
        /// answer from the hits. `partial`: something
        /// </summary>
        Sufficient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrievalCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalCoverage value)
        {
            return value switch
            {
                RetrievalCoverage.Insufficient => "insufficient",
                RetrievalCoverage.Partial => "partial",
                RetrievalCoverage.Sufficient => "sufficient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalCoverage? ToEnum(string value)
        {
            return value switch
            {
                "insufficient" => RetrievalCoverage.Insufficient,
                "partial" => RetrievalCoverage.Partial,
                "sufficient" => RetrievalCoverage.Sufficient,
                _ => null,
            };
        }
    }
}