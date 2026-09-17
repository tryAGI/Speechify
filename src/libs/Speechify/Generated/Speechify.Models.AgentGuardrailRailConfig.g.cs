
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Check-specific settings, validated per check. Pattern checks<br/>
    /// take `min_severity` (low, medium, high, critical).<br/>
    /// `pii_patterns` also takes `entities` (a subset of us_ssn,<br/>
    /// credit_card, email, phone) and `placeholder` (the text a<br/>
    /// mask writes over a match, 1 to 64 characters). `tool_authz`<br/>
    /// takes `require_trusted_tools`, `require_trusted_capabilities`<br/>
    /// and `allow_untrusted_tools` (lists of names) and<br/>
    /// `default_require_trusted` (boolean); a capability is a<br/>
    /// tool's action class (read, communicate_internal,<br/>
    /// communicate_external, data_export, financial,<br/>
    /// irreversible_other), read from the agent's attached tools.<br/>
    /// `moderation` takes no settings.
    /// </summary>
    public sealed partial class AgentGuardrailRailConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}