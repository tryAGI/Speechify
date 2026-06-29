
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Customer-facing dynamic variables this call ran with: the<br/>
    /// agent's stored variable defaults overlaid with the<br/>
    /// per-session `dynamic_variables` overrides, resolved to<br/>
    /// their values. Reserved `system__*` keys are excluded —<br/>
    /// they are runtime-derived and not part of the audit<br/>
    /// snapshot. Omitted for SIP inbound calls (which take no<br/>
    /// per-session variables) and for legacy conversations<br/>
    /// recorded before this field existed. Populated only on<br/>
    /// detail responses; the<br/>
    /// list endpoint skips it, mirroring `agent_snapshot`.
    /// </summary>
    public sealed partial class ConversationDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}