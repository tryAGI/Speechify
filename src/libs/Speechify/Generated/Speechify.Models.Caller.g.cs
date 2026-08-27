
#nullable enable

namespace Speechify
{
    /// <summary>
    /// First-class Caller entity. Identified by<br/>
    /// the (tenant, agent, identity) triple. Memories and conversations<br/>
    /// FK at it via `caller_id`.
    /// </summary>
    public sealed partial class Caller
    {
        /// <summary>
        /// Prefixed wire identifier (`caller_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`ws_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the owning workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent the caller is scoped under.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The raw identifier the caller arrived with (E.164 phone for SIP, LiveKit<br/>
        /// participant id for web). Stable for the life of the caller row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller_identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallerIdentity { get; set; }

        /// <summary>
        /// Operator-editable display name, nullable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional handle into the customer's own CRM, nullable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ref")]
        public string? ExternalRef { get; set; }

        /// <summary>
        /// Customer-supplied JSON metadata blob.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Timestamp of the earliest observed conversation / memory for this caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FirstSeenAt { get; set; }

        /// <summary>
        /// Timestamp of the most recent observation. Drives the default list ordering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastSeenAt { get; set; }

        /// <summary>
        /// Number of conversation rows currently pointing at this caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConversationCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Caller" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`caller_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="tenantId">
        /// Prefixed wire identifier (`ws_&lt;26 char Crockford base32&gt;`) of<br/>
        /// the owning workspace.
        /// </param>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent the caller is scoped under.
        /// </param>
        /// <param name="callerIdentity">
        /// The raw identifier the caller arrived with (E.164 phone for SIP, LiveKit<br/>
        /// participant id for web). Stable for the life of the caller row.
        /// </param>
        /// <param name="metadata">
        /// Customer-supplied JSON metadata blob.
        /// </param>
        /// <param name="firstSeenAt">
        /// Timestamp of the earliest observed conversation / memory for this caller.
        /// </param>
        /// <param name="lastSeenAt">
        /// Timestamp of the most recent observation. Drives the default list ordering.
        /// </param>
        /// <param name="conversationCount">
        /// Number of conversation rows currently pointing at this caller.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="displayName">
        /// Operator-editable display name, nullable.
        /// </param>
        /// <param name="externalRef">
        /// Optional handle into the customer's own CRM, nullable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Caller(
            string id,
            string tenantId,
            string agentId,
            string callerIdentity,
            object metadata,
            global::System.DateTime firstSeenAt,
            global::System.DateTime lastSeenAt,
            int conversationCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? displayName,
            string? externalRef)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CallerIdentity = callerIdentity ?? throw new global::System.ArgumentNullException(nameof(callerIdentity));
            this.DisplayName = displayName;
            this.ExternalRef = externalRef;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.FirstSeenAt = firstSeenAt;
            this.LastSeenAt = lastSeenAt;
            this.ConversationCount = conversationCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Caller" /> class.
        /// </summary>
        public Caller()
        {
        }

    }
}