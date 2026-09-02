
#nullable enable

namespace Speechify
{
    /// <summary>
    /// The hand-off a step describes: which team member took a sub-goal, and the child run that pursued it.<br/>
    /// It appears on BOTH halves of a hand-off, keyed by the same `child_run_id`: the `delegation` step that made it (carrying `depth`), and the later `observation` step that folded the child's result back (carrying `child_status`). Pair them on `child_run_id` to read a sub-goal and its outcome together. The sub-goal and the result themselves are those steps' `content`.<br/>
    /// `child_run_id` is a real run - fetch it with `getRun` (under `agent_id`) for the member's own status, output, and token usage. That is what makes a team run traversable: the parent's timeline links to each member's actual work rather than summarizing it.
    /// </summary>
    public sealed partial class RunStepDelegation
    {
        /// <summary>
        /// The child run that executed the sub-goal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChildRunId { get; set; }

        /// <summary>
        /// The team member the sub-goal went to. Absent when a run delegated to ITSELF (a same-agent sub-goal), which involves no member hand-off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The child's depth in the delegation tree (a root run is 0, so its children are 1). The runtime refuses a delegation past a fixed depth, bounding recursion. Present on the `delegation` step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// The state the child settled in, present on the `observation` step that folded its result back. Absent on the `delegation` step, where the child has not settled yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.RunStepDelegationChildStatusJsonConverter))]
        public global::Speechify.RunStepDelegationChildStatus? ChildStatus { get; set; }

        /// <summary>
        /// How many sub-goals the manager delegated in the SAME turn. A manager may hand out several at once; they run concurrently and only read as peers of that one turn if you can tell which of the crew each is. Absent on a single-target delegation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// 0-based position of this hand-off within its concurrent batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_index")]
        public int? BatchIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDelegation" /> class.
        /// </summary>
        /// <param name="childRunId">
        /// The child run that executed the sub-goal.
        /// </param>
        /// <param name="agentId">
        /// The team member the sub-goal went to. Absent when a run delegated to ITSELF (a same-agent sub-goal), which involves no member hand-off.
        /// </param>
        /// <param name="depth">
        /// The child's depth in the delegation tree (a root run is 0, so its children are 1). The runtime refuses a delegation past a fixed depth, bounding recursion. Present on the `delegation` step.
        /// </param>
        /// <param name="childStatus">
        /// The state the child settled in, present on the `observation` step that folded its result back. Absent on the `delegation` step, where the child has not settled yet.
        /// </param>
        /// <param name="batchSize">
        /// How many sub-goals the manager delegated in the SAME turn. A manager may hand out several at once; they run concurrently and only read as peers of that one turn if you can tell which of the crew each is. Absent on a single-target delegation.
        /// </param>
        /// <param name="batchIndex">
        /// 0-based position of this hand-off within its concurrent batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDelegation(
            string childRunId,
            string? agentId,
            int? depth,
            global::Speechify.RunStepDelegationChildStatus? childStatus,
            int? batchSize,
            int? batchIndex)
        {
            this.ChildRunId = childRunId ?? throw new global::System.ArgumentNullException(nameof(childRunId));
            this.AgentId = agentId;
            this.Depth = depth;
            this.ChildStatus = childStatus;
            this.BatchSize = batchSize;
            this.BatchIndex = batchIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDelegation" /> class.
        /// </summary>
        public RunStepDelegation()
        {
        }

    }
}