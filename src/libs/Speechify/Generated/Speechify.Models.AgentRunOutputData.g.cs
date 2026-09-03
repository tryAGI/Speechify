
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The structured output, present only when the run carried an<br/>
    /// `output_schema` and the agent produced an object satisfying it.<br/>
    /// Never present alongside `incomplete_reason: output_schema_violation`.
    /// </summary>
    public sealed partial class AgentRunOutputData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}