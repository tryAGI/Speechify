
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Runtime safety controls that are opt-in per agent rather than<br/>
    /// platform defaults, because each one bills work an ordinary call<br/>
    /// does not do.
    /// </summary>
    public sealed partial class AgentGuardrailsConfig
    {
        /// <summary>
        /// Arms the out-of-band injection guardrail. A second, isolated<br/>
        /// model reads the caller's turns off the live conversation and<br/>
        /// corrects the agent when it detects a privileged-identity<br/>
        /// claim, a prompt-extraction probe, an instruction override, or<br/>
        /// the caller pulling the call off its purpose. It runs off the<br/>
        /// turn critical path, so it does not add caller-facing latency,<br/>
        /// and it never receives the agent's own instructions - so it<br/>
        /// cannot be talked out of running by anything the caller says.<br/>
        /// Adds one inference call per caller turn. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observer_enabled")]
        public bool? ObserverEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGuardrailsConfig" /> class.
        /// </summary>
        /// <param name="observerEnabled">
        /// Arms the out-of-band injection guardrail. A second, isolated<br/>
        /// model reads the caller's turns off the live conversation and<br/>
        /// corrects the agent when it detects a privileged-identity<br/>
        /// claim, a prompt-extraction probe, an instruction override, or<br/>
        /// the caller pulling the call off its purpose. It runs off the<br/>
        /// turn critical path, so it does not add caller-facing latency,<br/>
        /// and it never receives the agent's own instructions - so it<br/>
        /// cannot be talked out of running by anything the caller says.<br/>
        /// Adds one inference call per caller turn. Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGuardrailsConfig(
            bool? observerEnabled)
        {
            this.ObserverEnabled = observerEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGuardrailsConfig" /> class.
        /// </summary>
        public AgentGuardrailsConfig()
        {
        }

    }
}