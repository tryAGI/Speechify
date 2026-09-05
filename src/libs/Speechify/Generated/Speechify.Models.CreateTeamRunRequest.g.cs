
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/teams/{team_id}/runs`.
    /// </summary>
    public sealed partial class CreateTeamRunRequest
    {
        /// <summary>
        /// The task or goal to give the team. The manager agent runs its brain against this, delegating sub-goals to the members, and returns its aggregated result. The server's limit is 8000 **bytes**, so a mostly non-ASCII instruction reaches it before 8000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Per-run values that seed the manager's flow variables (override its<br/>
        /// stored defaults). As on a single-agent run, the `system__*`<br/>
        /// namespace and the legacy `memory` alias belong to the platform and<br/>
        /// are rejected with a 400 naming `variables`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Upper bound on the manager run's internal turn budget - one turn is<br/>
        /// one plan-act-observe cycle. Defaults to 8 when omitted, and bounds<br/>
        /// the MANAGER only: each delegated child gets its own budget.<br/>
        /// **Clamped silently to the workspace's per-run ceiling**, which is 5<br/>
        /// on Free, 10 on Starter, 20 on Pro, 30 on Scale and 50 on<br/>
        /// Enterprise. There is no error: read `input.max_turns` on the<br/>
        /// returned run to see the budget it actually got.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTeamRunRequest" /> class.
        /// </summary>
        /// <param name="instruction">
        /// The task or goal to give the team. The manager agent runs its brain against this, delegating sub-goals to the members, and returns its aggregated result. The server's limit is 8000 **bytes**, so a mostly non-ASCII instruction reaches it before 8000 characters.
        /// </param>
        /// <param name="variables">
        /// Per-run values that seed the manager's flow variables (override its<br/>
        /// stored defaults). As on a single-agent run, the `system__*`<br/>
        /// namespace and the legacy `memory` alias belong to the platform and<br/>
        /// are rejected with a 400 naming `variables`.
        /// </param>
        /// <param name="maxTurns">
        /// Upper bound on the manager run's internal turn budget - one turn is<br/>
        /// one plan-act-observe cycle. Defaults to 8 when omitted, and bounds<br/>
        /// the MANAGER only: each delegated child gets its own budget.<br/>
        /// **Clamped silently to the workspace's per-run ceiling**, which is 5<br/>
        /// on Free, 10 on Starter, 20 on Pro, 30 on Scale and 50 on<br/>
        /// Enterprise. There is no error: read `input.max_turns` on the<br/>
        /// returned run to see the budget it actually got.
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
        public CreateTeamRunRequest(
            string instruction,
            object? variables,
            int? maxTurns,
            object? outputSchema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Variables = variables;
            this.MaxTurns = maxTurns;
            this.OutputSchema = outputSchema;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRunRequest" /> class.
        /// </summary>
        public CreateTeamRunRequest()
        {
        }

    }
}