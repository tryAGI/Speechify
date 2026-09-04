
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Body for `POST /v1/agents/{agent_id}/runs`.
    /// </summary>
    public sealed partial class CreateAgentRunRequest
    {
        /// <summary>
        /// The task or goal to give the agent. The agent runs its brain against this over a short internal conversation and returns its result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Per-run values that seed the agent's flow variables (override its<br/>
        /// stored defaults). The `system__*` namespace and the legacy `memory`<br/>
        /// alias belong to the platform and are rejected with a 400 naming<br/>
        /// `variables`, the same rule a conversation applies: the run binds its<br/>
        /// own values there, including `system__caller_id` for the person it<br/>
        /// acts for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Upper bound on the run's internal turn budget (server default when omitted; hard-capped).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// The person this run acts for, in your own vocabulary - the same<br/>
        /// field a conversation and a widget session take, so one workspace<br/>
        /// never has two answers to who a person is. The agent opens the run<br/>
        /// knowing what it has already learned about them.<br/>
        /// Omit it to run the agent for nobody in particular, which is how a<br/>
        /// run behaves with no memory of anyone. Must not begin with `user_`,<br/>
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
        /// Optional JSON Schema (2020-12, top-level `type: object`) the run's<br/>
        /// final answer must satisfy. When set, the agent answers with a JSON<br/>
        /// object, the platform validates it against this schema (re-asking the<br/>
        /// agent on a mismatch, bounded), and the conforming object is returned<br/>
        /// as `output.data`. A run that never produces a conforming object<br/>
        /// settles `succeeded` with `incomplete_reason: output_schema_violation`<br/>
        /// and no `output.data`. At most 16 KiB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Up to 16 arbitrary key/value pairs echoed back on the run.
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
        /// The task or goal to give the agent. The agent runs its brain against this over a short internal conversation and returns its result.
        /// </param>
        /// <param name="variables">
        /// Per-run values that seed the agent's flow variables (override its<br/>
        /// stored defaults). The `system__*` namespace and the legacy `memory`<br/>
        /// alias belong to the platform and are rejected with a 400 naming<br/>
        /// `variables`, the same rule a conversation applies: the run binds its<br/>
        /// own values there, including `system__caller_id` for the person it<br/>
        /// acts for.
        /// </param>
        /// <param name="maxTurns">
        /// Upper bound on the run's internal turn budget (server default when omitted; hard-capped).
        /// </param>
        /// <param name="userIdentity">
        /// The person this run acts for, in your own vocabulary - the same<br/>
        /// field a conversation and a widget session take, so one workspace<br/>
        /// never has two answers to who a person is. The agent opens the run<br/>
        /// knowing what it has already learned about them.<br/>
        /// Omit it to run the agent for nobody in particular, which is how a<br/>
        /// run behaves with no memory of anyone. Must not begin with `user_`,<br/>
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
        /// Optional JSON Schema (2020-12, top-level `type: object`) the run's<br/>
        /// final answer must satisfy. When set, the agent answers with a JSON<br/>
        /// object, the platform validates it against this schema (re-asking the<br/>
        /// agent on a mismatch, bounded), and the conforming object is returned<br/>
        /// as `output.data`. A run that never produces a conforming object<br/>
        /// settles `succeeded` with `incomplete_reason: output_schema_violation`<br/>
        /// and no `output.data`. At most 16 KiB.
        /// </param>
        /// <param name="metadata">
        /// Up to 16 arbitrary key/value pairs echoed back on the run.
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