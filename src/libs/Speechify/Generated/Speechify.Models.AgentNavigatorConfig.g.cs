
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Autonomous IVR-navigation configuration for outbound calls.
    /// </summary>
    public sealed partial class AgentNavigatorConfig
    {
        /// <summary>
        /// Tunes worker turn handling for autonomous outbound IVR<br/>
        /// navigation - longer endpointing and no barge-in. The<br/>
        /// navigation goal itself lives in the agent's prompt; this flag<br/>
        /// is the behaviour switch only. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Controls the IVR-menu cache consulted during navigation.<br/>
        /// Defaults to true so a navigator agent reuses learned menu<br/>
        /// layouts across calls. Set to false to force every outbound<br/>
        /// dial on this agent to navigate from scratch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_cache_enabled")]
        public bool? IvrCacheEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNavigatorConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Tunes worker turn handling for autonomous outbound IVR<br/>
        /// navigation - longer endpointing and no barge-in. The<br/>
        /// navigation goal itself lives in the agent's prompt; this flag<br/>
        /// is the behaviour switch only. Defaults to false.
        /// </param>
        /// <param name="ivrCacheEnabled">
        /// Controls the IVR-menu cache consulted during navigation.<br/>
        /// Defaults to true so a navigator agent reuses learned menu<br/>
        /// layouts across calls. Set to false to force every outbound<br/>
        /// dial on this agent to navigate from scratch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentNavigatorConfig(
            bool? enabled,
            bool? ivrCacheEnabled)
        {
            this.Enabled = enabled;
            this.IvrCacheEnabled = ivrCacheEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentNavigatorConfig" /> class.
        /// </summary>
        public AgentNavigatorConfig()
        {
        }

    }
}