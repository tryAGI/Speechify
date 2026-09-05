
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Names the contact being merged AWAY; the survivor is the one in the URL.
    /// </summary>
    public sealed partial class MergeContactsRequest
    {
        /// <summary>
        /// The contact to fold into the one in the URL. It is tombstoned, and<br/>
        /// everything pointing at it is re-pointed at the survivor. Must<br/>
        /// differ from the contact in the URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_contact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromContactId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeContactsRequest" /> class.
        /// </summary>
        /// <param name="fromContactId">
        /// The contact to fold into the one in the URL. It is tombstoned, and<br/>
        /// everything pointing at it is re-pointed at the survivor. Must<br/>
        /// differ from the contact in the URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergeContactsRequest(
            string fromContactId)
        {
            this.FromContactId = fromContactId ?? throw new global::System.ArgumentNullException(nameof(fromContactId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeContactsRequest" /> class.
        /// </summary>
        public MergeContactsRequest()
        {
        }

    }
}