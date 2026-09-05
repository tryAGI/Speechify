
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The document body (a JSON object, at most 256 KiB). On `updateDocument`, the fields to merge; a null removes a field.
    /// </summary>
    public sealed partial class WriteStoreDocumentRequestData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}