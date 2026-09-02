
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The frozen request the run was created with.
    /// </summary>
    public sealed partial class AgentRunInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// The team members this run may delegate sub-goals to, present only on a team run (started via `runTeam`). Each is a member agent with its role and hand-off note. Absent for a solo agent run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation_targets")]
        public global::System.Collections.Generic.IList<global::Speechify.AgentRunInputDelegationTargetsItems>? DelegationTargets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunInput" /> class.
        /// </summary>
        /// <param name="instruction"></param>
        /// <param name="variables"></param>
        /// <param name="maxTurns"></param>
        /// <param name="delegationTargets">
        /// The team members this run may delegate sub-goals to, present only on a team run (started via `runTeam`). Each is a member agent with its role and hand-off note. Absent for a solo agent run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunInput(
            string instruction,
            object? variables,
            int? maxTurns,
            global::System.Collections.Generic.IList<global::Speechify.AgentRunInputDelegationTargetsItems>? delegationTargets)
        {
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
            this.Variables = variables;
            this.MaxTurns = maxTurns;
            this.DelegationTargets = delegationTargets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunInput" /> class.
        /// </summary>
        public AgentRunInput()
        {
        }

    }
}