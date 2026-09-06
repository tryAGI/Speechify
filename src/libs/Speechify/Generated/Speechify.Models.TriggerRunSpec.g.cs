
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The durable run a trigger starts when it fires.
    /// </summary>
    public sealed partial class TriggerRunSpec
    {
        /// <summary>
        /// The goal instruction that drives the run (1-8000 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Variable seed for the run. A webhook fire's JSON body is merged in<br/>
        /// under the webhook's `payload_variable` key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Optional per-run turn budget; 0 uses the workspace default.
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
        /// The person every run this trigger fires acts for, in your own<br/>
        /// vocabulary - the same field a request-started run takes. A<br/>
        /// scheduled or webhook-fired run then opens with that person's<br/>
        /// memory, every tool it calls is told who it is for, and<br/>
        /// `GET /v1/agents/runs?user_identity=` finds it, so you keep no<br/>
        /// trigger-to-person index of your own. Validated when the trigger is<br/>
        /// saved, by the run surface's rule: must not begin with `user_`,<br/>
        /// `embed_` or `anon_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_identity")]
        public string? UserIdentity { get; set; }

        /// <summary>
        /// Up to 16 key/value pairs merged onto every run this trigger fires,<br/>
        /// beside the `trigger_id` and `trigger_fire_key` the platform stamps.<br/>
        /// Your own correlation ids belong here. The platform's keys<br/>
        /// (`trigger`, `trigger_id`, `trigger_fire_key`) are refused with a<br/>
        /// 400 when the trigger is saved, since the stamp would win.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRunSpec" /> class.
        /// </summary>
        /// <param name="instruction">
        /// The goal instruction that drives the run (1-8000 characters).
        /// </param>
        /// <param name="variables">
        /// Variable seed for the run. A webhook fire's JSON body is merged in<br/>
        /// under the webhook's `payload_variable` key.
        /// </param>
        /// <param name="maxTurns">
        /// Optional per-run turn budget; 0 uses the workspace default.
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
        /// <param name="userIdentity">
        /// The person every run this trigger fires acts for, in your own<br/>
        /// vocabulary - the same field a request-started run takes. A<br/>
        /// scheduled or webhook-fired run then opens with that person's<br/>
        /// memory, every tool it calls is told who it is for, and<br/>
        /// `GET /v1/agents/runs?user_identity=` finds it, so you keep no<br/>
        /// trigger-to-person index of your own. Validated when the trigger is<br/>
        /// saved, by the run surface's rule: must not begin with `user_`,<br/>
        /// `embed_` or `anon_`.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 key/value pairs merged onto every run this trigger fires,<br/>
        /// beside the `trigger_id` and `trigger_fire_key` the platform stamps.<br/>
        /// Your own correlation ids belong here. The platform's keys<br/>
        /// (`trigger`, `trigger_id`, `trigger_fire_key`) are refused with a<br/>
        /// 400 when the trigger is saved, since the stamp would win.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerRunSpec(
            string instruction,
            object? variables,
            int? maxTurns,
            object? outputSchema,
            string? userIdentity,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Variables = variables;
            this.MaxTurns = maxTurns;
            this.OutputSchema = outputSchema;
            this.UserIdentity = userIdentity;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRunSpec" /> class.
        /// </summary>
        public TriggerRunSpec()
        {
        }

    }
}