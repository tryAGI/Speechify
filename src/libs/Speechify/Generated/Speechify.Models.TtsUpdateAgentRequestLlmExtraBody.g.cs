
#nullable enable

namespace Speechify
{
    /// <summary>
    /// JSON object forwarded to the custom endpoint as<br/>
    /// chat.completions `extra_body`. Omit to leave unchanged;<br/>
    /// a JSON object (including `{}`) replaces it. Valid only<br/>
    /// when the resulting provider is `custom`.
    /// </summary>
    public sealed partial class TtsUpdateAgentRequestLlmExtraBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}