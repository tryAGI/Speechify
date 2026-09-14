
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Fields to add, keyed by where they land: the last segment is the<br/>
    /// field name, the segments before it the scope, so `issues[].url`<br/>
    /// adds `url` to every issue and `summary_url` adds it at the root.<br/>
    /// The value is a template whose `{{path}}` placeholders resolve<br/>
    /// relative to that scope; a missing value renders empty. A field the<br/>
    /// result already has is never overwritten.
    /// </summary>
    public sealed partial class ToolResponseMappingDerive
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}