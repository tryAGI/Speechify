
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-test dynamic-variable overrides. Keys substitute `{{key}}`<br/>
    /// placeholders inside the test config at run-start. Unknown keys<br/>
    /// render as empty string, matching session dispatch behaviour.
    /// </summary>
    public sealed partial class TtsAgentTestVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}