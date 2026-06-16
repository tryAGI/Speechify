
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional default value used when no per-session override is<br/>
    /// supplied. Must conform to the declared `type`.
    /// </summary>
    public sealed partial class DynamicVariableDefault
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}