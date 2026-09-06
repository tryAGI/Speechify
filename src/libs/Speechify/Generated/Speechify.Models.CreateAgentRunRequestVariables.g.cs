
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Per-run values that seed the agent's flow variables (override its<br/>
    /// stored defaults). The agent's prompt renders against the result<br/>
    /// before every step: a declared variable the run does not supply<br/>
    /// takes its default, one the run supplies takes the run's value, and<br/>
    /// a placeholder nothing supplies renders empty. The reserved<br/>
    /// `system__caller_id`, `system__agent_id`, `system__language` and<br/>
    /// `system__memory` keys are bound by the platform. The `system__*` namespace and the legacy `memory`<br/>
    /// alias belong to the platform and are rejected with a 400 naming<br/>
    /// `variables`, the same rule a conversation applies: the run binds its<br/>
    /// own values there, including `system__caller_id` for the person it<br/>
    /// acts for.
    /// </summary>
    public sealed partial class CreateAgentRunRequestVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}