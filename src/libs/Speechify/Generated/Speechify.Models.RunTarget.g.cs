
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The agent a targeted run binds to at run time. `agent_id` is<br/>
    /// required. `version` and `tag` pin a specific agent version once<br/>
    /// agent versioning ships; supplying either today returns 400, so<br/>
    /// agent-id targeting works now and version/tag light up later without<br/>
    /// a wire change.
    /// </summary>
    public sealed partial class RunTarget
    {
        /// <summary>
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent to run every test against: the run target, bound<br/>
        /// at run time, independent of any test's authored-from agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Reserved for version-pinned targeting once agent versioning<br/>
        /// ships. Not supported yet; supplying it returns 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Reserved for tag targeting once agent versioning ships. Not<br/>
        /// supported yet; supplying it returns 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTarget" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Prefixed wire identifier (`agent_&lt;26 char Crockford base32&gt;`)<br/>
        /// of the agent to run every test against: the run target, bound<br/>
        /// at run time, independent of any test's authored-from agent.
        /// </param>
        /// <param name="version">
        /// Reserved for version-pinned targeting once agent versioning<br/>
        /// ships. Not supported yet; supplying it returns 400.
        /// </param>
        /// <param name="tag">
        /// Reserved for tag targeting once agent versioning ships. Not<br/>
        /// supported yet; supplying it returns 400.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunTarget(
            string agentId,
            string? version,
            string? tag)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Version = version;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunTarget" /> class.
        /// </summary>
        public RunTarget()
        {
        }

    }
}