
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Display names for open-enum group values the client can't resolve from its own list endpoints, keyed by dimension then by the group value. Populated for `agent_id` so a soft-deleted agent (absent from the live agent list) renders "&lt;name&gt; (deleted)" instead of a bare `agent_&lt;id&gt;`. Absent when no group needs server-side resolution.
    /// </summary>
    public sealed partial class AnalyticsQueryResultLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}