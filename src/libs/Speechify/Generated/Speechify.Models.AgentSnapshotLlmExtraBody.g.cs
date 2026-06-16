
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Extra chat.completions body forwarded verbatim for custom-provider agents; null otherwise.
    /// </summary>
    public sealed partial class AgentSnapshotLlmExtraBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}