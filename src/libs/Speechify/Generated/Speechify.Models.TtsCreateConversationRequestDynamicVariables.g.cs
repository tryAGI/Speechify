
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-session variable overrides that merge on top of the agent's<br/>
    /// stored variable defaults for this one conversation. Keys in the<br/>
    /// reserved `system__` namespace are rejected. Values must match the<br/>
    /// declared type of the corresponding variable definition on the agent.
    /// </summary>
    public sealed partial class TtsCreateConversationRequestDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}