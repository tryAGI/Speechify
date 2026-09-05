
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchKnowledgeBasesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseSearchHit> Hits { get; set; }

        /// <summary>
        /// Retrieval's verdict on whether the evidence it found answers the<br/>
        /// question. `sufficient`: answer from the hits. `partial`: something<br/>
        /// related was found; answer with care. `insufficient`: nothing found<br/>
        /// clears even the low bar, and the honest answer is that the knowledge<br/>
        /// base does not cover this; the agent's `search_knowledge` tool then<br/>
        /// reports no relevant context rather than the weak hits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.RetrievalCoverageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.RetrievalCoverage Coverage { get; set; }

        /// <summary>
        /// The retrieval contract that produced this result, so results can<br/>
        /// be compared like with like across a rollout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetrievalVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeBasesResponse" /> class.
        /// </summary>
        /// <param name="hits"></param>
        /// <param name="coverage">
        /// Retrieval's verdict on whether the evidence it found answers the<br/>
        /// question. `sufficient`: answer from the hits. `partial`: something<br/>
        /// related was found; answer with care. `insufficient`: nothing found<br/>
        /// clears even the low bar, and the honest answer is that the knowledge<br/>
        /// base does not cover this; the agent's `search_knowledge` tool then<br/>
        /// reports no relevant context rather than the weak hits.
        /// </param>
        /// <param name="retrievalVersion">
        /// The retrieval contract that produced this result, so results can<br/>
        /// be compared like with like across a rollout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeBasesResponse(
            global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseSearchHit> hits,
            global::Speechify.RetrievalCoverage coverage,
            string retrievalVersion)
        {
            this.Hits = hits ?? throw new global::System.ArgumentNullException(nameof(hits));
            this.Coverage = coverage;
            this.RetrievalVersion = retrievalVersion ?? throw new global::System.ArgumentNullException(nameof(retrievalVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeBasesResponse" /> class.
        /// </summary>
        public SearchKnowledgeBasesResponse()
        {
        }

    }
}