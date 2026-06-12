
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-call variable overrides merged on top of the agent's stored<br/>
    /// defaults. Keys must not use the reserved `system__` prefix.<br/>
    /// Useful for injecting per-call context (customer name, order ID)<br/>
    /// into the agent prompt.
    /// </summary>
    public sealed partial class TtsCreateOutboundCallRequestDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}