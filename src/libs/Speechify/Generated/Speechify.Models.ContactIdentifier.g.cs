
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One typed handle attached to a contact, with the provenance that<br/>
    /// decides what may be joined to what. Two identifiers carrying the same<br/>
    /// `value` at different `asserted_by` levels are two different<br/>
    /// identifiers on two different contacts - collapsing them is exactly the<br/>
    /// cross-caller disclosure the trust model exists to prevent.
    /// </summary>
    public sealed partial class ContactIdentifier
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContactId { get; set; }

        /// <summary>
        /// The namespace the value lives in. Values of different kinds never<br/>
        /// denote the same person by themselves, whatever they look like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ContactIdentifierKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ContactIdentifierKind Kind { get; set; }

        /// <summary>
        /// The handle itself - an application user id, an E.164 number, an email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Who vouched for this identifier. Server-assigned, never accepted<br/>
        /// from a client.<br/>
        /// - `api` - your authenticated backend, via this endpoint or a<br/>
        ///   server-to-server session. May be linked to an existing contact.<br/>
        /// - `telephony` - carrier ANI on an inbound call. Trustworthy as a<br/>
        ///   fact about the call and silent about which of your users it is,<br/>
        ///   so it creates a phone-only contact until you say otherwise.<br/>
        /// - `unverified` - a self-asserted claim from a public or embedded<br/>
        ///   browser session. Nobody stands behind it, so it never joins a<br/>
        ///   verified contact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asserted_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.ContactIdentifierAssertedByJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.ContactIdentifierAssertedBy AssertedBy { get; set; }

        /// <summary>
        /// When an authenticated party asserted this identifier. Absent<br/>
        /// exactly when `asserted_by` is `unverified`, which is what lets you<br/>
        /// tell a vouched-for handle from a self-claim without re-deriving it<br/>
        /// from the value's shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_at")]
        public global::System.DateTime? VerifiedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="ContactIdentifier" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contactId"></param>
        /// <param name="kind">
        /// The namespace the value lives in. Values of different kinds never<br/>
        /// denote the same person by themselves, whatever they look like.
        /// </param>
        /// <param name="value">
        /// The handle itself - an application user id, an E.164 number, an email address.
        /// </param>
        /// <param name="assertedBy">
        /// Who vouched for this identifier. Server-assigned, never accepted<br/>
        /// from a client.<br/>
        /// - `api` - your authenticated backend, via this endpoint or a<br/>
        ///   server-to-server session. May be linked to an existing contact.<br/>
        /// - `telephony` - carrier ANI on an inbound call. Trustworthy as a<br/>
        ///   fact about the call and silent about which of your users it is,<br/>
        ///   so it creates a phone-only contact until you say otherwise.<br/>
        /// - `unverified` - a self-asserted claim from a public or embedded<br/>
        ///   browser session. Nobody stands behind it, so it never joins a<br/>
        ///   verified contact.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="verifiedAt">
        /// When an authenticated party asserted this identifier. Absent<br/>
        /// exactly when `asserted_by` is `unverified`, which is what lets you<br/>
        /// tell a vouched-for handle from a self-claim without re-deriving it<br/>
        /// from the value's shape.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContactIdentifier(
            string id,
            string contactId,
            global::Speechify.ContactIdentifierKind kind,
            string value,
            global::Speechify.ContactIdentifierAssertedBy assertedBy,
            global::System.DateTime createdAt,
            global::System.DateTime? verifiedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ContactId = contactId ?? throw new global::System.ArgumentNullException(nameof(contactId));
            this.Kind = kind;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.AssertedBy = assertedBy;
            this.VerifiedAt = verifiedAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactIdentifier" /> class.
        /// </summary>
        public ContactIdentifier()
        {
        }

    }
}