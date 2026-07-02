
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One salient fact extracted post-call about a specific caller on<br/>
    /// a specific agent. Retrieved at the next conversation-start for<br/>
    /// the same caller and injected into the agent's system prompt via<br/>
    /// the `{{memory}}` template variable.
    /// </summary>
    public sealed partial class Memory
    {
        /// <summary>
        /// Prefixed wire identifier (`memory_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the owning agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Stable caller key (LiveKit participant identity) the memory is scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallerIdentity { get; set; }

        /// <summary>
        /// Short third-person statement about the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fact { get; set; }

        /// <summary>
        /// When set, the prefixed wire identifier<br/>
        /// (`conv_&lt;26 char Crockford base32&gt;`) of the conversation this<br/>
        /// memory was extracted from. May be null if the source was<br/>
        /// deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_conversation_id")]
        public string? SourceConversationId { get; set; }

        /// <summary>
        /// LLM self-reported 0-1 confidence in the fact's durability and relevance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Confidence { get; set; }

        /// <summary>
        /// Populated only on retrieval hits — recency-weighted cosine similarity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public string? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Memory" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`memory_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the owning agent.
        /// </param>
        /// <param name="callerIdentity">
        /// Stable caller key (LiveKit participant identity) the memory is scoped to.
        /// </param>
        /// <param name="fact">
        /// Short third-person statement about the caller.
        /// </param>
        /// <param name="confidence">
        /// LLM self-reported 0-1 confidence in the fact's durability and relevance.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="sourceConversationId">
        /// When set, the prefixed wire identifier<br/>
        /// (`conv_&lt;26 char Crockford base32&gt;`) of the conversation this<br/>
        /// memory was extracted from. May be null if the source was<br/>
        /// deleted.
        /// </param>
        /// <param name="score">
        /// Populated only on retrieval hits — recency-weighted cosine similarity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Memory(
            string id,
            string agentId,
            string callerIdentity,
            string fact,
            string confidence,
            global::System.DateTime createdAt,
            string? sourceConversationId,
            string? score)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CallerIdentity = callerIdentity ?? throw new global::System.ArgumentNullException(nameof(callerIdentity));
            this.Fact = fact ?? throw new global::System.ArgumentNullException(nameof(fact));
            this.SourceConversationId = sourceConversationId;
            this.Confidence = confidence ?? throw new global::System.ArgumentNullException(nameof(confidence));
            this.Score = score;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Memory" /> class.
        /// </summary>
        public Memory()
        {
        }

    }
}