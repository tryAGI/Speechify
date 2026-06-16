
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional JSON object forwarded verbatim to the custom<br/>
    /// endpoint as the chat.completions `extra_body` (reasoning /<br/>
    /// sampling knobs). Valid only when `llm_provider` is<br/>
    /// `custom`.
    /// </summary>
    public sealed partial class CreateAgentRequestLlmExtraBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}