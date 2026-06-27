
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Memory projection returned by the per-caller memories list. Mirrors<br/>
    /// the legacy `/v1/agents/{agent_id}/memories` shape so console code can<br/>
    /// re-use existing renderers.
    /// </summary>
    public sealed partial class CallerMemoryItem
    {
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallerIdentity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fact { get; set; }

        /// <summary>
        /// When set, the prefixed wire identifier<br/>
        /// (`conv_&lt;26 char Crockford base32&gt;`) of the conversation this<br/>
        /// memory was extracted from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_conversation_id")]
        public string? SourceConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

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
        /// Initializes a new instance of the <see cref="CallerMemoryItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the owning agent.
        /// </param>
        /// <param name="callerIdentity"></param>
        /// <param name="fact"></param>
        /// <param name="confidence"></param>
        /// <param name="createdAt"></param>
        /// <param name="sourceConversationId">
        /// When set, the prefixed wire identifier<br/>
        /// (`conv_&lt;26 char Crockford base32&gt;`) of the conversation this<br/>
        /// memory was extracted from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallerMemoryItem(
            string id,
            string agentId,
            string callerIdentity,
            string fact,
            double confidence,
            global::System.DateTime createdAt,
            string? sourceConversationId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CallerIdentity = callerIdentity ?? throw new global::System.ArgumentNullException(nameof(callerIdentity));
            this.Fact = fact ?? throw new global::System.ArgumentNullException(nameof(fact));
            this.SourceConversationId = sourceConversationId;
            this.Confidence = confidence;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallerMemoryItem" /> class.
        /// </summary>
        public CallerMemoryItem()
        {
        }

    }
}