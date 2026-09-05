
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The surviving contact plus the audit tally of what moved onto it, so<br/>
    /// an operator reviewing a merge sees the blast radius without<br/>
    /// re-querying. A retry reports zeros - that is how a client tells<br/>
    /// "already applied" from "nothing matched".
    /// </summary>
    public sealed partial class MergeContactsResponse
    {
        /// <summary>
        /// A workspace-scoped person. Identity lives in the `identifiers` set,<br/>
        /// not in this row: a contact is whoever those handles denote, and each<br/>
        /// handle records who vouched for it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.Contact Contact { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.MergeContactsResponseMerged Merged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeContactsResponse" /> class.
        /// </summary>
        /// <param name="contact">
        /// A workspace-scoped person. Identity lives in the `identifiers` set,<br/>
        /// not in this row: a contact is whoever those handles denote, and each<br/>
        /// handle records who vouched for it.
        /// </param>
        /// <param name="merged"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergeContactsResponse(
            global::Speechify.Contact contact,
            global::Speechify.MergeContactsResponseMerged merged)
        {
            this.Contact = contact ?? throw new global::System.ArgumentNullException(nameof(contact));
            this.Merged = merged ?? throw new global::System.ArgumentNullException(nameof(merged));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeContactsResponse" /> class.
        /// </summary>
        public MergeContactsResponse()
        {
        }

    }
}