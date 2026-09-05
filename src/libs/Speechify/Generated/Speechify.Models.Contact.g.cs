
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A workspace-scoped person. Identity lives in the `identifiers` set,<br/>
    /// not in this row: a contact is whoever those handles denote, and each<br/>
    /// handle records who vouched for it.
    /// </summary>
    public sealed partial class Contact
    {
        /// <summary>
        /// Prefixed wire identifier (`contact_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this prefixed form; bare UUIDs are rejected<br/>
        /// with 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Workspace that owns this contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TenantId { get; set; }

        /// <summary>
        /// Operator-editable name. Absent when nobody has named this person<br/>
        /// and no resolver supplied one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Customer-controlled JSON blob.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// The contact's live identifiers. Always present; empty only for a<br/>
        /// contact whose every link has been detached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.ContactIdentifier> Identifiers { get; set; }

        /// <summary>
        /// Earliest sighting across every channel and agent. A merge widens<br/>
        /// this to span both records, because the window belongs to the<br/>
        /// person rather than to whichever record saw them first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FirstSeenAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastSeenAt { get; set; }

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
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`contact_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this prefixed form; bare UUIDs are rejected<br/>
        /// with 404.
        /// </param>
        /// <param name="tenantId">
        /// Workspace that owns this contact.
        /// </param>
        /// <param name="metadata">
        /// Customer-controlled JSON blob.
        /// </param>
        /// <param name="identifiers">
        /// The contact's live identifiers. Always present; empty only for a<br/>
        /// contact whose every link has been detached.
        /// </param>
        /// <param name="firstSeenAt">
        /// Earliest sighting across every channel and agent. A merge widens<br/>
        /// this to span both records, because the window belongs to the<br/>
        /// person rather than to whichever record saw them first.
        /// </param>
        /// <param name="lastSeenAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="displayName">
        /// Operator-editable name. Absent when nobody has named this person<br/>
        /// and no resolver supplied one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Contact(
            string id,
            string tenantId,
            object metadata,
            global::System.Collections.Generic.IList<global::Speechify.ContactIdentifier> identifiers,
            global::System.DateTime firstSeenAt,
            global::System.DateTime lastSeenAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? displayName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TenantId = tenantId ?? throw new global::System.ArgumentNullException(nameof(tenantId));
            this.DisplayName = displayName;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Identifiers = identifiers ?? throw new global::System.ArgumentNullException(nameof(identifiers));
            this.FirstSeenAt = firstSeenAt;
            this.LastSeenAt = lastSeenAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        public Contact()
        {
        }

    }
}