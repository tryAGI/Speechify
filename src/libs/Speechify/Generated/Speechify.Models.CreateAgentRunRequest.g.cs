
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/{agent_id}/runs`.
    /// </summary>
    public sealed partial class CreateAgentRunRequest
    {
        /// <summary>
        /// The task or goal to give the agent. The agent runs its brain against this over a short internal conversation and returns its result. The server's limit is 8000 **bytes**, so a mostly non-ASCII instruction reaches it before 8000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Upper bound on the run's internal turn budget - one turn is one<br/>
        /// plan-act-observe cycle, so a run that calls three tools uses at<br/>
        /// least four. Defaults to 8 when omitted.<br/>
        /// **Clamped to the workspace's per-run ceiling** (5 on Free, 10<br/>
        /// on Starter, 20 on Pro, 30 on Scale, 50 on Enterprise; per-workspace<br/>
        /// overrides apply): the run's `input.max_turns` echoes the budget it<br/>
        /// actually got, and `GET /v1/workspaces/current/entitlements`<br/>
        /// (`max_run_turns`) reports the ceiling up front, so plan against<br/>
        /// that rather than the value you sent. An omitted `max_turns` takes<br/>
        /// the default, clamped to the ceiling. On Free the<br/>
        /// ceiling is *below* the default, so omitting this field there yields<br/>
        /// 5, not 8.<br/>
        /// A run that exhausts its budget settles `succeeded` with<br/>
        /// `incomplete_reason: max_turns_exhausted` and whatever answer it had<br/>
        /// reached. Schema repairs count against this budget too - see<br/>
        /// `output_schema`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// The person this run acts for, in your own vocabulary - the same<br/>
        /// field a conversation and a widget session take, so one workspace<br/>
        /// never has two answers to who a person is. The agent opens the run<br/>
        /// knowing what it has already learned about them, and what a run<br/>
        /// that succeeds learns from its instruction and its reply is<br/>
        /// written back under this value, exactly as a call writes memory.<br/>
        /// Omit it to run the agent for nobody in particular, which is how a<br/>
        /// run behaves with no memory of anyone and learns nothing. Must not begin with `user_`,<br/>
        /// `embed_` or `anon_`, which name identities the platform derives.<br/>
        /// Every tool the run calls is told this value: a webhook receives<br/>
        /// it as `user_identity` inside the signed body, an MCP server as<br/>
        /// the `Speechify-User-Identity` header, and it renders in a tool's<br/>
        /// templated URL or headers as `{{system__caller_id}}`. A connector<br/>
        /// you wrote can therefore look up that person's own third-party<br/>
        /// token, which is how you integrate a system Speechify holds no<br/>
        /// credentials for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

        /// <summary>
        /// Optional JSON Schema (2020-12) the run's final answer must satisfy.<br/>
        /// When set, the agent answers with a JSON object, the platform<br/>
        /// validates it, and the conforming object is returned as<br/>
        /// `output.data`.<br/>
        /// The top level must be `type: object` - an array-typed or scalar<br/>
        /// schema is refused at create with `400`. At most 16 KiB.<br/>
        /// On a mismatch the platform re-asks the agent, feeding back up to 8<br/>
        /// of the violations. **At most two repair attempts, and each one<br/>
        /// spends a turn from `max_turns`** - so a schema-constrained run on a<br/>
        /// 5-turn ceiling has little room left for tool calls. Each attempt is<br/>
        /// journaled as an `observation` step whose `tool` is the reserved<br/>
        /// name `output_schema`, which a timeline renderer should expect<br/>
        /// alongside real tool names.<br/>
        /// A run that never produces a conforming object settles `succeeded`<br/>
        /// with `incomplete_reason: output_schema_violation` and no<br/>
        /// `output.data` - its prose answer is still on `output.reply`. The<br/>
        /// platform never returns an object the schema refused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Up to 16 arbitrary key/value pairs echoed back on the run. Your own correlation ids belong here - the platform never reads them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequest" /> class.
        /// </summary>
        /// <param name="instruction">
        /// The task or goal to give the agent. The agent runs its brain against this over a short internal conversation and returns its result. The server's limit is 8000 **bytes**, so a mostly non-ASCII instruction reaches it before 8000 characters.
        /// </param>
        /// <param name="variables">
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
        /// </param>
        /// <param name="maxTurns">
        /// Upper bound on the run's internal turn budget - one turn is one<br/>
        /// plan-act-observe cycle, so a run that calls three tools uses at<br/>
        /// least four. Defaults to 8 when omitted.<br/>
        /// **Clamped to the workspace's per-run ceiling** (5 on Free, 10<br/>
        /// on Starter, 20 on Pro, 30 on Scale, 50 on Enterprise; per-workspace<br/>
        /// overrides apply): the run's `input.max_turns` echoes the budget it<br/>
        /// actually got, and `GET /v1/workspaces/current/entitlements`<br/>
        /// (`max_run_turns`) reports the ceiling up front, so plan against<br/>
        /// that rather than the value you sent. An omitted `max_turns` takes<br/>
        /// the default, clamped to the ceiling. On Free the<br/>
        /// ceiling is *below* the default, so omitting this field there yields<br/>
        /// 5, not 8.<br/>
        /// A run that exhausts its budget settles `succeeded` with<br/>
        /// `incomplete_reason: max_turns_exhausted` and whatever answer it had<br/>
        /// reached. Schema repairs count against this budget too - see<br/>
        /// `output_schema`.
        /// </param>
        /// <param name="userIdentity">
        /// The person this run acts for, in your own vocabulary - the same<br/>
        /// field a conversation and a widget session take, so one workspace<br/>
        /// never has two answers to who a person is. The agent opens the run<br/>
        /// knowing what it has already learned about them, and what a run<br/>
        /// that succeeds learns from its instruction and its reply is<br/>
        /// written back under this value, exactly as a call writes memory.<br/>
        /// Omit it to run the agent for nobody in particular, which is how a<br/>
        /// run behaves with no memory of anyone and learns nothing. Must not begin with `user_`,<br/>
        /// `embed_` or `anon_`, which name identities the platform derives.<br/>
        /// Every tool the run calls is told this value: a webhook receives<br/>
        /// it as `user_identity` inside the signed body, an MCP server as<br/>
        /// the `Speechify-User-Identity` header, and it renders in a tool's<br/>
        /// templated URL or headers as `{{system__caller_id}}`. A connector<br/>
        /// you wrote can therefore look up that person's own third-party<br/>
        /// token, which is how you integrate a system Speechify holds no<br/>
        /// credentials for.
        /// </param>
        /// <param name="outputSchema">
        /// Optional JSON Schema (2020-12) the run's final answer must satisfy.<br/>
        /// When set, the agent answers with a JSON object, the platform<br/>
        /// validates it, and the conforming object is returned as<br/>
        /// `output.data`.<br/>
        /// The top level must be `type: object` - an array-typed or scalar<br/>
        /// schema is refused at create with `400`. At most 16 KiB.<br/>
        /// On a mismatch the platform re-asks the agent, feeding back up to 8<br/>
        /// of the violations. **At most two repair attempts, and each one<br/>
        /// spends a turn from `max_turns`** - so a schema-constrained run on a<br/>
        /// 5-turn ceiling has little room left for tool calls. Each attempt is<br/>
        /// journaled as an `observation` step whose `tool` is the reserved<br/>
        /// name `output_schema`, which a timeline renderer should expect<br/>
        /// alongside real tool names.<br/>
        /// A run that never produces a conforming object settles `succeeded`<br/>
        /// with `incomplete_reason: output_schema_violation` and no<br/>
        /// `output.data` - its prose answer is still on `output.reply`. The<br/>
        /// platform never returns an object the schema refused.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 arbitrary key/value pairs echoed back on the run. Your own correlation ids belong here - the platform never reads them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRunRequest(
            string instruction,
            object? variables,
            int? maxTurns,
            string? userIdentity,
            object? outputSchema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Variables = variables;
            this.MaxTurns = maxTurns;
            this.UserIdentity = userIdentity;
            this.OutputSchema = outputSchema;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequest" /> class.
        /// </summary>
        public CreateAgentRunRequest()
        {
        }

    }
}