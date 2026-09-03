
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Optional JSON Schema (2020-12, top-level `type: object`) the run's<br/>
    /// final answer must satisfy. When set, the agent answers with a JSON<br/>
    /// object, the platform validates it against this schema (re-asking the<br/>
    /// agent on a mismatch, bounded), and the conforming object is returned<br/>
    /// as `output.data`. A run that never produces a conforming object<br/>
    /// settles `succeeded` with `incomplete_reason: output_schema_violation`<br/>
    /// and no `output.data`. At most 16 KiB.
    /// </summary>
    public sealed partial class CreateAgentRunRequestOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}