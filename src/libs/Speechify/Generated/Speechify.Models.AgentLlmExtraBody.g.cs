
#nullable enable

namespace Speechify
{
    /// <summary>
    /// JSON object forwarded verbatim to the custom endpoint as<br/>
    /// the chat.completions `extra_body` (reasoning / sampling<br/>
    /// knobs). Non-null only when `llm_provider` is `custom`.
    /// </summary>
    public sealed partial class AgentLlmExtraBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}