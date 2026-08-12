
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Map inbound SIP headers onto agent variables, so an upstream that<br/>
    /// has already identified the caller can pass that through instead of<br/>
    /// the agent re-verifying it in conversation.<br/>
    /// Each key is an extension header on the INVITE (`X-…`, a valid SIP<br/>
    /// token); each value names the variable its content is exposed under.<br/>
    /// A header mapped to `customer_id` renders in the agent's prompt, and<br/>
    /// in flow tool arguments, as `{{system__sip_customer_id}}`. Two<br/>
    /// headers may not share a variable name, which is the one rule the<br/>
    /// schema cannot state and the server rejects with<br/>
    /// `validation_failed`.<br/>
    /// Only applies to inbound calls on this trunk. For `provider=byoc`<br/>
    /// the mapping takes effect when the trunk's first phone number is<br/>
    /// imported, which is when its inbound route is provisioned.<br/>
    /// **A mapped header is an identity assertion from your own phone<br/>
    /// system, and is only as trustworthy as that system.** PSTN caller ID<br/>
    /// is spoofable and is a hint, not a credential; do not treat either as<br/>
    /// proof of identity for a high-value action. Values are passed to the<br/>
    /// agent as data, never as instructions.
    /// </summary>
    public sealed partial class CreateSIPTrunkRequestHeadersToAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}