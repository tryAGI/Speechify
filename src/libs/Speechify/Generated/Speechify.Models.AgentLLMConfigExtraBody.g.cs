
#nullable enable

namespace Speechify
{
    /// <summary>
    /// JSON object forwarded verbatim to the custom endpoint as the<br/>
    /// chat.completions `extra_body` (reasoning / sampling knobs).<br/>
    /// Valid only when `provider` is `custom`.
    /// </summary>
    public sealed partial class AgentLLMConfigExtraBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}