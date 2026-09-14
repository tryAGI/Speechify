
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The vendor's JSON answer as it came, before the operation's<br/>
    /// `response` mapping. Present only when `outcome` is `ok` and the<br/>
    /// vendor answered JSON.
    /// </summary>
    public sealed partial class TestOpenAPICallResultRaw
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}