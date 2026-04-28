
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Free-form agent config JSON (evaluation_config is read via its own endpoint).
    /// </summary>
    public sealed partial class TtsAgentConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}