
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerRunSpec(
            string instruction,
            object? variables,
            int? maxTurns,
            object? outputSchema)
        {
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Variables = variables;
            this.MaxTurns = maxTurns;
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRunSpec" /> class.
        /// </summary>
        public TriggerRunSpec()
        {
        }

    }
}