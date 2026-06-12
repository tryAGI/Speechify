
#nullable enable

namespace Speechify
{
    /// <summary>
    /// LLM-extracted values for the agent's configured<br/>
    /// data-collection fields. Keys mirror the agent's<br/>
    /// data_collection field keys; values are typed per the<br/>
    /// declared field type.
    /// </summary>
    public sealed partial class TtsSimulationResultData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}