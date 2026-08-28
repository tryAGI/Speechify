
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The pass/fail judgment, present only once the run reached a<br/>
    /// verdict (`status` is `completed`).
    /// </summary>
    public sealed partial class AgentTestRunVerdict
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}