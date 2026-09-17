
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One guardrail rail: a check bound to a runtime seam with what to<br/>
    /// do when it trips. Name a `check`, or a `class` whose default<br/>
    /// check set stands in for one (`input`: injection_patterns;<br/>
    /// `output`: pii_patterns and secret_patterns; `tool_call` and<br/>
    /// `provenance`: tool_authz). A check bound to a seam it does not<br/>
    /// serve, or asked for an action it cannot take, is refused on write.
    /// </summary>
    public sealed partial class AgentGuardrailRail
    {
        /// <summary>
        /// A stable identifier, unique within the policy, echoed on every decision the rail records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The seam the rail runs at. `pre_input`: what the caller or<br/>
        /// person said, before the model sees it. `post_retrieval`: a<br/>
        /// knowledge search hit, a fetched page or a web result, before<br/>
        /// it re-enters the model. `pre_tool_call`: a tool call, before<br/>
        /// it runs. `post_output`: what the agent is about to say or<br/>
        /// post.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentGuardrailRailHookJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentGuardrailRailHook Hook { get; set; }

        /// <summary>
        /// What happens when the rail trips, in enforce mode. `observe`<br/>
        /// records only. `block` withholds the text (a blocked reply<br/>
        /// speaks the fallback line; a blocked tool call is refused and<br/>
        /// the model is told). `mask` substitutes the matched spans.<br/>
        /// Bounded by the policy `mode`: observe mode never blocks or<br/>
        /// masks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentGuardrailRailActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.AgentGuardrailRailAction Action { get; set; }

        /// <summary>
        /// The check the rail runs. `injection_patterns`: instruction<br/>
        /// override, prompt extraction, jailbreak and injected-role<br/>
        /// patterns (pre_input, post_retrieval). `pii_patterns`: SSN,<br/>
        /// card, email and phone patterns (post_output, post_retrieval).<br/>
        /// `secret_patterns`: private keys, cloud and provider tokens,<br/>
        /// JWTs and credential assignments (post_output,<br/>
        /// post_retrieval). `tool_authz`: refuse a gated tool fed<br/>
        /// arguments that derive from untrusted text (pre_tool_call;<br/>
        /// observe or block only). `moderation`: the platform content<br/>
        /// classifier with the same categories the speech API refuses<br/>
        /// (post_output, pre_input; observe or block only). A<br/>
        /// classifier's verdict is collected at the last moment before<br/>
        /// the caller could hear the reply and never delays it beyond a<br/>
        /// bounded wait.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentGuardrailRailCheckJsonConverter))]
        public global::Speechify.AgentGuardrailRailCheck? Check { get; set; }

        /// <summary>
        /// Selects the default check set when `check` is absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentGuardrailRailClassJsonConverter))]
        public global::Speechify.AgentGuardrailRailClass? Class { get; set; }

        /// <summary>
        /// The severity stamped on the decision when the rail trips. Defaults to medium.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.AgentGuardrailRailSeverityJsonConverter))]
        public global::Speechify.AgentGuardrailRailSeverity? Severity { get; set; }

        /// <summary>
        /// Check-specific settings, validated per check. Pattern checks<br/>
        /// take `min_severity` (low, medium, high, critical).<br/>
        /// `pii_patterns` also takes `entities` (a subset of us_ssn,<br/>
        /// credit_card, email, phone) and `placeholder` (the text a<br/>
        /// mask writes over a match, 1 to 64 characters). `tool_authz`<br/>
        /// takes `require_trusted_tools`, `require_trusted_capabilities`<br/>
        /// and `allow_untrusted_tools` (lists of names) and<br/>
        /// `default_require_trusted` (boolean); a capability is a<br/>
        /// tool's action class (read, communicate_internal,<br/>
        /// communicate_external, data_export, financial,<br/>
        /// irreversible_other), read from the agent's attached tools.<br/>
        /// `moderation` takes no settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGuardrailRail" /> class.
        /// </summary>
        /// <param name="id">
        /// A stable identifier, unique within the policy, echoed on every decision the rail records.
        /// </param>
        /// <param name="hook">
        /// The seam the rail runs at. `pre_input`: what the caller or<br/>
        /// person said, before the model sees it. `post_retrieval`: a<br/>
        /// knowledge search hit, a fetched page or a web result, before<br/>
        /// it re-enters the model. `pre_tool_call`: a tool call, before<br/>
        /// it runs. `post_output`: what the agent is about to say or<br/>
        /// post.
        /// </param>
        /// <param name="action">
        /// What happens when the rail trips, in enforce mode. `observe`<br/>
        /// records only. `block` withholds the text (a blocked reply<br/>
        /// speaks the fallback line; a blocked tool call is refused and<br/>
        /// the model is told). `mask` substitutes the matched spans.<br/>
        /// Bounded by the policy `mode`: observe mode never blocks or<br/>
        /// masks.
        /// </param>
        /// <param name="check">
        /// The check the rail runs. `injection_patterns`: instruction<br/>
        /// override, prompt extraction, jailbreak and injected-role<br/>
        /// patterns (pre_input, post_retrieval). `pii_patterns`: SSN,<br/>
        /// card, email and phone patterns (post_output, post_retrieval).<br/>
        /// `secret_patterns`: private keys, cloud and provider tokens,<br/>
        /// JWTs and credential assignments (post_output,<br/>
        /// post_retrieval). `tool_authz`: refuse a gated tool fed<br/>
        /// arguments that derive from untrusted text (pre_tool_call;<br/>
        /// observe or block only). `moderation`: the platform content<br/>
        /// classifier with the same categories the speech API refuses<br/>
        /// (post_output, pre_input; observe or block only). A<br/>
        /// classifier's verdict is collected at the last moment before<br/>
        /// the caller could hear the reply and never delays it beyond a<br/>
        /// bounded wait.
        /// </param>
        /// <param name="class">
        /// Selects the default check set when `check` is absent.
        /// </param>
        /// <param name="severity">
        /// The severity stamped on the decision when the rail trips. Defaults to medium.
        /// </param>
        /// <param name="config">
        /// Check-specific settings, validated per check. Pattern checks<br/>
        /// take `min_severity` (low, medium, high, critical).<br/>
        /// `pii_patterns` also takes `entities` (a subset of us_ssn,<br/>
        /// credit_card, email, phone) and `placeholder` (the text a<br/>
        /// mask writes over a match, 1 to 64 characters). `tool_authz`<br/>
        /// takes `require_trusted_tools`, `require_trusted_capabilities`<br/>
        /// and `allow_untrusted_tools` (lists of names) and<br/>
        /// `default_require_trusted` (boolean); a capability is a<br/>
        /// tool's action class (read, communicate_internal,<br/>
        /// communicate_external, data_export, financial,<br/>
        /// irreversible_other), read from the agent's attached tools.<br/>
        /// `moderation` takes no settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGuardrailRail(
            string id,
            global::Speechify.AgentGuardrailRailHook hook,
            global::Speechify.AgentGuardrailRailAction action,
            global::Speechify.AgentGuardrailRailCheck? check,
            global::Speechify.AgentGuardrailRailClass? @class,
            global::Speechify.AgentGuardrailRailSeverity? severity,
            object? config)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Hook = hook;
            this.Action = action;
            this.Check = check;
            this.Class = @class;
            this.Severity = severity;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGuardrailRail" /> class.
        /// </summary>
        public AgentGuardrailRail()
        {
        }

    }
}