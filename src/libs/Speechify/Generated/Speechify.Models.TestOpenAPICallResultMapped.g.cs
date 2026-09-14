
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The same answer after the operation's `response` mapping and<br/>
    /// before trimming: what a hosted API `tool` route would respond with.<br/>
    /// Identical to `raw` when the operation has no mapping or the mapping<br/>
    /// changed nothing. Present only when `outcome` is `ok` and the vendor<br/>
    /// answered JSON.
    /// </summary>
    public sealed partial class TestOpenAPICallResultMapped
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}