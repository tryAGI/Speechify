
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Runtime safety controls that are opt-in per agent rather than<br/>
    /// platform defaults, because each one bills work an ordinary call<br/>
    /// does not do. The policy (mode, fallback line, rails) is stored<br/>
    /// with the agent and runs on the agent's calls, chat turns,<br/>
    /// simulations and runs only once the workspace's guardrails<br/>
    /// capability is granted; until then it is kept, validated and<br/>
    /// inert. On update each field applies on its own; `rails`, when<br/>
    /// present, replaces the list whole.
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
        /// What the rails may do. `observe` (the default when absent):<br/>
        /// every rail records what it would have done and changes<br/>
        /// nothing, which is how a new rail is measured on real traffic<br/>
        /// before it acts. `enforce`: each rail's own `action` applies.<br/>
        /// `off`: none of the policy's own rails run; the platform's<br/>
        /// rails keep observing. Move an agent to `enforce` on its<br/>
        /// observed counts, never by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentGuardrailsConfigModeJsonConverter))]
        public global::Speechify.AgentGuardrailsConfigMode? Mode { get; set; }

        /// <summary>
        /// What the agent says or posts in place of an output a rail<br/>
        /// blocked in enforce mode. Spoken on a call in the agent's<br/>
        /// voice, posted on a chat channel; never appended to a run's<br/>
        /// reply. Absent, the platform's own line is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_reply")]
        public string? FallbackReply { get; set; }

        /// <summary>
        /// The rails, in order. Each binds a check to one of the four<br/>
        /// runtime seams with an action. The first rail that decides at<br/>
        /// a seam wins. Always an array on read; an agent with no policy<br/>
        /// reads as an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rails")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentGuardrailRail>? Rails { get; set; }

        /// <summary>
        /// The platform's own rails, which every agent runs after the<br/>
        /// policy's rails and under the policy's `mode`: the content<br/>
        /// categories the speech API refuses, secrets in a reply, and a<br/>
        /// consequential tool call whose arguments derive from text the<br/>
        /// agent read rather than from its configuration. Read-only; a<br/>
        /// policy can raise friction above them and never lower it. An<br/>
        /// id in this list starts with `platform:`, which a policy's own<br/>
        /// rails may not use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_rails")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentGuardrailRail>? PlatformRails { get; set; }

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
        /// <param name="mode">
        /// What the rails may do. `observe` (the default when absent):<br/>
        /// every rail records what it would have done and changes<br/>
        /// nothing, which is how a new rail is measured on real traffic<br/>
        /// before it acts. `enforce`: each rail's own `action` applies.<br/>
        /// `off`: none of the policy's own rails run; the platform's<br/>
        /// rails keep observing. Move an agent to `enforce` on its<br/>
        /// observed counts, never by default.
        /// </param>
        /// <param name="fallbackReply">
        /// What the agent says or posts in place of an output a rail<br/>
        /// blocked in enforce mode. Spoken on a call in the agent's<br/>
        /// voice, posted on a chat channel; never appended to a run's<br/>
        /// reply. Absent, the platform's own line is used.
        /// </param>
        /// <param name="rails">
        /// The rails, in order. Each binds a check to one of the four<br/>
        /// runtime seams with an action. The first rail that decides at<br/>
        /// a seam wins. Always an array on read; an agent with no policy<br/>
        /// reads as an empty list.
        /// </param>
        /// <param name="platformRails">
        /// The platform's own rails, which every agent runs after the<br/>
        /// policy's rails and under the policy's `mode`: the content<br/>
        /// categories the speech API refuses, secrets in a reply, and a<br/>
        /// consequential tool call whose arguments derive from text the<br/>
        /// agent read rather than from its configuration. Read-only; a<br/>
        /// policy can raise friction above them and never lower it. An<br/>
        /// id in this list starts with `platform:`, which a policy's own<br/>
        /// rails may not use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGuardrailsConfig(
            bool? observerEnabled,
            global::Speechify.AgentGuardrailsConfigMode? mode,
            string? fallbackReply,
            global::System.Collections.Generic.IList<global::Speechify.AgentGuardrailRail>? rails,
            global::System.Collections.Generic.IList<global::Speechify.AgentGuardrailRail>? platformRails)
        {
            this.ObserverEnabled = observerEnabled;
            this.Mode = mode;
            this.FallbackReply = fallbackReply;
            this.Rails = rails;
            this.PlatformRails = platformRails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGuardrailsConfig" /> class.
        /// </summary>
        public AgentGuardrailsConfig()
        {
        }

    }
}