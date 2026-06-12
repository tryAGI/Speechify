
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-session variable overrides that merge on top of the agent's<br/>
    /// stored variable defaults for this one session. Keys in the<br/>
    /// reserved `system__` namespace are rejected at this boundary.<br/>
    /// Values must match the declared type of the corresponding variable<br/>
    /// definition on the agent (a `string` type expects a JSON string,<br/>
    /// `number` expects a JSON number, etc.).
    /// </summary>
    public sealed partial class TtsCreateSessionRequestDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}