
#nullable enable

namespace Speechify
{
    /// <summary>
    /// A JSON Schema fragment for the value: `type` is string, number,<br/>
    /// integer, boolean or array (of a scalar `items`), plus `enum`,<br/>
    /// `description` and the ordinary scalar keywords.
    /// </summary>
    public sealed partial class OpenAPIParamSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}