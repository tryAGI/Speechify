
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The arguments the agent would pass: each param by its `name`, plus<br/>
    /// `body` when the operation takes one. Omitted, the call carries none.
    /// </summary>
    public sealed partial class TestOpenAPICallRequestArguments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}