
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The run's metadata. `trigger` says how the run started: `api`, `manual`, `schedule`, `webhook`, `team` or `delegation`.
    /// </summary>
    public sealed partial class AgentRunLifecycleMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}