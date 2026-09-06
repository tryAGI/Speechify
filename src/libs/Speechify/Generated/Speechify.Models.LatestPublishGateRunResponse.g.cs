
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The agent's most recent publish-gate decision, and whether the configuration<br/>
    /// it has RIGHT NOW is published. The two differ after an edit: the last decision<br/>
    /// still reads `passed` while `published` is false, because the edit re-armed the<br/>
    /// gate. Attaching or detaching a knowledge base is not such an edit.
    /// </summary>
    public sealed partial class LatestPublishGateRunResponse
    {
        /// <summary>
        /// Null when the agent has never been gated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gate_run")]
        public global::Speechify.PublishGateRun? GateRun { get; set; }

        /// <summary>
        /// Whether the agent's current configuration carries a passing (or overridden)<br/>
        /// decision, so a run on it is admitted. A trigger whose agent reads `false`<br/>
        /// here will fail every fire until the agent is published again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Published { get; set; }

        /// <summary>
        /// The identity of the current configuration - what a publish records. It moves<br/>
        /// with the prompt, model, guardrails, tools and their schemas, never with the<br/>
        /// knowledge bases attached or with per-run variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_fingerprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigFingerprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatestPublishGateRunResponse" /> class.
        /// </summary>
        /// <param name="published">
        /// Whether the agent's current configuration carries a passing (or overridden)<br/>
        /// decision, so a run on it is admitted. A trigger whose agent reads `false`<br/>
        /// here will fail every fire until the agent is published again.
        /// </param>
        /// <param name="configFingerprint">
        /// The identity of the current configuration - what a publish records. It moves<br/>
        /// with the prompt, model, guardrails, tools and their schemas, never with the<br/>
        /// knowledge bases attached or with per-run variables.
        /// </param>
        /// <param name="gateRun">
        /// Null when the agent has never been gated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LatestPublishGateRunResponse(
            bool published,
            string configFingerprint,
            global::Speechify.PublishGateRun? gateRun)
        {
            this.GateRun = gateRun;
            this.Published = published;
            this.ConfigFingerprint = configFingerprint ?? throw new global::System.ArgumentNullException(nameof(configFingerprint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatestPublishGateRunResponse" /> class.
        /// </summary>
        public LatestPublishGateRunResponse()
        {
        }

    }
}