
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-run values that seed the manager's flow variables (override its<br/>
    /// stored defaults). As on a single-agent run, the `system__*`<br/>
    /// namespace and the legacy `memory` alias belong to the platform and<br/>
    /// are rejected with a 400 naming `variables`.
    /// </summary>
    public sealed partial class CreateTeamRunRequestVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}