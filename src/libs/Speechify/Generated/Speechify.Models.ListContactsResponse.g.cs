
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Payload for GET /v1/contacts.
    /// </summary>
    public sealed partial class ListContactsResponse
    {
        /// <summary>
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// True when more rows exist beyond this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contacts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Speechify.Contact> Contacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactsResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// True when more rows exist beyond this page.
        /// </param>
        /// <param name="contacts"></param>
        /// <param name="nextCursor">
        /// Opaque keyset cursor for the next page. Pass back as the<br/>
        /// `cursor` request parameter. `null` when the caller has<br/>
        /// reached the end of the list (`has_more` is also `false`<br/>
        /// in that case).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListContactsResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Speechify.Contact> contacts,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Contacts = contacts ?? throw new global::System.ArgumentNullException(nameof(contacts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContactsResponse" /> class.
        /// </summary>
        public ListContactsResponse()
        {
        }

    }
}