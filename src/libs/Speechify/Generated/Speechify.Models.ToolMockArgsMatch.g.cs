
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional structured argument matcher. When set, the mock fires<br/>
    /// only if the tool call's arguments deep-contain every key/value<br/>
    /// in this object: nested objects match recursively as subsets,<br/>
    /// arrays and scalar leaves match by deep equality. An empty<br/>
    /// object matches unconditionally. When absent the mock matches<br/>
    /// unconditionally for this tool.
    /// </summary>
    public sealed partial class ToolMockArgsMatch
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}