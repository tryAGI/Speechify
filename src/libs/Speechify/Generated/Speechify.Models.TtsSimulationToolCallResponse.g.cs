
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Response returned to the agent (absent for system tools that end the call).
    /// </summary>
    public sealed partial class TtsSimulationToolCallResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}