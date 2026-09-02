
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Full per-type run detail (transcript, tool calls, per-type<br/>
    /// result), for a consumer that needs the synthetic conversation.<br/>
    /// Present when the case ran; absent on an errored case.
    /// </summary>
    public sealed partial class EvaluationCaseVerdictResult
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}