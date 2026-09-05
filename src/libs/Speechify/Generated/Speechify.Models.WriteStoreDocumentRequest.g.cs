
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WriteStoreDocumentRequest
    {
        /// <summary>
        /// On `createDocument`, the id to write at (letters, digits, `_ . - : ~ @ +`, at most 200);<br/>
        /// minted when absent. Ignored on `putDocument` / `updateDocument`, where the URL names it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The document body (a JSON object, at most 256 KiB). On `updateDocument`, the fields to merge; a null removes a field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteStoreDocumentRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// The document body (a JSON object, at most 256 KiB). On `updateDocument`, the fields to merge; a null removes a field.
        /// </param>
        /// <param name="id">
        /// On `createDocument`, the id to write at (letters, digits, `_ . - : ~ @ +`, at most 200);<br/>
        /// minted when absent. Ignored on `putDocument` / `updateDocument`, where the URL names it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WriteStoreDocumentRequest(
            object data,
            string? id)
        {
            this.Id = id;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteStoreDocumentRequest" /> class.
        /// </summary>
        public WriteStoreDocumentRequest()
        {
        }

    }
}